CREATE PROCEDURE [dbo].[Weighted_Problem_Results_SelectAll]
AS
  SELECT course_id,
         assignment_seq,
         student_user_id,
         term_id,
         problem_number,
         actual_score
    FROM dbo.Weighted_Problem_Results
GO
