CREATE PROCEDURE ResetIdVaccine
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el �ltimo ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM Vaccines;

    -- Reiniciar el ID al �ltimo ingresado
    DBCC CHECKIDENT (Vaccines, RESEED, @lastInsertedID);
END