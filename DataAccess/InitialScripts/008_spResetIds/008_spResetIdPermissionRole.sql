CREATE PROCEDURE ResetIdPermissionRole
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el �ltimo ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM PermissionsRoles;

    -- Reiniciar el ID al �ltimo ingresado
    DBCC CHECKIDENT (PermissionsRoles, RESEED, @lastInsertedID);
END