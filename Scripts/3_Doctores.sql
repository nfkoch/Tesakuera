USE Oculus
go

Create table Doctor(
Codigo int identity(1,1),
Matricula varchar(10),
CUIL varchar(11),
Nombre varchar(50),
Telefono varchar(50),
Email varchar(50),
Constraint pk_Doctor primary key(Codigo));

Create table Consultorio(
Codigo int,
Descripcion varchar(10),
Constraint pk_Consultorio primary key(Codigo));

Create table Agenda(
Codigo int identity(1,1),
Fecha date,
Hora time,
PacienteCodigo int,
DoctorCodigo int,
estado int,
Constraint pk_Agenda primary key(codigo),
constraint FK_AgendaPaciente foreign key (PacienteCodigo) references Paciente (codigo),
constraint FK_AgendaDoctor foreign key (DoctorCodigo) references Doctor(Codigo));

Create table Ficha(
Codigo int identity(1,1),
PacienteCodigo int,
FechaIngreso date,
AntecentesGenerales varchar(max),
AntecentesOculares varchar(max),
AntecentesClinicos varchar(max),
AntecentesQuirurgicos varchar(max),
AntecentesFamiliaresGenerales varchar(max),
AntecentesFamiliaresOculares varchar(max),
constraint pk_Ficha primary key(codigo),
constraint fk_fichaPaciente foreign key (PacienteCodigo) references Paciente(Codigo));

create table EvolucionConsulta(
Codigo int identity(1,1),
CodigoFicha int,
Fecha date,
Temperatura float,
peso float,
Talla float,
PadecimientoDescriptivo varchar(max),
CuandoEmpezo varchar(max),
PrimeraVez bit,
variacionPeso bit,
DescripcionDolor varchar(50),
LentesContacto bit,
LlegaConLentesContacto bit,
Constraint pk_EvolucionConsulta primary key(Codigo),
Constraint fk_EvolucionConsultaFicha foreign key (CodigoFicha) references Ficha(Codigo));

create table Estudio(
Codigo int identity(1,1),
CodigoFicha int,
Direccion varchar(max),
Constraint pk_Estudio primary key(codigo),
constraint fk_EstudioFicha foreign key (CodigoFicha) references Ficha(codigo)); 

/*
Create table ExploracionOftalmologica(
codigo int identity(1,1),
CodigoFicha int,
Ojo varchar(1),
*/