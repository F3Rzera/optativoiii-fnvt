using Repository.Data.Models;
using Services.Logica;
//fverdun
string connectionString = "Host=localhost;port=5432;Database=segundo_parcial;Username=postgres;Password=123456;";
ClienteService clienteService = new ClienteService(connectionString);
FacturaService facturaService = new FacturaService(connectionString);
SucursalService sucursalService = new SucursalService(connectionString);


Console.WriteLine("Ingrese: \n a - para añadir cliente" +
                            "\n b - para mostrar clientes " +
                            "\n c - Para añadir factura " +
                            "\n d - para mostrar facturas " +
                            "\n e - para añadir sucursal" +
                            "\n f - para mostrar sucurales");
string opcion = Console.ReadLine();

if (opcion == "a") {
    ClienteModel cliente = new ClienteModel();
    Console.Write("Ingrese su codigo de banco: ");
    cliente.id_banco = int.Parse(Console.ReadLine());
    Console.Write("Ingrese su nombre: ");
    cliente.nombre = Console.ReadLine();
    Console.Write("Ingrese su apellido: ");
    cliente.apellido = Console.ReadLine();
    Console.Write("Ingrese su documento: ");
    cliente.documento = Console.ReadLine();
    Console.Write("Ingrese su direccion: ");
    cliente.direccion = Console.ReadLine();
    Console.Write("Ingrese su mail: ");
    cliente.mail = Console.ReadLine();
    Console.Write("Ingrese su celular: ");
    cliente.celular = int.Parse(Console.ReadLine());
    Console.Write("Ingrese su estado: ");
    cliente.estado = Console.ReadLine();

    clienteService.add(cliente);
}
if (opcion == "b")
{
    clienteService.GetAll().ToList().ForEach(cliente =>
    Console.WriteLine(
        $"id_cliente: {cliente.id_cliente} \n " +
        $"id_banco: {cliente.id_banco} \n " +
        $"Nombre: {cliente.nombre} \n " +
        $"Apellido: {cliente.apellido} \n " +
        $"Documento: {cliente.documento} \n " +
        $"Direccion: {cliente.direccion} \n " +
        $"Correo: {cliente.mail} \n " +
        $"Celular: {cliente.celular} \n " +
        $"Estado: {cliente.estado} \n " 
        )
    );
}
if (opcion == "c")
{
    FacturaModel factura = new FacturaModel();
    Console.Write("Ingrese su codigo de id_cliente: ");
    factura.id_cliente = int.Parse(Console.ReadLine());
    Console.Write("Ingrese su nro de factura: ");
    factura.nro_factura = Console.ReadLine();
    Console.Write("Ingrese la fecha y hora de factura: ");
    factura.fecha_hora = DateTime.Parse(Console.ReadLine());
    Console.Write("Ingrese el monto total: ");
    factura.total = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el monto de iva 5%: ");
    factura.total_iva5 = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el monto de iva 10%: ");
    factura.total_iva10 = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el monto de iva total: ");
    factura.total_iva = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el monto total en letras: ");
    factura.total_letras = Console.ReadLine();
    Console.Write("Ingrese el id de la sucursal: ");
    factura.id_sucursal = int.Parse(Console.ReadLine());

    facturaService.add(factura);
}
if (opcion == "d")
{
    facturaService.GetAll().ToList().ForEach(factura =>
    Console.WriteLine(
        $"id_factura: {factura.id_factura} \n " +
        $"id_cliente: {factura.id_cliente} \n " +
        $"nro_factura: {factura.nro_factura} \n " +
        $"fecha_hora: {factura.fecha_hora} \n " +
        $"total: {factura.total} \n " +
        $"total_iva5: {factura.total_iva5} \n " +
        $"total_iva10: {factura.total_iva10} \n " +
        $"total_iva: {factura.total_iva} \n " +
        $"total_letras: {factura.total_letras} \n " +
        $"surcusal: {factura.id_sucursal} \n "


        )
    );
}
if (opcion == "e")
{
    SucursalModel sucursal = new SucursalModel();
    Console.Write("Ingrese el nombre de la sucursal: ");
    sucursal.descripcion = Console.ReadLine();
    Console.Write("Ingrese la direccion: ");
    sucursal.direccion = Console.ReadLine();
    Console.Write("Ingrese el telefono: ");
    sucursal.telefono = Console.ReadLine();
    Console.Write("Ingrese el whatsapp: ");
    sucursal.whatsapp = Console.ReadLine();
    Console.Write("Ingrese el mail: ");
    sucursal.mail = Console.ReadLine();
    Console.Write("Ingrese el estado (A = Activo, I = Inactivo): ");
    sucursal.estado = Console.ReadLine();

    sucursalService.add(sucursal);
}
if (opcion == "f")
{
    sucursalService.GetAll().ToList().ForEach(sucursal =>
    Console.WriteLine(
        $"id_sucursal: {sucursal.id_sucursal} \n " +
        $"descripcion: {sucursal.descripcion} \n " +
        $"direccion: {sucursal.direccion} \n " +
        $"telefono: {sucursal.telefono} \n " +
        $"whatsapp: {sucursal.whatsapp} \n " +
        $"mail: {sucursal.mail} \n " +
        $"estado: {sucursal.estado} \n "
        )
    );
}