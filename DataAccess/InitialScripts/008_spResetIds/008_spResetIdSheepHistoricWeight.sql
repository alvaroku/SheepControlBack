CREATE PROCEDURE ResetIdSheepHistoricWeight
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el último ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM SheepHistoricWeights;

    -- Reiniciar el ID al último ingresado
    DBCC CHECKIDENT (SheepHistoricWeight, RESEED, @lastInsertedID);
END