CREATE PROCEDURE [dbo].[Assignments_SelectByID]
   @course_id int,
   @assignment_seq int
AS
  SELECT course_id,
         assignment_seq,
         assignment_name,
         assignment_description,
         assignment_type_code
    FROM dbo.Assignments
   WHERE course_id = @course_id
         AND assignment_seq = @assignment_seq
GO
