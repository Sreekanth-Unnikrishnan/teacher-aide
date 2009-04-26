   ALTER TABLE dbo.Pass_Fail_Assignment_Results
ADD CONSTRAINT Pass_Fail_Assignment_Results$result_pass_fail
         CHECK (result IN ('P', 'F'))
