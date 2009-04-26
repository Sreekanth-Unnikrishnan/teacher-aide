   ALTER TABLE dbo.Graded_Assignments
ADD CONSTRAINT Graded_Assignments$course_id$assignment_sequence$scoring_method_code$Key
        UNIQUE (course_id, assignment_seq, scoring_method_code)