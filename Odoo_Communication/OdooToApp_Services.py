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
    [servicios] = [models.execute_kw(db, uid, password, 'x_servicios', 'search_read', [], {'fields': ['x_name', 'x_studio_id_servicio', 'x_studio_nombre', 'x_studio_descripcin', 'x_studio_precio'], 'limit': 100})]

    odoo = ET.Element('NewDataset')

    for servicio in servicios:
        Table1 = ET.SubElement(odoo, 'Table1')
        IDservicio = ET.SubElement(Table1, 'IDservicio')
        IDservicio.text = str(servicio['x_studio_id_servicio'])
        Nombre = ET.SubElement(Table1, 'Nombre')
        Nombre.text = servicio['x_studio_nombre']
        Descripcion = ET.SubElement(Table1, 'Descripcion')
        Descripcion.text = servicio['x_studio_descripcin']
        Precio = ET.SubElement(Table1, 'Precio')
        Precio.text = str(servicio['x_studio_precio'])
        
    xml = ET.ElementTree(odoo)
    xml.write('..\\XMLs\\odooToServices.xml')


else:
    print("autenticacion fallida")
