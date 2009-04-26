   ALTER TABLE dbo.Course_Enrollees
ADD CONSTRAINT Course_Enrollees$student_user_id$ref$Students$ta_user_id
   FOREIGN KEY (student_user_id)
    REFERENCES dbo.Students (ta_user_id)
