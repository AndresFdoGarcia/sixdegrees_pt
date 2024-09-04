CREATE DATABASE PruebaSD;
GO

-- Crear el login a nivel de servidor
CREATE LOGIN ApiTest
WITH PASSWORD = 'root1',
     CHECK_POLICY = ON;  -- Enforce password policy
GO

-- Usar la base de datos recién creada
USE PruebaSD;
GO

-- Crear un usuario en la base de datos asociado al login
CREATE USER ApiTest
FOR LOGIN ApiTest;
GO

-- Asignar roles al usuario en la base de datos
ALTER ROLE db_datareader ADD MEMBER ApiTest;
ALTER ROLE db_datawriter ADD MEMBER ApiTest;
GO

-- Confirmar que el usuario ha sido creado y tiene permisos
SELECT dp.name AS DatabaseRoleName, 
       mp.name AS MemberName
FROM sys.database_role_members AS drm
JOIN sys.database_principals AS dp ON drm.role_principal_id = dp.principal_id
JOIN sys.database_principals AS mp ON drm.member_principal_id = mp.principal_id
WHERE mp.name = 'ApiTest';
GO

-- Usar la base de datos recién creada
USE PruebaSD;
GO

-- Crear la tabla Usuario con las columnas especificadas
CREATE TABLE Usuario (
    usuID numeric(18,0) NOT NULL PRIMARY KEY,   -- Clave primaria de tipo numeric(18,0) que no permite NULL
    nombre varchar(100) NULL,        -- Columna de tipo varchar(100) que permite NULL
    apellido varchar(100) NULL       -- Columna de tipo varchar(100) que permite NULL
);
GO

-- Insertar 5 registros en la tabla Usuario
INSERT INTO Usuario (usuID, nombre, apellido) VALUES (1000, 'Andres', 'Rodriguez Vera');
INSERT INTO Usuario (usuID, nombre, apellido) VALUES (1002, 'Jose', 'Giraldo Perez');
INSERT INTO Usuario (usuID, nombre, apellido) VALUES (1003, 'Maria', null);
INSERT INTO Usuario (usuID, nombre, apellido) VALUES (1004, null, 'Gonzalez Ruiz');
INSERT INTO Usuario (usuID, nombre, apellido) VALUES (1005, 'Carlos', 'Sanchez Ortega');
GO
