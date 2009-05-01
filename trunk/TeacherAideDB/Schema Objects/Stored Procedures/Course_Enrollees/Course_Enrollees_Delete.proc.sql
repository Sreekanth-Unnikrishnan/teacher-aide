/****** Object:  StoredProcedure [dbo].[Course_Enrollees_Delete]    Script Date: 05/01/2009 14:56:49 ******/
CREATE PROCEDURE [dbo].[Course_Enrollees_Delete]
   @course_id int,
   @student_user_id int,
   @term_id int
AS
DELETE FROM [dbo].[Course_Enrollees]
      WHERE [course_id] = @course_id
            AND [student_user_id] = @student_user_id
            AND [term_id] = @term_id
GO
