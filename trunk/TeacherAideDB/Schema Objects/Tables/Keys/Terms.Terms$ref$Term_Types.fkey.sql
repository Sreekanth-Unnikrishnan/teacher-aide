   ALTER TABLE dbo.Terms
ADD CONSTRAINT Terms$ref$Term_Types
   FOREIGN KEY (term_type_code)
    REFERENCES dbo.Term_Types (term_type_code)	

