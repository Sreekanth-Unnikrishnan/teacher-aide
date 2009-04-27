CREATE PROCEDURE [dbo].[Weighted_Problem_Results_SelectByID]
   @course_id int,
   @assignment_seq int,
   @student_user_id int,
   @term_id int,
   @problem_number smallint
AS
  SELECT course_id,
         assignment_seq,
         student_user_id,
         term_id,
         problem_number,
         actual_score
    FROM dbo.Weighted_Problem_Results
   WHERE course_id = @course_id
         AND assignment_seq = @assignment_seq
         AND student_user_id = @student_user_id
         AND term_id = @term_id
         AND problem_number = @problem_number
GO
