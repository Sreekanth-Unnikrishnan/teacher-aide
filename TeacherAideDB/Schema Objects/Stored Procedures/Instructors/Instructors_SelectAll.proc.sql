CREATE PROCEDURE [dbo].[Instructors_SelectAll]
AS
  SELECT ta_user_id,
         instructor_id
    FROM dbo.Instructors
GO
