  create table contato(
	id int primary key auto_increment,
    nome varchar(45),
    email varchar(45),
    celular varchar(14)
 );
  insert into contato(nome, email, celular) 
  values ('mano', 'mano@gmail.com', '(47)991929394');


create table tb_contatos(
	id int primary key auto_increment,
    nome varchar(45),
    email varchar(45),
    fone varchar(45)
);

alter table tb_contatos modify nome varchar(45) not null;

/*(excluir tabela)*/
/*drop table tb_contatos*/

create table tb_locais(
	id int primary key auto_increment,
    nome varchar(45),
    rua varchar(45),
    numero int
);

create table tb_compromissos(
	id int primary key auto_increment,
    descricao varchar(100) not null,
    data date not null,
    hora time not null
);

/*(alterar tabela conectantos outra tabela)*/
alter table tb_compromissos add column tb_contatos_id int;
alter table tb_compromissos add constraint fk_contatos foreign key(tb_contatos_id) references tb_contatos(id);

alter table tb_compromissos add column tb_locais_id int;
alter table tb_compromissos add constraint fk_locais foreign key(tb_locais_id) references tb_locais(id);

/*(excluir conexao de tabelas)*/
alter table tb_compromissos drop constraint fk_contatos;
alter table tb_compromissos drop column tb_contatos_id;

alter table tb_compromissos drop constraint fk_locais;
alter table tb_compromissos drop column tb_locais_id;

drop table tb_compromissos;

/*create table tb_compromissos(
   id int primary key auto_increment,
   descricao varchar(100) not null,
   data date not null,
   hora time not null,
   tb_contatos_id int not null,
   tb_locais_id int not null,
   foreign key(tb_contatos_id) references tb_contatos(id),
   foreign key(tb_locais_id) references tb_locais(id)
)*/

