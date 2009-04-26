   ALTER TABLE dbo.Course_Enrollees
ADD CONSTRAINT Course_Enrollees$ref$Terms
   FOREIGN KEY (term_id)
    REFERENCES dbo.Terms (term_id)	

