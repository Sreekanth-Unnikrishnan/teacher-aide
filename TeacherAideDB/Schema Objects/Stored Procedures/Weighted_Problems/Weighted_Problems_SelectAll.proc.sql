CREATE PROCEDURE [dbo].[Weighted_Problems_SelectAll]
AS
  SELECT course_id,
         assignment_seq,
         problem_number,
         maximum_score,
         allow_partial_credit
    FROM dbo.Weighted_Problems
GO
