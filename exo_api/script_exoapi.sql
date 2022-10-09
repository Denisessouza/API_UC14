CREATE DATABASE db_exo;

USE db_exo;

CREATE TABLE Projeto
(
	id INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR (150) NOT NULL,
	Status VARCHAR (50) NOT NULL,
	Inicio VARCHAR (10) NOT NULL,
	Area VARCHAR (30) NOT NULL,
	Tecnologias VARCHAR (150),
	Requisitos VARCHAR (150)

);

	SELECT * FROM Projeto;

INSERT INTO Projeto (Titulo, Status, Inicio, Area)
VALUES ('Projeto A', 'Iniciado', '17/05/2022', 'RH');

INSERT INTO Projeto(Titulo, Status, Inicio, Area)
VALUES ('Projeto B', 'Suspenso', '23/05/2022', 'TI');

