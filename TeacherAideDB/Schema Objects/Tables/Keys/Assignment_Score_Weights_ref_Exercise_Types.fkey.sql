   ALTER TABLE dbo.Exercise_Score_Weights
ADD CONSTRAINT Assignment_Score_Weights$ref$Exercise_Types
   FOREIGN KEY (exercise_type_code)
    REFERENCES dbo.Exercise_Types (exercise_type_code)

