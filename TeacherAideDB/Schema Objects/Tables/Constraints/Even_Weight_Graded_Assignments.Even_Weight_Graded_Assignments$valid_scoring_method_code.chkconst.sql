   ALTER TABLE dbo.Even_Weight_Graded_Assignments
ADD CONSTRAINT Even_Weight_Graded_Assignments$valid_scoring_method_code
         CHECK (scoring_method_code = 2)
