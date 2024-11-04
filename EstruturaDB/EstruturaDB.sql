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