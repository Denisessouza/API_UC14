USE Chapter;

CREATE TABLE Usuarios
(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR (255) UNIQUE NOT NULL,
	Senha VARCHAR (120) NOT NULL,
	Tipo CHAR (10) NOT NULL


);


INSERT INTO Usuarios VALUES ('teste@email.com.br', '1234', '0');

SELECT * FROM Usuarios;

SELECT * FROM Usuarios WHERE Email= 'teste@email.com.br' AND Senha= '1234';

