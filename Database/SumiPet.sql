

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
update BlogPost set CreatedOnUtc = '2021-03-07 14:38:44.8733574' where Id = 2
update BlogPost set CreatedOnUtc = '2021-03-06 14:38:44.8733574' where Id = 3
update BlogPost set CreatedOnUtc = '2020-03-08 14:38:44.8733574' where Id = 4
update BlogPost set CreatedOnUtc = '2019-03-08 14:38:44.8733574' where Id = 5
update BlogPost set CreatedOnUtc = '2021-03-07 14:38:44.8733574' where Id = 6
update BlogPost set CreatedOnUtc = '2021-03-08 14:38:44.8733574' where Id = 7