   ALTER TABLE dbo.Weighted_Problem_Graded_Assignments
ADD CONSTRAINT Weighted_Problem_Graded_Assignments$ref$Graded_Assignment
   FOREIGN KEY (course_id, assignment_seq, scoring_method_code)
    REFERENCES dbo.Graded_Assignments (course_id, assignment_seq, scoring_method_code)

