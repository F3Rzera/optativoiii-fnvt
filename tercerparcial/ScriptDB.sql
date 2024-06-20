create database segundoparcial;

CREATE TABLE CLIENTE(
    id_cliente numeric(10),
    id_banco numeric(10),
    nombre varchar(50),
    apellido varchar(50),
    documento varchar(20),
    direccion varchar(50),
    mail varchar(50),
    celular numeric(10),
    estado varchar(1),
    primary key(id_cliente)
);

CREATE TABLE sucursal(
	id_sucursal numeric(10),
	descripcion varchar(100) not null,
	direccion varchar(100) not null,
	telefono varchar(40) not null,
	whatsapp varchar(40),
	mail varchar(50) not null,
	estado varchar(1) not null,
	primary key(id_sucursal)
);

CREATE TABLE FACTURA(
    id_factura numeric(10),
    id_cliente numeric(10),
    nro_factura varchar(14),
    fecha_hora timestamp,
    total numeric(18),
    total_iva5 numeric(18),
    total_iva10 numeric(18),
    total_iva numeric(18),
    total_letras varchar(100),
    id_sucursal numeric(10),
    primary key(id_factura),
    foreign key(id_cliente) references cliente(id_cliente),
	foreign key(id_sucursal) references sucursal(id_sucursal)
);

CREATE TABLE PRODUCTOS(
	ID_PRODUCTO NUMERIC(10),
	DESCRIPCION VARCHAR(100) NOT NULL,
	CANTIDAD_MINIMA NUMERIC(10) NOT NULL,
	CANTIDAD_STOCK NUMERIC(10) NOT NULL,
	PRECIO_COMPRA NUMERIC(18) NOT NULL,
	PRECIO_VENTA NUMERIC(18) NOT NULL,
	CATEGORIA VARCHAR(50) NOT NULL,
	MARCA VARCHAR(50) NOT NULL,
	ESTADO VARCHAR(1) NOT NULL,
	PRIMARY KEY(ID_PRODUCTO)
);

CREATE TABLE DETALLE_FACTURA(
	ID_DET_FACTURA NUMERIC(10),
	ID_FACTURA NUMERIC(10),
	ID_PRODUCTO NUMERIC(10),
	CANTIDAD_PRODUCTO NUMERIC(10)  NOT NULL,
	SUBTOTAL NUMERIC(18) NOT NULL,
	PRIMARY KEY(ID_DET_FACTURA),
	FOREIGN KEY(ID_FACTURA) REFERENCES FACTURA(ID_FACTURA),
	FOREIGN KEY(ID_PRODUCTO) REFERENCES PRODUCTOS(ID_PRODUCTO)
);

CREATE SEQUENCE public.id_cliente
    INCREMENT 1
    START 1
    MINVALUE 1
    OWNED BY cliente.id_cliente;
 
ALTER SEQUENCE public.id_cliente
    OWNER TO postgres;
   
CREATE SEQUENCE public.id_factura
    INCREMENT 1
    START 1
    MINVALUE 1
    OWNED BY factura.id_factura;
 
ALTER SEQUENCE public.id_factura
    OWNER TO postgres;
	

CREATE SEQUENCE public.id_sucursal
    INCREMENT 1
    START 1
    MINVALUE 1
    OWNED BY sucursal.id_sucursal;
 
ALTER SEQUENCE public.id_sucursal
    OWNER TO postgres;

CREATE SEQUENCE public.id_producto
    INCREMENT 1
    START 1
    MINVALUE 1
    OWNED BY productos.id_producto;
 
ALTER SEQUENCE public.id_producto
    OWNER TO postgres;

CREATE SEQUENCE public.id_det_factura
    INCREMENT 1
    START 1
    MINVALUE 1
    OWNED BY detalle_factura.id_det_factura;
 
ALTER SEQUENCE public.id_det_factura
    OWNER TO postgres;