   ALTER TABLE dbo.Pass_Fail_Graded_Exercises
ADD CONSTRAINT Pass_Fail_Graded_Exercises$ref$Graded_Exercises
   FOREIGN KEY (course_id, exercise_seq)
    REFERENCES dbo.Graded_Exercises (course_id, exercise_seq)

