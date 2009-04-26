CREATE TABLE dbo.Weighted_Problem_Assignment_Results
(
	course_id        INT     NOT NULL,
	assignment_seq   INT     NOT NULL,
	student_user_id  INT     NOT NULL,
	term_id          INT     NOT NULL,
	percentage_score TINYINT NOT NULL
)