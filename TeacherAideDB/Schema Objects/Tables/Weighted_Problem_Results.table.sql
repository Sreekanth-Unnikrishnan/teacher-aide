CREATE TABLE dbo.Weighted_Problem_Results
(
	assignment_id  INT      NOT NULL,
	result_seq     INT      NOT NULL,
  course_id      INT      NOT NULL,
  exercise_seq   INT      NOT NULL,
  problem_number SMALLINT NOT NULL,
	actual_score   INT      NOT NULL
)
