CREATE TABLE [dbo].[Categories_in_Products] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [Id_Categorie] INT NOT NULL,
    [Id_Product] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

