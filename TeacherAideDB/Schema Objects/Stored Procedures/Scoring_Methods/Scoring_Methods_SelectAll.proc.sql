CREATE PROCEDURE [dbo].[Scoring_Methods_SelectAll]
AS
  SELECT scoring_method_code,
         scoring_method_name
    FROM dbo.Scoring_Methods
GO
