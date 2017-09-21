CREATE PROCEDURE [dbo].[People_Insert]
	@Id int output
	,@FirstName nvarchar(50)
	,@MiddleInitial nchar(1)
	,@LastName nvarchar(50)
	,@DateOfBirth date
	,@ModifiedBy nvarchar(128)
AS
/*
DECLARE 
	@_id int  
	,@_firstName nvarchar(50) = 'Patty'
	,@_middleInitial nchar(1) 
	,@_lastName nvarchar(50) = 'Pierson'
	,@_dateOfBirth date = '1989-01-02'
	,@_createdDate DATETIME2(7) = getdate()
	,@_modifiedDate DATETIME2(7) = getdate()
	,@_modifiedBy nvarchar(128) = 'Sam'

EXECUTE [dbo].[People_Insert]
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
	INSERT INTO
		[dbo].[People]
			(
			FirstName,
			MiddleInitial,
			LastName,
			DateOfBirth,
			ModifiedBy
			)
	VALUES
		(
		@FirstName,
		@MiddleInitial,
		@LastName,
		@DateOfBirth,
		@ModifiedBy
		)
	Set
		@Id = SCOPE_IDENTITY();
END

