CREATE TABLE dbo.Assignments
(
	course_id              INT           NOT NULL,
	assignment_seq         INT           NOT NULL,
	assignment_name        NVARCHAR(40)  NOT NULL,
	assignment_description NVARCHAR(MAX) NOT NULL,
	assignment_type_code   INT           NOT NULL
)
