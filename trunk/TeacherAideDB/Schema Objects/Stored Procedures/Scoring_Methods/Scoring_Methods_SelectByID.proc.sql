/****** Object:  StoredProcedure [dbo].[Scoring_Methods_SelectByID]    Script Date: 05/01/2009 14:56:49 ******/
CREATE PROCEDURE [dbo].[Scoring_Methods_SelectByID]
   @scoring_method_code int
AS
  SELECT [scoring_method_code],
         [scoring_method_name]
    FROM [dbo].[Scoring_Methods]
   WHERE [scoring_method_code] = @scoring_method_code
GO
