   ALTER TABLE dbo.Pass_Fail_Graded_Exercises
ADD CONSTRAINT Pass_Fail_Graded_Exercises$Key
   PRIMARY KEY (course_id, exercise_seq)