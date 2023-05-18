CREATE PROCEDURE ResetIdController
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el último ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM Controllers;

    -- Reiniciar el ID al último ingresado
    DBCC CHECKIDENT (Controllers, RESEED, @lastInsertedID);
END