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

xml_file = ET.parse('C:\Users\Simon\source\repos\HotelSOL\HotelSOL\Odoo\Clients.xml')
root = xml_file.getroot()

clientes = []
for cliente in root.findall('./clientes/cliente'):
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

    for cliente in clientes:
        do_write = object.execute(db, uid, password, 'x_clientes', 'create', [cliente])
        print('Clientes cargados correctamente')

