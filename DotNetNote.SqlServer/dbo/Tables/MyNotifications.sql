CREATE TABLE [dbo].[MyNotifications](
	[Id] [int] IDENTITY(1,1) Primary key NOT NULL,
	[Timestamp] [datetimeoffset](7) DEFAULT (sysdatetimeoffset()) NOT NULL,
	[Message] [nvarchar](max) NULL,
	[Type] [nvarchar](50) NULL,
	[Url] [nvarchar](max) NULL,
	------------------------------------------------------sysdatetimeoffset DateTimeOffSet(7)에 대한 기본값  전세계 시간--
	UserId Int Null,
	IsComplete Bit Default(0) Not Null
)
