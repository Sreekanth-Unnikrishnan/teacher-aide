CREATE PROCEDURE [dbo].[Assignment_Score_Weights_SelectAll]
AS
  SELECT course_id,
         assignment_type_code,
         score_weight
    FROM dbo.Assignment_Score_Weights
GO
