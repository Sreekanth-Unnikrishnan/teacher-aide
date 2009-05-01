/****** Object:  StoredProcedure [dbo].[Assignment_Results_SelectByAssignmentId]    Script Date: 05/01/2009 14:56:49 ******/
CREATE PROCEDURE [dbo].[Assignment_Results_SelectByAssignmentId]
   @assignment_id int
AS
  SELECT [assignment_id],
         [result_seq],
         [completed_on]
    FROM [dbo].[Assignment_Results]
   WHERE [assignment_id] = @assignment_id
GO
