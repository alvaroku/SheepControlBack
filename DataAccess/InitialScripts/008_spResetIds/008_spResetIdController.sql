CREATE PROCEDURE ResetIdController
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el �ltimo ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM Controllers;

    -- Reiniciar el ID al �ltimo ingresado
    DBCC CHECKIDENT (Controllers, RESEED, @lastInsertedID);
END