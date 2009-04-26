CREATE TABLE dbo.Terms
(
	term_id         INT          NOT NULL IDENTITY(1,1),
	term_name       NVARCHAR(40) NOT NULL,
	term_type_code  INT          NOT NULL,
	term_begin_date DATETIME     NOT NULL,
	term_end_date   DATETIME         NULL
)
