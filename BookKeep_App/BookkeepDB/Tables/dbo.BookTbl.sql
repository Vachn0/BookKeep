CREATE TABLE [dbo].[BookTbl] (
    [BookID]    INT        NOT NULL,
    [BookName]  NCHAR (30) NULL,
    [Author]    NCHAR (15) NULL,
    [Publisher] NCHAR (15) NULL,
    [Cover]     IMAGE      NULL,
    [Available] FLOAT (53) NULL,
    CONSTRAINT [PK_BookTbl] PRIMARY KEY CLUSTERED ([BookID] ASC),
    CONSTRAINT [FK_BookTbl_BookTbl] FOREIGN KEY ([BookID]) REFERENCES [dbo].[RentTbl] ([RenterID])
);

