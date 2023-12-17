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
    [usuarios] = [models.execute_kw(db, uid, password, 'res.partner', 'search_read', [], {'fields': ['x_studio_nombre', 'x_studio_apellidos', 'x_studio_dni', 'x_studio_fecha_de_nacimiento_1', 'mobile', 'email', 'x_studio_direccin', 'x_studio_tarjeta_de_crdito_1', 'x_studio_descuento', 'x_studio_reserva_activa', 'customer_rank'], 'limit': 100})]

    odoo = ET.Element('NewDataset')

    for usuario in usuarios:
        if usuario['customer_rank'] > 0 :
            print("usuario", usuario)  
            Table1 = ET.SubElement(odoo, 'Table1')
            IDcliente = ET.SubElement(Table1, 'IDcliente')
            IDcliente.text = usuario['x_studio_dni']
            print(usuario['x_studio_dni'])
            Nombre = ET.SubElement(Table1, 'Nombre')
            Nombre.text = usuario['x_studio_nombre']
            Apellidos = ET.SubElement(Table1, 'Apellidos')
            Apellidos.text = usuario['x_studio_apellidos']
            FechaNac = ET.SubElement(Table1, 'FechaNac')
            FechaNac.text = usuario['x_studio_fecha_de_nacimiento_1']
            Telefono = ET.SubElement(Table1, 'Telefono')
            Telefono.text = usuario['mobile']
            Email = ET.SubElement(Table1, 'Email')
            Email.text = usuario['email']
            Direccion = ET.SubElement(Table1, 'Direccion')
            Direccion.text = usuario['x_studio_direccin']
            TarjetaCred = ET.SubElement(Table1, 'TarjetaCred')
            TarjetaCred.text = usuario['x_studio_tarjeta_de_crdito_1']
            Descuento = ET.SubElement(Table1, 'Descuento')
            Descuento.text = str(usuario['x_studio_descuento'])
            ReservaActiva = ET.SubElement(Table1, 'ReservaActiva')
            ReservaActiva.text = usuario['x_studio_reserva_activa']
            if usuario['x_studio_reserva_activa']:
                ReservaActiva.text = 'true'
            else:
                ReservaActiva.text = 'false'
    xml = ET.ElementTree(odoo)
    xml.write('odooToClients.xml')


else:
    print("autenticacion fallida")

