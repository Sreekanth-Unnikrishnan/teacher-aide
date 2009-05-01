/****** Object:  StoredProcedure [dbo].[Pass_Fail_Graded_Exercises_Update]    Script Date: 05/01/2009 14:56:49 ******/
CREATE PROCEDURE [dbo].[Pass_Fail_Graded_Exercises_Update]
   @course_id int,
   @exercise_seq int,
   @scoring_method_code int
AS
UPDATE [dbo].[Pass_Fail_Graded_Exercises]
   SET [scoring_method_code] = @scoring_method_code
 WHERE [course_id] = @course_id
       AND [exercise_seq] = @exercise_seq
GO
