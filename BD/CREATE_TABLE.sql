
-- Creación de la tabla PA_TIPOSUPERFICIE
CREATE TABLE PA_TIPOSUPERFICIE (
    ID_TIPOSUPERFICIE SERIAL PRIMARY KEY,
    DESCRIPCION VARCHAR(100)
);

-- Creación de la tabla PA_TIPOINTERVENCION
CREATE TABLE PA_TIPOINTERVENCION (
    ID_TIPOINTERTVENCION SERIAL PRIMARY KEY,
    DESCRIPCION VARCHAR(100)
);

-- Creación de la tabla PA_LOCALIDAD
CREATE TABLE PA_LOCALIDAD (
    ID_LOCALIDAD SERIAL PRIMARY KEY,
    DESCRIPCION VARCHAR(100)
);

-- Creación de la tabla IN_CONTRATO
CREATE TABLE IN_CONTRATO (
    ID_CONTRATO SERIAL PRIMARY KEY,
    ID_TIPOSUPERFICIE INTEGER REFERENCES PA_TIPOSUPERFICIE(ID_TIPOSUPERFICIE),
    ID_TIPOINTERTVENCION INTEGER REFERENCES PA_TIPOINTERVENCION(ID_TIPOINTERTVENCION),
    ID_LOCALIDAD INTEGER REFERENCES PA_LOCALIDAD(ID_LOCALIDAD),
    DIRECCION VARCHAR(200),
    FECHA_INICIO DATE,
    FECHA_FIN DATE
);

-- Creación de la tabla PA_ITEMPAGO
CREATE TABLE PA_ITEMPAGO (
    ID_ITEMPAGO SERIAL PRIMARY KEY,
    DESCRIPCION VARCHAR(100)
);

-- Creación de la tabla IN_REGISTROVISITA
CREATE TABLE IN_REGISTROVISITA (
    ID_REGISTROVISITA SERIAL PRIMARY KEY,
    ID_CONTRATO INTEGER REFERENCES IN_CONTRATO(ID_CONTRATO),
    ID_ITEMPAGO INTEGER REFERENCES PA_ITEMPAGO(ID_ITEMPAGO),
    LARGO NUMERIC,
    ANCHO NUMERIC,
    ESPESOR NUMERIC,
    UNIDAD NUMERIC
);


--INSERT pa_tiposuperficie
INSERT INTO public.pa_tiposuperficie(descripcion)
	VALUES ('totalmente impermeables');
INSERT INTO public.pa_tiposuperficie(descripcion)
	VALUES ('parcialmente impermeables');
INSERT INTO public.pa_tiposuperficie(descripcion)
	VALUES ('parcialmente permeables');
INSERT INTO public.pa_tiposuperficie(descripcion)
	VALUES ('permeables');
INSERT INTO public.pa_tiposuperficie(descripcion)
	VALUES ('Flexible');



--INSERT pa_tipointervencion
INSERT INTO public.pa_tipointervencion(descripcion)
	VALUES ('Comercial');
INSERT INTO public.pa_tipointervencion(descripcion)
	VALUES ('Religiosa');
INSERT INTO public.pa_tipointervencion(descripcion)
	VALUES ('Recreativa');
INSERT INTO public.pa_tipointervencion(descripcion)
	VALUES ('Cultural');
INSERT INTO public.pa_tipointervencion(descripcion)
	VALUES ('De Seguridad');
INSERT INTO public.pa_tipointervencion(descripcion)
	VALUES ('Habitacional');
INSERT INTO public.pa_tipointervencion(descripcion)
	VALUES ('De Extensión Habitacional');
INSERT INTO public.pa_tipointervencion(descripcion)
	VALUES ('Laboral');
INSERT INTO public.pa_tipointervencion(descripcion)
	VALUES ('Funcional');
INSERT INTO public.pa_tipointervencion(descripcion)
	VALUES ('Complementaria');


--INSERT pa_localidad
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Usaquén');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Chapinero');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Santa Fe');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('San Cristobal');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Usme');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Tunjuelito');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Bosa');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Kennedy');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Fontibón');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Engativá');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Suba');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Barrios Unidos');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Teusaquillo');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Los Mártires');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Antonio Nariño');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Puente Aranda');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('La Candelaria');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Rafael Uribe Uribe');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Ciudad Bolívar');
INSERT INTO public.pa_localidad(descripcion)
	VALUES ('Sumapaz');



--INSERT pa_itempago
INSERT INTO public.pa_itempago(descripcion)
	VALUES ('Materiales');
INSERT INTO public.pa_itempago(descripcion)
	VALUES ('Obra de mano');
INSERT INTO public.pa_itempago(descripcion)
	VALUES ('Seguridad');
INSERT INTO public.pa_itempago(descripcion)
	VALUES ('Infraestructura');

	
--INSERT
INSERT INTO public.in_contrato(id_tiposuperficie, id_tipointertvencion,
							   id_localidad, direccion, fecha_inicio, fecha_fin)
	VALUES (5, 6, 1,'Calle 161 # 14 -24','2023-08-15','2023-08-15');
	

