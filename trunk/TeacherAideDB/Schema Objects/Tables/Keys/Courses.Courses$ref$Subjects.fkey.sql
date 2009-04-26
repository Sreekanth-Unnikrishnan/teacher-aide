   ALTER TABLE dbo.Courses
ADD CONSTRAINT Courses$ref$Subjects
   FOREIGN KEY (subject_id)
    REFERENCES dbo.Subjects (subject_id)	

