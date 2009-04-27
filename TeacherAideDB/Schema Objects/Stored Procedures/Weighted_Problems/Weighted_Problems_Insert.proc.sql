CREATE PROCEDURE [dbo].[Weighted_Problems_Insert]
   @course_id int,
   @assignment_seq int,
   @problem_number smallint,
   @maximum_score int,
   @allow_partial_credit char (1)
AS
INSERT INTO dbo.Weighted_Problems
            (course_id,
             assignment_seq,
             problem_number,
             maximum_score,
             allow_partial_credit)
     VALUES (@course_id,
             @assignment_seq,
             @problem_number,
             @maximum_score,
             @allow_partial_credit)
GO
