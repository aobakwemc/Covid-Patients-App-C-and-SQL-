create database ZONE15

go

use ZONE15

create table Patients
(
PatientID int,
[Name] varchar(25),
Surname varchar(25),
Gender varchar(10),
DateAdmitted date) --YYYY-MM-DD


go

insert into Patients --no need to assume column names if inserting values into all columns
values
(33984, 'Mali', 'Zucker','Female', '2020-09-08'),
(32110, 'Hilger','Logar', 'Male', '2021-06-06'),
(39553, 'Xola', 'Senders','Female', '2020-10-07'),
(30019, 'Beulah', 'Asybo', 'Female', '2021-11-08'),
(34710, 'Ginka', 'Solari', 'Male', '2020-02-06')

go

create proc spDisplayAll
as
	begin
		select * from Patients
	end

go
