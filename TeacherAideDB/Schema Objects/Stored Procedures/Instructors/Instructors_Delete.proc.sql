CREATE PROCEDURE [dbo].[Instructors_Delete]
   @ta_user_id int
AS
DELETE FROM dbo.Instructors
      WHERE ta_user_id = @ta_user_id
GO
