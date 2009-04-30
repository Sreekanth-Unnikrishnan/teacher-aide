CREATE TABLE dbo.Weighted_Problems
(
  course_id            INT      NOT NULL,
  exercise_seq         INT      NOT NULL,
  problem_number       SMALLINT NOT NULL,
  maximum_score        INT      NOT NULL,
  allow_partial_credit CHAR(1)  NOT NULL
)
