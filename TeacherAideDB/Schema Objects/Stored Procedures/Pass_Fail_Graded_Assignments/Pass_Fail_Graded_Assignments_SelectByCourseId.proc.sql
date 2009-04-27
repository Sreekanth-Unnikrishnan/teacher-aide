CREATE PROCEDURE [dbo].[Pass_Fail_Graded_Assignments_SelectByCourseId]
   @course_id int
AS
  SELECT course_id,
         assignment_seq,
         scoring_method_code
    FROM dbo.Pass_Fail_Graded_Assignments
   WHERE course_id = @course_id
GO
