--Real All Employees
CREATE PROC [DBO].[usp_Get_Employee]
AS
BEGIN
	SELECT Id, FirstName, LastName, DateOfBirth, Email, Salary FROM DBO.Employees WITH (NOLOCK)
END

--Get By Id
CREATE PROC [DBO].[usp_Get_EmployeeById]
(
	@Id INT
)
AS
BEGIN
	SELECT Id, FirstName, LastName, DateOfBirth, Email, Salary FROM DBO.Employees WITH (NOLOCK)
	WHERE Id = @Id
END

--Insert
ALTER PROC [DBO].[usp_Insert_Employee]
(
	 @FirstName			VARCHAR(50) 
	,@LastName		    VARCHAR(50) 
	,@DateOfBirth	    DATE 
	,@Email			    VARCHAR(50)		
	,@Salary			FLOAT
)
AS
BEGIN
BEGIN TRY
	BEGIN TRAN
		INSERT INTO  DBO.Employees(FirstName, LastName, DateOfBirth, Email, Salary)
			   VALUES
			   (
					 @FirstName
					,@LastName
					,@DateOfBirth
					,@Email
					,@Salary
			   )
		COMMIT TRAN
END TRY
BEGIN CATCH 
	ROLLBACK TRAN
END CATCH
END

--Update
CREATE PROC [DBO].[usp_Update_Employee]
(
	 @Id			    INT 
	,@FirstName			VARCHAR(50) 
	,@LastName		    VARCHAR(50) 
	,@DateOfBirth	    DATE 
	,@Email			    VARCHAR(50)		
	,@Salary			FLOAT
)
AS
BEGIN
DECLARE @RowCount INT = 0
	BEGIN TRY 
		SET @RowCount = (SELECT COUNT(1) FROM DBO.Employees WITH (NOLOCK) WHERE Id = @Id)

		IF (@RowCount > 0)
			BEGIN
				BEGIN TRAN
					UPDATE DBO.Employees
						SET
							FirstName     =  @FirstName
							,LastName      =  @LastName
							,DateOfBirth   =  @DateOfBirth
							,Email         =  @Email
							,Salary        =  @Salary
						WHERE Id = @Id
				COMMIT TRAN
			END
		END TRY
BEGIN CATCH 
	ROLLBACK TRAN
END CATCH
END

--We made the table inside the database Employees and their respective columnns 
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[DateofBirth] [date] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Salary] [float] NOT NULL,
	CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/*
*/
