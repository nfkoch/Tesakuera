USE Oculus
go
create table ObraSocial(
codigo int identity(1,1),
Descripcion varchar(50),
Telefono varchar(100),
constraint pk_ObraSocial primary key(codigo));


--Tabla para registro de datos de los Pacientes
create table Paciente(
Codigo int identity(1,1),
CUIL varchar(11),
Nombre varchar(50),
FechaNacimiento date,
Direccion varchar(50),
Telefono varchar(50),
Email varchar(50),
CodigoLocalidad int,
CodigoProvincia int,
CodigoObraSocial int,
Sexo varchar(1),
constraint pk_Paciente primary key(Codigo),
constraint fk_PacienteLocalidad foreign key(codigolocalidad) references localidades(codigo),
constraint fk_PacienteProvincia foreign key(CodigoProvincia) references provincia(codigo),
Constraint fk_PacienteObraSocial foreign key(CodigoObraSocial) references ObraSocial(COdigo));
GO
-- Índice para búsquedas rápidas por CUIL
CREATE INDEX idx_Paciente_CUIL ON Paciente(CUIL);
GO
-- Índice para búsquedas rápidas por Nombre
CREATE INDEX idx_Paciente_Nombre ON Paciente(Nombre);
GO
-- Índice para búsquedas rápidas por Dirección
CREATE INDEX idx_Paciente_Direccion ON Paciente(Direccion);
GO
-- Índice para búsquedas rápidas por Teléfono
CREATE INDEX idx_Paciente_Telefono ON Paciente(Telefono);
GO
-- Índice para búsquedas rápidas por Email
CREATE INDEX idx_Paciente_Email ON Paciente(Email);
GO
-- Índice para búsquedas basadas en la relación con localidades
CREATE INDEX idx_Paciente_Localidad ON Paciente(CodigoLocalidad);
GO
-- Índice para búsquedas basadas en la relación con provincias
CREATE INDEX idx_Paciente_Provincia ON Paciente(CodigoProvincia);
GO

-- Procedimiento para insertar un Paciente
CREATE PROCEDURE InsertarPaciente
    @CUIL VARCHAR(11),
    @Nombre VARCHAR(50),
    @FechaNacimiento date,
    @Direccion VARCHAR(50),
    @Telefono VARCHAR(50),
    @Email VARCHAR(50),
    @CodigoLocalidad INT,
    @CodigoProvincia INT,
    @CodigoObraSocial INT
AS
BEGIN
    INSERT INTO Paciente (CUIL, Nombre,FechaNacimiento, Direccion, Telefono, Email, CodigoLocalidad, CodigoProvincia,CodigoObraSocial)
    VALUES (@CUIL, @Nombre,@FechaNacimiento, @Direccion, @Telefono, @Email, @CodigoLocalidad, @CodigoProvincia,@CodigoObraSocial);
END;
GO

-- Procedimiento para actualizar un Paciente
CREATE PROCEDURE ActualizarPaciente
    @Codigo INT,
    @CUIL VARCHAR(11),
    @Nombre VARCHAR(50),
    @FechaNacimiento date,
    @Direccion VARCHAR(50),
    @Telefono VARCHAR(50),
    @Email VARCHAR(50),
    @CodigoLocalidad INT,
    @CodigoProvincia INT,
    @CodigoObraSocial INT
AS
BEGIN
    UPDATE Paciente
    SET CUIL = @CUIL, Nombre = @Nombre,FechaNacimiento=@FechaNacimiento, Direccion = @Direccion, Telefono = @Telefono, Email = @Email,
        CodigoLocalidad = @CodigoLocalidad, CodigoProvincia = @CodigoProvincia, CodigoObraSocial=@CodigoObraSocial
    WHERE Codigo = @Codigo;
END;
GO

-- Procedimiento para eliminar un Paciente
CREATE PROCEDURE EliminarPaciente
    @Codigo INT
AS
BEGIN
    DELETE FROM Paciente WHERE Codigo = @Codigo;
END;
GO