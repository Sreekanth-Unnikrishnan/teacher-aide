/****** Object:  StoredProcedure [dbo].[Exercise_Types_SelectAll]    Script Date: 05/01/2009 14:56:49 ******/
CREATE PROCEDURE [dbo].[Exercise_Types_SelectAll]
AS
  SELECT [exercise_type_code],
         [exercise_type_name]
    FROM [dbo].[Exercise_Types]
GO
