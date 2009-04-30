   ALTER TABLE dbo.Graded_Exercises
ADD CONSTRAINT Graded_Exercises$ref$Scoring_Methods
   FOREIGN KEY (scoring_method_code)
    REFERENCES dbo.Scoring_Methods (scoring_method_code)	

