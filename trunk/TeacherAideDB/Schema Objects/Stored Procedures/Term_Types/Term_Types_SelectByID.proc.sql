/****** Object:  StoredProcedure [dbo].[Term_Types_SelectByID]    Script Date: 05/01/2009 14:56:49 ******/
CREATE PROCEDURE [dbo].[Term_Types_SelectByID]
   @term_type_code int
AS
  SELECT [term_type_code],
         [term_type_name]
    FROM [dbo].[Term_Types]
   WHERE [term_type_code] = @term_type_code
GO
