CREATE TABLE Majors
(
  MajorID INT PRIMARY KEY IDENTITY,
  [Name] VARCHAR(50) NOT NULL 
)

CREATE TABLE Subjects
(
  SubjectID INT PRIMARY KEY IDENTITY,
  SubjectName VARCHAR(50) NOT NULL 
)

CREATE TABLE Students
(
  StudentID INT PRIMARY KEY IDENTITY,
  StudentNumber INT NOT NULL,
  StudentName VARCHAR(50) NOT NULL,
  MajorID INT REFERENCES Majors(MajorID)
)

CREATE TABLE Payments
(
  PaymentID INT PRIMARY KEY IDENTITY,
  PaymentDate DATE NOT NULL,
  PaymentAmount INT NOT NULL,
  StudentID INT REFERENCES Students(StudentID)
)

CREATE TABLE Agenda
(
  StudentID INT REFERENCES Students(StudentID),
  SubjectID INT REFERENCES Subjects(SubjectID)

  CONSTRAINT PK_Students_Subjects PRIMARY KEY (StudentID, SubjectID)
)