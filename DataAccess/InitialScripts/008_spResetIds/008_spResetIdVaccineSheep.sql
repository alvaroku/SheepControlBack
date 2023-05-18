CREATE PROCEDURE ResetIdVaccineSheep
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @lastInsertedID INT;

    -- Obtener el �ltimo ID insertado
    SELECT @lastInsertedID = MAX(Id) FROM VaccinesSheeps;

    -- Reiniciar el ID al �ltimo ingresado
    DBCC CHECKIDENT (VaccinesSheeps, RESEED, @lastInsertedID);
END