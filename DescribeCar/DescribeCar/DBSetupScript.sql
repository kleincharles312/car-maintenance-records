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
	horsepower int,
	zeroToSixty float Not Null,
	Constraint pk_specs Primary Key (carId)
)

Create Table pic (
	picId int Identity Not Null,
	carId int Not Null,
	picURL varchar(150) Not Null,
	picAlt varchar(150) Not Null
	Constraint fk_pic_specs Foreign Key (carId) References specs(carId)
)

Insert into specs (yearMade, make, model, horsepower, zeroToSixty) values (2003, 'Mini', 'Cooper S', 163, 6.1);
Insert into pic (carId, picURL, picAlt) values (1, 'https://live.staticflickr.com/1083/1112654629_cfd5ba8751_b.jpg', 'Front view of yellow 2003 Mini Cooper S');

Insert into specs (yearMade, make, model, horsepower, zeroToSixty) values (2006, 'Pontiac', 'GTO', 400, 4.7);
Insert into pic (carId, picURL, picAlt) values (2, 'https://live.staticflickr.com/65535/49842052651_2406c65b7d_b.jpg', 'Blue 2006 Pontiac GTO from the front');

Insert into specs (yearMade, make, model, horsepower, zeroToSixty) values (2015, 'Tesla', 'Model S', 329, 3.1);
Insert into pic (carId, picURL, picAlt) values (3, 'https://live.staticflickr.com/959/42212246421_59097f399f_b.jpg', 'Tesla in the dark');

