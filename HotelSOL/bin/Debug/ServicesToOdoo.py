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

serviceOdooIds = object.execute(db, uid, password, 'product.template', 'search', [])
print(serviceOdooIds)
serviceIds = []
for id in serviceOdooIds:
    [record] = object.execute(db, uid, password, 'product.template', 'read', [id])
    serviceIds.append(record['name'])

servicios = []
for servicio in root:
    IDservicio = servicio.find('IDservicio').text 
    Nombre = servicio.find('Nombre').text
    Descripcion = servicio.find('Descripcion').text 
    Precio = servicio.find('Precio').text
    Available = servicio.find('Disponible').text

    if (not (Nombre in serviceIds)):
        servicios.append({
            'name' : Nombre,
            'x_studio_idservicio' : IDservicio,
            'x_studio_description' : Descripcion,
            'list_price': Precio,
            'qty_available' : Available,
            'detailed_type' : 'product'
        })

if len(servicios) > 0:
    for servicio in servicios:
        do_write = object.execute(db, uid, password, 'product.template', 'create', [servicio])
        print('Servicio cargado correctamente')
