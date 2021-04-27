CREATE TABLE DireccionesContactos(
IdContacto INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(80),
Apellidos VARCHAR(80),
Direccion VARCHAR(80),
Ciudad  VARCHAR(80),
Departamento VARCHAR(80),
Genero VARCHAR(80),
Telefono VARCHAR(20)
)


select * from DireccionesContactos