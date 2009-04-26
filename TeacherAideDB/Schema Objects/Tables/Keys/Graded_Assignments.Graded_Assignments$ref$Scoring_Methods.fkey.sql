   ALTER TABLE dbo.Graded_Assignments
ADD CONSTRAINT Graded_Assignments$ref$Scoring_Methods
   FOREIGN KEY (scoring_method_code)
    REFERENCES dbo.Scoring_Methods (scoring_method_code)	

