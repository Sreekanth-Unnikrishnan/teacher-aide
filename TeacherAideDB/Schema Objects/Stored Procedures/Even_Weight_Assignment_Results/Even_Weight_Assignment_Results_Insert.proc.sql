CREATE PROCEDURE [dbo].[Even_Weight_Assignment_Results_Insert]
   @course_id int,
   @assignment_seq int,
   @student_user_id int,
   @term_id int,
   @correct_answer_count int
AS
INSERT INTO dbo.Even_Weight_Assignment_Results
            (course_id,
             assignment_seq,
             student_user_id,
             term_id,
             correct_answer_count)
     VALUES (@course_id,
             @assignment_seq,
             @student_user_id,
             @term_id,
             @correct_answer_count)
GO
