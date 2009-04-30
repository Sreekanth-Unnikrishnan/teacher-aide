   ALTER TABLE dbo.Pass_Fail_Graded_Exercises
ADD CONSTRAINT Pass_Fail_Graded_Exercises$valid_scoring_method_code
         CHECK (scoring_method_code = 1)
