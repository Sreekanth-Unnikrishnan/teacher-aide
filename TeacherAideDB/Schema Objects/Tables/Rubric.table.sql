CREATE TABLE dbo.Rubric
(
	letter_grade      CHAR(1)      NOT NULL, 
	grade_description NVARCHAR(40) NOT NULL,
	score_lower_range TINYINT          NULL,
	score_upper_range TINYINT          NULL
)
