   ALTER TABLE dbo.Assignment_Results
ADD CONSTRAINT Assignment_Results$Key
   PRIMARY KEY (assignment_id, result_seq)