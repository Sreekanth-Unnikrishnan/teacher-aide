   ALTER TABLE dbo.Weighted_Problems
ADD CONSTRAINT Weighted_Problems$ref$Weighted_Problem_Graded_Exercises
   FOREIGN KEY (course_id, exercise_seq)
    REFERENCES dbo.Weighted_Problem_Graded_Exercises (course_id, exercise_seq)	

