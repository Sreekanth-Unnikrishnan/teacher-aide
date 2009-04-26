   ALTER TABLE dbo.Assignments
ADD CONSTRAINT Assignments$Key
   PRIMARY KEY (course_id, assignment_seq)