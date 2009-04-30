   ALTER TABLE dbo.Graded_Exercises
ADD CONSTRAINT Graded_Exercises$course_id$assignment_id$scoring_method_code$Key
        UNIQUE (course_id, exercise_seq, scoring_method_code)