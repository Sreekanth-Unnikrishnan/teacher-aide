   ALTER TABLE dbo.Assignment_Score_Weights
ADD CONSTRAINT Assignment_Score_Weights$Key
   PRIMARY KEY (course_id, assignment_type_code)