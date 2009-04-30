   ALTER TABLE dbo.Even_Weight_Graded_Exercises
ADD CONSTRAINT Even_Weight_Graded_Exercises$valid_scoring_method_code
         CHECK (scoring_method_code = 2)
