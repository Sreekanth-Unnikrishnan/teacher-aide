CREATE PROCEDURE [dbo].[Term_Types_SelectAll]
AS
  SELECT term_type_code,
         term_type_name
    FROM dbo.Term_Types
GO
