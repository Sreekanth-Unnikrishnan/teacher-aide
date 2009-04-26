   ALTER TABLE dbo.Assignment_Score_Weights
ADD CONSTRAINT Assignment_Score_Weights$ref$Courses
   FOREIGN KEY (course_id)
    REFERENCES dbo.Courses (course_id)	

