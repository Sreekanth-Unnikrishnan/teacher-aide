CREATE PROCEDURE [dbo].[Students_SelectByID]
   @ta_user_id int
AS
  SELECT ta_user_id,
         student_id
    FROM dbo.Students
   WHERE ta_user_id = @ta_user_id
GO
