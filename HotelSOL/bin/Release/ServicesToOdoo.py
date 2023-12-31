# Realizamos los imports de las librerias que necesitamos
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

xml_file = ET.parse('Exported_Services.xml')
root = xml_file.getroot()

serviceOdooIds = object.execute(db, uid, password, 'x_servicios', 'search', [])
serviceIds = []
for id in serviceOdooIds:
    [record] = object.execute(db, uid, password, 'x_servicios', 'read', [id])
    serviceIds.append(record['x_studio_id_servicio'])

servicios = []
for servicio in root:
    IDservicio = servicio.find('IDservicio').text 
    Nombre = servicio.find('Nombre').text 
    Descripcion = servicio.find('Descripcion').text 
    Precio = servicio.find('Precio').text 

    if (not (IDservicio in serviceIds)):
        servicios.append({
            'x_name' : Nombre,
            'x_studio_id_servicio' : IDservicio,
            'x_studio_nombre' : Nombre,
            'x_studio_descripcin' : Descripcion,
            'x_studio_precio' : Precio,
        })

if len(servicios) > 0:
    for servicio in servicios:
        do_write = object.execute(db, uid, password, 'x_servicios', 'create', [servicio])
        print('Servicio cargado correctamente')
