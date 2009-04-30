   ALTER TABLE dbo.Weighted_Problem_Graded_Exercises
ADD CONSTRAINT Weighted_Problem_Graded_Exercises$ref$Graded_Assignment
   FOREIGN KEY (course_id, exercise_seq, scoring_method_code)
    REFERENCES dbo.Graded_Exercises (course_id, exercise_seq, scoring_method_code)

