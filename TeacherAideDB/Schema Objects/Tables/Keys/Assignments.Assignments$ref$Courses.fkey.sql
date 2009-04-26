   ALTER TABLE dbo.Assignments
ADD CONSTRAINT Assignments$ref$Courses
   FOREIGN KEY (course_id)
    REFERENCES dbo.Courses (course_id)	

