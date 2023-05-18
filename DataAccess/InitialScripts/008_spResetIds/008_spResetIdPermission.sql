CREATE PROCEDURE ResetIdPermission
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el último ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM Permissions;

    -- Reiniciar el ID al último ingresado
    DBCC CHECKIDENT (Permissions, RESEED, @lastInsertedID);
END