/****** Object:  StoredProcedure [dbo].[Exercise_Types_Delete]    Script Date: 05/01/2009 14:56:49 ******/
CREATE PROCEDURE [dbo].[Exercise_Types_Delete]
   @exercise_type_code int
AS
DELETE FROM [dbo].[Exercise_Types]
      WHERE [exercise_type_code] = @exercise_type_code
GO
