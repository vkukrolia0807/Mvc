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