CREATE TABLE dbo.Weighted_Problem_Results
(
	course_id       INT      NOT NULL,
	assignment_seq  INT      NOT NULL,
	student_user_id INT      NOT NULL,
	term_id         INT      NOT NULL,
	problem_number  SMALLINT NOT NULL,
	actual_score    INT      NOT NULL
)
