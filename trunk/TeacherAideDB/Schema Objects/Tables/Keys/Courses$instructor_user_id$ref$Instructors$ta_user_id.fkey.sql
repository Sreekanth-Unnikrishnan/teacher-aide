   ALTER TABLE dbo.Courses
ADD CONSTRAINT Courses$instructor_user_id$ref$Instructors$ta_user_id
   FOREIGN KEY (instructor_user_id)
    REFERENCES dbo.Instructors (ta_user_id)

