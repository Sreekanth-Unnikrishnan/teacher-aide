/****** Object:  StoredProcedure [dbo].[Courses_SelectAll]    Script Date: 05/01/2009 14:56:49 ******/
CREATE PROCEDURE [dbo].[Courses_SelectAll]
AS
  SELECT [course_id],
         [course_name],
         [subject_id],
         [grade_level],
         [instructor_user_id]
    FROM [dbo].[Courses]
GO
