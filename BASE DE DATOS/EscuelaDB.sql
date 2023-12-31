USE [master]
GO
/****** Object:  Database [Escuela]    Script Date: 01/09/2023 12:21:50 p. m. ******/
CREATE DATABASE [Escuela] ON  PRIMARY 
( NAME = N'Escuela', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\Escuela.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Escuela_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\Escuela_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'Escuela', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Escuela].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Escuela] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Escuela] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Escuela] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Escuela] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Escuela] SET ARITHABORT OFF 
GO
ALTER DATABASE [Escuela] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Escuela] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Escuela] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Escuela] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Escuela] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Escuela] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Escuela] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Escuela] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Escuela] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Escuela] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Escuela] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Escuela] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Escuela] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Escuela] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Escuela] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Escuela] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Escuela] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Escuela] SET  MULTI_USER 
GO
ALTER DATABASE [Escuela] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Escuela] SET DB_CHAINING OFF 
GO
USE [Escuela]
GO
/****** Object:  Table [dbo].[alumno]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumno](
	[matricula] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[carrera] [varchar](10) NOT NULL,
 CONSTRAINT [PK_alumno] PRIMARY KEY CLUSTERED 
(
	[matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[alumnomateria]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumnomateria](
	[matricula] [int] NOT NULL,
	[clave] [varchar](10) NOT NULL,
 CONSTRAINT [PK_alumnomateria] PRIMARY KEY CLUSTERED 
(
	[matricula] ASC,
	[clave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[carrera]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carrera](
	[carrera] [varchar](10) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_carrera] PRIMARY KEY CLUSTERED 
(
	[carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[escuela]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[escuela](
	[escuelaid] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_escuela] PRIMARY KEY CLUSTERED 
(
	[escuelaid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[maestro]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[maestro](
	[maestroid] [int] IDENTITY(1,1) NOT NULL,
	[escuelaid] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[titulo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_maestro] PRIMARY KEY CLUSTERED 
(
	[maestroid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materia]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materia](
	[clave] [varchar](10) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[creditos] [int] NOT NULL,
 CONSTRAINT [PK_materia] PRIMARY KEY CLUSTERED 
(
	[clave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[alumno] ([matricula], [nombre], [apellido], [carrera]) VALUES (123, N'Alejandro', N'Gomez', N'IM')
INSERT [dbo].[alumno] ([matricula], [nombre], [apellido], [carrera]) VALUES (234, N'Jade', N'Benavides', N'DCHA')
INSERT [dbo].[alumno] ([matricula], [nombre], [apellido], [carrera]) VALUES (465, N'Alejandra', N'Alamilla', N'ISC')
INSERT [dbo].[alumno] ([matricula], [nombre], [apellido], [carrera]) VALUES (467, N'Valeria', N'Trejo', N'PD')
INSERT [dbo].[alumno] ([matricula], [nombre], [apellido], [carrera]) VALUES (569, N'Gabriela', N'Pauli', N'ISC')
INSERT [dbo].[alumno] ([matricula], [nombre], [apellido], [carrera]) VALUES (721, N'Diego', N'Rivas', N'LADE')
INSERT [dbo].[alumno] ([matricula], [nombre], [apellido], [carrera]) VALUES (789, N'Mariana', N'Arellano', N'ISC')
INSERT [dbo].[alumno] ([matricula], [nombre], [apellido], [carrera]) VALUES (7963, N'Gabriel', N'Salas', N'ISC')
GO
INSERT [dbo].[alumnomateria] ([matricula], [clave]) VALUES (123, N'123')
INSERT [dbo].[alumnomateria] ([matricula], [clave]) VALUES (234, N'123')
INSERT [dbo].[alumnomateria] ([matricula], [clave]) VALUES (234, N'567')
INSERT [dbo].[alumnomateria] ([matricula], [clave]) VALUES (465, N'567')
INSERT [dbo].[alumnomateria] ([matricula], [clave]) VALUES (467, N'567')
GO
INSERT [dbo].[carrera] ([carrera], [nombre]) VALUES (N'DCHA', N'Licenciatura en Derecho')
INSERT [dbo].[carrera] ([carrera], [nombre]) VALUES (N'IB', N'Ingenieria en Biotecnología ')
INSERT [dbo].[carrera] ([carrera], [nombre]) VALUES (N'IC', N'Ingenieria Civil')
INSERT [dbo].[carrera] ([carrera], [nombre]) VALUES (N'IIS', N'Ingenieria  Industrial y de Sistemas')
INSERT [dbo].[carrera] ([carrera], [nombre]) VALUES (N'IM', N'Ingenieria Mecatronica')
INSERT [dbo].[carrera] ([carrera], [nombre]) VALUES (N'ISC', N'Ingenieria en Sistemas Computacionales')
INSERT [dbo].[carrera] ([carrera], [nombre]) VALUES (N'LADE', N'Licenciatura en Administración de Empresas')
INSERT [dbo].[carrera] ([carrera], [nombre]) VALUES (N'PD', N'Medico Pediatra')
GO
SET IDENTITY_INSERT [dbo].[escuela] ON 

INSERT [dbo].[escuela] ([escuelaid], [nombre]) VALUES (1, N'Leyes')
INSERT [dbo].[escuela] ([escuelaid], [nombre]) VALUES (2, N'Sistemas')
INSERT [dbo].[escuela] ([escuelaid], [nombre]) VALUES (3, N'Ateneo')
INSERT [dbo].[escuela] ([escuelaid], [nombre]) VALUES (4, N'Arquitectura')
INSERT [dbo].[escuela] ([escuelaid], [nombre]) VALUES (5, N'Mercadotecnia')
INSERT [dbo].[escuela] ([escuelaid], [nombre]) VALUES (6, N'Trabajo Social')
INSERT [dbo].[escuela] ([escuelaid], [nombre]) VALUES (7, N'Artes')
INSERT [dbo].[escuela] ([escuelaid], [nombre]) VALUES (8, N'Conalep')
INSERT [dbo].[escuela] ([escuelaid], [nombre]) VALUES (9, N'UNAM')
INSERT [dbo].[escuela] ([escuelaid], [nombre]) VALUES (10, N'wash')
INSERT [dbo].[escuela] ([escuelaid], [nombre]) VALUES (11, N'w')
INSERT [dbo].[escuela] ([escuelaid], [nombre]) VALUES (12, N'POLI')
SET IDENTITY_INSERT [dbo].[escuela] OFF
GO
SET IDENTITY_INSERT [dbo].[maestro] ON 

INSERT [dbo].[maestro] ([maestroid], [escuelaid], [nombre], [titulo]) VALUES (1, 2, N'Urbano Flores', N'ING')
INSERT [dbo].[maestro] ([maestroid], [escuelaid], [nombre], [titulo]) VALUES (2, 3, N'Renteria', N'ING')
INSERT [dbo].[maestro] ([maestroid], [escuelaid], [nombre], [titulo]) VALUES (3, 1, N'Jadrick', N'DCHA')
INSERT [dbo].[maestro] ([maestroid], [escuelaid], [nombre], [titulo]) VALUES (4, 2, N'Maria Fernanda', N'ING')
SET IDENTITY_INSERT [dbo].[maestro] OFF
GO
INSERT [dbo].[materia] ([clave], [nombre], [creditos]) VALUES (N'123', N'Base de Datos II', 100)
INSERT [dbo].[materia] ([clave], [nombre], [creditos]) VALUES (N'567', N'Matematicas', 100)
GO
ALTER TABLE [dbo].[maestro]  WITH CHECK ADD  CONSTRAINT [FK_Table_1_Escuela] FOREIGN KEY([escuelaid])
REFERENCES [dbo].[escuela] ([escuelaid])
GO
ALTER TABLE [dbo].[maestro] CHECK CONSTRAINT [FK_Table_1_Escuela]
GO
/****** Object:  StoredProcedure [dbo].[spAlumnoDelete]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAlumnoDelete]
	@matricula INT
AS
BEGIN
	SET NOCOUNT ON;
    DELETE alumno WHERE matricula = @matricula
END
GO
/****** Object:  StoredProcedure [dbo].[spAlumnoGetById]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAlumnoGetById]
	@matricula INT,
	@nombre VARCHAR(50) OUT,
	@apellido VARCHAR(100) OUT,
	@carrera VARCHAR (10) OUT
AS
BEGIN
	SET NOCOUNT ON;
    SELECT @nombre=nombre, @apellido=apellido, @carrera=carrera  FROM alumno WHERE matricula = @matricula
END
GO
/****** Object:  StoredProcedure [dbo].[spAlumnoGetConCarrera]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAlumnoGetConCarrera]
AS
BEGIN	
SELECT a.matricula, {fn CONCAT(a.nombre, {fn CONCAT(' ', a.apellido) } ) } AS nombrecompleto, c.nombre AS nombrecarrera FROM alumno a INNER JOIN carrera c ON a.carrera = c.carrera
END
 
GO
/****** Object:  StoredProcedure [dbo].[spALumnoGetLista]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spALumnoGetLista]
AS
BEGIN
	SET NOCOUNT ON;
    SELECT * FROM alumno
END
GO
/****** Object:  StoredProcedure [dbo].[spAlumnoGetListByFilter]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spAlumnoGetListByFilter]
	@matricula INT = 0,
	@nombre VARCHAR(50) = '',
	@apellido VARCHAR(100) ='' ,
	@carrera VARCHAR (10) = ''
AS
BEGIN
	SET NOCOUNT ON;
    SELECT nombre, apellido, carrera  FROM alumno WHERE (matricula = @matricula OR @matricula=0) AND (nombre = @nombre OR @nombre='') AND (apellido = @apellido OR @apellido ='') AND (carrera = @carrera OR @carrera ='') 
END
GO
/****** Object:  StoredProcedure [dbo].[spAlumnoInsert]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAlumnoInsert]
	@matricula INT,
	@nombre VARCHAR(50),
	@apellido VARCHAR(100),
	@carrera VARCHAR (10)
AS
BEGIN
	SET NOCOUNT ON;
    INSERT INTO alumno(matricula, nombre, apellido, carrera) VALUES (@matricula, @nombre, @apellido, @carrera) 
END
GO
/****** Object:  StoredProcedure [dbo].[spAlumnoMateriaGetLista]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAlumnoMateriaGetLista] 
	@matricula int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT materia.clave, materia.nombre, materia.creditos FROM materia INNER JOIN alumnomateria ON  materia.clave = alumnomateria.clave where alumnomateria.matricula =@matricula
END
GO
/****** Object:  StoredProcedure [dbo].[spAlumnoMateriaInsert]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAlumnoMateriaInsert] 
	@matricula int,
	@clave varchar(10)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO alumnomateria VALUES(@matricula, @clave)
END
GO
/****** Object:  StoredProcedure [dbo].[spAlumnoUpdate]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAlumnoUpdate]
	@matricula INT,
	@nombre VARCHAR(50),
	@apellido VARCHAR(100),
	@carrera VARCHAR (10)
AS
BEGIN
	SET NOCOUNT ON;
    UPDATE alumno SET nombre=@nombre, apellido=@apellido, carrera=@carrera WHERE matricula = @matricula
END
GO
/****** Object:  StoredProcedure [dbo].[spEscuelaInsert]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEscuelaInsert]
(
	@escuelaid int OUT,
	@nombre varchar(100)
)
AS
BEGIN
	INSERT INTO escuela VALUES (@nombre)
	SET @escuelaid = SCOPE_IDENTITY ()
END
GO
/****** Object:  StoredProcedure [dbo].[spMateriaDelete]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMateriaDelete]
	@clave varchar(10)
AS
BEGIN
	SET NOCOUNT ON;
    DELETE materia WHERE clave = @clave
END
GO
/****** Object:  StoredProcedure [dbo].[spMateriaGetByClave]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMateriaGetByClave] 
	@clave varchar(10),
	@nombre varchar(100) OUT,
	@creditos int OUT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT @clave =clave, @nombre = nombre, @creditos = creditos FROM materia WHERE clave = @clave
END
GO
/****** Object:  StoredProcedure [dbo].[spMateriaGetLista]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMateriaGetLista]
AS
BEGIN
	SET NOCOUNT ON;
    SELECT * FROM Materia
END
GO
/****** Object:  StoredProcedure [dbo].[spMateriaInsert]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMateriaInsert] 
	@clave varchar(10),
	@nombre varchar(100),
	@creditos int 
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO materia VALUES(@clave, @nombre, @creditos)
END
GO
/****** Object:  StoredProcedure [dbo].[spMateriaUpdate]    Script Date: 01/09/2023 12:21:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMateriaUpdate]
	@clave varchar(10),
	@nombre varchar(100) OUT,
	@creditos int OUT
AS
BEGIN
	SET NOCOUNT ON;
    UPDATE materia SET clave = @clave, nombre=@nombre, creditos = @creditos WHERE clave = @clave
END
GO
USE [master]
GO
ALTER DATABASE [Escuela] SET  READ_WRITE 
GO
