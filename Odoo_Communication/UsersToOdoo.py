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

xml_file = ET.parse('..\\..\\..\\XMLs\\Exported_Users.xml')
root = xml_file.getroot()

usuarios = []
for usuario in root:
    IDusuario = usuario.find('IDusuario').text   
    Email = usuario.find('Email').text 
    Password = usuario.find('Password').text 
    print(IDusuario)

    usuarios.append({
        'x_name' : IDusuario,
        'x_studio_user' : IDusuario,
        'x_studio_password' : Password,
        'x_studio_email' : Email,
    })

for usuario in usuarios:
    do_write = object.execute(db, uid, password, 'x_usuarios', 'create', [usuario])
    print('Usuario cargado correctamente')


