   ALTER TABLE dbo.Exercises
ADD CONSTRAINT Exercises$ref$Exercise_Types
   FOREIGN KEY (exercise_type_code)
    REFERENCES dbo.Exercise_Types (exercise_type_code)	

