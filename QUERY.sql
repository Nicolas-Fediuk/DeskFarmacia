create database Farmacia;

use Farmacia;

use master

DROP DATABASE Farmacia

create table LABORATORIOS(
NOMBRE_LAB varchar(50) PRIMARY KEY,
TEL_LAB bigint null,
MAIL_LAB VARCHAR(40),
DIRECCION_LAB varchar(20) null
);

ALter table LABORATORIOS alter column TEL_LAB varchar(15)


create table LABXMED(
CODMED_LABXMED INT,
NOMLAB_LABXMED varchar(50),
PRECIO_LABXMED DECIMAL(7,2),


PRIMARY KEY (CODMED_LABXMED,NOMLAB_LABXMED),
foreign key (CODMED_LABXMED) references MEDICAMENTOS(CODIGO_MED),
foreign key (NOMLAB_LABXMED) references LABORATORIOS(NOMBRE_LAB)
);




create table MEDICAMENTOS(
CODIGO_MED INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE_MED varchar(30) null,
DESCRIP_MED VARCHAR(500),
STOCK_MED int not null,
RECETA_MED bit not null,
);

create table FAMILIAS(
CODIGO_FAM INT IDENTITY(1,1) primary key,
DESCRIP_FAM varchar(200) not null
);


create table MEDXFAMILIA(
CODMED_MEDXFAM INT,
CODFAM_MEDXFAM INT,

primary key(CODMED_MEDXFAM,CODFAM_MEDXFAM),
foreign key(CODMED_MEDXFAM) references MEDICAMENTOS(CODIGO_MED),
foreign key (CODFAM_MEDXFAM) references FAMILIAS(CODIGO_FAM)
);

create table VENTAS(
NUMFAC_VENTA INT IDENTITY(1,1) primary key,
FECALT_VENTA datetime default GETDATE(),
TOTAL_VENTA decimal(6,2) default 0,
CLIENTE_VENTA int null,
DNIUSU_PEDIDO VARCHAR(15),
USUARIO_PEDIDO VARCHAR(30),
MAQINAUSU_PEDIDO VARCHAR(50),

foreign key (CLIENTE_VENTA) references CLIENTES(ID_CLIENT),
foreign key (DNIUSU_PEDIDO) references USUARIOS(DNI_USU)
);

create table CLIENTES(
ID_CLIENT INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE_CLIENT VARCHAR(30) NOT NULL,
APELLIDO_CLIENT VARCHAR(30) NOT NULL,
CORREO_CLIENT VARCHAR(50),
TELEFONO_CLIENT VARCHAR(15),
FENAC_CLIENT DATE,
PAMI_CLIENTE BIT NOT NULL,
OBRASOC_CLIENTE BIT NOT NULL
);

create table DETVENTAS(
NUMITEM_DETVENT INT IDENTITY(1,1) PRIMARY KEY,
NUMFACT_DETVENT INT,
CODMED_DETVENT INT,
PRECIO_DETVENT decimal(6,2) not null,
CANTID_DETVENT smallint not null,

foreign key (NUMFACT_DETVENT) references VENTAS(NUMFAC_VENTA),
foreign key (CODMED_DETVENT) references MEDICAMENTOS(CODIGO_MED)
);

CREATE TABLE LOGIN(
CORREO_LOG VARCHAR(50),
PASSWORD_LOG VARCHAR(30),
PRIMARY KEY(CORREO_LOG,PASSWORD_LOG),
foreign key (CORREO_LOG) references USUARIOS(CORREO_USU)
)

CREATE TABLE USUARIOS(
DNI_USU VARCHAR(15) PRIMARY KEY,
NOMBRE_USU VARCHAR(30),
APELLIDO_USU VARCHAR(30),
CORREO_USU VARCHAR(50) UNIQUE,
MONAUT_USU DECIMAL(8,2)
)

CREATE TABLE PEDIDOS(
ID_PEDIDO INT IDENTITY(1,1) PRIMARY KEY,
NOMLAB_PEDIDO VARCHAR(50),
FECALT_PEDIDO DATE DEFAULT GETDATE(),
REC_PEDIDO BIT DEFAULT 0,
FECREC_PEDIDO DATE,
DNIUSU_PEDIDO VARCHAR(15),
USUARIO_PEDIDO VARCHAR(30),
MAQINAUSU_PEDIDO VARCHAR(50),

foreign key (NOMLAB_PEDIDO) references LABORATORIOS(NOMBRE_LAB),
foreign key (DNIUSU_PEDIDO) references USUARIOS(DNI_USU)
)

alter table PEDIDOS add DNIUSRPEDREC_PEDIDO varchar(15);

CREATE TABLE ITEMPEDIDOS(
IDPEDIDO_ITEMPED INT,
IDITEMPED_ITEMPED INT,
CODMED_ITEMPED INT,
CANTID_ITEMPED INT,
PRECIO_ITEMPED DECIMAL (10,2)

primary key(IDPEDIDO_ITEMPED,IDITEMPED_ITEMPED)
foreign key (IDPEDIDO_ITEMPED) references PEDIDOS(ID_PEDIDO),
)

INSERT INTO USUARIOS(DNI_USU,NOMBRE_USU,APELLIDO_USU,CORREO_USU,MONAUT_USU)
SELECT '41542382','	NICOLAS','FEDIUK','NICOLASFEDIUK@GMAIL.COM',999999.00

INSERT INTO LOGIN(CORREO_LOG,PASSWORD_LOG)
SELECT 'NICOLASFEDIUK@GMAIL.COM','123'

/****************************************************************************/

 
 INSERT INTO MEDICAMENTOS(NOMBRE_MED,DESCRIP_MED,STOCK_MED,RECETA_MED)
 SELECT 'Ibuprofeno','Alivia el dolor y reduce la inflamación. Se utiliza para tratar dolores de cabeza, dolores menstruales, dolor de espalda, artritis, lesiones musculares, fiebre, entre otros.',540,0 UNION
 SELECT 'Amoxicilina','Trata infecciones bacterianas como otitis, sinusitis, neumonía, infecciones de piel, infecciones del tracto urinario, entre otras.',341,0 UNION
 SELECT 'Lorazepam','Calma la ansiedad y la tensión. Se utiliza para tratar trastornos de ansiedad, ataques de pánico, insomnio y síndrome de abstinencia del alcohol.',78,1 UNION
 SELECT 'Furosemida','Ayuda a eliminar el exceso de agua y sal del cuerpo. Se utiliza para tratar la hipertensión arterial, la insuficiencia cardíaca y la insuficiencia renal.',53,1  UNION
 SELECT 'Omeprazol','Reduce la cantidad de ácido producido en el estómago. Se utiliza para tratar la enfermedad por reflujo gastroesofágico (ERGE), úlceras gástricas, úlceras duodenales y otros trastornos relacionados con el ácido estomacal.',210,0

 INSERT INTO FAMILIAS(DESCRIP_FAM)
 SELECT 'Analgésico, antiinflamatorio no esteroideo (AINE)' UNION
 SELECT 'Antibiótico, penicilina' UNION
 SELECT 'Ansiolítico, benzodiacepina' UNION
 SELECT 'Diurético de asa' UNION
 SELECT ' Inhibidor de la bomba de protones (IBP)'

 INSERT INTO MEDXFAMILIA(CODMED_MEDXFAM,CODFAM_MEDXFAM)
 SELECT 1,1 UNION
 SELECT 2,2 UNION
 SELECT 3,3 UNION
 SELECT 4,4 UNION
 SELECT 5,5 

 INSERT INTO LABORATORIOS (NOMBRE_LAB,TEL_LAB,MAIL_LAB,DIRECCION_LAB)
 SELECT 'Pfizer', 1123456789, 'pfizer@gmail.com','CABA - mitre 123' union
 select 'Novartis',1169380426, 'novatis@gmail.com','Neuquen - salta 34' union
 select 'Roche', 1134560927,'roche@gmail.com','GBA - callao 2345' union
 select 'Sanofi',11498336709,'sanofi@gmail.com','CABA - san martin 4' union
 select 'Merck',1140932516,'merck@gmail.com','CABA - belgrano 41' 

 SELECT * FROM LABORATORIOS

 INSERT INTO LABXMED(NOMLAB_LABXMED,CODMED_LABXMED,PRECIO_LABXMED)
 SELECT 'Merck',1,120 UNION
 SELECT 'Novartis',2,123 UNION
 SELECT 'Merck',3,560 UNION
 SELECT 'Pfizer',4,350 UNION
 SELECT 'Roche',5,90


 select CODIGO_MED,NOMBRE_MED from MEDICAMENTOS

