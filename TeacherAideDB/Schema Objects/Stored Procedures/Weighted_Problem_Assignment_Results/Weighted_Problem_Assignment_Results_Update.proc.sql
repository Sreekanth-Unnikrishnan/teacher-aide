CREATE PROCEDURE [dbo].[Weighted_Problem_Assignment_Results_Update]
   @course_id int,
   @assignment_seq int,
   @student_user_id int,
   @term_id int,
   @percentage_score tinyint
AS
UPDATE dbo.Weighted_Problem_Assignment_Results
   SET percentage_score = @percentage_score
 WHERE course_id = @course_id
       AND assignment_seq = @assignment_seq
       AND student_user_id = @student_user_id
       AND term_id = @term_id
GO
