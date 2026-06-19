--in this exercise i will try to make a table for a meeting and education schedules


-- SQL is used to communicate with a database
-- In this file I will practice:
-- CREATE TABLE  -> creates a new table
-- INSERT        -> for adding new data
-- SELECT        -> this one reads data
-- WHERE         -> filters data 
-- ORDER BY      -> sorts data
-- UPDATE        -> changes existing data (it's like updating)
-- DELETE        -> removes data 

/*
INT → number
NVARCHAR → stores text values unicode characters etc
DATE → date
TIME → is time

Exampple:
*/
 

 /*
CREATE TABLE Students(
    Id INT,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Age INT
);

*/ 

/*
CREATE TABLE StudentId{
    Id INT PRIMARY KEY IDENTITY(1,1), -- IDENTITY(1,1) means id will increase otomatically and primary key is uniqe id
    FirstName NVARCHAR(50) NOT NULL,  --NOt NULL means u cant leave it empty
    LastName NVARCHAR(50)NOT NULL,
    Age INT
};




/* what i need here is 
ID --> it has to be int because it will be a number
SessionDate --> it has to be date 
SessionTime --> this one time
Title             for the texts i should use NVARCHAR or VArCHAR 
SpeakerName
Room                            NVARCHAR(100)<NVARCHAR(150)<NVARCHAR(300)<NVARCHAR(max) (length)
Description 

i will use =>
 Title       → NVARCHAR(100)
SpeakerName → NVARCHAR(100)
Room        → NVARCHAR(100)
Description → NVARCHAR(150)
*/

/*
CREATE TABLE TrainingSessions
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    SessionDate DATE NOT NULL,
    SessionTime TIME NOT NULL,
    Title NVARCHAR(100) NOT NULL,
    SpeakerName NVARCHAR(100),
    Room NVARCHAR(150),
    Description NVARCHAR(150)
);

INSERT INTO TrainingSessions 
(
    SessionDate, SessionTime, Title, SpeakerName,Room, Description
)
VALUES(
    '2003-10-03','10:30','Academic Session','Doctor Abc','Conference Room','Important Meeting'
);


--now i will choose specific info from the table i made using SELECT

SELECT Title, SessionTime, SpeakerName -- if i say SELECT * it means select it all
FROM TrainingSessions;

SELECT Id , Room , SessionDate , Description
FROM TrainingSessions;


-- WHERE is using for bringing specific conditions

SELECT Room
    FROM TrainingSessions
    WHERE Room = 'Conference Room';


SELECT Title, Room , SessionDate
FROM TrainingSessions
Where Room = 'Conference Room';


SELECT Title, SpeakerName
FROM TrainingSessions
WHERE SpeakerName = 'DOCTOR AYŞE';

SELECT Title, SessionDate, Room, SessionDate
FROM TrainingSessions
WHERE SessionDate = '2003-10-03';

-- ORDER BY is for sorting

SELECT SessionDates
From TrainingSessions
ORDER BY SessionDate

-- or

SELECT SessionDates
From TrainingSessions
ORDER BY DESC SessionDate

--ASC is ascending(default one), DESC is descending


-- UPDATE (using WHERE with update is important)

UPDATE TrainingSessions
SET Room = 'Meeting Room';
-- all rooms became meeting room

UPDATE TrainingSessions
SET Room = 'Meeting Room'
Where Id = 1;
--only the row with  Id = 1 will be updated 

UPDATE TrainingSessions
SET Room = 'Big Room',
    SessionTime = '11:00'
WHERE SpeakerName = 'Doctor Abc';

--DELETE is used to remove existing rows from a table but if i dont use WHERE all the rows will be deleted

DELETE FROM TrainingSessions;
WHERE Id = 1;


/*
CRUD means
Create → INSERT
Read   → SELECT
Update → UPDATE
Delete → DELETE */

/*
--DROP TABLE

DROP TABLE TrainingSessions;
-- DELETE deletes data inside the table butDROP TABLE deletes the table completely

--COUNT

SELECT COUNT (*)
FROM TrainingSessions;

-- LIKE (ı dont remember what was it but there was sql in the title )
SELECT Title
FROM TrainingSessions
WHERE Title LIKE '%SQL%'

--AND & OR 

SELECT Title, Room, SessionDate
FROM TrainingSessions
WHERE Room = 'Conference Room'
AND SessionDate = '2026-01-01';

SELECT Title, Room
FROM TrainingSessions
WHERE Room = 'Conference Room'
OR Room = 'Meeting Room'; 