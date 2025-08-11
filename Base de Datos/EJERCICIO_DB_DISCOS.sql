--select * from ESTILOS
--select * from DISCOS
--select * from TIPOSEDICION

--1. Traer todos los discos con su respectivo estilo. La consulta debe mostrar: Nombre de disco, Fecha de lanzamiento, Estilo (no el id, sino la descripción).
select D.Titulo, D.FechaLanzamiento, e.Descripcion from DISCOS D, ESTILOS E

--2. Insertar al menos dos estilos nuevos y un tipo de edición de disco. 
insert into ESTILOS(Descripcion) values ('Heavy Metal'), ('Funk')

--3. Insertar al menos dos discos nuevos cargando correctamente su información.
insert into DISCOS(Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion) values 
('Ride the Lightning', '1984-07-27', '8', 'https://acortar.link/IiCt0j', 5,1),
('The Original Disco Man', '1979-07-01','7','https://acortar.link/Ual3dO',6,1)

--4. Actualizar al menos un disco modificando la cantidad de canciones y la fecha de lanzamiento. No te olvides del Where.
update DISCOS set CantidadCanciones = 11 where id = 1

--5. Borrar un disco a elección.
delete from DISCOS where Id = 1

--6. Traer todos los estilos que estén asociados a algún disco.
select D.IdEstilo,E.Descripcion FROM DISCOS D, ESTILOS E where D.IdEstilo = E.Id

--7. Traer todos los discos con el siguiente formato: Nombre, Estilo, Edición (todo texto).
select D.Titulo as Nombre, E.Descripcion as Estilo, T.Descripcion as Edicion from DISCOS D, ESTILOS E, TIPOSEDICION T

--8. Traer todos los discos que contengan en su nombre la sílaba "ho".
select * from DISCOS where Titulo like '%ho%' 




