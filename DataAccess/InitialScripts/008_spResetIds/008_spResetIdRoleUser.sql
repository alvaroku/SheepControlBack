CREATE PROCEDURE ResetIdRoleUser
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el último ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM RolesUsers;

    -- Reiniciar el ID al último ingresado
    DBCC CHECKIDENT (RolesUsers, RESEED, @lastInsertedID);
END