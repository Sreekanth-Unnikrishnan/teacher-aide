   ALTER TABLE dbo.Even_Weight_Assignment_Results
ADD CONSTRAINT Even_Weight_Assignment_Results$ref$Assignment_Results
   FOREIGN KEY (course_id, assignment_seq, student_user_id, term_id)
    REFERENCES dbo.Assignment_Results (course_id, assignment_seq, student_user_id, term_id)	

