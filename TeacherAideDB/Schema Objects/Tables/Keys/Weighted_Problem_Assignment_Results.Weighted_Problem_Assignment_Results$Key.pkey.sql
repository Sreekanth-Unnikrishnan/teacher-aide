   ALTER TABLE dbo.Weighted_Problem_Assignment_Results
ADD CONSTRAINT Weighted_Problem_Assignment_Results$Key
   PRIMARY KEY (assignment_id, result_seq)