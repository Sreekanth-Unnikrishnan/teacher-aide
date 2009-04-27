CREATE PROCEDURE [dbo].[Scoring_Methods_SelectByID]
   @scoring_method_code int
AS
  SELECT scoring_method_code,
         scoring_method_name
    FROM dbo.Scoring_Methods
   WHERE scoring_method_code = @scoring_method_code
GO
