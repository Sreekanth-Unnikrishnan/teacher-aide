   ALTER TABLE dbo.Weighted_Problem_Graded_Exercises
ADD CONSTRAINT Weighted_Problem_Graded_Exercises$valid_scoring_method_code
         CHECK (scoring_method_code = 3)
