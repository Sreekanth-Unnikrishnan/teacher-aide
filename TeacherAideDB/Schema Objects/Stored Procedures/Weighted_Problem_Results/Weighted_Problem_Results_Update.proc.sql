CREATE PROCEDURE [dbo].[Weighted_Problem_Results_Update]
   @course_id int,
   @assignment_seq int,
   @student_user_id int,
   @term_id int,
   @problem_number smallint,
   @actual_score int
AS
UPDATE dbo.Weighted_Problem_Results
   SET actual_score = @actual_score
 WHERE course_id = @course_id
       AND assignment_seq = @assignment_seq
       AND student_user_id = @student_user_id
       AND term_id = @term_id
       AND problem_number = @problem_number
GO
