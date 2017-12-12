CREATE TABLE [dbo].[BugTable] (
    [ID]             BIGINT            IDENTITY (1, 1) NOT NULL,
    [ApplicationName]      NVARCHAR (MAX) NULL,
    [BugDescription]    NVARCHAR (MAX) NULL,
    [BugOccurence] NVARCHAR (MAX) NULL,
    [SourceFile] NVARCHAR(MAX) NULL, 
    [ProjectName] NVARCHAR(MAX) NULL, 
    [ClassName] NVARCHAR(MAX) NULL, 
    [MethodName] NVARCHAR(MAX) NULL, 
    [LineNumber] NVARCHAR(MAX) NULL, 
    [ErrorMessage] NVARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

