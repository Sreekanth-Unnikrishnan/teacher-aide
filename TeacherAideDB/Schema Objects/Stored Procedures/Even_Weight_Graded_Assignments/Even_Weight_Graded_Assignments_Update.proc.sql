CREATE PROCEDURE [dbo].[Even_Weight_Graded_Assignments_Update]
   @course_id int,
   @assignment_seq int,
   @scoring_method_code int,
   @number_of_problems smallint
AS
UPDATE dbo.Even_Weight_Graded_Assignments
   SET scoring_method_code = @scoring_method_code,
       number_of_problems = @number_of_problems
 WHERE course_id = @course_id
       AND assignment_seq = @assignment_seq
GO
