
-- Crear la base de datos
CREATE DATABASE importadora_de_pina08;
GO

-- Seleccionar la base de datos
USE importadora_de_pina08;
GO

-- Crear la tabla Proveedor08
CREATE TABLE Proveedor08 (
    Id_proveedor08 INT PRIMARY KEY,
    Nombre NVARCHAR(100),
    Telefono NVARCHAR(15)
);
GO

-- Crear la tabla Producto08
CREATE TABLE Producto08 (
    Id_producto08 INT PRIMARY KEY,
    Nombre NVARCHAR(100),
    Precio DECIMAL(10, 2),
    Stock INT,
    Fk_id_proveedor08 INT,
    FOREIGN KEY (Fk_id_proveedor08) REFERENCES Proveedor08(Id_proveedor08)
);
GO

-- Crear la tabla Cliente08
CREATE TABLE Cliente08 (
    Id_cliente08 INT PRIMARY KEY,
    Nombre NVARCHAR(100),
    Telefono NVARCHAR(15),
    Direccion NVARCHAR(200)
);
GO

-- Crear la tabla Pedido08
CREATE TABLE Pedido08 (
    Id_pedido08 INT PRIMARY KEY,
    Fk_id_cliente08 INT,
    Fk_id_producto08 INT,
    Fecha_pedido DATE,
    Precio_total DECIMAL(10, 2),
    FOREIGN KEY (Fk_id_cliente08) REFERENCES Cliente08(Id_cliente08),
    FOREIGN KEY (Fk_id_producto08) REFERENCES Producto08(Id_producto08)
);
GO

-- Insertar datos de ejemplo en Proveedor08
INSERT INTO Proveedor08 (Id_proveedor08, Nombre, Telefono) VALUES
(1, 'Jasmir Alexander', '123-4567'),
(2, 'Jasmira Alexandra', '234-5678');
GO

-- Insertar datos de ejemplo en Producto08
INSERT INTO Producto08 (Id_producto08, Nombre, Precio, Stock, Fk_id_proveedor08) VALUES
(1, 'Piña India', 5.00, 100, 1),
(2, 'Piña Hawaiana', 7.00, 150, 2),
(3, 'Piña Reina Pequeña', 3.00, 120, 1),
(4, 'Piña Roja', 8.00, 80, 2);
GO

-- Insertar datos de ejemplo en Cliente08
INSERT INTO Cliente08 (Id_cliente08, Nombre, Telefono, Direccion) VALUES
(1, 'Marcos Cano', '555-1234', 'La Villa Masaya Calle 55'),
(2, 'Juan Francisco', '555-5678', 'Avenida Siempre Viva 742');
GO

-- Insertar datos de ejemplo en Pedido08
INSERT INTO Pedido08 (Id_pedido08, Fk_id_cliente08, Fk_id_producto08, Fecha_pedido, Precio_total) VALUES
(1, 1, 1, '2024-08-01', 5.00),
(2, 1, 2, '2024-08-02', 7.00),
(3, 2, 3, '2024-08-03', 3.00),
(4, 2, 4, '2024-08-04', 8.00);
GO

-- Verificar los datos insertados en Producto08
SELECT * FROM Producto08
GO
