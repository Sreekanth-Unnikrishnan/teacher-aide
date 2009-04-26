   ALTER TABLE dbo.Assignment_Results
ADD CONSTRAINT Assignment_Results$Key
   PRIMARY KEY (course_id, assignment_seq, student_user_id, term_id)