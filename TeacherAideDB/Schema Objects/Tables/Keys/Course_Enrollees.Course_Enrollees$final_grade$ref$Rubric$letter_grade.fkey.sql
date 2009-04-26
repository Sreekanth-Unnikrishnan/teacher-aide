   ALTER TABLE dbo.Course_Enrollees
ADD CONSTRAINT Course_Enrollees$final_grade$ref$Rubric$letter_grade
   FOREIGN KEY (final_grade)
    REFERENCES dbo.Rubric (letter_grade)	

