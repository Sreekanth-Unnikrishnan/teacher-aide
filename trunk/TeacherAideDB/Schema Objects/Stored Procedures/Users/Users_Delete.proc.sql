CREATE PROCEDURE dbo.Users_Delete
  @ta_user_id INT
AS
DELETE
  FROM dbo.Users
 WHERE ta_user_id = @ta_user_id