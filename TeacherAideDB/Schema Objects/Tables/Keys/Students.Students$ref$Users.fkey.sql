   ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [Students$ref$Users] 
   FOREIGN KEY (ta_user_id)
    REFERENCES dbo.Users (ta_user_id)	

