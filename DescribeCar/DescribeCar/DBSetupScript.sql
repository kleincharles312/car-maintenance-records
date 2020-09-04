--Begin tran
USE master
GO

--drop database if it exists
IF DB_ID('car_specs') IS NOT NULL
BEGIN
	ALTER DATABASE car_specs SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE car_specs;
END

CREATE DATABASE car_specs
GO

USE car_specs
GO

Create Table specs (
	carId int Identity (1,1) Not Null,
	yearMade varchar(4) Not Null,
	make varchar(20) Not Null,
	model varchar(30) Not Null,
	color varchar(15) Not Null,
	transmission varchar(50) Not Null,
	wheelSize varchar(50) Not Null,
	baseEngineSize varchar(20) Not Null
	Constraint pk_specs Primary Key (carId)
)

Create Table pic (
	picId int Identity Not Null,
	carId int Not Null,
	picURL varchar(150) Not Null,
	picAlt varchar(150) Not Null
	Constraint pk_pic Primary Key (picId),
	Constraint fk_pic_specs Foreign Key (carId) References specs(carId)
)

Create Table record (
	recordId int Identity (1,1) Not Null,
	carId int Not Null,
	dateOfRecord date,
	mileage int Not Null,
	description varchar(300) Not Null,
	Constraint pk_record Primary Key (recordId),
	Constraint fk_record_specs Foreign Key (carId) References specs(carId)
)

Insert into specs (yearMade, make, model, color, transmission, wheelSize, baseEngineSize) values ('2003', 'Mini', 'Cooper S', 'yellow', '6-speed manual', '16" diameter, 6.5" width', '1.6 L');
Insert into pic (carId, picURL, picAlt) values (1, 'https://live.staticflickr.com/1083/1112654629_cfd5ba8751_b.jpg', 'Front view of yellow 2003 Mini Cooper S');
Insert into pic (carId, picURL, picAlt) values (1, 'https://live.staticflickr.com/1392/1171507559_a36f1700e4_b.jpg', 'Yellow 2003 Mini Cooper S from side');
Insert into pic (carId, picURL, picAlt) values (1, 'https://live.staticflickr.com/1253/1172410372_3275d2941c_b.jpg', 'Yellow 2003 Mini Cooper S front view with doors open');

Insert into record (carId, dateOfRecord, mileage, description) values (1, '2019-03-20', 144295, 'Changed oil and filter. Used Moto 1 5W 30 High Mileage Conventional.');
Insert into record (carId, dateOfRecord, mileage, description) values (1, '2019-09-12', 146729, 'Changed oil and filter. Used Moto 1 5W 30 High Mileage Conventional.');
Insert into record (carId, dateOfRecord, mileage, description) values (1, '2019-10-02', 147101, 'Replaced two front headlights.');
Insert into record (carId, dateOfRecord, mileage, description) values (1, '2020-01-21', 150005, 'Changed oil and filter. Used Moto 1 5W 30 High Mileage Conventional. Replaced both rear brake pads.');
Insert into record (carId, dateOfRecord, mileage, description) values (1, '2020-04-12', 147101, 'Changed oil and filter. Used Moto 1 5W 30 High Mileage Conventional. Replaced air filter');