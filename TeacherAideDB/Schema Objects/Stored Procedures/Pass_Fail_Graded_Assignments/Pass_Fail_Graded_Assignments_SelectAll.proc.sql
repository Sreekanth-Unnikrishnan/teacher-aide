CREATE PROCEDURE [dbo].[Pass_Fail_Graded_Assignments_SelectAll]
AS
  SELECT course_id,
         assignment_seq,
         scoring_method_code
    FROM dbo.Pass_Fail_Graded_Assignments
GO
