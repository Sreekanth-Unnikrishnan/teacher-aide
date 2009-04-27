CREATE PROCEDURE [dbo].[Assignment_Score_Weights_Update]
   @course_id int,
   @assignment_type_code int,
   @score_weight tinyint
AS
UPDATE dbo.Assignment_Score_Weights
   SET score_weight = @score_weight
 WHERE course_id = @course_id
       AND assignment_type_code = @assignment_type_code
GO
