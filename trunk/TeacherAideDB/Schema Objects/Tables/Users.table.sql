CREATE TABLE dbo.Users
(
  ta_user_id      INT          NOT NULL IDENTITY(1,1),
  network_user_id VARCHAR(16)      NULL,
  last_name       NVARCHAR(40) NOT NULL,
  first_name      NVARCHAR(40) NOT NULL,
  middle_name     NVARCHAR(40) NOT NULL,
  nickname        NVARCHAR(40) NOT NULL
)
