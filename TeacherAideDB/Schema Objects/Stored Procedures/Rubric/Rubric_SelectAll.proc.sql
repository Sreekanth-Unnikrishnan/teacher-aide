CREATE PROCEDURE [dbo].[Rubric_SelectAll]
AS
  SELECT letter_grade,
         grade_description,
         score_lower_range,
         score_upper_range
    FROM dbo.Rubric
GO
