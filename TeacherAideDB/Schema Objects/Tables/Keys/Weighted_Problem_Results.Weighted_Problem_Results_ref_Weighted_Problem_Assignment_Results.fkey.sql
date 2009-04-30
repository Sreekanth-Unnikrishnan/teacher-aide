   ALTER TABLE dbo.Weighted_Problem_Results
ADD CONSTRAINT Weighted_Problem_Results$ref$Weighted_Problem_Assignment_Results
   FOREIGN KEY (assignment_id, result_seq)
    REFERENCES dbo.Weighted_Problem_Assignment_Results (assignment_id, result_seq)

