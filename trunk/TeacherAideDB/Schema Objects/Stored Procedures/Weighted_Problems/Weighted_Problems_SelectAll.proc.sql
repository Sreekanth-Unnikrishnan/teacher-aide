/****** Object:  StoredProcedure [dbo].[Weighted_Problems_SelectAll]    Script Date: 05/01/2009 14:56:50 ******/
CREATE PROCEDURE [dbo].[Weighted_Problems_SelectAll]
AS
  SELECT [course_id],
         [exercise_seq],
         [problem_number],
         [maximum_score],
         [allow_partial_credit]
    FROM [dbo].[Weighted_Problems]
GO
