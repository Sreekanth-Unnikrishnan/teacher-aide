   ALTER TABLE dbo.Active_School_Days
ADD CONSTRAINT [Active_School_Days$ref$Terms] 
   FOREIGN KEY (term_id)
    REFERENCES dbo.Terms (term_id)	

