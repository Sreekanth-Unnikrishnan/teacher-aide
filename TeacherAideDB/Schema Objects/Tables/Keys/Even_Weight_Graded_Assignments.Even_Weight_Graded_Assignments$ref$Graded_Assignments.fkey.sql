   ALTER TABLE dbo.Even_Weight_Graded_Exercises
ADD CONSTRAINT Even_Weight_Graded_Exercises$ref$Graded_Exercises
   FOREIGN KEY (course_id, exercise_seq)
    REFERENCES dbo.Graded_Exercises (course_id, exercise_seq)

