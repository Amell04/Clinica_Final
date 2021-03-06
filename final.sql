USE [master]
GO
/****** Object:  Database [Clinica_Vet_Final]    Script Date: 03/10/2018 11:29:12 p. m. ******/
CREATE DATABASE [Clinica_Vet_Final]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Clinica_Vet_Final', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Clinica_Vet_Final.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Clinica_Vet_Final_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Clinica_Vet_Final_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Clinica_Vet_Final] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Clinica_Vet_Final].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Clinica_Vet_Final] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET ARITHABORT OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Clinica_Vet_Final] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Clinica_Vet_Final] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Clinica_Vet_Final] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Clinica_Vet_Final] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Clinica_Vet_Final] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Clinica_Vet_Final] SET  MULTI_USER 
GO
ALTER DATABASE [Clinica_Vet_Final] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Clinica_Vet_Final] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Clinica_Vet_Final] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Clinica_Vet_Final] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Clinica_Vet_Final] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Clinica_Vet_Final] SET QUERY_STORE = OFF
GO
USE [Clinica_Vet_Final]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Clinica_Vet_Final]
GO
/****** Object:  Table [dbo].[cita]    Script Date: 03/10/2018 11:29:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cita](
	[codcita] [int] IDENTITY(1,1) NOT NULL,
	[codusuario] [int] NULL,
	[codmascota] [int] NULL,
	[codveterinario] [int] NULL,
	[fecha] [varchar](12) NULL,
	[hora] [varchar](8) NULL,
	[codestado] [int] NULL,
 CONSTRAINT [PK_cita] PRIMARY KEY CLUSTERED 
(
	[codcita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[consulta]    Script Date: 03/10/2018 11:29:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[consulta](
	[codconsulta] [int] IDENTITY(1,1) NOT NULL,
	[diagnostico] [varchar](150) NULL,
	[observaciones] [varchar](150) NULL,
	[codcita] [int] NULL,
 CONSTRAINT [PK_consulta] PRIMARY KEY CLUSTERED 
(
	[codconsulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado]    Script Date: 03/10/2018 11:29:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado](
	[codestado] [int] IDENTITY(1,1) NOT NULL,
	[estado] [varchar](50) NULL,
 CONSTRAINT [PK_estado] PRIMARY KEY CLUSTERED 
(
	[codestado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mascota]    Script Date: 03/10/2018 11:29:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mascota](
	[codmascota] [int] IDENTITY(1,1) NOT NULL,
	[codpropietario] [int] NULL,
	[codtipo] [int] NULL,
	[nombre] [varchar](50) NULL,
	[peso] [varchar](5) NULL,
	[sexo] [varchar](10) NULL,
	[fechanacimiento] [date] NULL,
 CONSTRAINT [PK_mascota] PRIMARY KEY CLUSTERED 
(
	[codmascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicamento]    Script Date: 03/10/2018 11:29:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamento](
	[idMed] [int] IDENTITY(1,1) NOT NULL,
	[Medicamento] [varchar](50) NULL,
	[fechaVencimiento] [date] NULL,
 CONSTRAINT [PK_Medicamento] PRIMARY KEY CLUSTERED 
(
	[idMed] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Propietario_Mascota]    Script Date: 03/10/2018 11:29:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Propietario_Mascota](
	[codpropietario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[dui] [varchar](15) NULL,
	[sexo] [varchar](10) NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [varchar](15) NULL,
 CONSTRAINT [PK_Propietario_Mascota] PRIMARY KEY CLUSTERED 
(
	[codpropietario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[recetaDetalle]    Script Date: 03/10/2018 11:29:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[recetaDetalle](
	[idreceta] [int] IDENTITY(1,1) NOT NULL,
	[idMed] [int] NULL,
	[idConsulta] [int] NULL,
	[dosis] [varchar](50) NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK_recetaDetalle] PRIMARY KEY CLUSTERED 
(
	[idreceta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol]    Script Date: 03/10/2018 11:29:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rol] [varchar](50) NULL,
 CONSTRAINT [PK_rol] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_mascota]    Script Date: 03/10/2018 11:29:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_mascota](
	[codtipo] [int] IDENTITY(1,1) NOT NULL,
	[especie] [varchar](100) NULL,
 CONSTRAINT [PK_tipo_mascota] PRIMARY KEY CLUSTERED 
(
	[codtipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 03/10/2018 11:29:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](100) NULL,
	[pass] [varchar](100) NULL,
	[id_rol] [int] NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[veterinario]    Script Date: 03/10/2018 11:29:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[veterinario](
	[codVeterinario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[dui] [varchar](10) NULL,
	[telefono] [varchar](14) NULL,
	[sexo] [varchar](10) NULL,
	[direccion] [varchar](150) NULL,
 CONSTRAINT [PK_veterinario] PRIMARY KEY CLUSTERED 
(
	[codVeterinario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cita]  WITH CHECK ADD  CONSTRAINT [FK_cita_estado] FOREIGN KEY([codestado])
REFERENCES [dbo].[estado] ([codestado])
GO
ALTER TABLE [dbo].[cita] CHECK CONSTRAINT [FK_cita_estado]
GO
ALTER TABLE [dbo].[cita]  WITH CHECK ADD  CONSTRAINT [FK_cita_mascota] FOREIGN KEY([codmascota])
REFERENCES [dbo].[mascota] ([codmascota])
GO
ALTER TABLE [dbo].[cita] CHECK CONSTRAINT [FK_cita_mascota]
GO
ALTER TABLE [dbo].[cita]  WITH CHECK ADD  CONSTRAINT [FK_cita_usuario] FOREIGN KEY([codusuario])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[cita] CHECK CONSTRAINT [FK_cita_usuario]
GO
ALTER TABLE [dbo].[cita]  WITH CHECK ADD  CONSTRAINT [FK_cita_veterinario] FOREIGN KEY([codveterinario])
REFERENCES [dbo].[veterinario] ([codVeterinario])
GO
ALTER TABLE [dbo].[cita] CHECK CONSTRAINT [FK_cita_veterinario]
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD  CONSTRAINT [FK_consulta_cita] FOREIGN KEY([codcita])
REFERENCES [dbo].[cita] ([codcita])
GO
ALTER TABLE [dbo].[consulta] CHECK CONSTRAINT [FK_consulta_cita]
GO
ALTER TABLE [dbo].[mascota]  WITH CHECK ADD  CONSTRAINT [FK_mascota_Propietario_Mascota] FOREIGN KEY([codpropietario])
REFERENCES [dbo].[Propietario_Mascota] ([codpropietario])
GO
ALTER TABLE [dbo].[mascota] CHECK CONSTRAINT [FK_mascota_Propietario_Mascota]
GO
ALTER TABLE [dbo].[mascota]  WITH CHECK ADD  CONSTRAINT [FK_mascota_tipo_mascota] FOREIGN KEY([codtipo])
REFERENCES [dbo].[tipo_mascota] ([codtipo])
GO
ALTER TABLE [dbo].[mascota] CHECK CONSTRAINT [FK_mascota_tipo_mascota]
GO
ALTER TABLE [dbo].[recetaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_recetaDetalle_consulta] FOREIGN KEY([idConsulta])
REFERENCES [dbo].[consulta] ([codconsulta])
GO
ALTER TABLE [dbo].[recetaDetalle] CHECK CONSTRAINT [FK_recetaDetalle_consulta]
GO
ALTER TABLE [dbo].[recetaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_recetaDetalle_Medicamento] FOREIGN KEY([idMed])
REFERENCES [dbo].[Medicamento] ([idMed])
GO
ALTER TABLE [dbo].[recetaDetalle] CHECK CONSTRAINT [FK_recetaDetalle_Medicamento]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_rol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[rol] ([id])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_rol]
GO
USE [master]
GO
ALTER DATABASE [Clinica_Vet_Final] SET  READ_WRITE 
GO
