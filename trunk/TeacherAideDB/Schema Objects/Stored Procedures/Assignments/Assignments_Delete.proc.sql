/****** Object:  StoredProcedure [dbo].[Assignments_Delete]    Script Date: 05/01/2009 14:56:49 ******/
CREATE PROCEDURE [dbo].[Assignments_Delete]
   @assignment_id int
AS
DELETE FROM [dbo].[Assignments]
      WHERE [assignment_id] = @assignment_id
GO
