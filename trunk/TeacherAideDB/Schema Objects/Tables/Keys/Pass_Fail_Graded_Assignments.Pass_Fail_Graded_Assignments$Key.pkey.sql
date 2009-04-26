   ALTER TABLE dbo.Pass_Fail_Graded_Assignments
ADD CONSTRAINT Pass_Fail_Graded_Assignments$Key
   PRIMARY KEY (course_id, assignment_seq)