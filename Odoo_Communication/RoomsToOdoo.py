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

xml_file = ET.parse('..\\..\\..\\XMLs\\Exported_Rooms.xml')
root = xml_file.getroot()

roomOdooIds = object.execute(db, uid, password, 'x_habitaciones', 'search', [])
roomIds = []
for id in roomOdooIds:
    [record] = object.execute(db, uid, password, 'x_habitaciones', 'read', [id])
    roomIds.append(record['x_studio_nm_hab'])

habitaciones = []
for habitacion in root:
    IDhabitacion = habitacion.find('IDhabitacion').text   
    Tipo = habitacion.find('Tipo').text 
    Capacidad = habitacion.find('Capacidad').text
    PrecioL = habitacion.find('PrecioL').text 
    PrecioM = habitacion.find('PrecioM').text
    PrecioH = habitacion.find('PrecioH').text
    print(IDhabitacion)

    if (not (IDhabitacion in roomIds)):
        habitaciones.append({
            'x_name' : IDhabitacion,
            'x_studio_nm_hab' : IDhabitacion,
            'x_studio_tipo_1' : Tipo,
            'x_studio_capacidad' : Capacidad,
            'x_studio_precio_temp_baja' : PrecioL,
            'x_studio_precio_temp_media' : PrecioM,
            'x_studio_precio_temp_alta' : PrecioH,
        })

if len(habitaciones) > 0:
    for habitacion in habitaciones:
        do_write = object.execute(db, uid, password, 'x_habitaciones', 'create', [habitacion])
        print('Habitacion cargada correctamente')

