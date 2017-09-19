CREATE PROCEDURE [dbo].[People_SelectAll]
AS
/* 
EXECUTE [dbo].[People_SelectAll]
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
END
