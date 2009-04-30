CREATE TABLE dbo.Assignments
(
  assignment_id   INT      NOT NULL IDENTITY(1,1),
  course_id       INT      NOT NULL,
  exercise_seq    INT      NOT NULL,
	student_user_id INT      NOT NULL,
	term_id         INT      NOT NULL,
	due_date        DATETIME NOT NULL
)
