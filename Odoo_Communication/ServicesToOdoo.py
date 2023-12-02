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

xml_file = ET.parse('..\\..\\..\\XMLs\\Exported_Services.xml')
root = xml_file.getroot()

servicios = []
for servicio in root:
    IDservicio = servicio.find('IDservicio').text 
    Nombre = servicio.find('Nombre').text 
    Descripcion = servicio.find('Descripcion').text 
    Precio = servicio.find('Precio').text 

    servicios.append({
        'x_name' : Nombre,
        'x_studio_id_servicio' : IDservicio,
        'x_studio_nombre' : Nombre,
        'x_studio_descripcin' : Descripcion,
        'x_studio_precio' : Precio,
    })

for servicio in servicios:
    do_write = object.execute(db, uid, password, 'x_servicios', 'create', [servicio])
    print('Servicio cargado correctamente')
