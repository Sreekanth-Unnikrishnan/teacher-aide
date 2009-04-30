   ALTER TABLE dbo.Graded_Exercises
ADD CONSTRAINT Graded_Exercises$Key
   PRIMARY KEY (course_id, exercise_seq)