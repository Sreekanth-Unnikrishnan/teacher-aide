CREATE PROCEDURE [dbo].[Assignment_Score_Weights_SelectByID]
   @course_id int,
   @assignment_type_code int
AS
  SELECT course_id,
         assignment_type_code,
         score_weight
    FROM dbo.Assignment_Score_Weights
   WHERE course_id = @course_id
         AND assignment_type_code = @assignment_type_code
GO
