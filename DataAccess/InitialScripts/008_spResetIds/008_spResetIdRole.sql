CREATE PROCEDURE ResetIdRole
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el último ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM Roles;

    -- Reiniciar el ID al último ingresado
    DBCC CHECKIDENT (Roles, RESEED, @lastInsertedID);
END