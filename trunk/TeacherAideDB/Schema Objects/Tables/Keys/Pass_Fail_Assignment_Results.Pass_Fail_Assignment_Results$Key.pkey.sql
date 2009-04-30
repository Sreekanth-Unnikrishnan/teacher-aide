   ALTER TABLE dbo.Pass_Fail_Assignment_Results
ADD CONSTRAINT Pass_Fail_Assignment_Results$Key
   PRIMARY KEY (assignment_id, result_seq)