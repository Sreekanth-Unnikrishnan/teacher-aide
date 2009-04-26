   ALTER TABLE dbo.Instructors
ADD CONSTRAINT Instructors$ref$Users
   FOREIGN KEY (ta_user_id)
    REFERENCES dbo.Users (ta_user_id)	

