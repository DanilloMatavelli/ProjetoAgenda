create database dbAgenda;
use dbAgenda;

CREATE TABLE tbUsuarios (
    nome VARCHAR(60) PRIMARY KEY,
    usuario VARCHAR(20) NOT NULL,
    senha VARCHAR(30)
);

select * from tbcategoria
where usuario="DAN3465" and binary senha="123456789";

-- Para Criar a tabela catgoria e ir adicionando as categorias
CREATE TABLE tbCategoria (
	cod_categoria int AUTO_INCREMENT primary key,
    categoria VARCHAR(60) NOT NULL,
	usuario varchar(20) NOT NULL
);

-- Comando para excluir categoria no banco de Dados
DELETE FROM tbCategoria WHERE cod_categoria = @cod_categoria;

-- Criando um usuario 
CREATE USER 'usuario'@'%' IDENTIFIED BY 'senha123';

-- Triggers
DELIMITER $$

CREATE TRIGGER trInsertCategoria
	BEFORE 
	INSERT 
	ON tbcategoria
	FOR EACH ROW
BEGIN
	SET NEW.usuario = CURRENT_USER();
END;
$$

DELIMITER ;

Insert INTO tbcategoria (categoria,usuario)
VALUES('amigos' , 'Dan2604');


SELECT cod_categoria AS 'Código', categoria AS 'Categoria'
                            FROM tbCategoria
                            WHERE usuario = @usuario;

--  Criando Log

CREATE TABLE tbLog(
	cod_log INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR (20),
    date_hora DATETIME,
    descriçao VARCHAR (60)
);

-- lOG PARA DELETE CATEGORIA 
DELIMITER $$

CREATE TRIGGER trlogcategoriadelete
	AFTER
	DELETE
	ON tbcategoria
	FOR EACH ROW
BEGIN
	INSERT INTO tblog
		(usuario,
         date_hora,
         descriçao)
	VALUES
		(USER(),
        current_TIMESTAMP(),
        CONCAT("A categoria ", old.categoria, "foi excluida.")
        );
        
    
END;
$$

DELIMITER ;

-- lOG PARA ADICIONAR CATEGORIA 

DELIMITER $$

CREATE TRIGGER trlogcategoriaadicionar
	AFTER
	INSERT 
	ON tbcategoria
	FOR EACH ROW
BEGIN
	INSERT INTO tblog
		(usuario,
         date_hora,
         descriçao)
	VALUES
		(USER(),
        current_TIMESTAMP(),
        CONCAT("A categoria ", new.categoria, "foi adicionada.")
        );
        
    
END;
$$

DELIMITER ;

-- lOG PARA ALTERAR CATEGORIA 

DELIMITER $$

CREATE TRIGGER trlogcategoriaupdate
	AFTER
	UPDATE
	ON tbcategoria
	FOR EACH ROW
BEGIN
	INSERT INTO tblog
		(usuario,
         date_hora,
         descriçao)
	VALUES
		(USER(),
        current_TIMESTAMP(),
        CONCAT("A categoria ", old.categoria, "foi alterada.")
        );
        
    
END;
$$

DELIMITER ;

-- Criando um codigo UPDATE para Alterar Categoria

select usuario, senha, nome from tbUsuarios
where usuario='DAN'
and binary senha='11111111';



CREATE USER 'FATHER2'@'%' IDENTIFIED BY '111111111';
GRANT SELECT, INSERT, UPDATE, DELETE ON dbagenda.* TO 'FATHER'@'%';
FLUSH PRIVILEGES;

SELECT cod_categoria AS 'Código', categoria AS 'Categoria'
FROM tbCategoria
WHERE usuario = 'DUDA';

SELECT cod_categoria AS 'Código', categoria AS 'Categoria'
FROM tbCategoria
WHERE usuario LIKE 'DUDA';

-- Criando tabela contato
CREATE TABLE tbContatos (
	cod_contato INT AUTO_INCREMENT PRIMARY KEY,
    contato VARCHAR (30) NOT NULL,
    Telefone INT NOT NULL,
    Categoria VARCHAR(30) NOT NULL
);

-- Testando o comando Adicionar contato
INSERT INTO tbContatos (contato, telefone, categoria)
                VALUES ('Matheus', 9999-9999, 'Trabalho');
                
-- Testando comando do GET Contatos
                
SELECT cod_contato AS 'Código', 
       contato AS 'Matheus', 
       telefone AS '9999-9999', 
       categoria AS 'Trabalho'
FROM tbContatos
WHERE usuario = USER();