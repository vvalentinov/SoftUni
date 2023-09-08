CREATE TABLE Users
(
  Id BIGINT PRIMARY KEY IDENTITY,
  Username VARCHAR(30) NOT NULL,
  [Password] VARCHAR(26) NOT NULL,
  ProfilePicture VARCHAR(MAX),
  LastLoginTime DATETIME,
  IsDeleted BIT
)

INSERT INTO Users (Username, [Password], ProfilePicture, LastLoginTime, IsDeleted) VALUES
('Angel Egotrip','tfrgiiuus_77','https://www.google.bg/url?sa=i&url=https%3A%2F%2Fwww.istockphoto.com%2Fphotos%2Fstruggle&psig=AOvVaw3jzipEHQF5VQkJU2xdiHmn&ust=1630419363773000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCNjuhsv32PICFQAAAAAdAAAAABAD','5/6/2021',0),
('Made Savage','hrefdsfeds','https://www.google.bg/url?sa=i&url=https%3A%2F%2Fwww.istockphoto.com%2Fphotos%2Fstruggle&psig=AOvVaw3jzipEHQF5VQkJU2xdiHmn&ust=1630419363773000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCNjuhsv32PICFQAAAAAdAAAAABAD','4/12/2021',1),
('Binary Bark','ffffwqwdsa3','https://www.google.bg/url?sa=i&url=https%3A%2F%2Fwww.istockphoto.com%2Fphotos%2Fstruggle&psig=AOvVaw3jzipEHQF5VQkJU2xdiHmn&ust=1630419363773000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCNjuhsv32PICFQAAAAAdAAAAABAD','8/8/2021',0),
('The Deal','adfdfref78','https://www.google.bg/url?sa=i&url=https%3A%2F%2Fwww.istockphoto.com%2Fphotos%2Fstruggle&psig=AOvVaw3jzipEHQF5VQkJU2xdiHmn&ust=1630419363773000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCNjuhsv32PICFQAAAAAdAAAAABAD','5/2/2021',1),
('Fiddle Pie','hjgjgh77','https://www.google.bg/url?sa=i&url=https%3A%2F%2Fwww.istockphoto.com%2Fphotos%2Fstruggle&psig=AOvVaw3jzipEHQF5VQkJU2xdiHmn&ust=1630419363773000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCNjuhsv32PICFQAAAAAdAAAAABAD','7/11/2021',0)