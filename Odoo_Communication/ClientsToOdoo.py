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

xml_file = ET.parse('..\\..\\..\\XMLs\\Exported_Clients.xml')
root = xml_file.getroot()

clientOdooIds = object.execute(db, uid, password, 'x_clientes', 'search', [])
clientIds = []
for id in clientOdooIds:
    [record] = object.execute(db, uid, password, 'x_clientes', 'read', [id])
    clientIds.append(record['x_studio_dni'])

clientes = []
for cliente in root:
    IDcliente = cliente.find('IDcliente').text 
    Nombre = cliente.find('Nombre').text 
    Apellidos = cliente.find('Apellidos').text 
    FechaNac = cliente.find('FechaNac').text 
    Telefono = cliente.find('Telefono').text 
    Email = cliente.find('Email').text 
    Direccion = cliente.find('Direccion').text 
    TarjetaCred = cliente.find('TarjetaCred').text 
    Descuento = cliente.find('Descuento').text 
    ReservaActiva = cliente.find('ReservaActiva').text
    print(clientIDs)

    if (not (IDcliente in clientIds)):
        clientes.append({
            'x_name' : IDcliente,
            'x_studio_dni' : IDcliente,
            'x_studio_nombre' : Nombre,
            'x_studio_apellidos' : Apellidos,
            'x_studio_fecha_de_nacimiento_1' : FechaNac,
            'x_studio_telfono' : Telefono,
            'x_studio_email' : Email,
            'x_studio_direccin' : Direccion,
            'x_studio_tarjeta_de_crdito' : TarjetaCred,
            'x_studio_descuento' : Descuento,
            'x_studio_reserva_activa' : ReservaActiva,
        })

if len(clientes) > 0:
    for cliente in clientes:
        do_write = object.execute(db, uid, password, 'x_clientes', 'create', [cliente])
        print('Cliente cargado correctamente')



