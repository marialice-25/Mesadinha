
use mesadinha;

create table usu(
id int unsigned auto_increment not null,
nome varchar(40) not null,
telefone varchar(40) not null,
email varchar(80) not null,
endereco varchar(80) not null,
senha varchar(30) not null,
contas_id int unsigned not null,
foreign key(contas_id) references contas(id),
primary key(id)
)engine=innodb;

create table categorias(
id int unsigned auto_increment not null,
categoria varchar(50) not null,
primary key(id)
)engine=innodb;

create table conta(
id int unsigned auto_increment not null,
nome varchar(80) not null,
tipo varchar(40) not null,
categorias_id int unsigned not null,
foreign key(categorias_id) references categorias(id),
primary key(id)
)engine=innodb;


create table movimentacoes(
id int unsigned auto_increment not null,
conta varchar(40) not null,
valor double(9,2) not null,
conta_id int unsigned not null,
foreign key(conta_id) references conta(id),
primary key(id)
)engine=innodb;











