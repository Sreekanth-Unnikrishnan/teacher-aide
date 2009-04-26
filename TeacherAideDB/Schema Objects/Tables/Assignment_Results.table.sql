CREATE TABLE dbo.Assignment_Results
(
	course_id       INT      NOT NULL,
	assignment_seq  INT      NOT NULL,
	student_user_id INT      NOT NULL,
	term_id         INT      NOT NULL,
	completed_on    DATETIME NOT NULL
)
