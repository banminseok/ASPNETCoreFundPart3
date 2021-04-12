CREATE TABLE [dbo].[Attendees]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1000,1),		--일련번호
	[UID]	Int Not Null ,				-- 사용자 UID(fn)
	[UserID]	Nvarchar(25) Not Null ,				-- 사용자 ID(fn)
	[Name]		Nvarchar(25) Not Null,				-- 참석자 이름
	Mobile	Nvarchar(25) Null,						-- 휴대폰번호
	[CreationDate]	DateTime Default(Getdate())		-- 등록일
)
