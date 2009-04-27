CREATE PROCEDURE [dbo].[Pass_Fail_Graded_Assignments_Delete]
   @course_id int,
   @assignment_seq int
AS
DELETE FROM dbo.Pass_Fail_Graded_Assignments
      WHERE course_id = @course_id
            AND assignment_seq = @assignment_seq
GO
