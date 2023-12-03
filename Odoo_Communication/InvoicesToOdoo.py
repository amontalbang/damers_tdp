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

xml_file = ET.parse('..\\..\\..\\XMLs\\Exported_Invoices.xml')
root = xml_file.getroot()

invoiceOdooIds = object.execute(db, uid, password, 'x_facturas', 'search', [])
invoiceIds = []
for id in invoiceOdooIds:
    [record] = object.execute(db, uid, password, 'x_facturas', 'read', [id])
    invoiceIds.append(record['x_studio_id_factura'])

facturas = []
for factura in root:
    IDfactura = factura.find('IDfactura').text   
    IDreserva = factura.find('IDreserva').text 
    Total = factura.find('Total').text
    print(IDfactura)

    if (not (IDfactura in invoiceIds)):
        facturas.append({
            'x_name' : IDfactura,
            'x_studio_id_factura' : IDfactura,
            'x_studio_id_reserva' : IDreserva,
            'x_studio_total' : Total,
        })

if len(facturas) > 0:
    for factura in facturas:
        do_write = object.execute(db, uid, password, 'x_facturas', 'create', [factura])
        print('Factura cargadas correctamente')
