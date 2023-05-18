CREATE PROCEDURE ResetIdRole
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el �ltimo ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM Roles;

    -- Reiniciar el ID al �ltimo ingresado
    DBCC CHECKIDENT (Roles, RESEED, @lastInsertedID);
END