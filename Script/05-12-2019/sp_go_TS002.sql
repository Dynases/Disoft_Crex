USE BDDistBHF_CF
GO
/****** Object:  StoredProcedure [dbo].[sp_go_TS002]    Script Date: 6/12/2019 06:06:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[sp_go_TS002](@tipo int, @numi int=-1, @cia int=-1, @alm int=-1, @sfc int=-1, @autoriz decimal(18,0)=0,
									 @nfac int=-1, @key nvarchar(255)='', @fdel date=null, @fal date=null, @nota nvarchar(255)='',
									 @nota2 nvarchar(255)='', @est bit=0,  
									 @uact nvarchar(10)='',
									 @filtro INT=-1)
AS
BEGIN
	DECLARE @newHora nvarchar(5)
	set @newHora=CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE()))

	DECLARE @newFecha date
	set @newFecha=GETDATE()
	
	IF @tipo=-1 --ELIMINAR REGISTRO
	BEGIN
		BEGIN TRY 
			DELETE FROM TS002 WHERE yenumi=@numi
			SELECT @numi AS newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea ,bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), -1, @newFecha, @newHora, @uact)
		END CATCH
	END

	IF @tipo=1 --NUEVO REGISTRO
	BEGIN
		BEGIN TRAN INSERTAR
		BEGIN TRY 
			set @numi=IIF((select COUNT(yenumi) from TS002)=0, 0, (select MAX(yenumi) from TS002))+1
			
			INSERT INTO TS002 VALUES(@numi, @cia, @alm, @sfc, @autoriz, @nfac, @key, @fdel, @fal, @nota, @nota2, @est, 
									 @newFecha, @newHora, @uact)

			-- DEVUELVO VALORES DE CONFIRMACION
			SELECT @numi AS newNumi
			COMMIT TRAN
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 1, @newFecha, @newHora,@uact)
			ROLLBACK TRAN
		END CATCH
	END
	
	IF @tipo=2--MODIFICACION
	BEGIN
		BEGIN TRAN MODIFICACION
		BEGIN TRY

			UPDATE TS002 SET yecia=@cia, yealm =@alm, yesfc =@sfc, yeautoriz =@autoriz, yenunf =@nfac, yekey =@key,
							 yefdel =@fdel, yefal =@fal, yenota =@nota, yenota2 =@nota2, yeap =@est,
							 yefact =@newFecha, yehact =@newHora, yeuact =@uact
					 Where yenumi  = @numi

			--DEVUELVO VALORES DE CONFIRMACION
			select @numi as newNumi
			COMMIT TRAN
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 2, @newFecha, @newHora, @uact)
			ROLLBACK TRAN
		END CATCH
	END

	IF @tipo=3 --MOSTRAR TODOS
	BEGIN
		BEGIN TRY
			SELECT	a.yenumi as numi, a.yecia as cia, a.yealm  as alm, a.yesfc  as sfc, a.yeautoriz  as autoriz, a.yenunf  as nfac, 
					a.yekey  as [key], a.yefdel  as fdel, a.yefal  as fal, a.yenota  as nota, a.yenota2  as nota2, a.yeap  as est,
					a.yefact  as fact, a.yehact  as hact, a.yeuact  as uact
			FROM 
				TS002 a
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 3, @newFecha, @newHora, @uact)
		END CATCH
	END

	IF @tipo=4 --Listar compañias
	BEGIN
		BEGIN TRY
			SELECT	1 as cod, 'CIA PRINCIPAL' as [desc]
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 4, @newFecha, @newHora, @uact)
		END CATCH
	END

	IF @tipo=5 --Listar almacenes
	BEGIN
		BEGIN TRY
			SELECT	1 as cod, 'ALM PRINCIPAL' as [desc]
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum, baproc, balinea, bamensaje, batipo, bafact, bahact, bauact)
				   VALUES(ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), ERROR_MESSAGE(), 5, @newFecha, @newHora, @uact)
		END CATCH
	END

END


