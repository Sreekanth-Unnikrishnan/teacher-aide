CREATE TABLE dbo.Exercises
(
	course_id            INT           NOT NULL,
	exercise_seq         INT           NOT NULL,
	exercise_name        NVARCHAR(40)  NOT NULL,
	exercise_description NVARCHAR(MAX) NOT NULL,
	exercise_type_code   INT           NOT NULL
)
