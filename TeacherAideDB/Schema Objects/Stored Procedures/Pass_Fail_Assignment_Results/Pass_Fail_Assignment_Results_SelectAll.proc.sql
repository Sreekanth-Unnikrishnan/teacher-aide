CREATE PROCEDURE [dbo].[Pass_Fail_Assignment_Results_SelectAll]
AS
  SELECT course_id,
         assignment_seq,
         student_user_id,
         term_id,
         result
    FROM dbo.Pass_Fail_Assignment_Results
GO
