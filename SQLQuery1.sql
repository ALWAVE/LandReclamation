use dbLand;

drop table Users;

create table Users(
id_users int PRIMARY KEY IDENTITY(1,1) not null,
userlogin VARCHAR (50),
username VARCHAR(50),
surname VARCHAR(50),
user_role VARCHAR (50),
user_password VARCHAR(100),
)

select * from Users;
INSERT INTO Users (userlogin, username, surname, user_role, user_password) VALUES ('admin', 'admin', 'admin', 'Администратор', 'admin');

create table LandReclamation(
id_land int PRIMARY KEY IDENTITY(1,1) not null,
organization_name VARCHAR(50),
adress VARCHAR(100),
city VARCHAR(100),
additionalImprovedField VARCHAR(100),
additionalWeedingField VARCHAR(100),
size VARCHAR(50),
price BIGINT,
id_belongs INT,
create_data datetime,
land_status VARCHAR(50),
FOREIGN KEY (id_belongs) REFERENCES Users(id_users)
)


create procedure CreateAccountingLand
@city_AccLand VARCHAR (48),
@addres_AccLand VARCHAR(48),
@countHectare_AccLand VARCHAR(48),
@comments_AccLand VARCHAR(256),
@id_owner int
as
begin
insert into AccountingLand (city_AccLand,addres_AccLand,countHectare_AccLand,comments_AccLand,id_owner)
values(@city_AccLand,@addres_AccLand,@countHectare_AccLand,@comments_AccLand,@id_owner)
end
go

create table AccountingLand(
id_AccLand int primary key identity (1,1) not null,
city_AccLand VARCHAR (48) not null,
addres_AccLand VARCHAR(48)not null,
countHectare_AccLand VARCHAR(48)not null,
comments_AccLand VARCHAR(256) null,
id_owner int,
FOREIGN KEY (id_owner) REFERENCES Users(id_users) ON DELETE CASCADE
);
drop table UserRating;
create table UserRating(
id_UserRating int primary key identity (1,1) not null,
mark_Users int,
comment_Users VARCHAR(256),
addressedTo VARCHAR(98) null,
id_User int,
foreign key (id_User) REFERENCES Users(id_users)
);

select * from UserRating;
drop table LandReclamation;

select * from LandReclamation;
insert into LandReclamation (land_name, adress, price) VALUES  ('Поле 1', 'Ул. Пушкина', 500000);