   ALTER TABLE dbo.Weighted_Problem_Results
ADD CONSTRAINT Weighted_Problem_Results$Key
   PRIMARY KEY (course_id, assignment_seq, student_user_id, term_id, problem_number)