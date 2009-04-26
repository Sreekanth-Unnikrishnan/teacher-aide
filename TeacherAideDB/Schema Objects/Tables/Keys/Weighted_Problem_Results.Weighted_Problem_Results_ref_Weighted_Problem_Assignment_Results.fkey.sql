   ALTER TABLE dbo.Weighted_Problem_Results
ADD CONSTRAINT Weighted_Problem_Results$ref$Weighted_Problem_Assignment_Results
   FOREIGN KEY (course_id, assignment_seq, student_user_id, term_id)
    REFERENCES dbo.Weighted_Problem_Assignment_Results (course_id, assignment_seq, student_user_id, term_id)	

