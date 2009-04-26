   ALTER TABLE dbo.Rubric
ADD CONSTRAINT Rubric$score_lower_range_less_than_score_upper_range
         CHECK ((score_upper_range IS NOT NULL
                 AND score_lower_range IS NOT NULL
                 AND score_upper_range > score_lower_range)
               OR (score_upper_range IS NULL
                  AND score_lower_range IS NULL))
