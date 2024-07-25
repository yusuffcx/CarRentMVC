--insert into Company(CompanyName,Address,Phone,Email) values ('BRent a Car','Istanbul/Bakırköy','02124759886','Brent@gmail.com');


/*insert into Vehicles(CompanyID,Brand,Model,Color,Year,DailyRate,LicensePlate,AvailableFrom,
AvailableTo,FuelType,TransmissionType,MileAge) 
values (scope_identity(),'Ford','Focus','Mavi',2022,775,'34 BHG 814',DATEADD(dd,15,getdate()) ,DATEADD(dd,58,GETDATE()),'Dizel','Otomatik',14479);
*/

/*
insert into VehicleImages(VehicleID,ImagePath) values (scope_identity(),'\images\focus2022.jpg');
*/
select * from Company;
select * from  Vehicles;
select * from  VehicleImages;

--UPDATE Vehicles
--SET CompanyID = 2
--WHERE VehicleID = 4;



