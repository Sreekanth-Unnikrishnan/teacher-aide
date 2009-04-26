   ALTER TABLE dbo.Pass_Fail_Assignment_Results
ADD CONSTRAINT Pass_Fail_Assignment_Results$Key
   PRIMARY KEY (course_id, assignment_seq, student_user_id, term_id)