
														--LUNES 2020 JUNIO 15 10:10AM--
USE master
GO
											--GESTOR DE BASE DATOS = SQL SERVER 2014 MANAGEMENT STUDIO--

CREATE DATABASE FRESHDENT /*SE CREA LA BASE DE DATOS APLICANDO NOMBRE A ELLA*/
GO

USE FRESHDENT /*SE MANDA A LLAMAR EL NOMBRE DE LA BASE DE DATOS PARA GUARDAR LA CODIFICACIÓN QUE TENDRÁ PARA QUE MÁS ADELANTE UTILIZARLA PARA GUARDAR INFORMACIÓN POR OTROS MEDIOS PROGRAMATIVOS, EN ESTE CASO EL SISTEMA
				QUE ESTÁ CREADO EN VISUAL STUDIO RELACIONADO A ODONTOLOGIA*/
GO

CREATE TABLE Expediente (																--Creación de la tabla Expediente.
IdExpediente INT PRIMARY KEY IDENTITY (1,1),											--Almacena el código de expediente.
Cedula VARCHAR (100),																	--Almacena la cédula de la persona en el expediente.
Nombres VARCHAR (80),																	--Almacena los nombres de la persona en el expediente.
Apellidos VARCHAR (80),																	--Almacena los apellidos de la persona en el expediente.
Fecha_Nacimiento varchar (30),															--Almacena la fecha de nacimiento de la persona en el expediente.
Telefono_Celular INT,																	--Almacena el teléfono-celular de la persona en el expediente.
Municipio VARCHAR (50),																	--Almacena el municipio donde vive la persona en el expediente. 
Departamento VARCHAR (50),																--Almacena el departamento que forma parte el municipio donde vive la persona en el expediente.
CONSTRAINT Expediente_Paciente UNIQUE (Cedula, Fecha_Nacimiento, Telefono_Celular)
);

CREATE TABLE Receta (																	--Creación de la tabla Receta.
IdReceta INT PRIMARY KEY IDENTITY (1,1),												--Almacena código de receta médica.
Nombre VARCHAR (50),																	--Almacena el nombre de lo medicamento.
Presentacion VARCHAR (100),																--Almacena la información del medicamento.
Cantidad INT,																			--Almacena cantidad de medicamentos.
Descripcion VARCHAR (150),																--Almacena la indicación de la toma del medicamento.
CONSTRAINT Receta_Info UNIQUE (Nombre, Cantidad)
);

CREATE TABLE Especialidad (																--Creación de la tabla Especialidad.
IdEspecialidad INT PRIMARY KEY IDENTITY (1,1),											--Almacena código de especialidad.
NombreEspecialidad VARCHAR (50),														--Almacena nombre de especialidad.
DescpEspecialidad VARCHAR (500),														--Almacena descripción de especialidad.
CONSTRAINT Especialista UNIQUE (NombreEspecialidad, DescpEspecialidad)
);

CREATE TABLE Medico (																	--Creación de la tabla Médico
IdMedico INT PRIMARY KEY IDENTITY (1,1),												--Almacena el código del médico.
NombreMedico VARCHAR (30),																--Almacena el nombre del médico.
Telefono_Celular INT,																	--Almacena el número telefónico personal del médico.
IdEspecialidad INT																		/*Almacena el código de la especialidad.*/
FOREIGN KEY (IdEspecialidad) REFERENCES Especialidad (IdEspecialidad),
CONSTRAINT Medico_Nombre UNIQUE (Telefono_Celular)
);

CREATE TABLE Cita (																		--Creación de la tabla Cita.
IdCita INT PRIMARY KEY IDENTITY (1,1),													--Almacena código de la cita.
FechaCita DATE,																			--Almacena fecha de cita.
HoraDisponible TIME,																	--Almacena hora disponible de la cita.
Precio INT,																				--Almacena costo de la cita.
Tipo VARCHAR (50),																		--Almacena el tipo de cita, es decir si está programada o no.
IdExpediente INT																		/*Almacena el código del expediente.*/
FOREIGN KEY (IdExpediente) REFERENCES Expediente (IdExpediente),
IdMedico INT																			/*Almacena el código del médico.*/
FOREIGN KEY (IdMedico) REFERENCES Medico (IdMedico),
CONSTRAINT Opcion CHECK (Tipo = 'Programada' OR Tipo = 'No programada')
);

CREATE TABLE Consulta (																	--Creación de la tabla Consulta.
IdConsulta INT PRIMARY KEY IDENTITY (1,1),												--Almacena código de consulta.
Fecha DATE,																				--Almacena la fecha que se está realizando la consulta.
Hora TIME,																				--Almacena la hora que se está realizando la consulta.
Sintoma VARCHAR (250),																	--Almacena los síntomas mencionada por la persona que está en consulta.
Diagnostico VARCHAR (200),																--Almacena el diagnóstico que determina el medico.
IdExpediente INT																		/*Almacena el código del expediente.*/
FOREIGN KEY (IdExpediente) REFERENCES Expediente (IdExpediente),
IdMedico INT																			/*Almacena el código del médico.*/
FOREIGN KEY (IdMedico) REFERENCES Medico (IdMedico),
);

CREATE TABLE Consulta_Receta(
IdConsulta INT																			/*Almacena código de consulta.*/
FOREIGN KEY (IdConsulta) REFERENCES Consulta (IdConsulta),
IdReceta INT																			/*Almacena código de receta médica.*/
FOREIGN KEY (IdReceta) REFERENCES Receta (IdReceta),
);

CREATE TABLE Users(																		--Creación de la tabla Usuarios.
UserID INT IDENTITY (1,1) PRIMARY KEY,													--Almacena código de usuario.
LoginName NVARCHAR (100) UNIQUE NOT NULL,												--Almacena nombre de usuario.
Password NVARCHAR (100) NOT NULL														--Almacena contraseña de usuario.
);

------------Inserción de datos------------------
insert into Users values ('doctor','0987654321')										--Datos ingresado que no tendrá cambio                                 
insert into Users values ('admin','1234567890')											--Datos ingresado que no tendrá cambio

 ----------------------------------------------------------------PROCEDIMIENTO ALMACENADO------------------------------------------------------------------------------------

--Procedimiento almacenado para la tabla users
CREATE PROCEDURE Us
	@b INT, @UserID int ,@LoginName nvarchar (100), @Password nvarchar (100)
	-----------Atributo que tiene el procedimiento almacenado---------------
	AS
		BEGIN
			SET NOCOUNT ON;
			
			IF @b=1
				INSERT INTO Users VALUES (@LoginName,@Password); --Guarda la información insertada.
			IF @b=2
				SELECT * FROM Users--Muestra toda la información guardada.
			IF @b=3
				UPDATE Users SET LoginName=@LoginName, Password=@Password WHERE UserID = @UserID; --Actualiza la información seleccionada por el número de registro asignado.
			IF @b=4
				SELECT * FROM Users WHERE LoginName = @LoginName and [Password] = @Password --Inicia sesión el usuario
		END
	GO

 --Se crea el procedimiento almacenado para la tabla Expediente
CREATE PROCEDURE Expedient
	@b INT, @IdExpediente INT, @Cedula VARCHAR (100), @Nombres VARCHAR (80), @Apellidos VARCHAR (80), @Fecha_Nacimiento varchar (20), @Telefono_Celular INT, @Municipio VARCHAR (50), @Departamento VARCHAR (50)
	---------------------------------------------------------------------------Atributos que tiene el procedimiento almacenado------------------------------------------------------------------------------
	
	AS
		BEGIN
			SET NOCOUNT ON;
			
			IF @b=1
				INSERT INTO Expediente VALUES (@Cedula, @Nombres, @Apellidos, @Fecha_Nacimiento, @Telefono_Celular, @Municipio, @Departamento); --Guarda la información insertada.
			IF @b=2
				DELETE FROM Expediente WHERE IdExpediente = @IdExpediente; --Elimina la información guardada utilizando el número que fue asignado de forma automática.
			IF @b=3
				SELECT * FROM Expediente --Muestra toda la información guardada.
			IF @b=4
				UPDATE Expediente SET Cedula=@Cedula, Nombres=@Nombres, Apellidos=@Apellidos, Fecha_Nacimiento=@Fecha_Nacimiento, Telefono_Celular = @Telefono_Celular, Municipio = @Municipio, Departamento = @Departamento WHERE IdExpediente = @IdExpediente; --Actualiza la información seleccionada por el número de registro asignado.
			IF @b=5
				SELECT * FROM Expediente WHERE Nombres LIKE '%' + @Nombres + '%' --Busca la información utilizando un atributo de la entidad, en este caso se utiliza Nombres para observar la información de la persona determinada.
		END
	GO

--Se crea el procedimiento almacenado para la tabla Especialidad
CREATE PROCEDURE Especialid
	@b INT, @IdEspecialidad INT, @NombreEspecialidad VARCHAR (50), @DescpEspecialidad VARCHAR (500)
	-------------------Atributos que tiene el procedimiento almacenado----------------------------
	
	AS
		BEGIN
			SET NOCOUNT ON;
			
			IF @b=1
				INSERT INTO Especialidad VALUES (@NombreEspecialidad, @DescpEspecialidad); --Guarda la información insertada.
			IF @b=2
				DELETE FROM Especialidad WHERE IdEspecialidad = @IdEspecialidad; --Elimina la información guardada utilizando el número que fue asignado de forma automática.
			IF @b=3
				SELECT * FROM Especialidad --Muestra toda la información guardada.
			IF @b=4
				UPDATE Especialidad SET NombreEspecialidad = @NombreEspecialidad, DescpEspecialidad = @DescpEspecialidad WHERE IdEspecialidad = @IdEspecialidad; --Actualiza la información seleccionada por el número de registro asignado.
			IF @b=5
				SELECT * FROM Especialidad WHERE NombreEspecialidad LIKE '%' + @NombreEspecialidad + '%' --Busca la información utilizando un atributo de la entidad, en este caso se utiliza Nombre Especialidad para observar la información de la especialidad determinada.
		END
	GO

--Se crea el procedimiento almacenado para la tabla Médico
alter PROCEDURE Medic
	@b INT, @IdMedico INT, @NombreMedico VARCHAR (30), @Telefono_Celular INT, @IdEspecialidad INT
	-------------------Atributos que tiene el procedimiento almacenado----------------------------
	
	AS
		BEGIN
			SET NOCOUNT ON;
			
			IF @b=1
				INSERT INTO Medico VALUES (@NombreMedico, @Telefono_Celular, @IdEspecialidad); --Guarda la información insertada
			IF @b=2
				DELETE FROM Medico WHERE IdMedico = @IdMedico; --Elimina la información guardada utilizando el número que fue asignado de forma automática.
			IF @b=3
				SELECT M.IdMedico,M.NombreMedico, M.Telefono_Celular,E.IdEspecialidad,E.NombreEspecialidad
				FROM Medico AS M INNER JOIN Especialidad AS E
				ON M.IdEspecialidad = E.IdEspecialidad
			IF @b=4
				UPDATE Medico SET NombreMedico = @NombreMedico, Telefono_Celular = @Telefono_Celular, IdEspecialidad = @IdEspecialidad WHERE IdMedico = @IdMedico; --Actualiza la información seleccionada por el número de registro asignado.
			IF @b=5
				SELECT * FROM Medico WHERE NombreMedico LIKE '%' + @NombreMedico + '%' --Buscar la información utilizando un atributo de la entidad, en este caso se utiliza Nombre Medico para observar la información del médico determinado.
		END
	GO

--Se crea el procedimiento almacenado para la tabla Consulta
alter PROCEDURE Consul
	@b INT, @IdConsulta INT, @Fecha DATE, @Hora TIME, @Sintoma VARCHAR (250), @Diagnostico VARCHAR (200), @IdExpediente INT, @IdMedico INT
	----------------------------------------Atributos que tiene el procedimiento almacenado-----------------------------------------------
	
	AS
		BEGIN
			SET NOCOUNT ON;

			IF @b=1
				INSERT INTO Consulta VALUES (@Fecha, @Hora, @Sintoma, @Diagnostico, @IdExpediente, @IdMedico); --Guarda la información insertada
			IF @b=2
				DELETE FROM Consulta WHERE IdConsulta = @IdConsulta; --Elimina la información guardada utilizando el número que fue asignado de forma automática.
			IF @b=3
				SELECT c.IdConsulta,c.Fecha,c.Hora,c.Sintoma,c.Diagnostico,m.IdMedico,M.NombreMedico,X.IdExpediente,X.Nombres
				FROM Medico AS M INNER JOIN Consulta AS c
				ON M.IdMedico =c.IdMedico  inner join Expediente as X on X.IdExpediente=C.IdExpediente   --Muestra toda la información guardada.
		END 
	GO

--Se crea el procedimiento almacenado para la tabla Receta
CREATE PROCEDURE Recet 
	@b INT, @IdReceta INT, @Nombre VARCHAR (50), @Presentacion VARCHAR (100), @Cantidad INT, @Descripcion VARCHAR (150)
	-------------------------------Atributos que tiene el procedimiento almacenado------------------------------------
	
	AS
		BEGIN
			SET NOCOUNT ON;

			IF @b=1
				INSERT INTO Receta VALUES (@Nombre, @Presentacion, @Cantidad, @Descripcion); --Guarda la información insertada
			IF @b=2
				DELETE FROM Receta WHERE IdReceta = @IdReceta; --Elimina la información guardada utilizando el número que fue asignado de forma automática.
			IF @b=3
				SELECT * FROM Receta --Muestra toda la información guardada.
		END
	GO

--Se crea el procedimiento almacenado para la tabla Cita
create PROCEDURE Cit
	@b INT, @IdCita INT, @FechaCita DATE, @HoraDisponible TIME, @Precio INT, @Tipo VARCHAR (50), @IdExpediente INT, @IdMedico INT
	----------------------------------Atributos que tiene el procedimiento almacenado--------------------------------------------
	
	AS
		BEGIN
			SET NOCOUNT ON;

			IF @b=1
				INSERT INTO Cita VALUES (@FechaCita, @HoraDisponible, @Precio, @Tipo, @IdExpediente, @IdMedico); --Guarda la información insertada
			IF @b=2
				DELETE FROM Cita WHERE IdCita = @IdCita; --Elimina la información guardada utilizando el número que fue asignado de forma automática.
			IF @b=3
				SELECT c.IdCita,c.FechaCita,c.Tipo,c.Precio,c.HoraDisponible,m.IdMedico,M.NombreMedico,X.IdExpediente,X.Nombres
				FROM Medico AS M INNER JOIN cita AS c
				ON M.IdMedico =c.IdMedico  inner join Expediente as X on X.IdExpediente=C.IdExpediente  --Muestra toda la información guardada.
			IF @b=4
				UPDATE Cita SET FechaCita = @FechaCita, HoraDisponible = @HoraDisponible, Precio = @Precio, Tipo = @Tipo, IdExpediente = @IdExpediente, IdMedico = @IdMedico WHERE IdCita = @IdCita; --Actualiza la información seleccionada por el número de registro asignado.
			IF @b=5
				SELECT * FROM Cita WHERE Tipo LIKE '%' + @Tipo + '%'  --Buscar la información utilizando un atributo de la entidad, en este caso se utiliza Tipo para observar la información de la cita determinada.

		END
	GO

--Se crea el procedimiento almacenado para el Respaldo
CREATE PROCEDURE RespaldoBD_GER
	AS
		BEGIN
			SET NOCOUNT ON;

			BACKUP DATABASE FRESHDENT
			TO DISK = N'C:\Users\Elkin Maltez\Documents\Ingenieria en Sistema\2020\I Semestre\Programación de Base de Datos\Proyecto' ---Directorio donde se guardará el respaldo de la base de datos
			WITH CHECKSUM;
		END
	GO