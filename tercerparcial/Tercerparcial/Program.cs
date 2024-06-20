using Repository.Data.Models;
using Services.Logica;

string connectionString = "Host=localhost;port=5433;Database=segundoparcial;Username=postgres;Password=password;";
ClienteService clienteService = new ClienteService(connectionString);
FacturaService facturaService = new FacturaService(connectionString);
SucursalService sucursalService = new SucursalService(connectionString);
ProductoService productoService = new ProductoService(connectionString);
DetalleFacturaService detalleFacturaService = new DetalleFacturaService(connectionString);

Console.WriteLine("Ingrese: \n a - para agregar cliente" +
                            "\n b - para listar clientes " +
                            "\n c - Para agregar factura " +
                            "\n d - para listar facturas " +
                            "\n e - para agregar sucursal" +
                            "\n f - para listar sucurales" +
                            "\n g - para agregar productos" +
                            "\n h - para listar productos" +
                            "\n i - para agregar detalles de facturas" +
                            "\n j - para listar detalles de facturas");
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
if (opcion == "g")
{
    ProductoModel producto = new ProductoModel();
    Console.Write("Ingrese el nombre del producto: ");
    producto.descripcion = Console.ReadLine();
    Console.Write("Ingrese la cantidad minima: ");
    producto.cantidad_minima = int.Parse(Console.ReadLine());
    Console.Write("Ingrese la cantidad de stock: ");
    producto.cantidad_stock = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el precio de compra: ");
    producto.precio_compra = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el precio de venta: ");
    producto.precio_venta = int.Parse(Console.ReadLine());
    Console.Write("Ingrese la categoria: ");
    producto.categoria = Console.ReadLine();
    Console.Write("Ingrese la marca: ");
    producto.marca = Console.ReadLine();
    Console.Write("Ingrese el estado: ");
    producto.estado = Console.ReadLine();

    productoService.add(producto);
}
if (opcion == "h")
{
    productoService.GetAll().ToList().ForEach(producto =>
    Console.WriteLine(
        $"id_producto: {producto.id_producto} \n " +
        $"descripcion: {producto.descripcion} \n " +
        $"cantidad_minima: {producto.cantidad_minima} \n " +
        $"cantidad_stock: {producto.cantidad_stock} \n " +
        $"precio_compra: {producto.precio_compra} \n " +
        $"precio_venta: {producto.precio_venta} \n " +
        $"categoria: {producto.categoria} \n " +
        $"marca: {producto.marca} \n " +
        $"estado: {producto.estado} \n "
        )
    );
}
if (opcion == "i")
{
    DetalleFacturaModel detalleFactura = new DetalleFacturaModel();
    Console.Write("Ingrese el id de la factura: ");
    detalleFactura.id_factura = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el id del producto: ");
    detalleFactura.id_producto = int.Parse(Console.ReadLine());
    Console.Write("Ingrese la cantidad del producto: ");
    detalleFactura.cantidad_producto = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el subtotal: ");
    detalleFactura.subtotal = int.Parse(Console.ReadLine());

    detalleFacturaService.add(detalleFactura);
}
if (opcion == "j")
{
    detalleFacturaService.GetAll().ToList().ForEach(detalleFactura =>
    Console.WriteLine(
        $"id_det_factura: {detalleFactura.id_det_factura} \n " +
        $"id_factura: {detalleFactura.id_factura} \n " +
        $"id_producto: {detalleFactura.id_producto} \n " +
        $"cantidad_producto: {detalleFactura.cantidad_producto} \n " +
        $"subtotal: {detalleFactura.subtotal} \n "
        )
    );
}