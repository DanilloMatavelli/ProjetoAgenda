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
