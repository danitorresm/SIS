CREATE TABLE Employees(  
    Id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(45),
    LastName VARCHAR(50),
    Cedula VARCHAR(50) UNIQUE,
    Phone VARCHAR(50),
    Email VARCHAR(50),
    Password VARCHAR(50),
    Status VARCHAR(30),
    Register_id int,
)

DROP TABLE Employees

ALTER TABLE `Employees`ADD FOREIGN KEY (Register_id) REFERENCES `Registers` (Id)


ALTER TABLE Employees DROP COLUMN Tipo_Cuenta



CREATE TABLE Registers(  
    Id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
    HoraEntrada DATETIME,
    HoraSalida DATETIME,
    Fecha DATE
)

INSERT INTO Employees (Name, LastName, Cedula, Phone, Email, Password, Status, Tipo_Cuenta, Register_id)
VALUES
('John', 'Doe', '123456789', '555-1234', 'john.doe@example.com', 'password123', 'Active', 'Admin', 1),
('Jane', 'Smith', '987654321', '555-5678', 'jane.smith@example.com', 'password456', 'Active', 'Employee', 2),
('Alice', 'Johnson', '456789123', '555-9012', 'alice.johnson@example.com', 'password789', 'Inactive', 'Employee', 3);


INSERT INTO Registers (Id, HoraEntrada, HoraSalida, Fecha)
VALUES
(1, '2024-04-15 09:00:00', '2024-04-15 17:00:00', '2024-04-15'),
(2, '2024-04-15 08:30:00', '2024-04-15 16:30:00', '2024-04-15'),
(3, '2024-04-15 10:00:00', '2024-04-15 18:00:00', '2024-04-15'),
(4, '2024-04-15 09:15:00', '2024-04-15 17:15:00', '2024-04-15'),
(5, '2024-04-15 08:45:00', '2024-04-15 16:45:00', '2024-04-15');
