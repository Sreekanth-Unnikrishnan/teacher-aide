CREATE PROCEDURE [dbo].[Assignment_Types_SelectAll]
AS
  SELECT assignment_type_code,
         assignment_type_name
    FROM dbo.Assignment_Types
GO
