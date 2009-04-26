   ALTER TABLE dbo.Weighted_Problem_Assignment_Results
ADD CONSTRAINT Weighted_Problem_Assignment_Results$Key
   PRIMARY KEY (course_id, assignment_seq, student_user_id, term_id)