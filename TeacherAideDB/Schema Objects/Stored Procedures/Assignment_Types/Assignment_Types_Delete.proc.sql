CREATE PROCEDURE [dbo].[Assignment_Types_Delete]
   @assignment_type_code int
AS
DELETE FROM dbo.Assignment_Types
      WHERE assignment_type_code = @assignment_type_code
GO
