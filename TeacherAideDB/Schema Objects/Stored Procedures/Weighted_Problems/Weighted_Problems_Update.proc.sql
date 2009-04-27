CREATE PROCEDURE [dbo].[Weighted_Problems_Update]
   @course_id int,
   @assignment_seq int,
   @problem_number smallint,
   @maximum_score int,
   @allow_partial_credit char (1)
AS
UPDATE dbo.Weighted_Problems
   SET maximum_score = @maximum_score,
       allow_partial_credit = @allow_partial_credit
 WHERE course_id = @course_id
       AND assignment_seq = @assignment_seq
       AND problem_number = @problem_number
GO
