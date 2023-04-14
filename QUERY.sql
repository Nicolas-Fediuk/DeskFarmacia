create database Farmacia;
use Farmacia;

create table LABORATORIOS(
CODIGO_LAB INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE_LAB varchar(15) not null,
TEL_LAB int null,
DIRECCION_LAB varchar(20) null,
);
--CREAR ESTA TABLA, ELIMINAR DE MEDICAMENTO 
create table MEDXLAB(

);


alter table LABORATORIOS add EMAIL_LAB varchar(50) not null

create table TIPO_MEDICAMENTOS(
CODIGO_TM INT IDENTITY(1,1) PRIMARY KEY,
DESCRIP_TM VARCHAR(255) null
);

create table MEDICAMENTOS(
COD_MED INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE_MED varchar(30) null,
TIPO_MED INT not null,
STOCK_MED int not null,
CODLAB_MED INT NOT null ,
PRECIO_MED decimal(6,2) not null,
RECETA_MED bit not null,

foreign key (TIPO_MED) references TIPO_MEDICAMENTOS(CODIGO_TM),
foreign key (CODLAB_MED) references LABORATORIOS(CODIGO_LAB)
);

create table FAMILIAS(
CODIGO_FAMILIA INT IDENTITY(1,1) primary key,
DESCRIP_FAMILIA varchar(30) not null
);

alter table FAMILIAS alter column DESCRIP_FAMILIA varchar(200) not null

create table MEDXFAMILIA(
CODMEDICAMENTO_MEDXFAMILIA INT,
CODFAMILIA_MEDXFAMILIA INT,

primary key(CODMEDICAMENTO_MEDXFAMILIA,CODFAMILIA_MEDXFAMILIA),
foreign key(CODMEDICAMENTO_MEDXFAMILIA) references MEDICAMENTOS(COD_MED),
foreign key (CODFAMILIA_MEDXFAMILIA) references FAMILIAS(CODIGO_FAMILIA)
);

create table VENTAS(
NUMFACTURA_VENTAS INT IDENTITY(1,1) primary key,
FECALT_VENTAS datetime default GETDATE(),
TOTAL_VENTAS decimal(6,2) default 0,
CLIENTE_VENTAS int null

foreign key (CLIENTE_VENTAS) references CLIENTES(ID_CLIENTE),
);

create table CLIENTES(
ID_CLIENTE INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE_CLIENTE VARCHAR(30) NOT NULL,
APELLIDO_CLIENTE VARCHAR(30) NOT NULL,
CORREO_CLIENTE VARCHAR(50),
TELEFONO_CLIENTE VARCHAR(15),
FENAC_CLIENTE DATE,
PAMI_CLIENTE BIT NOT NULL,
OBRASOC_CLIENTE INT, 
NUMOBRASOC_CLIETNE VARCHAR(200) NULL

foreign key (OBRASOC_CLIENTE) references OBRASOCIALES(ID_OBRASOC),
);

CREATE TABLE OBRASOCIALES(
ID_OBRASOC INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE_OBRASOC VARCHAR(50) NOT NULL
);

create table DETVENTAS(
NUMITEM_DETVENTAS INT IDENTITY(1,1),
NUMFACTURA_DETVENTAS INT,
CODMED_DETVENTAS INT,
PRECIO_DETVENTAS decimal(6,2) not null,
CANTIDVEND_DETVENTAS smallint not null,

primary key (NUMITEM_DETVENTAS),
foreign key (NUMFACTURA_DETVENTAS) references VENTAS(NUMFACTURA_VENTAS),
foreign key (CODMED_DETVENTAS) references MEDICAMENTOS(COD_MED)
);

CREATE TABLE PASS(
USR_SEC VARCHAR(30),
PASS_SEC VARCHAR(30)
PRIMARY KEY(USR_SEC,PASS_SEC)
)

INSERT INTO PASS(USR_SEC,PASS_SEC)
SELECT 'ADMIN','123'

DROP DATABASE Farmacia

