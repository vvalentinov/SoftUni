CREATE TABLE People 
(
  Id INT PRIMARY KEY IDENTITY,
  [Name] VARCHAR(200) NOT NULL,
  Picture VARCHAR(MAX),
  Height DECIMAL(10,2),
  [Weight] DECIMAL(10,2),
  Gender CHAR NOT NULL,
  CHECK (Gender='m' OR Gender='f'),
  Birthdate VARCHAR(20) NOT NULL,
  Biography VARCHAR(MAX)
)

INSERT INTO People ([Name], Picture, Height, Weight, Gender, Birthdate, Biography) VALUES
('IVAN','https://www.shutterstock.com/image-photo/aerial-view-monemvasia-island-linked-mainland-1944646087',198.678,80.789,'m','5/5/2000',NULL),
('PETAR','https://www.shutterstock.com/image-photo/aerial-view-monemvasia-island-linked-mainland-1944646087',166.678,90.789,'m','5/5/2000',NULL),
('MARIA','https://www.shutterstock.com/image-photo/aerial-view-monemvasia-island-linked-mainland-1944646087',166.678,60.789,'f','5/5/2000',NULL),
('STANISLAV','https://www.shutterstock.com/image-photo/aerial-view-monemvasia-island-linked-mainland-1944646087',189.678,85.789,'m','5/5/2000',NULL),
('IVANA','https://www.shutterstock.com/image-photo/aerial-view-monemvasia-island-linked-mainland-1944646087',168.678,63.789,'f','5/5/2000',NULL)