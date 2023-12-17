import xmlrpc.client
import xml.etree.cElementTree as ET

## Creamos la conexion con Odoo
url = 'https://damerstpd.odoo.com/'
db = 'damerstpd'
username = 'smaquedam@uoc.edu'
password = 'DAMERs_IoT'

common = xmlrpc.client.ServerProxy('{}/xmlrpc/2/common'.format(url))
uid = common.authenticate(db, username, password, {})
models = xmlrpc.client.ServerProxy('{}/xmlrpc/2/object'.format(url))

if uid:
    print("autenticacion exitosa") 
    [facturas] = [models.execute_kw(db, uid, password, 'x_facturas', 'search_read', [], {'fields': ['x_name', 'x_studio_id_reserva', 'x_studio_id_factura', 'x_studio_total'], 'limit': 100})]

    odoo = ET.Element('NewDataset')

    for factura in facturas:
        print(factura)
        Table1 = ET.SubElement(odoo, 'Table1')
        IDfactura = ET.SubElement(Table1, 'IDfactura')
        IDfactura.text = factura['x_studio_id_factura']
        IDreserva = ET.SubElement(Table1, 'IDreserva')
        IDreserva.text = str(factura['x_studio_id_reserva'])
        Total = ET.SubElement(Table1, 'Total')
        Total.text = str(factura['x_studio_total'])
        
    xml = ET.ElementTree(odoo)
    xml.write('odooToInvoices.xml')


else:
    print("autenticacion fallida")