   ALTER TABLE dbo.Rubric
ADD CONSTRAINT Rubric$max_score_upper_range
         CHECK (score_upper_range <= 100)
