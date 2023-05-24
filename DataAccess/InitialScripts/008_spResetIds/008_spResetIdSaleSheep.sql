CREATE PROCEDURE ResetIdSaleSheep
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el último ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM SaleSheeps;

    -- Reiniciar el ID al último ingresado
    DBCC CHECKIDENT (SaleSheeps, RESEED, @lastInsertedID);
END