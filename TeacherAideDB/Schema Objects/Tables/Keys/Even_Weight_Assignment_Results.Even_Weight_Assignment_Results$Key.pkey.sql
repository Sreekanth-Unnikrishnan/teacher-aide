   ALTER TABLE dbo.Even_Weight_Assignment_Results
ADD CONSTRAINT Even_Weight_Assignment_Results$Key
   PRIMARY KEY (course_id, assignment_seq, student_user_id, term_id)