   ALTER TABLE dbo.Weighted_Problems
ADD CONSTRAINT Weighted_Problems$allow_partial_credit_yes_no
         CHECK (allow_partial_credit IN ('Y', 'N'))
