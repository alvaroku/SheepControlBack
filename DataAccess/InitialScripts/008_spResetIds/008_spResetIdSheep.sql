CREATE PROCEDURE ResetIdSheep
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el último ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM Sheeps;

    -- Reiniciar el ID al último ingresado
    DBCC CHECKIDENT (Sheeps, RESEED, @lastInsertedID);
END