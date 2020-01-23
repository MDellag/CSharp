#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <conio.h>



#include "ArrayEmployees.h"
#include "utn.h"


// variables globales
int auxId = 0; //Contador para verificar el ultimo Id que se asigno
int contadorDeAltas = 0; //contador para verificar cuantos usuarios se van dando de alta



 /*
  * \brief Bucle que almacena datos de un array Employee. Utiliza 2 variables globales para registrar los ultimos 
  *  dados de alta y que no comience en 0 nuevamente al salir y entrar en la funcion. 
  * \parametro empleado: array de empleados , cantEmpleado: lenght del array empleado
  * \Return void
  */
void altaEmpleado(Employee empleado[], int cantEmpleado)
{
   int i;  //Variables del For



   char ingresar = 'S'; // condicion While

   system("cls");

   while (ingresar == 'S')
   {
       for ( i = 0; i < cantEmpleado; i++)
       {
           if (empleado[i].isEmpty == 1)
           {


               printf("\nNombre del empleado: ");
               miFgets(empleado[i].name, 50);
               stringIsValid(empleado[i].name, 50);



               printf("\nApellido del empleado: ");
               miFgets(empleado[i].lastName, 50);
               stringIsValid(empleado[i].lastName, 50);

            /* ------------------------------------------ */


               empleado[i].id = auxId + 1;
               auxId = empleado[i].id;


            /* ------------------------------------------- */





               empleado[i].sector = getInt("\nSector del empleado: ");


               empleado[i].salary = getFloat("\nSalario del empleado: ");
               salaryIsValid(empleado[i].salary);



               empleado[i].isEmpty = 0;

               break;
           }//fin if

       }//fin for



       contadorDeAltas++;

      if ( contadorDeAltas < cantEmpleado){

          do{
             printf("\nDar de alta otro Empleado? S/N \n\n");
             ingresar = toupper(getch());
          }while(ingresar != 'S' && ingresar != 'N');
      }
       else{
          break;
      }//Fin if, ELse

   }//fin while


}






 /*
  * \brief Se le pasa un Id de un empleado dado ya de alta anteriormente y da 
  *  (solor si el empleado existe dado el Id) un submenu con las opciones a modificar
  * \parametro empleado: array de empleados , cantEmpleado: lenght del array empleado
  * \Return void
  */
void modificarEmpleado(Employee empleado[], int length)
{
    int i, idAux;
    int flag = 0, contador = 0;
    int opcion;
    system("cls");

    for ( i = 0; i < length; i++)
    {
        if (empleado[i].isEmpty == 0)
        {
            contador ++;
        }

    }


 if(contador > 0) {

    idAux = getInt("\nIngrese el Id del Empleado a Modificar: ");

    for ( i = 0; i < length; i++)
    {
        if (empleado[i].id == idAux)
        {
                system("cls");
                printf("\n\n\n1- Modificar Nombre ");
                printf("\n2- Modificar Apellido ");
                printf("\n3- Modificar Sector ");
                printf("\n4- Modificar Salario ");



                printf("\n\n\n0- Salir ");
                printf("\n  Opcion -->  ");
                scanf("%i", &opcion);

                flag = 1;
                switch (opcion)
                 {
                    case 1:
                           printf("\nNombre del empleado: ");
                          miFgets(empleado[i].name, 50);
                          stringIsValid(empleado[i].name, 50);
                     break;

                    case 2:
                        printf("\nApellido del empleado: ");
                        miFgets(empleado[i].lastName, 50);
                        stringIsValid(empleado[i].lastName, 50);
                     break;



                    case 3:
                        empleado[i].sector = getInt("\nSector del empleado: ");
                      break;

                   case 4:
                       empleado[i].salary = getFloat("\nSalario del empleado: ");
                     break;




                case 0: break;

              default: printf("\nLa opcion no Existe");
              continue;
            }//Fin Switch
           break;
       }

    }//Fin For()

    if(flag == 0)
    {

        printf("\nEl Empleado no existe\n\n");
    }
 } //Fin If contador..


    else
    {
        printf("\nAun no hay Empleados registrados\n\n\n");
    }



}






 /*
  * \brief Se le pasa un Id de un empleado existente dado de alta anteriormente
  *  y modifica automaticamente su IsEmpty a 1, por lo que deja el lugar libre para 
  *  dar de alta otro empleado
  * \parametro empleado: array de empleados , cantEmpleado: lenght del array empleado
  * \Return void
  */
void borrarEmpleado(Employee empleado[], int length)
{
    int i, auxId;
    int flag = 0, contador = 0;
    system("cls");
    for ( i = 0; i < length; i++)
    {
        if (empleado[i].isEmpty == 0)
        {
            contador ++;
        }

    }

    if(contador > 0){

    auxId = getInt("\nIngrese el Legajo del Empleado a eliminar: ");

    for ( i = 0; i < length; i++)
    {
        if (empleado[i].id == auxId)
        {
            flag = 1;
            empleado[i].isEmpty = 1;
        }

    }

    if(flag == 0)
    {
        printf("\nEl Empleado no existe");
    }

    }else
    {
        printf("\nAun no hay Empleados Registrados\n\n\n");
    }

}


 /*
  * \brief Ordena los empleados por apellido y en caso de que el apellido sea igual
  *  los ordena por sector (solo aplicable a empleados dados de alta) 
  * \parametro empleado: array de empleados , cantEmpleado: lenght del array empleado
  * \Return void
  */
void ordenamientoEmpleados(Employee empleado[], int length)
{
   Employee auxEmpl;
   int i, k;

   for ( i = 0; i < length - 1; i++)
   {
       for ( k = i +1 ; k < length; k++)
       {
           if ( strcmpi(empleado[i].lastName, empleado[k].lastName) == 0 )
           {
               if ( empleado[i].sector >  empleado[k].sector)
               {
                     auxEmpl = empleado[i];
                     empleado[i] = empleado[k];
                     empleado[k] = auxEmpl;
               }

           }

           else if ( strcmpi(empleado[i].lastName, empleado[k].lastName)  > 0 )
           {
                 auxEmpl = empleado[i];
                 empleado[i] = empleado[k];
                 empleado[k] = auxEmpl;
           }

       }

   }

}


 /*
  * \brief Muestra datos de un solo empleado 
  * \parametro empleado: campos de un empleado
  * \Return void
  */
void listarUno(Employee empleado)
{
    printf("\n%s\t\t%s\t%i\t\t$%.2f\t\t%i",
     empleado.lastName, empleado.name, empleado.id, empleado.salary, empleado.sector);
}



 /*
  * \brief Muestra por pantalla los campos asignados a los Empleados(solo aplicable a empleados dados de alta)
  *  (Imprime error por pantalla si no hay empleados dados de alta) 
  * \parametro empleado: array de empleados , cantEmpleado: lenght del array empleado
  * \Return void
  */
void listarTodos(Employee empleado[], int length)
{
    int i, contador = 0;
    system("cls");
    for ( i = 0; i <  length; i++)
    {
        if (empleado[i].isEmpty == 0)
        {
            contador ++;
        }

    }

    if (contador > 0)
    {
        ordenamientoEmpleados(empleado, length);
        system("cls");
        printf("\n\nApellido\tNombre\t\tID\tSalario\t\tSector");
        for ( i = 0; i < length; i++)
         {
            if (empleado[i].isEmpty == 0)
            {
                listarUno(empleado[i]);
            }

        }

        printf("\n\n\n");
    }else
    {
       printf("\nAun No hay Empleados Registrados\n\n\n");
    }


}


 /*
  * \brief Imprime por pantalla Un total de salario, promedio y Cuantos empleados superan el promedio
  *  (Todos los calculos son realizados en esta misma funcion) 
  * \parametro empleado: array de empleados , cantEmpleado: lenght del array empleado
  * \Return void
  */
void informe(Employee empleados[], int length){

    int i;
    int contadorEmpleados = 0;
    int empleadosAboveSalary = 0;
    float totalSalario = 0;
    float promedio;

    system("cls");

    printf("\n\nTotalSalarios\tPromedioSalarios\tEmpleadosPorEncimaPromedioSalarial");
    for(i = 0; i < length; i++)
    {
        if (empleados[i].isEmpty == 0)
        {
            contadorEmpleados++;
            totalSalario += empleados[i].salary;
        }

    }

    promedio = totalSalario / contadorEmpleados;

    for ( i = 0; i < length; i++)
    {
        if (empleados[i].salary > promedio && empleados[i].isEmpty == 0)
        {
            empleadosAboveSalary++ ;
        }

    }


   printf("\n$%.2f\t\t$%.2f\t\t%i", totalSalario, promedio, empleadosAboveSalary);
   printf("\n\n\n");
}



 /*
  * \brief SubMenu de informes
  * \parametro empleado: array de empleados , cantEmpleado: lenght del array empleado
  * \Return void
  */
void menuListado(Employee empleados[], int length){

     int opcion;
     int i;
     int contador = 0;
     system("cls");

     for ( i = 0; i <  length; i++)
    {
        if (empleados[i].isEmpty == 0)
        {
            contador ++;
        }

    }

    if (contador > 0)
    {

        printf("\n1- Listar empleados ");
        printf("\n2- Total, Promedio y Empleados por encima del promedio ");

        printf("\n\n0- Salir ");

        opcion = getInt("\n\n Opcion --> ");

        switch (opcion)
        {
           case 1: listarTodos(empleados, length);
              break;

           case 2: informe(empleados, length);

        default:
            break;
      }
    }
    else{
        printf("\nAun no hay Empleados dados de Alta\n\n");
    }
}



 /*
  * \brief Menu Principal para el ABM de empleados 
  * \parametro empleado: array de empleados , cantEmpleado: lenght del array empleado
  * \Return void
  */
void menuEmpleados(Employee empleado[], int length)
{
    int opcion;
    char seguir = 'S';

    while(seguir == 'S')
    {
    printf("\n1- Dar de Alta un empleado ");
    printf("\n2- Dar de Baja un empleado ");
    printf("\n3- Modificar un empleado ");
    printf("\n4- Informar ");
    printf("\n\n0- Salir ");

    printf("\n\n Opcion --> ");

    scanf("%i", &opcion);

        switch (opcion)
        {
            case 1: altaEmpleado(empleado, length); seguir = 'S'; break;

            case 2: borrarEmpleado(empleado, length); seguir = 'S'; break;

            case 3: modificarEmpleado(empleado, length); seguir = 'S'; break;

            case 4: menuListado(empleado, length); seguir = 'S'; break;



            case 0: seguir = 'N';
                break;

        }

    }

}





 /*
  * \brief Inicializador del programa 
  * \parametro empleado: array de empleados , cantEmpleado: lenght del array empleado
  * \Return void
  */
void _initEmployees(Employee list[], int length)
{
    int i; //variables de recorrido For()

    for ( i = 0; i < length; i++)
    {
        list[i].isEmpty = 1;
    }


    menuEmpleados(list, length);

}

