CREATE PROCEDURE [dbo].[Courses_SelectAll]
AS
  SELECT course_id,
         course_name,
         subject_id,
         grade_level,
         instructor_user_id
    FROM dbo.Courses
GO
