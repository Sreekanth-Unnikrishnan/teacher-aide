CREATE PROCEDURE [dbo].[Assignment_Types_Insert]
   @assignment_type_code int,
   @assignment_type_name nvarchar (40)
AS
INSERT INTO dbo.Assignment_Types
            (assignment_type_code,
             assignment_type_name)
     VALUES (@assignment_type_code,
             @assignment_type_name)
GO
