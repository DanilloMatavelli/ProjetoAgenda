create database dbAgenda;
use dbAgenda;

CREATE TABLE tbUsuarios (
    nome VARCHAR(60) PRIMARY KEY,
    usuario VARCHAR(20) NOT NULL,
    senha VARCHAR(30)
);

select * from tbUsuarios;

//Para verificar se o usuario existe no banco de dados 
select * from tbUsuarios
where usuario="DAN3465" and binary senha="123456789";

//Para Criar a tabela catgoria e ir adicionando as categorias
CREATE TABLE tbCategoria (
	cod_categoria int AUTO_INCREMENT primary key,
    categoria VARCHAR(60) NOT NULL,
	usuario varchar(20) NOT NULL
);

select * from tbCategoria;

//Comando para excluir categoria no banco de Dados
DELETE FROM tbCategoria WHERE cod_categoria = @cod_categoria;

//Criando um usuario 
CREATE USER 'usuario'@'%' IDENTIFIED BY 'senha123';

//Triggers
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

select * from tbcategoria;

select nome
from categorias
where usuario = "Dan2604";

SELECT cod_categoria AS 'Código', categoria AS 'Categoria'
                            FROM tbCategoria
                            WHERE usuario = @usuario;

// Criando Log

CREATE TABLE tbLog(
	cod_log INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR (20),
    date_hora DATETIME,
    descriçao VARCHAR (60)
);

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
