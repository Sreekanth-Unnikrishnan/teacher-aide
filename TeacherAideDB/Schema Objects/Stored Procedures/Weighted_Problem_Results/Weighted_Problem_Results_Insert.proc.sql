CREATE PROCEDURE [dbo].[Weighted_Problem_Results_Insert]
   @course_id int,
   @assignment_seq int,
   @student_user_id int,
   @term_id int,
   @problem_number smallint,
   @actual_score int
AS
INSERT INTO dbo.Weighted_Problem_Results
            (course_id,
             assignment_seq,
             student_user_id,
             term_id,
             problem_number,
             actual_score)
     VALUES (@course_id,
             @assignment_seq,
             @student_user_id,
             @term_id,
             @problem_number,
             @actual_score)
GO
