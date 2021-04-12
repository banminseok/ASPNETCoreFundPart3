CREATE TABLE [dbo].[Devices]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1),
	ModelName	NVarchar(Max) Null,
	ModelType	NVarchar(Max) Null,
	DeviceType	NVarchar(Max) Null,
	DeviceId	NVarchar(Max) Null,
	Maker	NVarchar(Max) Null,
	UserRef	NVarchar(Max) Null,		-- 홈페이지
	UnitPrice	BigInt Null,		-- 단가

	CreatedDate DateTimeOffset Default(Getdate())
)
