   ALTER TABLE dbo.Assignments
ADD CONSTRAINT Assignments$ref$Exercises
   FOREIGN KEY (course_id, exercise_seq)
    REFERENCES dbo.Exercises (course_id, exercise_seq)	

