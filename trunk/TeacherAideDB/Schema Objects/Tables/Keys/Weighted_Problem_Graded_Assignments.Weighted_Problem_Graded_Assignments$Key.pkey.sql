   ALTER TABLE dbo.Weighted_Problem_Graded_Exercises
ADD CONSTRAINT Weighted_Problem_Graded_Exercises$Key
   PRIMARY KEY (course_id, exercise_seq)