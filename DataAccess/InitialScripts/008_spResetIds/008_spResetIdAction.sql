CREATE PROCEDURE ResetIdAction
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el �ltimo ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM Actions;

    -- Reiniciar el ID al �ltimo ingresado
    DBCC CHECKIDENT (Actions, RESEED, @lastInsertedID);
END