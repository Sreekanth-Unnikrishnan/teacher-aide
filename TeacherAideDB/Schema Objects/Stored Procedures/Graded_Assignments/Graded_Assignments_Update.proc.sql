CREATE PROCEDURE [dbo].[Graded_Assignments_Update]
   @course_id int,
   @assignment_seq int,
   @scoring_method_code int,
   @maximum_score int
AS
UPDATE dbo.Graded_Assignments
   SET scoring_method_code = @scoring_method_code,
       maximum_score = @maximum_score
 WHERE course_id = @course_id
       AND assignment_seq = @assignment_seq
GO
