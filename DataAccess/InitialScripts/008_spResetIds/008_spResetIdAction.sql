CREATE PROCEDURE ResetIdAction
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el último ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM Actions;

    -- Reiniciar el ID al último ingresado
    DBCC CHECKIDENT (Actions, RESEED, @lastInsertedID);
END