   ALTER TABLE dbo.Assignment_Score_Weights
ADD CONSTRAINT Assignment_Score_Weights$ref$Assignment_Types
   FOREIGN KEY (assignment_type_code)
    REFERENCES dbo.Assignment_Types (assignment_type_code)	

