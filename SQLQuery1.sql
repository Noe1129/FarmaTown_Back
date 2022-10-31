USE [farmatown]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ARTICULOS_COMBO_BOX]    Script Date: 31/10/2022 10:44:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_CONSULTAR_ARTICULOS_COMBO_BOX]
AS
BEGIN
	
	--SELECT idArticulo, nombre, tp.idTipoArticulo, descripcion,d.id_droga, nombreDroga, l.id_laboratorio, nombreLab,
	--a.precioUnitario
	--from articulos a join tipoArticulos tp on a.idTipoArticulo=tp.idTipoArticulo
	--JOIN laboratorios l ON a.id_laboratorio = l.id_laboratorio
	--JOIN drogas d ON a.id_droga= d.id_droga;


	SELECT idArticulo, nombre +' $' + convert(varchar(100), precioUnitario) as Articulo, tp.idTipoArticulo, descripcion,d.id_droga, nombreDroga, l.id_laboratorio, nombreLab,
	a.precioUnitario
	from articulos a join tipoArticulos tp on a.idTipoArticulo=tp.idTipoArticulo
	JOIN laboratorios l ON a.id_laboratorio = l.id_laboratorio
	JOIN drogas d ON a.id_droga= d.id_droga;


	
END	
