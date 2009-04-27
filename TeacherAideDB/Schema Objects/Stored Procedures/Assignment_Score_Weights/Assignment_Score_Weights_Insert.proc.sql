CREATE PROCEDURE [dbo].[Assignment_Score_Weights_Insert]
   @course_id int,
   @assignment_type_code int,
   @score_weight tinyint
AS
INSERT INTO dbo.Assignment_Score_Weights
            (course_id,
             assignment_type_code,
             score_weight)
     VALUES (@course_id,
             @assignment_type_code,
             @score_weight)
GO
