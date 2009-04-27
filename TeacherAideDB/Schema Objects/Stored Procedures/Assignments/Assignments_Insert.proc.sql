CREATE PROCEDURE [dbo].[Assignments_Insert]
   @course_id int,
   @assignment_seq int,
   @assignment_name nvarchar (40),
   @assignment_description nvarchar,
   @assignment_type_code int
AS
INSERT INTO dbo.Assignments
            (course_id,
             assignment_seq,
             assignment_name,
             assignment_description,
             assignment_type_code)
     VALUES (@course_id,
             @assignment_seq,
             @assignment_name,
             @assignment_description,
             @assignment_type_code)
GO
