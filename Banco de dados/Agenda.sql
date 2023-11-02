select * from tb_locais;

update tb_contatos set 
nome = 'loterio'
where id = 1;

select descricao,data, email as Contato, rua
from tb_comromisso, tb_contatos, tb_locais
where tb_compromissos.tb_contatos_id = tb_contatos.id and tb_compromissos.tb_locais_id = tb_locais.id;

insert into tb_locais (nome, rua, numero)
values('pescar', 'rua da macaxeira', '34');

select tb_comp.id, descricao as Descrição, data, hora, nome as Contato
from tb_compromissos tb_comp
inner join tb_contatos tc on tb_comp.tb_contatos_id = tc.id
where tb_comp.tb_contatos_id = 2;

/*atividade*/

create table compromisso(
	id int primary key auto_increment,
    descricao varchar(45),
    data date,
    hora time
);
insert into compromisso(descricao, data, hora) values ('tomar café', '2023-10-18', '21:00:00');

 create table contato(
	id int primary key auto_increment,
    nome varchar(45),
    email varchar(45),
    celular varchar(14)
 );
 insert into contato(nome, email, celular) values ('jamal', 'jamal@gmail.com', '47991653086');
 
create table compromisso_has_contato(
	contato_id int,
    compromisso_id int
);

alter table compromisso_has_contato add constraint fk_contato foreign key(contato_id) references contato(id);
table compromisso_has_contato add constraint fk_compromisso foreign key(compromisso_id) references compromisso(id);

insert into compromisso_has_contato(contato_id, compromisso_id) values ( '1', '1');
select * from compromisso_has_contato