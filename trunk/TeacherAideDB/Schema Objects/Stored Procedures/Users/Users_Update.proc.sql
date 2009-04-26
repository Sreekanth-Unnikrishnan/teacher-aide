CREATE PROCEDURE dbo.Users_Update
  @ta_user_id      INT,
  @network_user_id VARCHAR(16),
  @last_name       NVARCHAR(40),
  @first_name      NVARCHAR(40),
  @middle_name     NVARCHAR(40),
  @nickname        NVARCHAR(40)
AS
UPDATE dbo.Users
   SET network_user_id = @network_user_id,
       last_name = @last_name,
       first_name = @first_name,
       middle_name = @middle_name,
       nickname = @nickname
 WHERE ta_user_id = @ta_user_id