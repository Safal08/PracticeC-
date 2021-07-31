/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
      ,[Address]
      ,[Faculty]
  FROM [PracticeStudent].[dbo].[Students]

  Select *From Students;
  DELETE FROM Students Where Id=4;

  Insert into Students (Name,Address, Faculty)  
  Values ('Safal Mahat', 'Thankot', 'BBS')

  UPDATE Students SET Faculty = 'CSIT' Where Id=5;




  