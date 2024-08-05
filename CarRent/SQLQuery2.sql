insert into Vehicles(CompanyID,Brand,Model,Color,Year,DailyRate,LicensePlate,AvailableFrom,
AvailableTo,FuelType,TransmissionType,MileAge) 
values (1,'Fiat','Fiorino','Derin Mavi',2024,850,'34 FT 1475',DATEADD(dd,8,GETDATE()),DATEADD(dd,60,GETDATE()),'Dizel','Manuel',1745);



insert into VehicleImages(VehicleID,ImagePath) values (scope_identity(),'\images\fiorino2024.jpg');
select * from  VehicleImages;
select * from  Vehicles;



