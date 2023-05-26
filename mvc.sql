use Vidhi335_schoolmgmt
use Vidhi335_schoolmgmt


create   proc   sp_add_student(
@FirstName varchar(255),
@LastName varchar(255) ,
@PhoneNumber varchar(255),
@EmailId varchar(255),
@BirthDate date ,
@Gender varchar(255) ,
@Address varchar(500),
@Country int ,
@state int ,
@city int ,
@teacher varchar(255) 
)
as
begin
insert into [student] values (@FirstName,@LastName,@PhoneNumber,@EmailId,@BirthDate,@Gender,@Address,@Country,@state,@city,@teacher)
end;

select * from Student



create   proc   sp_add_teacher(
@FirstName varchar(255),
@LastName varchar(255) ,
@PhoneNumber varchar(255),
@EmailId varchar(255),
@BirthDate date ,
@Gender varchar(255) ,
@Address varchar(500),
@Country int ,
@state int ,
@city int ,
@subject varchar(255) 
)
as
begin
insert into Teacher values (@FirstName,@LastName,@PhoneNumber,@EmailId,@BirthDate,@Gender,@Address,@Country,@state,@city,@subject)
end;


select * from teacher

create   proc   sp_add_student(
@FirstName varchar(255),
@LastName varchar(255) ,
@PhoneNumber varchar(255),
@EmailId varchar(255),
@BirthDate date ,
@Gender varchar(255) ,
@Address varchar(500),
@Country int ,
@state int ,
@city int ,
@teacher varchar(255) 
)
as
begin
insert into [student] values (@FirstName,@LastName,@PhoneNumber,@EmailId,@BirthDate,@Gender,@Address,@Country,@state,@city,@teacher)
end;

select * from [student]



create   proc   sp_add_teacher(
@FirstName varchar(255),
@LastName varchar(255) ,
@PhoneNumber varchar(255),
@EmailId varchar(255),
@BirthDate date ,
@Gender varchar(255) ,
@Address varchar(500),
@Country int ,
@state int ,
@city int ,
@subject varchar(255) 
)
as
begin
insert into Teacher values (@FirstName,@LastName,@PhoneNumber,@EmailId,@BirthDate,@Gender,@Address,@Country,@state,@city,@subject)
end;


select * from Student

insert into subject values ('science')

create or alter proc add_country(
@countryname varchar(155)
)
as
begin
insert into Country values(@countryname)
end;
exec add_country 'india'


insert into City values('jAIPUR',3)


CREATE  PROC UPDATE_DATA
(@id int,
@Fname varchar(100),
@Lname varchar(100),
@phone varchar(20),
@email varchar(255),
@Birthdate date,
@gender varchar(20),
@address varchar(max),
@country int,
@state int,
@city int,
@teacher VARCHAR(255)
)
AS
BEGIN
UPDATE [Student]
SET FirstName=@Fname,LastName=@Lname,[PhoneNumber]=@phone,[EmailId]=@email,[BirthDate]=@Birthdate,
[Gender]=@gender,[Address]=@address, [City]=@city ,[State]=@state, [Country]=@country,teacher=@teacher
WHERE Id=@id;
END;



CREATE  PROC UPDATE_Teacher
(@id int,
@Fname varchar(100),
@Lname varchar(100),
@phone varchar(20),
@email varchar(255),
@Birthdate date,
@gender varchar(20),
@address varchar(max),
@country int,
@state int,
@city int,
@subject VARCHAR(255)
)
AS
BEGIN
UPDATE Teacher
SET FirstName=@Fname,LastName=@Lname,[PhoneNumber]=@phone,[EmailId]=@email,[BirthDate]=@Birthdate,
[Gender]=@gender,[Address]=@address, [City]=@city ,[State]=@state, [Country]=@country,subject=@subject
WHERE Id=@id;
END;


CREATE  PROC Delete_Student
(@id int
)
AS
BEGIN
  DELETE FROM [Student]
WHERE Id=@id;
END;

CREATE  PROC Delete_Teacher
(@id int
)
AS
BEGIN
  DELETE FROM Teacher
WHERE Id=@id;
END;
exec Delete_Teacher 11

select * from Student


insert Into  [SchoolUserLogin] values ('Vidhi','vkukrolia@gmail.com','12345678')
--use while registration
CREATE TABLE [SchoolUserLogin](
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [FName] VARCHAR(255) NOT NULL,
    [EmailId] VARCHAR(255) NOT NULL UNIQUE,
    [Password] VARCHAR(20)  NOT NULL
);
select * from [SchoolUserLogin]

create table [Student](
Id int primary key identity(1,1),
FirstName varchar(255) not null,
LastName varchar(255) not null,
PhoneNumber varchar(255) not null,
EmailId varchar(255) not null,
BirthDate date not null,
Gender varchar(255) not null,
Address varchar(500) not null,
Country int not null,
state int not null,
city int not null,
teacher varchar(255) not null
)
select * from [Teacher]
 

create table [Teacher](
Id int primary key identity(1,1),
FirstName varchar(255) not null,
LastName varchar(255) not null,
PhoneNumber varchar(255) not null,
EmailId varchar(255) not null,
BirthDate date not null,
Gender varchar(255) not null,
Address varchar(500) not null,
Country int not null,
state int not null,
city int not null,
Subject varchar(255) not null
)

 
create table [subject](
[Id] INT PRIMARY KEY IDENTITY(1,1),
[Name] VARCHAR(255) NOT NULL
)
create proc add_subject(
@subjectNAME VARCHAR(255)
)
AS
BEGIN
INSERT INTO [subject] VALUES (@subjectNAME)
END;
EXEC add_subject 'Biology'


drop table Teacher

CREATE TABLE [Country](
    [CountryId] INT PRIMARY KEY IDENTITY(1,1),
    [CountryName] VARCHAR(255)
);


create proc add_country(
@CountryNAME VARCHAR(255)
)
AS
BEGIN
INSERT INTO [Country] VALUES (@CountryNAME)
END;
EXEC add_country 'pakistan'
select * from [Teacher]

create proc add_state(
@stateNAME VARCHAR(255),
@couid int
)
AS
BEGIN
INSERT INTO [State] VALUES (@stateNAME,@couid)
END;
exec add_state 'ANDHRA PRADESH',1

create proc add_city(
@CityNAME VARCHAR(255),
@STATEID INT
)
AS
BEGIN
INSERT INTO [City] VALUES (@CityNAME,@STATEID)
END;
EXEC add_city 'DAHOD',1

CREATE  PROC UPDATE_DATA
(@id int,
@Fname varchar(100),
@Lname varchar(100),
@phone varchar(20),
@email varchar(255),
@Birthdate date,
@gender varchar(20),
@address varchar(max),
@country int,
@state int,
@city int,
@teacher VARCHAR(255)
)
AS
BEGIN
UPDATE [Student]
SET FirstName=@Fname,LastName=@Lname,[PhoneNumber]=@phone,[EmailId]=@email,[BirthDate]=@Birthdate,
[Gender]=@gender,[Address]=@address, [City]=@city ,[State]=@state, [Country]=@country,teacher=@teacher
WHERE Id=@id;
END;
EXEC UPDATE_DATA 1, 'Moxi','Gadariya','9924699291','moxigadariya@gmail.com','2008-04-16','female','Limdi',9,1,20,'Ravindra'


CREATE PROC UPDATE_Teacher
(@id int,
@Fname varchar(100),
@Lname varchar(100),
@phone varchar(20),
@email varchar(255),
@Birthdate date,
@gender varchar(20),
@address varchar(max),
@country int,
@state int,
@city int,
@subject VARCHAR(255)
)
AS
BEGIN
UPDATE [Teacher]
SET FirstName=@Fname,LastName=@Lname,[PhoneNumber]=@phone,[EmailId]=@email,[BirthDate]=@Birthdate,
[Gender]=@gender,[Address]=@address, [City]=@city ,[State]=@state, [Country]=@country,[Subject]=@subject
WHERE Id=@id;
END;
EXEC UPDATE_Teacher 1, 'Ravindra','Mali','9924699289','ravindra@gmail.com','1995-04-16','male','Limdi',9,1,20,'Social Science'


CREATE TABLE [State](
    [StateId] INT PRIMARY KEY IDENTITY(1,1),
    [StateName] VARCHAR(255),
    [CountryId] INT 
);


CREATE TABLE [City](
    [CityId] INT PRIMARY KEY IDENTITY(1,1),
    [CityName] VARCHAR(255),
    [StateId] INT
);
SELECT * FROM [Country]
ALTER TABLE [State]

ADD FOREIGN KEY ([CountryId]) REFERENCES [Country]([CountryId]);

ALTER TABLE [City]
ADD FOREIGN KEY ([StateId]) REFERENCES [State]([StateId]);

create proc add_user(
@fname varchar(255),
@email varchar(255),
@password varchar(25)
)
as
begin

insert into [SchoolUserLogin] values(@fname,@email,@password)
end;
exec add_user 'vidhi','vkukrolia@gmail.com','1234'

create proc sp_add_teacher(
@FirstName varchar(255),
@LastName varchar(255) ,
@PhoneNumber varchar(255),
@EmailId varchar(255),
@BirthDate date ,
@Gender varchar(255) ,
@Address varchar(500),
@Country int ,
@state int ,
@city int ,
@Subject varchar(255) 
)
as
begin
insert into [Teacher] values (@FirstName,@LastName,@PhoneNumber,@EmailId,@BirthDate,@Gender,@Address,@Country,@state,@city,@Subject)
end;
exec sp_add_teacher 'VIDHI','KUKROLIA','7414785212','VIDHI2GMAIL.COM','2002-08-06','FEMALE','DAHOD','9','1','20','pHYSICS'

select * from Student

create  or alter proc   sp_add_student(
@FirstName varchar(255),
@LastName varchar(255) ,
@PhoneNumber varchar(255),
@EmailId varchar(255),
@BirthDate date ,
@Gender varchar(255) ,
@Address varchar(500),
@Country int ,
@state int ,
@city int ,
@teacher varchar(255) 
)
as
begin
insert into [student] values (@FirstName,@LastName,@PhoneNumber,@EmailId,@BirthDate,@Gender,@Address,@Country,@state,@city,@teacher)
end;
exec sp_add_student 'VIDHI','KUKROLIA','7414785212','VIDHI2GMAIL.COM','2002-08-06','FEMALE','DAHOD','9','1','20','nita vyas'

CREATE  PROC Delete_DATA
(@id int
)
AS
BEGIN
  DELETE FROM [Student]
WHERE Id=@id;
END;


CREATE  PROC Delete_DATA_teacher
(@id int
)
AS
BEGIN
  DELETE FROM [Teacher]
WHERE Id=@id;
END;

Create proc add_update_Country(
@id int,
@Countryname varchar(250)
)
as
begin
Update [Country] 
set [CountryName]=@Countryname where [CountryId]=@id
end;
exec add_update_Country

Select * From  Country


Create proc ViewCountry
As
Begin
   Select * From Country
End
