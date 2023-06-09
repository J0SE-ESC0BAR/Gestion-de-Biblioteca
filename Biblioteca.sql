CREATE DATABASE Biblioteca;
GO
USE  Biblioteca
GO
CREATE TABLE Libros (
    id_libro INT IDENTITY(1,1) PRIMARY KEY,
    titulo VARCHAR(100) NOT NULL,
    autor VARCHAR(50) NOT NULL,
    editorial VARCHAR(50) NOT NULL,
    año_publicacion DATE NOT NULL,
    genero VARCHAR(50) NOT NULL, 
	original int NOT NULL,
	copia int NOT NULL,
    num_paginas INT NOT NULL
);

GO
/*
CREATE TABLE Ejemplares (
    id_ejemplar INT IDENTITY(1,1) PRIMARY KEY,
    id_libro INT FOREIGN KEY REFERENCES Libros(id_libro) NOT NULL,
    ubicacion VARCHAR(50) NOT NULL,
    estado VARCHAR(10) NOT NULL
);*/

GO
CREATE TABLE Usuarios (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellidos VARCHAR(50) NOT NULL,
    direccion VARCHAR(100) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    email VARCHAR(50) NOT NULL
);
GO
CREATE TABLE Prestamos (
    id_prestamo INT IDENTITY(1,1) PRIMARY KEY,
    id_ejemplar INT FOREIGN KEY REFERENCES Ejemplares(id_ejemplar) NOT NULL,
    id_usuario INT FOREIGN KEY REFERENCES Usuarios(id_usuario) NOT NULL,
    fecha_prestamo DATE NOT NULL,
    fecha_devolucion DATE NOT NULL,
    estado VARCHAR(10) NOT NULL
);
GO



/*Ingresando uns registros de prueba*/
/*Libros*/
INSERT INTO Libros VALUES ('La sombra del viento', 'Carlos Ruiz Zafón', 'Planeta', 2001, 'Novela', 570);
INSERT INTO Libros VALUES ('1984', 'George Orwell', 'Debolsillo', 1949, 'Ciencia ficción', 400);
INSERT INTO Libros VALUES ('Cien años de soledad', 'Gabriel García Márquez', 'Círculo de Lectores', 1967, 'Realismo mágico', 450);
INSERT INTO Libros VALUES ('El código Da Vinci', 'Dan Brown', 'Umbriel', 2003, 'Misterio', 590);
INSERT INTO Libros VALUES ('El Señor de los Anillos', 'J.R.R. Tolkien', 'Minotauro', 1954, 'Fantasía', 1178);

/*Ejemplares*/
INSERT INTO Ejemplares VALUES (1, 'Estante 1, sección A', 'Disponible');
INSERT INTO Ejemplares VALUES (1, 'Estante 1, sección B', 'Prestado');
INSERT INTO Ejemplares VALUES (2, 'Estante 2, sección C', 'Disponible');
INSERT INTO Ejemplares VALUES (3, 'Estante 3, sección A', 'Disponible');
INSERT INTO Ejemplares VALUES (4, 'Estante 4, sección D', 'Prestado');

/*Usuarios*/
INSERT INTO Usuarios VALUES ('Juan', 'Pérez García', 'Calle Mayor 1, Madrid', '910111213', 'juan.perez@gmail.com');
INSERT INTO Usuarios VALUES ('María', 'González Sánchez', 'Calle Alcalá 123, Madrid', '910141516', 'maria.gonzalez@gmail.com');
INSERT INTO Usuarios VALUES ('Pedro', 'Martínez Fernández', 'Avenida de América 67, Madrid', '910171819', 'pedro.martinez@gmail.com');
INSERT INTO Usuarios VALUES ('Ana', 'Ruiz López', 'Calle Gran Vía 10, Madrid', '910202122', 'ana.ruiz@gmail.com');
INSERT INTO Usuarios VALUES ('David', 'Sánchez Pérez', 'Calle Serrano 100, Madrid', '910232425', 'david.sanchez@gmail.com');
/*Prestamos*/
INSERT INTO Prestamos VALUES (1, 2, '2023-05-05', '2023-05-12', 'Pendiente');
INSERT INTO Prestamos VALUES (2, 4, '2023-05-08', '2023-05-15', 'Pendiente');
INSERT INTO Prestamos VALUES (3, 1, '2023-05-06', '2023-05-13', 'Pendiente');
INSERT INTO Prestamos VALUES (4, 3, '2023-05-07', '2023-05-14', 'Pendiente');
INSERT INTO Prestamos VALUES (5, 5, '2023-05-09', '2023-05-14','Entregado');


/*Procedimiento almacenados para el windows Forms*/
ALTER PROCEDURE spRegistrarCliente
	@nombre varchar(50),
	@apellidos varchar(50),
	@direccion varchar(100),
	@telefono varchar(20),
	@email varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	insert into Usuarios(nombre, apellidos, direccion, telefono, email) values(@nombre,@apellidos,@direccion,@telefono,@email)
	select @@IDENTITY /*Variable del sistema ultimo id insertado*/
END

/*Ejecutar el procedimiento almacenado*/
EXEC spRegistrarCliente 'Pedro', 'Juares Mendes', 'Calle Mayor 5, Madrid', '181245191', 'pedro.mendes@gmail.com'
EXEC spRegistrarCliente @nombre='Rodrigo', @apellidos='Prez García', @direccion='Calle Mayor 1, Madrid', @telefono='191011121', @email='rodrigo.perez@gmail.com'

select * from Usuarios
select * from Libros
/*Elimitar todos los registros de los */
DELETE FROM Libros;
select *from Ejemplares
GO