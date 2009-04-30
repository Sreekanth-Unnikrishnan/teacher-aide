   ALTER TABLE dbo.Assignments
ADD CONSTRAINT Assignments$ref$Course_Enrollees 
   FOREIGN KEY (course_id, student_user_id, term_id)
    REFERENCES dbo.Course_Enrollees (course_id, student_user_id, term_id)	

