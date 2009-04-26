   ALTER TABLE dbo.Course_Enrollees
ADD CONSTRAINT Course_Enrollees$ref$Courses
   FOREIGN KEY (course_id)
    REFERENCES dbo.Courses (course_id)

