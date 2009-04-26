   ALTER TABLE dbo.Assignments
ADD CONSTRAINT Assignments$ref$Assignment_Types
   FOREIGN KEY (assignment_type_code)
    REFERENCES dbo.Assignment_Types (assignment_type_code)	

