   ALTER TABLE dbo.Weighted_Problem_Assignment_Results
ADD CONSTRAINT Weighted_Problem_Assignment_Results$percentage_score_valid_range
         CHECK (percentage_score BETWEEN 0 AND 100)
