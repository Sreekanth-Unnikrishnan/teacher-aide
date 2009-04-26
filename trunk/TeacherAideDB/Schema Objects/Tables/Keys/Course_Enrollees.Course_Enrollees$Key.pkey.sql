   ALTER TABLE dbo.Course_Enrollees
ADD CONSTRAINT Course_Enrollees$Key
   PRIMARY KEY (course_id, student_user_id, term_id)