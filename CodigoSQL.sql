DROP DATABASE loginBebe;
CREATE DATABASE loginBebe;
use loginBebe;

create table loginapp (
  username varchar(100),
  pasword varchar(100)
);

INSERT INTO loginapp (username,pasword)
VALUES('db','2025');

CREATE TABLE tienda (
   id int not null identity,
   producto varchar(100) NOT NULL,
   precio decimal(6,2),
   marca varchar(100) DEFAULT NULL,
   PRIMARY KEY(id)
);

insert into tienda values('Leche','1230','de vaca');

select * from loginapp;
select*from tienda;