# Realizamos los imports de las librerias que necesitamos
import json
import xmlrpc.client
import xml.etree.ElementTree as ET
import base64

# Creamos la conexion con Odoo
url = 'https://damerstpd.odoo.com/'
db = 'damerstpd'
username = 'smaquedam@uoc.edu'
password = 'DAMERs_IoT'

common = xmlrpc.client.ServerProxy('{}/xmlrpc/2/common'.format(url))
object = xmlrpc.client.ServerProxy('{}/xmlrpc/2/object'.format(url))
uid = common.authenticate(db, username, password, {})

xml_file = ET.parse('Exported_Invoices1.xml')
root = xml_file.getroot()

#invoiceOdooIds = object.execute(db, uid, password, 'account.move', 'search', [])
#print(invoiceOdooIds)
#invoiceIds = []
#for id in invoiceOdooIds:
#    [record] = object.execute(db, uid, password, 'account.move', 'read', [id])
#    invoiceIds.append(record['name'])

facturas = []
for factura in root:
    Nombre = factura.find('Nombre').text 
    print(Nombre)
    Apellidos = factura.find('Apellidos').text 
    IDfactura = factura.find('IDfactura').text   
    IDreserva = factura.find('IDreserva').text
    Total = factura.find('Total').text
    IDhabitacion = factura.find('IDhabitacion').text
    IDCliente = factura.find('IDCliente').text
    FechaEntr = factura.find('FechaEntr').text
    FechaSal = factura.find('FechaSal').text
    Temporada = factura.find('Temporada').text
    Regimen = factura.find('Regimen').text
    Estancia = factura.find('Estancia').text
    Precio_dia = factura.find('Precio_dia').text
    print(IDfactura)

    #if (not (IDfactura in invoiceIds)):
    facturas.append({
        'move_type': 'out_invoice',
        'name' : IDfactura,
        'x_studio_cliente_1' : Nombre + ' ' + Apellidos,
        'x_studio_dni_1' : IDCliente,
        'x_studio_nm_de_reserva' : IDreserva,
        'x_studio_nm_de_habitacin' : IDhabitacion,
        'x_studio_fecha_de_entrada' : FechaEntr,
        'x_studio_fecha_de_salida_1' : FechaSal,
        'x_studio_temporada' : Temporada,
        'x_studio_rgimen' : Regimen,
        'invoice_date' : FechaSal,
        'invoice_date_due' : FechaSal,
        'invoice_line_ids': [(0,0,{
                'name': 'Noches de alojamiento',
                'quantity': Estancia,
                'price_unit': Precio_dia,
                }), 
                (0,0,{
                'name': 'Coca-Cola',
                'quantity': 5,
                'price_unit': 3,
                }), 
                (0,0,{
                'name': 'Sandwich',
                'quantity': 1,
                'price_unit': 5,
                }), 
                (0,0,{
                'name': 'Masaje',
                'quantity': 1,
                'price_unit': 47,
                }), 
                (0,0,{
                'name': 'Lavanderia',
                'quantity': 2,
                'price_unit': 18,
                })],
    })

if len(facturas) > 0:
    for factura in facturas:
        do_write = object.execute(db, uid, password, 'account.move', 'create', [factura])
        print('Factura cargadas correctamente')