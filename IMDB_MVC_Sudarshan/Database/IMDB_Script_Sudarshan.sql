Create database DBImdbMvcSudarshan;
go

use DBImdbMvcSudarshan
go


CREATE TABLE [dbo].[Actor] (

 intId int IDENTITY(1,1),
 strName varchar(128) NOT NULL,
 strSex  char(6) NOT NULL,  
 datDOB  datetime NOT NULL,
 strBio  varchar(512) NULL,

 CONSTRAINT Actor_PK PRIMARY KEY CLUSTERED(intId)
)



CREATE TABLE [dbo].[Producer] (
	intId int IDENTITY(1,1) ,
	strName varchar(128) NOT NULL,
	strSex char(6) NOT NULL,
	datDOB datetime NOT NULL,
	strBio varchar(512) NULL,

	CONSTRAINT Producer_PK PRIMARY KEY CLUSTERED(intId)
	)

	CREATE TABLE [dbo].[Movie] (
	intId int IDENTITY(1,1),
	strName varchar(128) NOT NULL,
	sintYor smallint  NOT NULL CHECK (sintYor BETWEEN 1000 AND 9999),
	strPoster varchar(128),
	ProducerId int NOT NULL,

	CONSTRAINT Movie_PK PRIMARY KEY CLUSTERED(intId),
	CONSTRAINT Movie_FK_Producer FOREIGN KEY (ProducerId) REFERENCES Producer (intId)
	)

CREATE TABLE [dbo].[ActorMovie] (

	intActorId int ,
	intMovieId int ,

	CONSTRAINT ActorMovie_PK PRIMARY KEY CLUSTERED (intActorId , intMovieId),
	CONSTRAINT ActorMovie_FK_Actor FOREIGN KEY (intActorId) REFERENCES Actor (intId),
	CONSTRAINT ActorMovie_FK_Movie FOREIGN KEY (intMovieId) REFERENCES Movie (intId),

 )




INSERT INTO [dbo].[Actor](strName , strSex , datDOB , strBio) VALUES
('Tom Hanks' ,'MALE' , '19590118 10:34:05 AM', 'Thomas Jeffrey Hanks is an American actor and filmmaker.');
INSERT INTO [dbo].[Actor](strName , strSex , datDOB , strBio) VALUES
('Will Smith' ,'MALE' , '19680925 10:34:05 AM', 'Willard Carroll Smith Jr. is an American actor, producer, rapper, comedian, and songwriter.');
INSERT INTO [dbo].[Actor](strName , strSex , datDOB , strBio) VALUES
('Emile Hirch' ,'MALE' , '19850313 10:34:05 AM', 'Thomas Jeffrey Hanks is an American actor and filmmaker.');

INSERT INTO [dbo].[Actor](strName , strSex , datDOB , strBio) VALUES
('Samual L. Jakson' ,'MALE' , '19481221 10:34:05 AM', 'Samuel Leroy Jackson is an American actor and film producer. He achieved prominence and critical acclaim in the early 1990s with films such as Goodfellas, Jungle Fever');

INSERT INTO [dbo].[Actor](strName , strSex , datDOB , strBio) VALUES
('Hugh Jackman' ,'MALE' , '19681012 10:34:05 AM', 'Hugh Michael Jackman is an Australian actor, singer, and producer.');

INSERT INTO [dbo].[Actor](strName , strSex , datDOB , strBio) VALUES
('J. K. Simmons' ,'MALE' , '19550109 10:34:05 AM', 'Jonathan Kimble Simmons is an American character actor and voice actor. In television, he is known for playing Dr. Emil Skoda on the');

INSERT INTO [dbo].[Actor](strName , strSex , datDOB , strBio) VALUES
('Mandy Moore' ,'FEMALE' , '19841004 10:34:05 AM', 'Amanda Leigh "Mandy" Moore is an American singer-songwriter and actress. After coming to fame in 1999 with her debut single "Candy", which peaked at number 41 on the Billboard Hot 100');

INSERT INTO [dbo].[Actor](strName , strSex , datDOB , strBio) VALUES
('Helen Hunt' ,'FEMALE' , '19630615 10:34:05 AM', 'Helen Elizabeth Hunt is an American actress');


go

INSERT INTO [dbo].[Producer] (strName , strSex , datDOB, strBio ) VALUES
	('Jack Rapke' , 'MALE' , '19430612 01:24:12 PM' , 'excellent')

INSERT INTO [dbo].[Producer] (strName , strSex , datDOB, strBio ) VALUES
	('George Lucas' , 'MALE' , '19430612 01:24:12 PM' , 'George Walton Lucas Jr. is an American filmmaker and entrepreneur. Lucas is best known as the creator of the Star Wars and Indiana Jones franchises')
	


INSERT INTO [dbo].[Producer] (strName , strSex , datDOB, strBio ) VALUES
	('Kevin Spacey' , 'MALE' , '19430726 01:24:12 PM' , 'Kevin Spacey Fowler KBE is an American actor, producer and singer.')

INSERT INTO [dbo].[Producer] (strName , strSex , datDOB, strBio ) VALUES
	('Kathleen Kennedy' , 'FEMALE' , '19530605 01:24:12 PM' , 'Kathleen Kennedy is an American film producer.')

go

INSERT INTO [dbo].[Movie] (strName, sintYor , strPoster,ProducerId) VALUES
	('Cast Away' , 2000,'xyz\img',1)

INSERT INTO [dbo].[Movie] (strName, sintYor , strPoster,ProducerId) VALUES
	('Into the wild' , 2007,'xyz\img',1)
INSERT INTO [dbo].[Movie] (strName, sintYor , strPoster,ProducerId) VALUES
	('The Pursuit of happiness' ,2006 ,'xyz\img',1)
INSERT INTO [dbo].[Movie] (strName, sintYor , strPoster,ProducerId) VALUES
	('Coach Carter' , 2005,'xyz\img',1)
INSERT INTO [dbo].[Movie] (strName, sintYor , strPoster,ProducerId) VALUES
	('Whiplash' , 2014,'xyz\img',1)

INSERT INTO [dbo].[Movie] (strName, sintYor , strPoster,ProducerId) VALUES
	('A walk to remember' , 2002,'xyz\img',1)



