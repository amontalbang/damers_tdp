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
    [reservas] = [models.execute_kw(db, uid, password, 'x_reservas', 'search_read', [], {'fields': ['x_name', 'x_studio_id_de_reserva', 'x_studio_id_habitacin', 'x_studio_id_cliente', 'x_studio_fecha_entrada', 'x_studio_fecha_salida', 'x_studio_temporada', 'x_studio_rgimen', 'x_studio_estado'], 'limit': 100})]

    odoo = ET.Element('NewDataset')

    for reserva in reservas:
        print(reserva)
        Table1 = ET.SubElement(odoo, 'Table1')
        IDreserva = ET.SubElement(Table1, 'IDreserva')
        IDreserva.text = str(reserva['x_studio_id_de_reserva'])
        IDhabitacion = ET.SubElement(Table1, 'IDhabitacion')
        IDhabitacion.text = str(reserva['x_studio_id_habitacin'])
        IDcliente = ET.SubElement(Table1, 'IDcliente')
        IDcliente.text = reserva['x_studio_id_cliente']
        FechaEntr = ET.SubElement(Table1, 'FechaEntr')
        FechaEntr.text = reserva['x_studio_fecha_entrada']
        FechaSal = ET.SubElement(Table1, 'FechaSal')
        FechaSal.text = reserva['x_studio_fecha_salida']
        Temporada = ET.SubElement(Table1, 'Temporada')
        Temporada.text = reserva['x_studio_temporada']
        Regimen = ET.SubElement(Table1, 'Regimen')
        Regimen.text = reserva['x_studio_rgimen']
        Estado = ET.SubElement(Table1, 'Estado')
        if reserva['x_studio_estado']:
            Estado.text = 'true'
        else:
            Estado.text = 'false'
    xml = ET.ElementTree(odoo)
    xml.write('odooToReservations.xml')


else:
    print("autenticacion fallida")
