CREATE PROCEDURE [dbo].[Assignment_Types_SelectByID]
   @assignment_type_code int
AS
  SELECT assignment_type_code,
         assignment_type_name
    FROM dbo.Assignment_Types
   WHERE assignment_type_code = @assignment_type_code
GO
