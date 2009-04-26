CREATE TABLE dbo.Even_Weight_Assignment_Results
(
	course_id            INT NOT NULL,
	assignment_seq       INT NOT NULL,
	student_user_id      INT NOT NULL,
	term_id              INT NOT NULL,
	correct_answer_count INT NOT NULL
)