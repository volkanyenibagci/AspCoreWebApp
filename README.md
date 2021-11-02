# AspCoreWebApp
Asp Core Web Application

# Using Materials

IDE : Jetbrains Rider
Tech : Asp.Net Core
Database : Postgresql
Theme : adminlte

## * LINQ ile sorgulama,

## * Katmanlı mimari kullanımı ,

## * Stored Procedure Kullanımı ,
Database Side
```
CREATE OR REPLACE PROCEDURE insert_data(DepartmanAdi varchar(50))

 LANGUAGE 'plpgsql'

AS $$
BEGIN
	insert into aspcore.public."Departman" ("DepartmanAd","Durum") values ($1,true);
commit;
end;
$$
;
```
Core Application Side
```
string DepartmanAdi="Yeni Departman";
modelBuilder.Query<insert_data(DepartmanAdi)>();  
```

## * WebAPI SWAGGER -- https://localhost:5001/Departman Sample Get Request 
<img width="1437" alt="Screen Shot 2021-10-31 at 20 06 35" src="https://user-images.githubusercontent.com/22456678/139594476-add58f4d-c72d-445f-8b07-6adb17cbffb0.png">
<img width="1437" alt="Screen Shot 2021-10-31 at 20 06 49" src="https://user-images.githubusercontent.com/22456678/139594479-faee6015-61c9-4a86-a955-9f1f8e860d3c.png">
<img width="1437" alt="Screen Shot 2021-11-01 at 00 49 52" src="https://user-images.githubusercontent.com/22456678/139602338-4659106c-355b-4a71-8f2a-afda4584a218.png">

## * Code First with EFCORE , 
You can migrate of datase with Code First with EFCore.
Basic CLI commands for using EFCore is down below.
```
After clone the project;
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef (Test)
dotnet ef migrations add initial
dotnet ef database update
```

## * No framework is used on the FrontEnd side. Can be used Devexpress, Mvc Grid, Kendo , Telerik and other stuffs .
<img width="1437" alt="Screen Shot 2021-10-31 at 20 05 18" src="https://user-images.githubusercontent.com/22456678/139594433-94811a07-1c12-4916-bfb5-fd392abd1607.png">
<img width="1437" alt="Screen Shot 2021-10-31 at 20 05 30" src="https://user-images.githubusercontent.com/22456678/139594466-d3d9deeb-9ccf-4010-8b17-77834675063c.png">
<img width="1437" alt="Screen Shot 2021-10-31 at 20 05 42" src="https://user-images.githubusercontent.com/22456678/139594472-91c6b193-eb61-497b-a6a4-d245474268c4.png">
<img width="1437" alt="Screen Shot 2021-10-31 at 20 05 54" src="https://user-images.githubusercontent.com/22456678/139594473-8ae7543b-1317-4ff1-8a98-1d837689975f.png">

