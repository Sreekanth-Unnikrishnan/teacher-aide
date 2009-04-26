   ALTER TABLE dbo.Even_Weight_Graded_Assignments
ADD CONSTRAINT Even_Weight_Graded_Assignments$ref$Graded_Assignments
   FOREIGN KEY (course_id, assignment_seq, scoring_method_code)
    REFERENCES dbo.Graded_Assignments (course_id, assignment_seq, scoring_method_code)

