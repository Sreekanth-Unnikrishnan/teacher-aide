CREATE PROCEDURE dbo.Users_SelectByKey
  @ta_user_id INT
AS
SELECT ta_user_id,
       network_user_id,
       last_name,
       first_name,
       middle_name,
       nickname
  FROM dbo.Users
 WHERE ta_user_id = @ta_user_id