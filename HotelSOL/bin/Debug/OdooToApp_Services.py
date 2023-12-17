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
    [servicios] = [models.execute_kw(db, uid, password, 'product.template', 'search_read', [], {'fields': ['default_code', 'name', 'list_price', 'x_studio_description', 'detailed_type', 'qty_available', 'sale_ok'], 'limit': 100})]
    odoo = ET.Element('NewDataset')

    for servicio in servicios:
        if ((servicio['detailed_type'] == 'consu') or (servicio['detailed_type'] == 'product')) and (servicio['sale_ok']):
            Table1 = ET.SubElement(odoo, 'Table1')
            IDservicio = ET.SubElement(Table1, 'IDservicio')
            IDservicio.text = str(servicio['default_code'])
            Nombre = ET.SubElement(Table1, 'Nombre')
            Nombre.text = servicio['name']
            Descripcion = ET.SubElement(Table1, 'Descripcion')
            Descripcion.text = servicio['x_studio_description']
            Precio = ET.SubElement(Table1, 'Precio')
            Precio.text = str(int(servicio['list_price']))
            Available = ET.SubElement(Table1, 'Available')
            if (servicio['detailed_type'] == 'consu'):
                Available.text = '0'
            else:
                Available.text = str(int(servicio['qty_available']))
        
    xml = ET.ElementTree(odoo)
    xml.write('odooToServices.xml')


else:
    print("autenticacion fallida")
