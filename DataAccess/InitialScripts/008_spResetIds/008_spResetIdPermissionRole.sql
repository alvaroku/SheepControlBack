CREATE PROCEDURE ResetIdPermissionRole
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el último ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM PermissionsRoles;

    -- Reiniciar el ID al último ingresado
    DBCC CHECKIDENT (PermissionsRoles, RESEED, @lastInsertedID);
END