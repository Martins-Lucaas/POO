CREATE TABLE cliente(
	id_cliente SERIAL PRIMARY KEY,
	nome VARCHAR(100) NOT NULL,
	cpf VARCHAR(100) NOT NULL,
	login VARCHAR(100) NOT NULL,
	senha VARCHAR(100) NOT NULL
);

CREATE TABLE computador(
	id_computador SERIAL PRIMARY KEY,
	processador VARCHAR(100) NOT NULL,
	placa_de_video VARCHAR(100) NOT NULL,
	memoria_ram VARCHAR(100) NOT NULL,
	preco_hr NUMERIC NOT NULL
);

CREATE TABLE Aluguel(
	id_aluguel SERIAL PRIMARY KEY,
	total NUMERIC NOT NULL,
	id_cliente INT NOT NULL,
	id_computador INT NOT NULL,
	FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente),
	FOREIGN KEY (id_computador) REFERENCES computador(id_computador)
);

SELECT * FROM cliente;
SELECT * FROM computador;
SELECT * FROM Aluguel;

SELECT aluguel.id_aluguel,aluguel.total,aluguel.id_cliente,aluguel.id_computador,cliente.nome
FROM aluguel
JOIN cliente ON aluguel.id_cliente = cliente.id_cliente