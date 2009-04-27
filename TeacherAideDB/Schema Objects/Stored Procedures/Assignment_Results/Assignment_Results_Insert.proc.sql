CREATE PROCEDURE [dbo].[Assignment_Results_Insert]
   @course_id int,
   @assignment_seq int,
   @student_user_id int,
   @term_id int,
   @completed_on datetime
AS
INSERT INTO dbo.Assignment_Results
            (course_id,
             assignment_seq,
             student_user_id,
             term_id,
             completed_on)
     VALUES (@course_id,
             @assignment_seq,
             @student_user_id,
             @term_id,
             @completed_on)
GO
