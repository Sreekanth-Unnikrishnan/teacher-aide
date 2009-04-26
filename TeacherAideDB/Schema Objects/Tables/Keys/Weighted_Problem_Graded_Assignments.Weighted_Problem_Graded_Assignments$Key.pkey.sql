   ALTER TABLE dbo.Weighted_Problem_Graded_Assignments
ADD CONSTRAINT Weighted_Problem_Graded_Assignments$Key
   PRIMARY KEY (course_id, assignment_seq)