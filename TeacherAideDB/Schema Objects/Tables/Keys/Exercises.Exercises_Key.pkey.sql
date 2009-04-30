   ALTER TABLE dbo.Exercises
ADD CONSTRAINT Exercises$Key
   PRIMARY KEY (course_id, exercise_seq)