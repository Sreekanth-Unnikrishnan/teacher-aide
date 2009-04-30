   ALTER TABLE dbo.Graded_Exercises
ADD CONSTRAINT Graded_Exercises$ref$Assignments
   FOREIGN KEY (course_id, exercise_seq)
    REFERENCES dbo.Exercises (course_id, exercise_seq)

