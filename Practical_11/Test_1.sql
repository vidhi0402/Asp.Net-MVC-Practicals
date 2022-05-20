Create table employee (
Id int NOT NULL IDENTITY (1,1) PRIMARY KEY,
FirstName varchar(50) NOT NULL,
MiddleName varchar(50) ,
LastName varchar(50) NOT NULL,
DOB Date NOT NULL,
MobileNumber varchar(10) NOT NULL,
Address varchar(100) 

);

select * from employee;

insert into employee values('Vidhi','Sunilkumar','Mehta','2001-02-04','8401299411','Gandhinagar');
insert into employee values('Janvi',null,'Khatrani','2000-10-08','1234567890','Ahmedabad');
insert into employee values('Nishit','Bhavesh','Amin','2001-02-16','9423561290','Maninagar');
insert into employee values('Yash','Dilip','Punjabi','2004-02-17','8768756425',null);
insert into employee values('Vrunda',null,'Solanki','1998-12-22','9876543271','Diu');
insert into employee values('Devi',null,'Panchal','2000-12-05','7865341290',null);

update employee set FirstName='SQLPerson' where id=1;
update employee set MiddleName='I';

delete from employee where id<2;
delete from employee;
