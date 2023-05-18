CREATE PROCEDURE ResetIdVaccine
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el último ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM Vaccines;

    -- Reiniciar el ID al último ingresado
    DBCC CHECKIDENT (Vaccines, RESEED, @lastInsertedID);
END