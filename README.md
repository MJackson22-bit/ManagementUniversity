# Ejercicio-3
 
La clase principal es CFacultad la contiene una lista de objetos de tipo CPersona en el cual se
insertaran cada una de las personas de la institución ya sean trabajadores o estudiantes.
En la clase de CPersona se tienen los datos propios de una persona (nombre, dirección, sexo,
teléfono y fecha de nacimiento). Donde la fecha de nacimiento será un objeto de la clase CFecha, la
clase CFecha contiene los miembros día, mes y año. Esta clase se encargara de verificar que la fecha
sea válida.
Tenemos también las clases CAlumno y CEmpleado ambas derivadas de la CPersona las cuales a su
vez sirven de clases base.
Para las clases CBecadoExt y CBecadoInt su clase base será CAlumno y CEmpleado servirá de clase
base para las clases CProfesor y CAdministrativo.

CPersona   
-nombre
-direccion
-sexo
-telefono
-fecha de nacimiento

CAlumno
-Carnet
-Carrera

CBecadoExt
monto

CBecadoInt
-Numero de cuarto
Residencia

CEmpleado
-Numero inss
-titulo
-cargo
-salario
-antiguedad

CProcesor
-Departamento
-Categoria (titular, asistente)

CAdministrativo
-Dependencias
