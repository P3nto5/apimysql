USE agilAPP;

select * from Persons;

INSERT INTO Persons(tbName, tbIndex) VALUES('Pessoa 1', 'Endereço 1');
INSERT INTO Persons(tbName, tbIndex) VALUES('Pessoa 2', 'Endereço 2');
INSERT INTO Persons(tbName, tbIndex) VALUES('Pessoa 3', 'Endereço 3');
INSERT INTO Persons(tbName, tbIndex) VALUES('Pessoa 4', 'Endereço 4');
INSERT INTO Persons(tbName, tbIndex) VALUES('Pessoa 5', 'Endereço 5');

UPDATE Persons  set tbName = 'Samuel' where id = 3 ;

select * from Users;


