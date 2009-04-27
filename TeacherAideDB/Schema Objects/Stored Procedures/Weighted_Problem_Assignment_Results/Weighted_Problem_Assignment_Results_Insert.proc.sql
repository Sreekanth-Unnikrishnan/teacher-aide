CREATE PROCEDURE [dbo].[Weighted_Problem_Assignment_Results_Insert]
   @course_id int,
   @assignment_seq int,
   @student_user_id int,
   @term_id int,
   @percentage_score tinyint
AS
INSERT INTO dbo.Weighted_Problem_Assignment_Results
            (course_id,
             assignment_seq,
             student_user_id,
             term_id,
             percentage_score)
     VALUES (@course_id,
             @assignment_seq,
             @student_user_id,
             @term_id,
             @percentage_score)
GO
