CREATE table Designation(
Id int IDENTITY (1,1) PRIMARY KEY NOT NULL,
Designation VARCHAR(50) NOT NULL
);

CREATE table Employee(
Id int IDENTITY (1,1) PRIMARY KEY NOT NULL,
FirstName VARCHAR(50) NOT NULL,
MiddleName VARCHAR(50),
LastName VARCHAR(50) NOT NULL,
DOB DATE NOT NULL,
MobileNumber VARCHAR(10) NOT NULL,
Address VARCHAR(100),
Salary DECIMAL NOT NULL,
DesignationId int foreign key references Designation(Id)
);

select * from Designation;
select * from Employee;

INSERT INTO Designation VALUES('Sales Executive')
INSERT INTO Designation VALUES('Graphic Designer')
INSERT INTO Designation VALUES('Accountant')
INSERT INTO Designation VALUES('Android Developer')
INSERT INTO Designation VALUES('Marketing Manager')
INSERT INTO Designation VALUES('Fashion Designer')
INSERT INTO Designation VALUES('Salesman')
INSERT INTO Designation VALUES('PHP Developer')
INSERT INTO Designation VALUES('DOT NET Developer')

INSERT INTO Employee VALUES('Vidhi','Ben','Mehta','2001-02-04',8401299411,'Gandhinagar',35000,9)
INSERT INTO Employee VALUES('Janvi',NULL,'Patel','2000-08-10',8301197421,'Ahmedabad',33000,8)
INSERT INTO Employee VALUES('Shrey','Bhai','Shah','1998-10-31',9876453421,NULL,32000,1)
INSERT INTO Employee VALUES('Yash',NULL,'Punjabi','2001-04-04',8965743270,'Vastral',40000,5)
INSERT INTO Employee VALUES('Devi','Ben','Panchal','1999-10-05',7854329012,NULL,35000,6)
INSERT INTO Employee VALUES('Vrunda','Ben','Solanki','1997-12-22',9076895432,'Gandhinagar',25000,5)
INSERT INTO Employee VALUES('Luv',NULL,'Desai','2001-09-17',6789043213,'Chandkheda',30000,2)
INSERT INTO Employee VALUES('Mahek','Ben','Ardeshna','2000-04-12',9874523107,NULL,32000,3)

SELECT count(Designation) from Designation;

SELECT e.FirstName, e.MiddleName, e.LastName, d.Designation from Employee e left join Designation d on e.DesignationId=d.Id;

CREATE VIEW EmpInfo as select e.Id,e.FirstName, e.MiddleName, e.LastName, d.Designation, e.DOB,e.MobileNumber, e.Address, e.salary from Employee e left join Designation d on e.DesignationId=d.Id;

select * from EmpInfo;

CREATE PROCEDURE InsertDatainEmployee
(
	@name varchar(50)
)
As
BEGIN;

insert into Designation(Designation) Values(@name);

END;

