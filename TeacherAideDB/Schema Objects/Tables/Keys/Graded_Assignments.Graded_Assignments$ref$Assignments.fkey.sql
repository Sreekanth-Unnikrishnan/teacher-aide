   ALTER TABLE dbo.Graded_Assignments
ADD CONSTRAINT Graded_Assignments$ref$Assignments
   FOREIGN KEY (course_id, assignment_seq)
    REFERENCES dbo.Assignments (course_id, assignment_seq)	

