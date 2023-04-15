CREATE TABLE [dbo].[RentTbl] (
    [RenterID]    INT  NOT NULL,
    [RentDate]    DATE NULL,
    [RentingDays] INT  NULL,
    [ReturnDate]  DATE NULL,
    CONSTRAINT [PK_RentTbl] PRIMARY KEY CLUSTERED ([RenterID] ASC)
);

