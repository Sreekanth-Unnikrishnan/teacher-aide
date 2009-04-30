   ALTER TABLE dbo.Even_Weight_Assignment_Results
ADD CONSTRAINT Even_Weight_Assignment_Results$ref$Assignment_Results
   FOREIGN KEY (assignment_id, result_seq)
    REFERENCES dbo.Assignment_Results (assignment_id, result_seq)

