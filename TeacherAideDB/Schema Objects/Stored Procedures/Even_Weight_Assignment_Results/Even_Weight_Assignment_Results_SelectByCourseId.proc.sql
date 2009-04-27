CREATE PROCEDURE [dbo].[Even_Weight_Assignment_Results_SelectByCourseId]
   @course_id int
AS
  SELECT course_id,
         assignment_seq,
         student_user_id,
         term_id,
         correct_answer_count
    FROM dbo.Even_Weight_Assignment_Results
   WHERE course_id = @course_id
GO
