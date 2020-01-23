/******************************************************************************
* Programa: Empresa. Trabajo Practico N_2
*
* Objetivo:
*          Una empresa requiere un sistema para administrar su nomina de empleados:

*      1. ALTAS: Se debe permitir ingresar un empleado calculando automáticamente el número
*          de Id. El resto de los campos se le pedirá al usuario.

*      2. MODIFICAR: Se ingresará el Número de Id, permitiendo modificar: o Nombre o Apellido
*            o Salario o Sector

*      3. BAJA: Se ingresará el Número de Id y se eliminará el empleado del sistema.
*    
*
*      4. INFORMAR:
*         1. Listado de los empleados ordenados alfabéticamente por Apellido y Sector.
*         2. Total y promedio de los salarios, y cuántos empleados superan el salario promedio.
*
* Alumno: Dellagiovanna Mauricio
* Comision: 1F
*******************************************************************************/

#include <stdio.h>
#include <stdlib.h>
#include "ArrayEmployees.h"
#define MAX 10

int main()
{
    system("color f0");
    Employee empleados[MAX];

    _initEmployees(empleados, MAX);

    return 0;
}
