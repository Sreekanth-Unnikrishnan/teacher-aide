/****** Object:  StoredProcedure [dbo].[Even_Weight_Assignment_Results_Insert]    Script Date: 05/01/2009 14:56:49 ******/
CREATE PROCEDURE [dbo].[Even_Weight_Assignment_Results_Insert]
   @assignment_id int,
   @result_seq int,
   @correct_answer_count int
AS
INSERT INTO [dbo].[Even_Weight_Assignment_Results]
            ([assignment_id],
             [result_seq],
             [correct_answer_count])
     VALUES (@assignment_id,
             @result_seq,
             @correct_answer_count)
GO
