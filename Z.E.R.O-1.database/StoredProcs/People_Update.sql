CREATE PROCEDURE [dbo].[People_Update]
	@Id int 
	,@FirstName nvarchar(50)
	,@MiddleInitial nchar(1)
	,@LastName nvarchar(50)
	,@DateOfBirth date
	,@ModifiedBy nvarchar(128)
AS
/*
DECLARE 
	@_id int = 1
	,@_firstName nvarchar(50) = 'Samuel'
	,@_middleInitial nchar(1) = 'J'
	,@_lastName nvarchar(50) = 'Santibout'
	,@_dateOfBirth date = '1989-01-02'
	,@_createdDate DATETIME2(7) = getdate()
	,@_modifiedDate DATETIME2(7) = getdate()
	,@_modifiedBy nvarchar(128) = 'Sam'

EXECUTE [dbo].[People_Update]
	@_id 
	,@_firstName 
	,@_middleInitial 
	,@_lastName 
	,@_dateOfBirth 
	,@_modifiedBy 

	SELECT * FROM [dbo].[People] where Id = @_id;
	SELECT * FROM [dbo].[People]
*/
BEGIN
	UPDATE 
		[dbo].[People]
	SET
		FirstName = @FirstName,
		MiddleInitial = @MiddleInitial,
		LastName = @LastName,
		DateOfBirth = @DateOfBirth,
		ModifiedBy = @ModifiedBy
	WHERE
		Id = @Id;
END

