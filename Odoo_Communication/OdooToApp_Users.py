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
    [usuarios] = [models.execute_kw(db, uid, password, 'x_usuarios', 'search_read', [], {'fields': ['x_name', 'x_studio_user', 'x_studio_password', 'x_studio_email'], 'limit': 100})]

    odoo = ET.Element('NewDataset')

    for usuario in usuarios:
        Table1 = ET.SubElement(odoo, 'Table1')
        IDusuario = ET.SubElement(Table1, 'IDusuario')
        IDusuario.text = usuario['x_studio_user']
        Email = ET.SubElement(Table1, 'Email')
        Email.text = usuario['x_studio_email']
        Password = ET.SubElement(Table1, 'Password')
        Password.text = usuario['x_studio_password']
        
    xml = ET.ElementTree(odoo)
    xml.write('odooToUsers.xml')


else:
    print("autenticacion fallida")
