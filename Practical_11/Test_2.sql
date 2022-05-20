Create table employee (
Id int NOT NULL IDENTITY (1,1) PRIMARY KEY,
FirstName varchar(50) NOT NULL,
MiddleName varchar(50) ,
LastName varchar(50) NOT NULL,
DOB Date NOT NULL,
MobileNumber varchar(10) NOT NULL,
Address varchar(100),
Salary Decimal NOT NULL
);

select * from employee;

insert into employee values('Vidhi',null,'Mehta','2001-02-04','8401299411','Gandhinagar',35000);
insert into employee values('Janvi',null,'Khatrani','2000-10-08','1234567890','Ahmedabad',30000);
insert into employee values('Nishit','Bhavesh','Amin','2001-02-16','9423561290','Maninagar',32000);
insert into employee values('Yash','Dilip','Punjabi','2004-02-17','8768756425',null,23500);
insert into employee values('Vrunda',null,'Solanki','1998-12-22','9876543271','Diu',50000);
insert into employee values('Devi',null,'Panchal','2000-12-05','7865341290',null,25500);
insert into employee values('Luv','Bhai','Desai','1999-02-22','9876523275','Chandkheda',40000);
insert into employee values('Mahek','Ben','Ardeshna','2000-11-05','6215341290',null,30500);


select SUM(Salary) as "Total Salary" from employee;
select * from employee where DOB<'01-01-2000';
select count(*) as MiddleNameNull from Employee where MiddleName is null;
