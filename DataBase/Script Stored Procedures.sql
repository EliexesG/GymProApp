use GymPro

GO

-- ==================================================================

-- //INICIO EXPEDIENTEUSUARIO//

CREATE PROCEDURE SP_Insertar_ExpedienteUsuario
(@Fecha Date, @IdentificacionUsuario nvarchar(18), @Peso float, @Altura float,
 @IMC float, @MetabolismoBasal float)
 AS
	IF EXISTS (SELECT * FROM ExpedienteUsuario WHERE Fecha = @Fecha and IdentificacionUsuario = @IdentificacionUsuario)
	BEGIN
		UPDATE ExpedienteUsuario
		SET
		Peso = @Peso,
		Altura = @Altura,
		IMC = @IMC,
		MetabolismoBasal = @MetabolismoBasal,
		Activo = 1
		WHERE (Fecha = @Fecha) AND (IdentificacionUsuario = @IdentificacionUsuario)
	END
	ELSE
	BEGIN
		INSERT INTO ExpedienteUsuario (Fecha, IdentificacionUsuario, Peso, 
		Altura, IMC, MetabolismoBasal, Activo)
		VALUES (@Fecha, @IdentificacionUsuario, @Peso, @Altura,
		@IMC, @MetabolismoBasal, 1)
	END
 ;

 GO

 CREATE PROCEDURE SP_Modificar_ExpedienteUsuario
 (@Fecha Date, @IdentificacionUsuario nvarchar(18), @Peso float, @Altura float,
  @IMC float, @MetabolismoBasal float)
 AS
	UPDATE ExpedienteUsuario
	SET 
	Peso = @Peso,
	Altura = @Altura,
	IMC = @IMC,
	MetabolismoBasal = @MetabolismoBasal
	WHERE (Fecha = @Fecha) AND (IdentificacionUsuario = @IdentificacionUsuario)
 ;

 GO

 CREATE PROCEDURE SP_Eliminar_ExpedienteUsuario
 (@Fecha Date, @IdentificacionUsuario nvarchar(18))
 AS
	UPDATE ExpedienteUsuario
	SET
	Activo = 0
	WHERE (Fecha = @Fecha) AND (IdentificacionUsuario = @IdentificacionUsuario)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_ExpedienteUsuario_Todos
 AS
	SELECT
	Fecha, IdentificacionUsuario, Peso, Altura, IMC, MetabolismoBasal
	FROM ExpedienteUsuario
	WHERE (Activo = 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_ExpedienteUsuario_Id
 (@Fecha Date, @IdentificacionUsuario nvarchar(18))
 AS
	SELECT
	Fecha, IdentificacionUsuario, Peso, Altura, IMC, MetabolismoBasal
	FROM ExpedienteUsuario
	WHERE ((Fecha = @Fecha) AND (IdentificacionUsuario = @IdentificacionUsuario)) AND (Activo = 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_ExpedienteUsuario_IdentificacionUsuario
 (@IdentificacionUsuario nvarchar(18))
 AS
	SELECT
	Fecha, IdentificacionUsuario, Peso, Altura, IMC, MetabolismoBasal
	FROM ExpedienteUsuario
	WHERE (IdentificacionUsuario = @IdentificacionUsuario) AND (Activo = 1)
 ;

 GO
 -- //FIN EXPENDIENTEUSUARIO//

 -- ==================================================================

 -- //INICIO USUARIO//

 CREATE PROCEDURE SP_Insertar_Usuario
 (@Identificacion nvarchar(18), @Nombre nvarchar(30), @Apellido1 nvarchar(30), @Apellido2 nvarchar(30),
  @Fotografia varbinary(max), @CodigoTipoUsuario int, @Contrasenna varbinary(max), @FechaNacimiento Date,
  @Correo nvarchar(50), @Telefono nvarchar(15), @Genero int)
 AS
	INSERT INTO Usuario (Identificacion, Nombre, Apellido1, Apellido2, Fotografia,
	CodigoTipoUsuario, Contrasenna, FechaNacimiento, Correo, Telefono, Genero, Activo)
	VALUES (@Identificacion, @Nombre, @Apellido1, @Apellido2, @Fotografia, @CodigoTipoUsuario,
	@Contrasenna, @FechaNacimiento, @Correo, @Telefono, @Genero, 0)
 ;

  GO
  
  CREATE PROCEDURE SP_Modificar_Usuario
  (@Identificacion nvarchar(18), @Nombre nvarchar(30), @Apellido1 nvarchar(30), @Apellido2 nvarchar(30),
   @Fotografia varbinary(max), @CodigoTipoUsuario int, @Contrasenna varbinary(max), @FechaNacimiento Date,
   @Correo nvarchar(50), @Telefono nvarchar(15), @Genero int)
  AS
	UPDATE Usuario
	SET
	Nombre = @Nombre,
	Apellido1 = @Apellido1,
	Apellido2 = @Apellido2,
	Fotografia = @Fotografia,
	CodigoTipoUsuario = @CodigoTipoUsuario,
	Contrasenna = @Contrasenna,
	FechaNacimiento = @FechaNacimiento,
	Correo = @Correo,
	Telefono = @Telefono,
	Genero = @Genero
	WHERE (Identificacion = @Identificacion)
  ;

  GO

  CREATE PROCEDURE SP_Eliminar_Usuario
  (@Identificacion nvarchar(18))
  AS
	UPDATE Usuario
	SET
	Activo = 0
	WHERE (Identificacion = @Identificacion)
  ;

  GO

  CREATE PROCEDURE SP_Activar_Usuario
  (@Identificacion nvarchar(18))
  AS
	UPDATE Usuario
	SET
	Activo = 1
	WHERE (Identificacion = @Identificacion)
  ;

  GO

  CREATE PROCEDURE SP_Obtener_Usuario_Activo_Todos
  AS
	SELECT
	Identificacion, Nombre, Apellido1, Apellido2, Fotografia, CodigoTipoUsuario,
	Contrasenna, FechaNacimiento, Correo, Telefono, Genero
	FROM Usuario
	WHERE (Activo = 1)
  ;

  GO

  CREATE PROCEDURE SP_Obtener_Usuario_Inactivo_Todos
  AS
	SELECT
	Identificacion, Nombre, Apellido1, Apellido2, Fotografia, CodigoTipoUsuario,
	Contrasenna, FechaNacimiento, Correo, Telefono, Genero
	FROM Usuario
	WHERE (Activo = 0)
  ;

  GO

  CREATE PROCEDURE SP_Obtener_Usuario_Identificacion
  (@Identificacion nvarchar(18))
  AS
	SELECT
	Identificacion, Nombre, Apellido1, Apellido2, Fotografia, CodigoTipoUsuario,
	Contrasenna, FechaNacimiento, Correo, Telefono, Genero
	FROM Usuario
	WHERE (Identificacion = @Identificacion) AND (Activo = 1)
  ;

  GO

 -- //FIN USUARIO//

 -- ==================================================================

 -- //INICIO FACTURAENCABEZADO//

 CREATE PROCEDURE SP_Insertar_FacturaEncabezado
 (@IdentificacionUsuario nvarchar(18), @CodigoQR varbinary(max), @FechaPago Date,
  @FechaProximoPago Date, @MontoTotal float, @MontoMulta float)
 AS
	INSERT INTO FacturaEncabezado (IdentificacionUsuario, CodigoQR, FechaPago, FechaProximoPago,
	MontoTotal, MontoMulta, Activo)
	VALUES (@IdentificacionUsuario, @CodigoQR, @FechaPago, @FechaProximoPago, @MontoTotal, @MontoMulta,
	1)
 ;

 GO

 CREATE PROCEDURE SP_Modificar_FacturaEncabezado
 (@Codigo int, @IdentificacionUsuario nvarchar(18), @CodigoQR varbinary(max), @FechaPago Date,
  @FechaProximoPago Date, @MontoTotal float, @MontoMulta float)
 AS
	UPDATE FacturaEncabezado
	SET
	IdentificacionUsuario = @IdentificacionUsuario,
	CodigoQR = @CodigoQR,
	FechaPago = @FechaPago,
	FechaProximoPago = @FechaProximoPago,
	MontoTotal = @MontoTotal,
	MontoMulta = @MontoMulta
	WHERE (Codigo = @Codigo)
 ;

 GO

 CREATE PROCEDURE SP_Eliminar_FacturaEncabezado
 (@Codigo int)
 AS
	UPDATE FacturaEncabezado
	SET
	Activo = 0
	WHERE (Codigo = @Codigo)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_FacturaEncabezado_Todas
 AS
	SELECT 
	Codigo, IdentificacionUsuario, CodigoQR, FechaPago, FechaProximoPago, MontoTotal, MontoMulta
	FROM FacturaEncabezado
	WHERE (Activo = 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_FacturaEncabezado_Id
 (@Codigo int)
 AS
	SELECT
	Codigo, IdentificacionUsuario, CodigoQR, FechaPago, FechaProximoPago, MontoTotal, MontoMulta
	FROM FacturaEncabezado
	WHERE (Codigo = @Codigo) AND (Activo = 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_FacturaEncabezado_IdentificacionUsuario
 (@IdentificacionUsuario nvarchar(18))
 AS
	SELECT
	Codigo, IdentificacionUsuario, CodigoQR, FechaPago, FechaProximoPago, MontoTotal, MontoMulta
	FROM FacturaEncabezado
	WHERE (IdentificacionUsuario = @IdentificacionUsuario) AND (Activo = 1)
 ;

 GO

 -- //FIN FACTURAENCABEZADO//

 -- ==================================================================

 -- //INICIO FACTURADETALLE//

 CREATE PROCEDURE SP_Insertar_FacturaDetalle
 (@CodigoFactura int, @CodigoServicio int)
 AS
	INSERT INTO FacturaDetalle (CodigoFactura, CodigoServicio, Activo)
	VALUES (@CodigoFactura, @CodigoServicio, 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_FacturaDetalle_Todas
 AS
	SELECT
	CodigoFactura, CodigoServicio
	FROM FacturaDetalle
	WHERE (Activo = 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_FacturaDetalle_CodigoFactura
 (@CodigoFactura int)
 AS
	SELECT
	CodigoFactura, CodigoServicio
	FROM FacturaDetalle
	WHERE (CodigoFactura = @CodigoFactura) AND (Activo = 1)
 ;

 GO

 -- //FIN FACTURADETALLE//

 -- ==================================================================

 -- //INICIO SERVICIO//

 CREATE PROCEDURE SP_Obtener_Servicio_Todos
 AS
	SELECT
	Codigo, Descripcion, Monto
	FROM Servicio
 ;

 GO

 CREATE PROCEDURE SP_Obtener_Servicio_Id
 (@Codigo int)
 AS
	SELECT
	Codigo, Descripcion, Monto
	FROM Servicio
	WHERE (Codigo = @Codigo)
 ;
 
 GO

 -- //FIN SERVICIO//

 -- ==================================================================

 -- //INICIO ENTRENAMIENTO//

 CREATE PROCEDURE SP_Insertar_Entrenamiento
 (@IdentificacionCliente nvarchar(18), @IdentificacionEntrenador nvarchar(18), 
  @Nombre nvarchar(30))
 AS
	INSERT INTO Entrenamiento (IdentificacionCliente, IdentificacionEntrenador, 
	Nombre, Activo)
	VALUES (@IdentificacionCliente, @IdentificacionEntrenador, @Nombre, 1)
 ;

 GO

 CREATE PROCEDURE SP_Modificar_Entrenamiento
 (@Codigo int, @IdentificacionCliente nvarchar(18), @IdentificacionEntrenador nvarchar(18), 
  @Nombre nvarchar(30))
 AS
	UPDATE Entrenamiento
	SET
	IdentificacionCliente = @IdentificacionCliente,
	IdentificacionEntrenador = @IdentificacionEntrenador,
	Nombre = @Nombre
	WHERE (Codigo = @Codigo)
 ;

 GO

 CREATE PROCEDURE SP_Eliminar_Entrenamiento
 (@Codigo int)
 AS
	UPDATE Entrenamiento
	SET
	Activo = 0
	WHERE (Codigo = @Codigo)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_Entrenamiento_Todos
 AS
	SELECT
	Codigo, IdentificacionCliente, IdentificacionEntrenador, Nombre
	FROM Entrenamiento
	WHERE (Activo = 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_Entrenamiento_Id
 (@Codigo int)
 AS
	SELECT
	Codigo, IdentificacionCliente, IdentificacionEntrenador, Nombre
	FROM Entrenamiento
	WHERE (Codigo = @Codigo) AND (Activo = 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_Entrenamiento_IdentificacionUsuario_Cliente
 (@IdentificacionUsuario nvarchar(18))
 AS
	SELECT
	Codigo, IdentificacionCliente, IdentificacionEntrenador, Nombre
	FROM Entrenamiento
	WHERE (IdentificacionCliente = @IdentificacionUsuario) AND (Activo = 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_Entrenamiento_IdentificacionUsuario_Entrenador
 (@IdentificacionUsuario nvarchar(18))
 AS
	SELECT
	Codigo, IdentificacionCliente, IdentificacionEntrenador, Nombre
	FROM Entrenamiento
	WHERE (IdentificacionEntrenador = @IdentificacionUsuario) AND (Activo = 1)
 ;

 GO

 -- //FIN ENTRENAMIENTO

 -- ==================================================================

 -- //INICIO DIAENTRENAMIENTO

 CREATE PROCEDURE SP_Insertar_DiaEntrenamiento
 (@CodigoEntrenamiento int, @Dia int)
 AS

	IF EXISTS (SELECT * FROM DiaEntrenamiento WHERE CodigoEntrenamiento = @CodigoEntrenamiento and Dia = @Dia)
	BEGIN
		UPDATE DiaEntrenamiento
		SET
		Activo = 1
		WHERE (CodigoEntrenamiento = @CodigoEntrenamiento) AND (Dia = @Dia)
	END
	ELSE
	BEGIN
		INSERT DiaEntrenamiento (CodigoEntrenamiento, Dia, Activo)
		VALUES (@CodigoEntrenamiento, @Dia, 1)
	END
 ;

 GO

 CREATE PROCEDURE SP_Eliminar_DiaEntrenamiento
 (@CodigoEntrenamiento int, @Dia int)
 AS
	UPDATE DiaEntrenamiento
	SET
	Activo = 0
	WHERE (CodigoEntrenamiento = @CodigoEntrenamiento) AND (Dia = @Dia)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_DiaEntrenamiento_Todos
 AS
	SELECT
	CodigoEntrenamiento, Dia
	FROM DiaEntrenamiento
	WHERE (Activo = 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_DiaEntrenamiento_CodigoEntrenamiento
 (@CodigoEntrenamiento int)
 AS
	SELECT
	CodigoEntrenamiento, Dia
	FROM DiaEntrenamiento
	WHERE (CodigoEntrenamiento = @CodigoEntrenamiento) AND (Activo = 1)
 ;

 GO

 -- //FIN DIAENTRENAMIENTO

 -- ==================================================================

 -- //INICIO EJERCICIOENENTRENAMIENTO

 CREATE PROCEDURE SP_Insertar_EjercicioEnEntrenamiento
 (@CodigoEntrenamiento int, @CodigoEjercicio int, @Repeticiones int, @Peso float, 
  @Series nvarchar(30), @Tiempo int)
 AS

	IF EXISTS (SELECT * FROM EjercicioEnEntrenamiento WHERE CodigoEntrenamiento = @CodigoEntrenamiento and CodigoEjercicio = @CodigoEjercicio)
	BEGIN
		UPDATE EjercicioEnEntrenamiento
		SET
		Repeticiones = @Repeticiones,
		Peso = @Peso,
		Series = @Series,
		Tiempo = @Tiempo,
		Activo = 1
		WHERE (CodigoEntrenamiento = @CodigoEntrenamiento) AND (CodigoEjercicio = @CodigoEjercicio)
	END
	ELSE
	BEGIN
		INSERT INTO EjercicioEnEntrenamiento (CodigoEntrenamiento, CodigoEjercicio, Repeticiones, Peso,
		Series, Tiempo, Activo)
		VALUES (@CodigoEntrenamiento, @CodigoEjercicio, @Repeticiones, @Peso, @Series, @Tiempo, 1)
	END

 ;

 GO

 CREATE PROCEDURE SP_Modificar_EjercicioEnEntrenamiento
 (@CodigoEntrenamiento int, @CodigoEjercicio int, @Repeticiones int, @Peso float, 
  @Series nvarchar(30), @Tiempo int)
 AS
	UPDATE EjercicioEnEntrenamiento
	SET
	Repeticiones = @Repeticiones,
	Peso = @Peso,
	Series = @Series,
	Tiempo = @Tiempo
	WHERE (CodigoEntrenamiento = @CodigoEntrenamiento) AND (CodigoEjercicio = @CodigoEjercicio)
 ;

 GO

 CREATE PROCEDURE SP_Eliminar_EjercicioEnEntrenamiento
 (@CodigoEntrenamiento int, @CodigoEjercicio int)
 AS
	UPDATE EjercicioEnEntrenamiento
	SET
	Activo = 0
	WHERE (CodigoEntrenamiento = @CodigoEntrenamiento) AND (CodigoEjercicio = @CodigoEjercicio)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_EjercicioEnEntrenamiento_Todos
 AS
	SELECT
	CodigoEntrenamiento, CodigoEjercicio, Repeticiones, Peso, Series, Tiempo
	FROM EjercicioEnEntrenamiento
	WHERE (Activo = 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_EjercicioEnEntrenamiento_Id
 (@CodigoEntrenamiento int, @CodigoEjercicio int)
 AS
	SELECT
	CodigoEntrenamiento, CodigoEjercicio, Repeticiones, Peso, Series, Tiempo
	FROM EjercicioEnEntrenamiento
	WHERE (Activo = 1) AND ((CodigoEjercicio = @CodigoEjercicio) AND (CodigoEntrenamiento = @CodigoEntrenamiento))
 ;

 GO

 CREATE PROCEDURE SP_Obtener_EjercicioEnEntrenamiento_CodigoEntrenamientoo
 (@CodigoEntrenamiento int)
 AS
	SELECT
	CodigoEntrenamiento, CodigoEjercicio, Repeticiones, Peso, Series, Tiempo
	FROM EjercicioEnEntrenamiento
	WHERE (CodigoEntrenamiento = @CodigoEntrenamiento) AND (Activo = 1)
 ;

 GO

 -- //FIN EJERCICIOENENTRENAMIENTO

 -- ==================================================================

 -- //INICIO EJERCICIO//

 CREATE PROCEDURE SP_Insertar_Ejercicio
 (@Nombre nvarchar(30), @Descripcion nvarchar(max), @CodigoTipo int, @Multimedia varbinary(max))
 AS
	INSERT INTO Ejercicio (Nombre, Descripcion, CodigoTipo, Multimedia, Activo)
	VALUES (@Nombre, @Descripcion, @CodigoTipo, @Multimedia, 1)
 ;

 GO

 CREATE PROCEDURE SP_Modificar_Ejercicio
 (@Codigo int, @Nombre nvarchar(30), @Descripcion nvarchar(max), @CodigoTipo int, @Multimedia varbinary(max))
 AS
	UPDATE Ejercicio
	SET
	Nombre = @Nombre,
	Descripcion = @Descripcion,
	CodigoTipo = @CodigoTipo,
	Multimedia = @Multimedia
	WHERE (Codigo = @Codigo)
 ;

 GO

 CREATE PROCEDURE SP_Eliminar_Ejercicio
 (@Codigo int)
 AS
	UPDATE Ejercicio
	SET
	Activo = 0
	WHERE (Codigo = @Codigo)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_Ejercicio_Todos
 AS
	SELECT
	Codigo, Nombre, Descripcion, CodigoTipo, Multimedia
	FROM Ejercicio
	WHERE (Activo = 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_Ejercicio_Id
 (@Codigo int)
 AS
	SELECT
	Codigo, Nombre, Descripcion, CodigoTipo, Multimedia
	FROM Ejercicio
	WHERE (Codigo = @Codigo) AND (Activo = 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_Ejercicio_CodigoTipo
 (@CodigoTipo int)
 AS
	SELECT
	Codigo, Nombre, Descripcion, CodigoTipo, Multimedia
	FROM Ejercicio
	WHERE (CodigoTipo = @CodigoTipo) AND (Activo = 1)
 ;

 GO

 -- //FIN EJERCICIO//

 -- ==================================================================

 -- //INICIO TIPOEJERCICIO

 CREATE PROCEDURE SP_Insertar_TipoEjercicio
 (@Nombre nvarchar(30), @Descripcion nvarchar(max))
 AS
	INSERT INTO TipoEjercicio (Nombre, Descripcion, Activo)
	VALUES (@Nombre, @Descripcion, 1)
 ;

 GO

 CREATE PROCEDURE SP_Modificar_TipoEjercicio
 (@Codigo int, @Nombre nvarchar(30), @Descripcion nvarchar(max))
 AS
	UPDATE TipoEjercicio
	SET
	Nombre = @Nombre,
	Descripcion = @Descripcion
	WHERE (Codigo = @Codigo)
 ;

 GO

 CREATE PROCEDURE SP_Eliminar_TipoEjercicio
 (@Codigo int)
 AS
	UPDATE TipoEjercicio
	SET
	Activo = 0
	WHERE (Codigo = @Codigo)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_TipoEjercicio_Todos
 AS
	SELECT
	Codigo, Nombre, Descripcion
	FROM TipoEjercicio
	WHERE (Activo = 1)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_TipoEjercicio_Id
 (@Codigo int)
 AS
	SELECT
	Codigo, Nombre, Descripcion
	FROM TipoEjercicio
	WHERE (Codigo = @Codigo) AND (Activo = 1)
 ;

 GO

 -- //FIN TIPOEJERCICIO

 -- ==================================================================

 -- //INICIO TIPOUSUARIO

 CREATE PROCEDURE SP_Obtener_TipoUsuario_Todos
 AS
	SELECT
	Codigo, Descripcion
	FROM TipoUsuario
 ;

 GO

 CREATE PROCEDURE SP_Obtener_TipoUsuario_Id
 (@Codigo int)
 AS
	SELECT
	Codigo, Descripcion
	FROM TipoUsuario
	WHERE (Codigo = @Codigo)
 ;

 GO

 -- //FIN TIPOUSUARIO

 -- ==================================================================

 -- //INICIO CONTROLINGRESOEGRESO

 CREATE PROCEDURE SP_Insertar_Ingreso
 (@IdentificacionUsuario nvarchar(18), @Fecha date, @HoraEntrada time)
 AS
	INSERT INTO  ControlIngresoEgreso (IdentificacionUsuario, Fecha, HoraEntrada)
	VALUES (@IdentificacionUsuario, @Fecha, @HoraEntrada)
 ;

 GO

 CREATE	PROCEDURE SP_Modificar_Egreso
 (@IdentificacionUsuario nvarchar(18), @Fecha date, @HoraSalida time)
 AS
	UPDATE ControlIngresoEgreso
	SET
	HoraSalida = @HoraSalida
	WHERE (IdentificacionUsuario = @IdentificacionUsuario) AND (Fecha = @Fecha)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_ControlIngresoEgreso_Todos
 AS
	SELECT
	IdentificacionUsuario, Fecha, HoraEntrada, HoraSalida
	FROM ControlIngresoEgreso
 ;

 GO

 CREATE PROCEDURE SP_Obtener_ControlIngresoEgreso_IdentificacionUsuario
 (@IdentificacionUsuario nvarchar(18))
 AS
	SELECT
	IdentificacionUsuario, Fecha, HoraEntrada, HoraSalida
	FROM ControlIngresoEgreso
	WHERE (IdentificacionUsuario = @IdentificacionUsuario)
 ;

 GO

 CREATE PROCEDURE SP_Obtener_ControlIngresoEgreso_Ultimo_IdentificacionUsuario
 (@IdentificacionUsuario nvarchar(18))
 AS
	SELECT
	IdentificacionUsuario, Fecha, HoraEntrada, HoraSalida
	FROM ControlIngresoEgreso
	WHERE (IdentificacionUsuario = @IdentificacionUsuario) AND 
	(Fecha = (SELECT MAX(Fecha) FROM ControlIngresoEgreso))
 ;

 -- //FIN CONTROLINGRESOEGRESO

 -- ==================================================================