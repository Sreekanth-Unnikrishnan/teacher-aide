CREATE PROCEDURE [dbo].[Even_Weight_Graded_Assignments_SelectAll]
AS
  SELECT course_id,
         assignment_seq,
         scoring_method_code,
         number_of_problems
    FROM dbo.Even_Weight_Graded_Assignments
GO
