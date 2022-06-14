use master
go
---------------------- CREATE Database ---------------------------------------
CREATE database SchoolManagement
go
use SchoolManagement
go
-----------------------  Class Table ---------------------------------------
Go
use SchoolManagement
Go
CREATE Table ClassTable 
(
	class_ID int primary key identity,
	class_Name varchar(50) not null 
);

INSERT INTO ClassTable (class_Name)Values ('One');
INSERT INTO ClassTable (class_Name)Values ('Two');
INSERT INTO ClassTable (class_Name)Values ('Three');
INSERT INTO ClassTable (class_Name)Values ('Four');
INSERT INTO ClassTable (class_Name)Values ('Five');
INSERT INTO ClassTable (class_Name)Values ('Six');
INSERT INTO ClassTable (class_Name)Values ('Seven');
INSERT INTO ClassTable (class_Name)Values ('Eight');
INSERT INTO ClassTable (class_Name)Values ('Nine');
INSERT INTO ClassTable (class_Name)Values ('Ten');


----------- CREATE StudentTable ---------------------------------------------
CREATE table StudentTable
(StudentID int primary key identity,
FirstName varchar(50) not null,
LastName varchar(50) not null,
sGender varchar(50) not null,
sDOB date not null,
sClass int not null REFERENCES ClassTable (class_ID) ON DELETE CASCADE ON UPDATE CASCADE,
sSection varchar(50) not null,
sGroup varchar(50) not null,
sAddress varchar(50) not null,
sFatherName varchar(50) not null,
sFatherContact varchar(50) not null,
sPhoto varchar(500) not null
);


-------------------------------------Master Store Procedure ------------------------------------------------
Go
use SchoolManagement
Go
CREATE proc spMasterSrocStudentTable
(@sId int = null,
	@s_fname varchar(50) = null,
	@s_lname varchar(50) = null, 
	@s_gender varchar(50) = null,
	@s_dob varchar(50) = null,
	@s_class int = null,
	@s_section varchar(50) = null,
	@s_group varchar(50) = null,
	@s_address varchar(50) = null,
	@s_faName varchar(50) = null,
	@s_faContact varchar(50) = null,
	@s_photo varchar(500) = null,
	@action nvarchar(50) = '')

As
	Begin
		if @action = 'INSERT'
		Begin
			INSERT INTO StudentTable 
			(FirstName, LastName, sGender, sDOB, sClass, sSection, sGroup, sAddress, sFatherName, sFatherContact, sPhoto)
			Values(@s_fname, @s_lname, @s_gender, @s_dob, @s_class, @s_section, @s_group, @s_address, @s_faName, @s_faContact, @s_photo);
		End

		if @action = 'SELECT'
		Begin
			SELECT st.StudentID, st.FirstName, st.LastName, st.sGender, st.sDOB, ct.class_Name, st.sSection, st.sGroup, st.sAddress, st.sFatherName, st.sFatherContact, st.sPhoto 
			FROM StudentTable st INNER JOIN ClassTable ct
			ON st.sClass = ct.class_ID;
		End

		if @action = 'Update'
		Begin
			Update StudentTable 
			SET FirstName = @s_fname, LastName = @s_lname, sGender = @s_gender, sDOB = @s_dob,
				sClass	= @s_class, sSection = @s_section, sGroup = @s_group, sAddress = @s_address,
				sFatherName	= @s_faName, sFathercontact	= @s_faContact,
				sPhoto	= @s_photo
			where StudentID = @sId;
		End

		if @action = 'Delete'
		Begin
			Delete FROM StudentTable where StudentID = @sId;
		End
	End

	
---------------------------------------------------------------------------------------------------------
--exec spMasterSrocStudentTable @s_fname = 'Abul',
--@s_lname = 'aaaaKhayer', 
--@s_gender = 'bbbbbMale',
--@s_dob = '2012-12-31', 
--@s_class = 10, 
--@s_section = 'day', 
--@s_group = 'arts', 
--@s_address = 'dhaka', 
--@s_faName ='Abu',
--@s_faContact ='dhaka', 
--@s_photo = 'photo nai', 
--@action = 'INSERT';
--go
--exec spMasterSrocStudentTable @action ='SELECT' ; 


------------------------ Result & Payment Table --------------------------------------------------------
Go
CREATE Table StudentResult
(
	SR_ID int primary key identity,
	StudentID int not null REFERENCES StudentTable (StudentID) ON DELETE CASCADE ON UPDATE CASCADE,
	TotalFee money not null,
	TotalPayment money not null,
	PaymentDate date not null,
	Exam varchar(50) not null,
	Grade varchar(50) not null,
	ExamYear date not null
);

------------------------------ Join Query ----------------------------------
GO
use SchoolManagement
Go
CREATE proc spStudentProfileQuery
@id int
AS
SELECT st.StudentID, st.FirstName, st.LastName, st.sGender,st.sDOB, ct.class_Name, st.sSection, st.sGroup, st.sAddress, st.sFatherName, st.sFatherContact
	, sr.Exam, sr.Grade, sr.ExamYear, st.sPhoto, sr.TotalFee, sr.TotalPayment, sr.PaymentDate
FROM StudentTable st INNER JOIN ClassTable ct
On st.sClass = ct.class_ID
INNER JOIN StudentResult sr
ON st.StudentID = sr.StudentID
Where st.StudentID = @id;


---------------------------- aler join query -------------------------------------
GO
use SchoolManagement
Go
CREATE proc spStudentProfileAlterQuery
@id int
AS
SELECT st.StudentID, st.FirstName, st.LastName, st.sGender,st.sDOB, ct.class_Name, 
	st.sSection, st.sGroup, st.sAddress, st.sFatherName, st.sFatherContact ,st.sPhoto
FROM StudentTable st INNER JOIN ClassTable ct
On st.sClass = ct.class_ID
Where st.StudentID = @id;


-------------------------- Create Teacher Table -------------------------------------
CREATE TABLE TeacherTable
(
	TeacherID INT PRIMARY KEY IDENTITY,
	tFirstName varchar(50) not null,
	tLastName varchar(50) not null,
	tGender varchar(50) not null,
	tDOB date not null,
	tClass varchar(50) not null,
	tSection varchar(50) not null,
	tDesignation varchar(50) not null,
	tPresentAddress varchar(100) not null,
	tGroup int not null,
	tSubject int not null,
	tPhoto varchar(200) not null
);

------------------------------------ Create Group Table ----------------------------------
CREATE TABLE GroupTable
(
	Group_Id int PRIMARY KEY IDENTITY,
	GroupName varchar(50)
)

INSERT INTO GroupTable(GroupName) VALUES('Science');
INSERT INTO GroupTable(GroupName) VALUES('Business Studies');
INSERT INTO GroupTable(GroupName) VALUES('Arts');

SELECT * FROM GroupTable
------------------------------------- Create Subject Table -------------------------------
CREATE TAble SubjectTable
(
	Subject_Id int PRIMARY KEY IDENTITY,
	Group_Id int not null REFERENCES GroupTable (Group_Id) ON DELETE CASCADE ON UPDATE CASCADE,
	SubjectName varchar(50)
	
);

INSERT INTO SubjectTable (Group_Id, SubjectName) Values (1, 'Physics');
INSERT INTO SubjectTable (Group_Id, SubjectName) Values (1, 'Chemistry');
INSERT INTO SubjectTable (Group_Id, SubjectName) Values (1, 'Biology');
INSERT INTO SubjectTable (Group_Id, SubjectName) Values (2, 'Finance');
INSERT INTO SubjectTable (Group_Id, SubjectName) Values (2, 'Accounting');
INSERT INTO SubjectTable (Group_Id, SubjectName) Values (2, 'Marketing');
INSERT INTO SubjectTable (Group_Id, SubjectName) Values (2, 'Management');
INSERT INTO SubjectTable (Group_Id, SubjectName) Values (2, 'Enterpreunership');
INSERT INTO SubjectTable (Group_Id, SubjectName) Values (3, 'History');
INSERT INTO SubjectTable (Group_Id, SubjectName) Values (3, 'Social Science');
INSERT INTO SubjectTable (Group_Id, SubjectName) Values (3, 'Geology');
INSERT INTO SubjectTable (Group_Id, SubjectName) Values (3, 'Econimics');
-----------------------------------Store procedure for subject ComboBox ---------------------------------------------------
go
use SchoolManagement
go 

CREATE proc spRelationalSubject
@gId int
AS
	Select SubjectName
	From SubjectTable st inner join GroupTable gt
	on st.Group_Id = gt.Group_Id
	where gt.Group_Id = @gId;


	--------------------------------- Report Procedure -----------------------------------------------------
	Go
	use SchoolManagement
	go
	Create proc spReport
	AS
	Select st.StudentID, st.FirstName,st.sGroup, st.sSection, ct.class_Name
	, sr.TotalPayment, sr.PaymentDate, (sr.TotalFee - sr.TotalPayment) Due 
	from StudentTable st inner join ClassTable ct
	ON st.sClass = ct.class_ID 
	inner join StudentResult sr
	ON st.StudentID = sr.StudentID