CREATE DATABASE primer_parcial;
USE primer_parcial;

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
 
CREATE TABLE FACTURA(
    id_factura numeric(10),
    id_cliente numeric(10),
    nro_factura varchar(14),
    fecha_hora varchar(18),
    total numeric(18),
    total_iva5 numeric(18),
    total_iva10 numeric(18),
    total_iva numeric(18),
    total_letras varchar(100),
    sucursal varchar(50),
    primary key(id_factura),
    foreign key(id_cliente) references cliente(id_cliente)
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
