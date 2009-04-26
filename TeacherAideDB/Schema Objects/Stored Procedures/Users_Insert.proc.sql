CREATE PROCEDURE dbo.Users_Insert
  @network_user_id VARCHAR(16),
  @last_name       NVARCHAR(40),
  @first_name      NVARCHAR(40),
  @middle_name     NVARCHAR(40),
  @nickname        NVARCHAR(40),
  @ta_user_id      INT OUTPUT
AS

INSERT INTO dbo.Users
            (network_user_id,
             last_name,
             first_name,
             middle_name,
             nickname)
     VALUES (@network_user_id,
             @last_name,
             @first_name,
             @middle_name,
             @nickname)

SELECT @ta_user_id = SCOPE_IDENTITY()
