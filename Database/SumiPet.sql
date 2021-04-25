

select top 10 PictureId, * from news

update news set pictureid = 15
update news set ShowOnHomePage = 1

select top 10 PictureId, ShowOnHOmePage,* from BlogPost

update BlogPost set ShowOnHomePage = 0 where Id IN(5, 6)


update BlogPost set pictureid = 18
update BlogPost set ShowOnHomePage = 1

select * from Picture

alter table news add 	[PictureId] [int]  NULL
alter table BlogPost add [PictureId] [int]  NULL

alter table news add DisplayOrder INT default(0) not null
alter table BlogPost add DisplayOrder INT default(0) not null



alter table news add ShowOnHomePage BIT default(0) not null
alter table BlogPost add ShowOnHomePage BIT default(0) not null

select CreatedOnUtc,* from BlogPost

update BlogPost set CreatedOnUtc = '2021-03-08 14:38:44.8733574' where Id = 1
update BlogPost set CreatedOnUtc = '2021-02-07 14:38:44.8733574' where Id = 2
update BlogPost set CreatedOnUtc = '2021-01-06 14:38:44.8733574' where Id = 3
update BlogPost set CreatedOnUtc = '2020-03-08 14:38:44.8733574' where Id = 4
update BlogPost set CreatedOnUtc = '2019-03-08 14:38:44.8733574' where Id = 5
update BlogPost set CreatedOnUtc = '2021-03-07 14:38:44.8733574' where Id = 6
update BlogPost set CreatedOnUtc = '2021-06-08 14:38:44.8733574' where Id = 7












select top 100 * from PermissionRecord

select top 100 * from CustomerRole

select top 100 * from [dbo].[PermissionRecord_Role_Mapping] m join PermissionRecord p on m.PermissionRecord_Id = p.Id
where CustomerRole_Id = 1

select top 100 * from [dbo].[PermissionRecord_Role_Mapping]
where CustomerRole_Id = 2

insert into  [dbo].[PermissionRecord_Role_Mapping](PermissionRecord_Id, CustomerRole_Id) values(1, 2)
insert into  [dbo].[PermissionRecord_Role_Mapping](PermissionRecord_Id, CustomerRole_Id) values(3, 2)
insert into  [dbo].[PermissionRecord_Role_Mapping](PermissionRecord_Id, CustomerRole_Id) values(4, 2)
insert into  [dbo].[PermissionRecord_Role_Mapping](PermissionRecord_Id, CustomerRole_Id) values(30, 2)

insert into  [dbo].[PermissionRecord_Role_Mapping](PermissionRecord_Id, CustomerRole_Id) values(43, 2)

insert into  [dbo].[PermissionRecord_Role_Mapping](PermissionRecord_Id, CustomerRole_Id) values(7, 2)

insert into  [dbo].[PermissionRecord_Role_Mapping](PermissionRecord_Id, CustomerRole_Id) values(22, 2)

insert into  [dbo].[PermissionRecord_Role_Mapping](PermissionRecord_Id, CustomerRole_Id) values(23, 2)

insert into  [dbo].[PermissionRecord_Role_Mapping](PermissionRecord_Id, CustomerRole_Id) values(44, 2)
select top 100 * from [dbo].[Customer_CustomerRole_Mapping]


