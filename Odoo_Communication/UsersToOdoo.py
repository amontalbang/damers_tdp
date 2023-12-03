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

# Creamos la llamada rpc a Odoo
common = xmlrpc.client.ServerProxy('{}/xmlrpc/2/common'.format(url))
object = xmlrpc.client.ServerProxy('{}/xmlrpc/2/object'.format(url))
uid = common.authenticate(db, username, password, {})

# Recogemos el XML que procede y le damos formato
xml_file = ET.parse('..\\XMLs\\Exported_Users.xml')
root = xml_file.getroot()

# Creamos un array con los datos existentes en Odoo usando los identificadores
userIds = object.execute(db, uid, password, 'x_usuarios', 'search', [])
userEmails = []
for id in userIds:
    [record] = object.execute(db, uid, password, 'x_usuarios', 'read', [id])
    userEmails.append(record['x_studio_email'])

# Creamos un segundo array con los datos del XML a exportar
usuarios = []
for usuario in root:
    IDusuario = usuario.find('IDusuario').text   
    Email = usuario.find('Email').text 
    Password = usuario.find('Password').text 
    print(IDusuario)

    if (not (Email in userEmails)):
        usuarios.append({
            'x_name' : IDusuario,
            'x_studio_user' : IDusuario,
            'x_studio_password' : Password,
            'x_studio_email' : Email,
        })

# Recorremos ese segundo array escribiendo los datos en Odoo
if len(usuarios) > 0:
    for usuario in usuarios:
        do_write = object.execute(db, uid, password, 'x_usuarios', 'create', [usuario])
        print('Usuario cargado correctamente')


