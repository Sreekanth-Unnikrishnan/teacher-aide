/****** Object:  StoredProcedure [dbo].[Students_Update]    Script Date: 05/01/2009 14:56:49 ******/
CREATE PROCEDURE [dbo].[Students_Update]
   @ta_user_id int,
   @student_id varchar (10)
AS
UPDATE [dbo].[Students]
   SET [student_id] = @student_id
 WHERE [ta_user_id] = @ta_user_id
GO
