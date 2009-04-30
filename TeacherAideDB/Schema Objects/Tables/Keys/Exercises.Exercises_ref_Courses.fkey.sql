   ALTER TABLE dbo.Exercises
ADD CONSTRAINT Exercises$ref$Courses
   FOREIGN KEY (course_id)
    REFERENCES dbo.Courses (course_id)	

