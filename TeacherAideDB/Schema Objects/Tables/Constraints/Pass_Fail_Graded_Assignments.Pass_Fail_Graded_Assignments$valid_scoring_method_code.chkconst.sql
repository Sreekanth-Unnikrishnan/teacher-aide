   ALTER TABLE dbo.Pass_Fail_Graded_Assignments
ADD CONSTRAINT Pass_Fail_Graded_Assignments$valid_scoring_method_code
         CHECK (scoring_method_code = 1)
