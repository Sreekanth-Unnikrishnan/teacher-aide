   ALTER TABLE dbo.Weighted_Problems
ADD CONSTRAINT Weighted_Problems$Key
   PRIMARY KEY (course_id, exercise_seq, problem_number)