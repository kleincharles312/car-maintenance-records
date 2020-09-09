--Begin Tran
Use car_specs

Delete from record
Delete from pic
Delete from specs


Insert into specs (yearMade, make, model, color, transmission, wheelSize, baseEngineSize) values ('2003', 'Mini', 'Cooper S', 'yellow', '6-speed manual', '"16" diameter, 6.5" width', '1.6 L');
Declare @carId int = @@Identity;

Insert into pic (carId, picURL, picAlt) values (@carId, 'https://live.staticflickr.com/1083/1112654629_cfd5ba8751_b.jpg', 'Front view of yellow 2003 Mini Cooper S');
Insert into pic (carId, picURL, picAlt) values (@carId, 'https://live.staticflickr.com/1392/1171507559_a36f1700e4_b.jpg', 'Yellow 2003 Mini Cooper S from side');
Insert into pic (carId, picURL, picAlt) values (@carId, 'https://live.staticflickr.com/1253/1172410372_3275d2941c_b.jpg', 'Yellow 2003 Mini Cooper S front view with doors open');

Insert into record (carId, dateOfRecord, mileage, description) values (@carId, '2019-03-20', 144295, 'Changed oil and filter. Used Moto 1 5W 30 High Mileage Conventional.');
Insert into record (carId, dateOfRecord, mileage, description) values (@carId, '2019-09-12', 146729, 'Changed oil and filter. Used Moto 1 5W 30 High Mileage Conventional.');
Insert into record (carId, dateOfRecord, mileage, description) values (@carId, '2019-10-02', 147101, 'Replaced two front headlights.');
Insert into record (carId, dateOfRecord, mileage, description) values (@carId, '2020-01-21', 150005, 'Changed oil and filter. Used Moto 1 5W 30 High Mileage Conventional. Replaced both rear brake pads.');
Insert into record (carId, dateOfRecord, mileage, description) values (@carId, '2020-04-12', 147101, 'Changed oil and filter. Used Moto 1 5W 30 High Mileage Conventional. Replaced air filter');

Select @carId

--Rollback Tran