   ALTER TABLE dbo.Graded_Assignments
ADD CONSTRAINT Graded_Assignments$Key
   PRIMARY KEY (course_id, assignment_seq)