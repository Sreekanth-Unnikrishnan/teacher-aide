CREATE TABLE dbo.Courses
(
	course_id          INT          NOT NULL IDENTITY(1,1),
	course_name        NVARCHAR(40) NOT NULL,
	subject_id         INT          NOT NULL,
	grade_level        TINYINT      NOT NULL,
	instructor_user_id INT          NOT NULL
)
