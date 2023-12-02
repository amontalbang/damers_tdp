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

xml_file = ET.parse('..\\..\\..\\XMLs\\Exported_Reservations.xml')
root = xml_file.getroot()

reservas = []
for reserva in root:
    IDreserva = reserva.find('IDreserva').text   
    IDhabitacion = reserva.find('IDhabitacion').text 
    IDCliente = reserva.find('IDCliente').text
    FechaEntr = reserva.find('FechaEntr').text 
    FechaSal = reserva.find('FechaSal').text
    Temporada = reserva.find('Temporada').text
    Regimen = reserva.find('Regimen').text
    Estado = reserva.find('Estado').text
    print(IDreserva)

    reservas.append({
        'x_name' : IDreserva,
        'x_studio_id_de_reserva' : IDreserva,
        'x_studio_id_habitacin' : IDhabitacion,
        'x_studio_id_cliente' : IDCliente,
        'x_studio_fecha_entrada' : FechaEntr,
        'x_studio_fecha_salida' : FechaSal,
        'x_studio_temporada' : Temporada,
        'x_studio_rgimen' : Regimen,
        'x_studio_estado' : Estado,
    })

for reserva in reservas:
    do_write = object.execute(db, uid, password, 'x_reservas', 'create', [reserva])
    print('Reserva cargadas correctamente')
