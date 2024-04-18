using Primerparcial.Modelos;
using Repository.Data.Models;
using Services.Logica;
using System.Numerics;

string connectionString = "Host=localhost;port=5432;Database=primer_parcial;Username=postgres;Password=123456;";
ClienteService clienteService = new ClienteService(connectionString);
FacturaService facturaService = new FacturaService(connectionString);


Console.WriteLine("Ingrese: \n a - para insertar cliente \n b - para listar clientes \n c - Para agregar factura \n d - para listar factura");
string opcion = Console.ReadLine();

if (opcion == "a") {
    ClienteModel cliente = new ClienteModel();
    Console.Write("Ingrese su codigo de banco: ");
    cliente.id_banco = BigInteger.Parse(Console.ReadLine());
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
    cliente.celular = BigInteger.Parse(Console.ReadLine());
    Console.Write("Ingrese su estado: ");
    cliente.estado = Console.ReadLine();

    clienteService.insertar(cliente);
}
if (opcion == "b")
{
    clienteService.listado().ForEach(cliente =>
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
    factura.id_cliente = BigInteger.Parse(Console.ReadLine());
    Console.Write("Ingrese su nro de factura: ");
    factura.nro_factura = Console.ReadLine();
    Console.Write("Ingrese la fecha y hora de factura: ");
    factura.fecha_hora = DateTime.Parse(Console.ReadLine());
    Console.Write("Ingrese el monto total: ");
    factura.total = BigInteger.Parse(Console.ReadLine());
    Console.Write("Ingrese el monto de iva 5%: ");
    factura.total_iva5 = BigInteger.Parse(Console.ReadLine());
    Console.Write("Ingrese el monto de iva 10%: ");
    factura.total_iva10 = BigInteger.Parse(Console.ReadLine());
    Console.Write("Ingrese el monto de iva total: ");
    factura.total_iva = BigInteger.Parse(Console.ReadLine());
    Console.Write("Ingrese el monto total en letras: ");
    factura.total_letras = Console.ReadLine();
    Console.Write("Ingrese la sucursal: ");
    factura.sucursal = Console.ReadLine();

    facturaService.insertar(factura);
}
if (opcion == "d")
{
    facturaService.listado().ForEach(factura =>
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
        $"surcusal: {factura.sucursal} \n "


        )
    );
}