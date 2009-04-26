   ALTER TABLE dbo.Weighted_Problem_Assignment_Results
ADD CONSTRAINT Weighted_Problem_Assignment_Results$ref$Assignment_Results
   FOREIGN KEY (course_id, assignment_seq, student_user_id, term_id)
    REFERENCES dbo.Assignment_Results (course_id, assignment_seq, student_user_id, term_id)	

