CREATE PROCEDURE ResetIdRoleUser
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el �ltimo ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM RolesUsers;

    -- Reiniciar el ID al �ltimo ingresado
    DBCC CHECKIDENT (RolesUsers, RESEED, @lastInsertedID);
END