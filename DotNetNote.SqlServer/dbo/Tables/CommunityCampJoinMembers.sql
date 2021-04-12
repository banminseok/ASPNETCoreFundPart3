CREATE TABLE [dbo].[CommunityCampJoinMembers]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1),		--일련번호
	ComunityName	Nvarchar(25) Not Null,
	[Name]		Nvarchar(25) Not Null,				-- 참석자 이름
	Mobile	Nvarchar(25) Not Null,						-- 휴대폰번호
	Email	Nvarchar(25) Not Null,
	Size	Nvarchar(25) Not Null Default('L'),				-- 티셔츠 기념품 사이즈
	CreationDate	DateTime Dafault(Getdate())		-- 등록일
)
