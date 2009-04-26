   ALTER TABLE dbo.Weighted_Problems
ADD CONSTRAINT Weighted_Problems$ref$Weighted_Problem_Graded_Assignments
   FOREIGN KEY (course_id, assignment_seq)
    REFERENCES dbo.Weighted_Problem_Graded_Assignments (course_id, assignment_seq)	

