CREATE PROCEDURE [dbo].[People_SelectById]
	@Id int 
AS
/*
declare 
	@_id int = 1
EXECUTE [dbo].[People_SelectById]
	@_id 
*/
BEGIN
	SELECT
		[Id],
		[FirstName],
		[MiddleInitial],
		[LastName],
		[DateOfBirth],
		[CreatedDate],
		[ModifiedDate],
		[ModifiedBy]
	FROM 
		[dbo].[People]
	WHERE
		@Id = Id;
END

