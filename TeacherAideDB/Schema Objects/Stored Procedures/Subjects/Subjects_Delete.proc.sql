CREATE PROCEDURE [dbo].[Subjects_Delete]
   @subject_id int
AS
DELETE FROM dbo.Subjects
      WHERE subject_id = @subject_id
GO
