   ALTER TABLE dbo.Assignment_Results
ADD CONSTRAINT Assignment_Results$ref$Assignments
   FOREIGN KEY (assignment_id)
    REFERENCES dbo.Assignments (assignment_id)	

