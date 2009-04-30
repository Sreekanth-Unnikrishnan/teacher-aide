   ALTER TABLE dbo.Exercise_Score_Weights
ADD CONSTRAINT Assignment_Score_Weights$Key
   PRIMARY KEY (course_id, exercise_type_code)