

select top 10 PictureId, * from news

update news set pictureid = 15
update news set ShowOnHomePage = 1

select top 10 PictureId,* from BlogPost

update BlogPost set pictureid = 18
update BlogPost set ShowOnHomePage = 1

select * from Picture

alter table news add 	[PictureId] [int]  NULL
alter table BlogPost add [PictureId] [int]  NULL

alter table news add DisplayOrder INT default(0) not null
alter table BlogPost add DisplayOrder INT default(0) not null



alter table news add ShowOnHomePage BIT default(0) not null
alter table BlogPost add ShowOnHomePage BIT default(0) not null