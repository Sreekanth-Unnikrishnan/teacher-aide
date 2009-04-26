CREATE TABLE dbo.Even_Weight_Graded_Assignments
(
  course_id           INT      NOT NULL,
  assignment_seq      INT      NOT NULL,
  scoring_method_code INT      NOT NULL,
  number_of_problems  SMALLINT NOT NULL
)
