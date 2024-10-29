create database dbAgenda;
use dbAgenda;

CREATE TABLE tbUsuarios (
    nome VARCHAR(60) PRIMARY KEY,
    usuario VARCHAR(20) NOT NULL,
    senha VARCHAR(30)
);

select * from tbUsuarios;