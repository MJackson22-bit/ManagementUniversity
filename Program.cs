using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CFacultad cFacultad = new CFacultad();
            CAlumno cAlumno;
            CFecha cFecha = new CFecha();
            CEmpleado cEmpleado;
            CBecadoExt cBecadoExt;
            CBecadoInt cBecadoInt;
            CProcesor cProcesor;
            CAdministrativo cAdministrativo;
            string nom, depen, carnet, inss, dir, fec, carg, res, car, ttl, dep, cat;
            long tel;
            int nc, an;
            float mnt, sal;
            char s;
            DateTime d;
            bool salir = false, vf, cont;
            int op, b;
            while (salir == false)
            {
                do
                {
                    menu();
                    op = Leer.datoInt();
                } while (op < 1 || op > 7);
                switch (op)
                {
                    case 1:
                        //insertar alumno
                        do
                        {
                            menuIngresarAlumno();
                            op = Leer.datoInt();
                        } while (op < 1 || op > 4);
                        switch (op)
                        {
                            case 1:
                                //Insertar alumno
                                cont = false;
                                Console.WriteLine("\tINGRESANDO ALUMNO...");
                                Console.Write("Nombre: ");
                                nom = Console.ReadLine();
                                Console.Write("Dirección: ");
                                dir = Console.ReadLine();
                                Console.Write("Sexo (M/F): ");
                                s = char.Parse(Console.ReadLine());
                                while (s != 'M' && s != 'F')
                                {
                                    Console.WriteLine("\tERROR - SEXO INVÁLIDO, VUELVE A INTENTARLO...");
                                    Console.Write("Sexo (M/F): ");
                                    s = char.Parse(Console.ReadLine());
                                }
                                Console.Write("Teléfono: ");
                                tel = Leer.datoLong();
                                Console.Write("Fecha de Nacimiento: ");
                                fec = cFecha.VerificarFecha(); 
                                vf = DateTime.TryParse(fec, out d);
                                while (vf == false)
                                {
                                    Console.WriteLine(fec);
                                    Console.Write("Fecha de Nacimiento: ");
                                    fec = cFecha.VerificarFecha();
                                    vf = DateTime.TryParse(fec, out d);
                                }
                                Console.Write("Carnet: ");
                                carnet = Console.ReadLine();
                                Console.Write("Carrera: ");
                                car = Console.ReadLine();
                                foreach (CFacultad cFacultad1 in cFacultad.cPersonas)
                                {

                                    cAlumno = new CAlumno();
                                    cAlumno = cFacultad1 as CAlumno;
                                    if (cAlumno != null)
                                    {
                                        if (cAlumno.Carnet == carnet)
                                        {
                                            cont = true;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                Console.WriteLine(cont);
                                if (cont == false)
                                {
                                    cAlumno = new CAlumno(nom, dir, s, tel, fec, carnet, car);
                                    cFacultad.cPersonas.Add(cAlumno);
                                }
                                else
                                {
                                    Console.WriteLine("\tYA EXISTE UN ALUMNO CON EL CARNET: {0}", carnet);
                                }
                                Console.WriteLine("__________________________________________");
                                break;
                            case 2:
                                //insertar becado externo
                                cont = false;
                                Console.WriteLine("\tINSERTANDO BECADO EXTERNO...");
                                Console.Write("Nombre: ");
                                nom = Console.ReadLine();
                                Console.Write("Dirección: ");
                                dir = Console.ReadLine();
                                Console.Write("Sexo (M/F): ");
                                s = char.Parse(Console.ReadLine());
                                while (s != 'M' && s != 'F')
                                {
                                    Console.WriteLine("\tERROR - SEXO INVÁLIDO, VUELVE A INTENTARLO...");
                                    Console.Write("Sexo (M/F): ");
                                    s = char.Parse(Console.ReadLine());
                                }
                                Console.Write("Teléfono: ");
                                tel = Leer.datoLong();
                                Console.Write("Fecha de Nacimiento: ");
                                fec = cFecha.VerificarFecha();
                                vf = DateTime.TryParse(fec, out d);
                                while (vf == false)
                                {
                                    Console.WriteLine(fec);
                                    Console.Write("Fecha de Nacimiento: ");
                                    fec = cFecha.VerificarFecha();
                                    vf = DateTime.TryParse(fec, out d);
                                }
                                Console.Write("Carnet: ");
                                carnet = Console.ReadLine();
                                Console.Write("Carrera: ");
                                car = Console.ReadLine();
                                Console.Write("Monto: ");
                                mnt = Leer.datoFloat();
                                foreach (CFacultad cFacultad1 in cFacultad.cPersonas)
                                {

                                    cBecadoExt = new CBecadoExt();
                                    cBecadoExt = cFacultad1 as CBecadoExt;
                                    if (cBecadoExt != null)
                                    {
                                        if (cBecadoExt.Carnet == carnet)
                                        {
                                            cont = true;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                if (cont == false)
                                {
                                    cBecadoExt = new CBecadoExt(nom, dir, s, tel, fec, carnet, car, mnt);
                                    cFacultad.cPersonas.Add(cBecadoExt);
                                }
                                else
                                {
                                    Console.WriteLine("\tYA EXISTE UN BECADO EXTERNO CON EL CARNET: {0}", carnet);
                                }
                               
                                Console.WriteLine("__________________________________________");
                                break;
                            case 3:
                                //insertar becado interno
                                cont = false;
                                Console.WriteLine("\tINSERTANDO BECADO INTERNO...");
                                Console.Write("Nombre: ");
                                nom = Console.ReadLine();
                                Console.Write("Dirección: ");
                                dir = Console.ReadLine();
                                Console.Write("Sexo (M/F): ");
                                s = char.Parse(Console.ReadLine());
                                while (s != 'M' && s != 'F')
                                {
                                    Console.WriteLine("\tERROR - SEXO INVÁLIDO, VUELVE A INTENTARLO...");
                                    Console.Write("Sexo (M/F): ");
                                    s = char.Parse(Console.ReadLine());
                                }
                                Console.Write("Teléfono: ");
                                tel = Leer.datoLong();
                                Console.Write("Fecha de Nacimiento: ");
                                fec = cFecha.VerificarFecha();
                                vf = DateTime.TryParse(fec, out d);
                                while (vf == false)
                                {
                                    Console.WriteLine(fec);
                                    Console.Write("Fecha de Nacimiento: ");
                                    fec = cFecha.VerificarFecha();
                                    vf = DateTime.TryParse(fec, out d);
                                }
                                Console.Write("Carnet: ");
                                carnet = Console.ReadLine();
                                Console.Write("Carrera: ");
                                car = Console.ReadLine();
                                Console.Write("Residencia: ");
                                res = Console.ReadLine();
                                Console.Write("N° Cuarto: ");
                                nc = Leer.datoInt();
                                foreach (CFacultad cFacultad1 in cFacultad.cPersonas)
                                {

                                    cBecadoInt = new CBecadoInt();
                                    cBecadoInt = cFacultad1 as CBecadoInt;
                                    if (cBecadoInt != null)
                                    {
                                        if (cBecadoInt.Carnet == carnet)
                                        {
                                            cont = true;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                if (cont == false)
                                {
                                    cBecadoInt = new CBecadoInt(nom, dir, s, tel, fec, carnet, car, res, nc);
                                    cFacultad.cPersonas.Add(cBecadoInt);
                                }
                                else
                                {
                                    Console.WriteLine("\tYA EXISTE UN BECADO INTERNO CON EL CARNET: {0}", carnet);
                                }
                               
                                Console.WriteLine("__________________________________________");
                                break;
                        }
                        break;
                    case 2:
                        //insertar empleado
                        do
                        {
                            menuInsertarEmpleado();
                            op = Leer.datoInt();
                        } while (op < 1 || op > 3);
                        switch (op)
                        {
                            case 1:
                                //insertar procesor
                                cont = false;
                                Console.WriteLine("\tINSERTANDO PROCESOR...");
                                Console.Write("Nombre: ");
                                nom = Console.ReadLine();
                                Console.Write("Dirección: ");
                                dir = Console.ReadLine();
                                Console.Write("Sexo (M/F): ");
                                s = char.Parse(Console.ReadLine());
                                while (s != 'M' && s != 'F')
                                {
                                    Console.WriteLine("\tERROR - SEXO INVÁLIDO, VUELVE A INTENTARLO...");
                                    Console.Write("Sexo (M/F): ");
                                    s = char.Parse(Console.ReadLine());
                                }
                                Console.Write("Teléfono: ");
                                tel = Leer.datoLong();
                                Console.Write("Fecha de Nacimiento: ");
                                fec = cFecha.VerificarFecha();
                                vf = DateTime.TryParse(fec, out d);
                                while (vf == false)
                                {
                                    Console.WriteLine(fec);
                                    Console.Write("Fecha de Nacimiento: ");
                                    fec = cFecha.VerificarFecha();
                                    vf = DateTime.TryParse(fec, out d);
                                }
                                Console.Write("Número INSS: ");
                                inss = Console.ReadLine();
                                Console.Write("Título: ");
                                ttl = Console.ReadLine();
                                Console.Write("Cargo: ");
                                carg = Console.ReadLine();
                                Console.Write("Salario: ");
                                sal = Leer.datoFloat();
                                Console.Write("Antigüedad: ");
                                an = Leer.datoInt();
                                Console.Write("Departamento: ");
                                dep = Console.ReadLine();
                                Console.WriteLine("\tCATEGORIA...");
                                Console.WriteLine("=> Titular");
                                Console.WriteLine("=> Asistente");
                                Console.Write("=> ");
                                cat = Console.ReadLine();
                                while (cat != "Titular" && cat != "Asistente" && cat != "asistente" && cat != "titular")
                                {
                                    Console.WriteLine("\tOPCION INVÁLIDA - VUELVE A INTENTRALO");
                                    Console.WriteLine("\tCATEGORIA...");
                                    Console.WriteLine("=> Titular");
                                    Console.WriteLine("=> Asistente");
                                    Console.Write("=> ");
                                    cat = Console.ReadLine();
                                }
                                foreach (CFacultad cFacultad1 in cFacultad.cPersonas)
                                {

                                    cProcesor = new CProcesor();
                                    cProcesor = cFacultad1 as CProcesor;
                                    if (cProcesor != null)
                                    {
                                        if (cProcesor.NumeroSeguroSocial == inss)
                                        {
                                            cont = true;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                if (cont == false)
                                {
                                    cProcesor = new CProcesor(nom, dir, s, tel, fec, inss, ttl, carg, sal, an, dep, cat);
                                    cFacultad.cPersonas.Add(cProcesor);
                                }
                                else
                                {
                                    Console.WriteLine("\tYA EXISTE UN PROCESOR CON EL INSS: {0}...", inss);
                                }
                                Console.WriteLine("__________________________________________");
                                break;
                            case 2:
                                //insertar administrativo
                                cont = false;
                                Console.WriteLine("\tINSERTANDO ADMINISTRATIVO...");
                                Console.Write("Nombre: ");
                                nom = Console.ReadLine();
                                Console.Write("Dirección: ");
                                dir = Console.ReadLine();
                                Console.Write("Sexo (M/F): ");
                                s = char.Parse(Console.ReadLine());
                                while (s != 'M' && s != 'F')
                                {
                                    Console.WriteLine("\tERROR - SEXO INVÁLIDO, VUELVE A INTENTARLO...");
                                    Console.Write("Sexo (M/F): ");
                                    s = char.Parse(Console.ReadLine());
                                }
                                Console.Write("Teléfono: ");
                                tel = Leer.datoLong();
                                Console.Write("Fecha de Nacimiento: ");
                                fec = cFecha.VerificarFecha();
                                vf = DateTime.TryParse(fec, out d);
                                while (vf == false)
                                {
                                    Console.WriteLine(fec);
                                    Console.Write("Fecha de Nacimiento: ");
                                    fec = cFecha.VerificarFecha();
                                    vf = DateTime.TryParse(fec, out d);
                                }
                                Console.Write("Número INSS: ");
                                inss = Console.ReadLine();
                                Console.Write("Título: ");
                                ttl = Console.ReadLine();
                                Console.Write("Cargo: ");
                                carg = Console.ReadLine();
                                Console.Write("Salario: ");
                                sal = Leer.datoFloat();
                                Console.Write("Antigüedad: ");
                                an = Leer.datoInt();
                                Console.Write("Dependencia: ");
                                depen = Console.ReadLine();
                                foreach (CFacultad cFacultad1 in cFacultad.cPersonas)
                                {

                                    cAdministrativo = new CAdministrativo();
                                    cAdministrativo = cFacultad1 as CAdministrativo;
                                    if (cAdministrativo != null)
                                    {
                                        if (cAdministrativo.NumeroSeguroSocial == inss)
                                        {
                                            cont = true;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                if (cont == false)
                                {
                                    cAdministrativo = new CAdministrativo(nom, dir, s, tel, fec, inss, ttl, carg, sal, an, depen);
                                    cFacultad.cPersonas.Add(cAdministrativo);
                                }
                                else
                                {
                                    Console.WriteLine("\tYA EXISTE UN ADMINISTRATIVO CON EL INSS: {0}...", inss);
                                }
                                Console.WriteLine("__________________________________________");
                                break;
                        }
                        break;
                    case 3:
                        //eliminar alumno
                        Console.WriteLine("\tELIMINADO ALUMNO...\n");
                        Console.Write("Ingrese el carnet del alumno: ");
                        carnet = Console.ReadLine();
                        b = 0;
                        cont = false;
                        foreach (CFacultad cFacultad1 in cFacultad.cPersonas)
                        {
                            cAlumno = new CAlumno();
                            cAlumno = cFacultad1 as CAlumno;
                            if (cAlumno != null)
                            {
                                if (cAlumno.Carnet == carnet)
                                {
                                    cont = true;
                                    break;
                                }
                            }
                            b++;
                        }
                        if (cont == false)
                        {
                            Console.WriteLine("\tNO SE HA ENCONTRADO EL ESTUDIANTE CON EL CARNET: {0} Ó NO HAY ALUMNOS EN LA LISTA", carnet);
                        }
                        else
                        {
                            cFacultad.cPersonas.RemoveAt(b);
                            Console.WriteLine("\t¡¡¡ALUMNO ELIMINADO CON ÉXITO!!!");
                        }
                        break;
                    case 4:
                        //eliminar emplpeado
                        Console.WriteLine("\tELIMINANDO EMPLEADO...\n");
                        Console.WriteLine("Ingrese el INSS del empleado");
                        inss = Console.ReadLine();
                        b = 0;
                        cont = false;
                        foreach (CFacultad cFacultad1 in cFacultad.cPersonas)
                        {
                            cEmpleado = new CEmpleado();
                            cEmpleado = cFacultad1 as CEmpleado;
                            if (cEmpleado != null)
                            {
                                if (cEmpleado.NumeroSeguroSocial == inss)
                                {
                                    cont = true;
                                    break;
                                }
                            }
                            else
                            {
                                continue;
                            }
                            b++;
                        }
                        if (cont == false)
                        {
                            Console.WriteLine("\tNO SE HA ENCONTRADO EL EMOLEADO CON EL INSS: {0} Ó NO HAY EMPLEADOS  EN LA LISTA", inss);
                        }
                        else
                        {
                            cFacultad.cPersonas.RemoveAt(b);
                            Console.WriteLine("\t¡¡¡EMPLEADO ELIMINADO CON ÉXITO!!!");
                        }
                        break;
                    case 5:
                        //buscar persona
                        do
                        {
                            buscarPersona();
                            op = Leer.datoInt();
                        } while (op < 1 || op > 6);
                        switch (op)
                        {
                            case 1:
                                //busacr alumno
                                Console.WriteLine("\tBUSCANDO ALUMNO...\n");
                                Console.Write("Ingrese el carnet del alumno: ");
                                carnet = Console.ReadLine();
                                cont = false;
                                foreach (CFacultad cFacultad1 in cFacultad.cPersonas)
                                {
                                    CAlumno cAlumno1 = new CAlumno();
                                    cAlumno1 = cFacultad1 as CAlumno;
                                    if (cAlumno1 != null)
                                    {
                                        if (cAlumno1.Carnet == carnet)
                                        {
                                            Console.WriteLine("\tALUMNO ENCONTRADO EXITOSAMENTE...");
                                            cont = true;
                                            Console.WriteLine(cFacultad1.ToString());
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                if (cont == false)
                                {
                                    Console.WriteLine("\tNO SE HA ENCONTRADO EL ALUMNO CON EL CARNET: {0} Ó NO HAY ALUMNOS EN LA LISTA", carnet);
                                }
                                break;
                            case 2:
                                //buscar becado externo
                                Console.WriteLine("\tBUSCANDO BECADO EXTERNO...\n");
                                Console.Write("Ingrese el carnet del becado externo: ");
                                carnet = Console.ReadLine();
                                b = 0;
                                cont = false;
                                foreach (CFacultad cFacultad1 in cFacultad.cPersonas)
                                {
                                    cBecadoExt = new CBecadoExt();
                                    cBecadoExt = cFacultad1 as CBecadoExt;
                                    if (cBecadoExt != null)
                                    {
                                        if (cBecadoExt.Carnet == carnet)
                                        {
                                            Console.WriteLine("\tBECADO EXTERNO ENCONTRADO EXITOSAMENTE...");
                                            cont = true;
                                            Console.WriteLine(cFacultad1.ToString());
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                if (cont == false)
                                {
                                    Console.WriteLine("\tNO SE HA ENCONTRADO EL BECADO EXTERNO CON EL CARNET: {0} Ó NO HAY BECADOS EXTERNOS EN LA LLISTA", carnet);
                                }
                                break;
                            case 3:
                                //buscar becado interno
                                Console.WriteLine("\tBUSCANDO BECADO INTERNO...\n");
                                Console.Write("Ingrese el carnet del becado interno: ");
                                carnet = Console.ReadLine();
                                cont = false;
                                foreach (CFacultad cFacultad1 in cFacultad.cPersonas)
                                {
                                    cBecadoInt = new CBecadoInt();
                                    cBecadoInt = cFacultad1 as CBecadoInt;
                                    if (cBecadoInt != null)
                                    {
                                        if (cBecadoInt.Carnet == carnet)
                                        {
                                            Console.WriteLine("\tBECADO INTERNO ENCONTRADO EXITOSAMENTE...");
                                            cont = true;
                                            Console.WriteLine(cFacultad1.ToString());
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                if (cont == false)
                                {
                                    Console.WriteLine("\tNO SE HA ENCONTRADO EL BECADO INTERNO CON EL CARNET: {0} Ó NO HAY BECADOS INTERNOS EN LA LISTA", carnet);
                                }
                                break;
                            case 4:
                                //buscar profesor
                                Console.WriteLine("\tBUSCANDO PROCESDOR...\n");
                                Console.WriteLine("Ingrese el INSS del procesor");
                                inss = Console.ReadLine();
                                cont = false;
                                foreach (CFacultad cFacultad1 in cFacultad.cPersonas)
                                {
                                    cProcesor = new CProcesor();
                                    cProcesor = cFacultad1 as CProcesor;
                                    if (cProcesor != null)
                                    {
                                        if (cProcesor.NumeroSeguroSocial == inss)
                                        {
                                            Console.WriteLine("\tPROCESOR ENCONTRADO EXITOSAMENTE...");
                                            Console.WriteLine(cFacultad1.ToString());
                                            cont = true;
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                if (cont == false)
                                {
                                    Console.WriteLine("\tNO SE HA ENCONTRADO EL PROCESOR CON EL INSS: {0} Ó NO HAY PROCESORES EN LA LISTA", inss);
                                }
                                break;
                            case 5:
                                //buscar administrativo
                                Console.WriteLine("\tBUSCANDO ADMINISTRATIVO...\n");
                                Console.WriteLine("Ingrese el INSS del administrativo");
                                inss = Console.ReadLine();
                                cont = false;
                                foreach (CFacultad cFacultad1 in cFacultad.cPersonas)
                                {
                                    cAdministrativo = new CAdministrativo();
                                    cAdministrativo = cFacultad1 as CAdministrativo;
                                    if (cAdministrativo != null)
                                    {
                                        if (cAdministrativo.NumeroSeguroSocial == inss)
                                        {
                                            Console.WriteLine("\tPROCESOR ENCONTRADO EXITOSAMENTE...");
                                            Console.WriteLine(cFacultad1.ToString());
                                            cont = true;
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                if (cont == false)
                                {
                                    Console.WriteLine("\tNO SE HA ENCONTRADO EL ADMINISTRATIVO CON EL INSS: {0} Ó NO HAY ADMINISTRATIVOS EN LA LISTA", inss);
                                }
                                break;
                        }
                        break;
                    case 6:
                        //borrar todo
                        Console.WriteLine("\tBORRANDO TODA LISTA...");
                        cFacultad.cPersonas.Clear();
                        Console.WriteLine("\tLISTA ELIMINADA EXITOSAMENTE...");
                        break;
                    case 7:
                        salir = true;
                        break;

                }
            }
            /**/
            Console.ReadKey();
        }
        public static void menu()
        {
            Console.WriteLine("\tMENÚ PRINCIPAL...");
            Console.WriteLine("1) Insertar alumno");
            Console.WriteLine("2) Insertar empleado");
            Console.WriteLine("3) Eliminar alumno");
            Console.WriteLine("4) Eliminar empleado");
            Console.WriteLine("5) Buscar persona");
            Console.WriteLine("6) Borrar todo");
            Console.WriteLine("7) Salir");
        }
        public static void menuIngresarAlumno()
        {
            Console.WriteLine("\tMENÚ DE ALUMNO...");
            Console.WriteLine("1) Insertar alumno");
            Console.WriteLine("2) Insertar becado externo");
            Console.WriteLine("3) Insertar becado interno");
            Console.WriteLine("4) Regresar");
        }
        public static void menuInsertarEmpleado()
        {
            Console.WriteLine("\tMENÚ DE EMPLEADOS...");
            Console.WriteLine("1) Insertar profesor");
            Console.WriteLine("2) Insertar administrativo");
            Console.WriteLine("3) Regresar");
        }
        public static void buscarPersona()
        {
            Console.WriteLine("\tMENÚ DE BUSCAR PERSONA...");
            Console.WriteLine("1) Buscar alumno");
            Console.WriteLine("2) Buscar becado externo");
            Console.WriteLine("3) Buscar becado interno");
            Console.WriteLine("4) Buscar profesor");
            Console.WriteLine("5) Buscar administrativo");
            Console.WriteLine("6) Regresar");
        }
    }
}
