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
    [habitaciones] = [models.execute_kw(db, uid, password, 'x_habitaciones', 'search_read', [], {'fields': ['x_studio_nm_hab', 'x_studio_tipo_1', 'x_studio_capacidad', 'x_studio_precio_temp_baja', 'x_studio_precio_temp_media', 'x_studio_precio_temp_alta'], 'limit': 100})]

    odoo = ET.Element('NewDataset')

    for habitacion in habitaciones:
        print("usuario", habitacion)  
        Table1 = ET.SubElement(odoo, 'Table1')
        IDhabitacion = ET.SubElement(Table1, 'IDhabitacion')
        IDhabitacion.text = habitacion['x_studio_nm_hab']
        Tipo = ET.SubElement(Table1, 'Tipo')
        Tipo.text = habitacion['x_studio_tipo_1']
        Capacidad = ET.SubElement(Table1, 'Capacidad')
        Capacidad.text = habitacion['x_studio_capacidad']
        PrecioL = ET.SubElement(Table1, 'PrecioL')
        PrecioL.text = habitacion['x_studio_precio_temp_baja']
        PrecioM = ET.SubElement(Table1, 'PrecioM')
        PrecioM.text = habitacion['x_studio_precio_temp_media']
        PrecioH = ET.SubElement(Table1, 'PrecioH')
        PrecioH.text = habitacion['x_studio_precio_temp_alta']
    xml = ET.ElementTree(odoo)
    xml.write('..\\XMLs\\odooToRooms.xml')


else:
    print("autenticacion fallida")
