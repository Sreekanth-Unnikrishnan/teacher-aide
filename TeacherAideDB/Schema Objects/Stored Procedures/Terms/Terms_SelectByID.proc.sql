CREATE PROCEDURE [dbo].[Terms_SelectByID]
   @term_id int
AS
  SELECT term_id,
         term_name,
         term_type_code,
         term_begin_date,
         term_end_date
    FROM dbo.Terms
   WHERE term_id = @term_id
GO
