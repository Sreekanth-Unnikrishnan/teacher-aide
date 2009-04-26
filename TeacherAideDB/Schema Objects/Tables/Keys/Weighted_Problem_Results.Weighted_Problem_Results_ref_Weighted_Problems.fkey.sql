   ALTER TABLE dbo.Weighted_Problem_Results
ADD CONSTRAINT Weighted_Problem_Results$ref$Weighted_Problems
   FOREIGN KEY (course_id, assignment_seq, problem_number)
    REFERENCES dbo.Weighted_Problems (course_id, assignment_seq, problem_number)	

