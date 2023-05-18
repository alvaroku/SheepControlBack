CREATE PROCEDURE ResetIdUser
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el último ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM Users;

    -- Reiniciar el ID al último ingresado
    DBCC CHECKIDENT (Users, RESEED, @lastInsertedID);
END