CREATE TABLE Hairdressers_TG (
ID INT NOT NULL IDENTITY, 
Hairdressers_FName VARCHAR(25) NOT NULL, 
Hairdressers_LName VARCHAR(25) ,
Gender VARCHAR (6),
Phone CHAR (13)  
)

INSERT INTO Hairdressers_TG
(Hairdressers_FName, Hairdressers_LName, Gender, Phone)
VALUES 
('George','Hroshev','Male','0957826485'),
('Sergey','Zubniak','Male','0955316485'),
('Nina','Sokolova','Female','0957826498'),
('Andriy','Pavliuk','Male','0457826463'),
('Valeriy','Nukolushun','Male','0657826435'),
('Anna','Samoshod','Female','0997826499'),
('Irina','Yanovska','Female','0897826332'),
('Angelika','Rulska','Female','0957826444')

SELECT top 10 Hairdressers_FName, Hairdressers_LName, Gender, Phone FROM Hairdressers_TG




