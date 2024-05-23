create database segundo_parcial;

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