   ALTER TABLE dbo.Assignment_Results
ADD CONSTRAINT Assignment_Results$ref$Course_Enrollees
   FOREIGN KEY (course_id, student_user_id, term_id)
    REFERENCES dbo.Course_Enrollees (course_id, student_user_id, term_id)	

