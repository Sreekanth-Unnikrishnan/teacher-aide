/****** Object:  StoredProcedure [dbo].[Students_SelectAll]    Script Date: 05/01/2009 14:56:49 ******/
CREATE PROCEDURE [dbo].[Students_SelectAll]
AS
  SELECT [ta_user_id],
         [student_id]
    FROM [dbo].[Students]
GO
