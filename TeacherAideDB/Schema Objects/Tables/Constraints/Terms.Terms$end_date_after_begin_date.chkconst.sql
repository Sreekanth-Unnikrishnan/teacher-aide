   ALTER TABLE dbo.Terms
ADD CONSTRAINT Terms$end_date_after_begin_date
         CHECK (term_end_date IS NULL OR term_end_date > term_begin_date)
