   ALTER TABLE dbo.Assignment_Results
ADD CONSTRAINT Assignment_Results$ref$Assignments
   FOREIGN KEY (course_id, assignment_seq)
    REFERENCES dbo.Assignments (course_id, assignment_seq)	

