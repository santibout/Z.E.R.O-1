CREATE PROCEDURE [dbo].[People_Delete]
	@Id int 
AS
/*
DECLARE 
	EXEC [dbo].[People_Delete] 8
	SELECT * FROM [dbo].[People]
*/
BEGIN
	DELETE 
		[dbo].[People]
	
	WHERE
		Id = @Id;
END

