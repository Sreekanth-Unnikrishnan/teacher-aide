   ALTER TABLE dbo.Scoring_Methods
ADD CONSTRAINT Scoring_Methods$valid_scoring_method_codes
         CHECK (scoring_method_code BETWEEN 1 AND 3)
