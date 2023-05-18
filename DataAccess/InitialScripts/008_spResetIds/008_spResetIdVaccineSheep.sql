CREATE PROCEDURE ResetIdVaccineSheep
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el último ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM VaccinesSheeps;

    -- Reiniciar el ID al último ingresado
    DBCC CHECKIDENT (VaccinesSheeps, RESEED, @lastInsertedID);
END