# TaskManager

    Funcionalidades:
    1.Login
    Logica de Login usando la clase "user.cs", ademas de logica para registrar nuevos usuarios
    campos username, password y rol(almacenar en una lista)
    Validaciones basicas(campos vacios, longitud maxima 10)


    2.Cargar lista de opciones según el rol del usuario(JEFATURA o EMPLEADO)


    3.Proyectos(crear, editar y eliminar)
    campos: id(autogenerado), nombre, cantidad de tareas(maximo 5), estado, responsable(usuario que crea el proyecto)
    no se pueden eliminar proyectos con al menos 1 tarea(deben estar vacios)
    Solo disponible para jefatura


    4.Tareas(crear, editar y eliminar)
    campos: id(autogenerado), nombre, FechaVencimiento, estado, proyecto(nombre del pr.al que pertenece)
    Una tarea puede o no pertenecer a un proyecto
    disponible para jefatura y empleado


    5.Empleados(crear, editar y eliminar)
    campos: id(autogenerado), nombre, estado, tarea(por defecto: no tiene, sino mostrar nombre)
    solo visible para rol JEFATURA


    6.Asignar Tarea
    en empleado, se modifican los campos estado y tarea(nombre)
    no permitir asignar tareas si no existe ningun empleado
    no permitir asignar tareas a un empleado con tarea en curso


    7.Buscar Tarea
    8.Buscar Proyecto
    mostrar opciones para buscar por nombre o por ID.


    9.Generar Informes
    Solo se pueden generar informes de proyectos
    mostrar responsable, porcentaje de avance(segun tareas finalizadas), 
    Lista de tareas: nombre y empleado a cargo, fecha de vencimiento.Ordenar las tareas segun la fecha vencimiento mas proxima