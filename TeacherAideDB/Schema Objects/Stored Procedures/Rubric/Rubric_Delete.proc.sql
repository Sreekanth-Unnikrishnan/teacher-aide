CREATE PROCEDURE [dbo].[Rubric_Delete]
   @letter_grade char (1)
AS
DELETE FROM dbo.Rubric
      WHERE letter_grade = @letter_grade
GO
