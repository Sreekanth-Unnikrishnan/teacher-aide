CREATE TABLE dbo.Course_Enrollees
(
	course_id        INT     NOT NULL, 
	student_user_id  INT     NOT NULL,
	term_id          INT     NOT NULL,
	final_grade      CHAR(1)     NULL
)
