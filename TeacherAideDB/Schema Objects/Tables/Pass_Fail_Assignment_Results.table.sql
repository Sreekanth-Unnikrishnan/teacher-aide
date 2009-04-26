CREATE TABLE dbo.Pass_Fail_Assignment_Results
(
	course_id       INT     NOT NULL,
	assignment_seq  INT     NOT NULL,
	student_user_id INT     NOT NULL,
	term_id         INT     NOT NULL,
	result          CHAR(1) NOT NULL
)
