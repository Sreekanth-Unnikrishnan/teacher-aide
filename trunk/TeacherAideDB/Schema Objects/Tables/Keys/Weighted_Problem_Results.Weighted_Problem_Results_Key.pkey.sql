   ALTER TABLE dbo.Weighted_Problem_Results
ADD CONSTRAINT Weighted_Problem_Results$Key
   PRIMARY KEY (assignment_id, result_seq, problem_number)