CREATE PROCEDURE ResetIdSheepHistoricWeight
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el �ltimo ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM SheepHistoricWeights;

    -- Reiniciar el ID al �ltimo ingresado
    DBCC CHECKIDENT (SheepHistoricWeight, RESEED, @lastInsertedID);
END