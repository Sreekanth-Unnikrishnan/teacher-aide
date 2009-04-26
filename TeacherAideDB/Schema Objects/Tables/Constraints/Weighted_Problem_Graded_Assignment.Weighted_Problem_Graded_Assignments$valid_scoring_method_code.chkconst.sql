   ALTER TABLE dbo.Weighted_Problem_Graded_Assignments
ADD CONSTRAINT Weighted_Problem_Graded_Assignments$valid_scoring_method_code
         CHECK (scoring_method_code = 3)
