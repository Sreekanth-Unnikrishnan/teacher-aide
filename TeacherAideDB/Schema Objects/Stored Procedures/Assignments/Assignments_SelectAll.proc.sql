CREATE PROCEDURE [dbo].[Assignments_SelectAll]
AS
  SELECT course_id,
         assignment_seq,
         assignment_name,
         assignment_description,
         assignment_type_code
    FROM dbo.Assignments
GO
