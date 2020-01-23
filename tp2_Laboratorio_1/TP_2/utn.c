#include <stdio.h>
#include <stdlib.h>
#include <string.h>


 /*
  * \brief Solicita un numero al usuario y devuelve el resultado
  * \parametro mensaje. Es el mensaje a ser mostrado
  * \Return El numero ingresado por el usuario
  */
float getFloat(char mensaje[])
{

    float auxiliar;

    printf("%s", mensaje);
    scanf("%f", &auxiliar);
    return auxiliar;
}



 /*
  * \brief Solicita un numero al usuario y devuelve el resultado
  * \parametro mensaje. Es el mensaje a ser mostrado
  * \Return El numero ingresado por el usuario
  */
int getInt(char mensaje[])
{

    int auxiliar;

    printf("%s", mensaje);
    scanf("%i", &auxiliar);
    return auxiliar;
}




 /*
  * \brief Guarda la cadena de caracteres ingresada por teclado
  * \parametro nombre: array de char , cantidad: lenght del array char
  * \Return void
  */
void miFgets(char nombre[], int cantidad){

    fflush(stdin);
    fgets(nombre, cantidad-2, stdin);

    nombre[cantidad-1] = '\0';
}




 /*
  * \brief Verifica que la cadena no supere el maximo de caracteres dado
  * \parametro name: array de char , length: lenght del array char
  * \Return void
  */
void stringIsValid(char name[], int length)
{
    if (strlen(name) > length - 1)
    {
        do
        {
            system("cls");
            printf("\nERROR. Reingrese Nombre: ");
            fflush(stdin);
            scanf("%s", name);
        } while (strlen(name) > length - 1);

    }

}





/*
 * \brief Verifica que la cadena no supere el maximo de caracteres dado
 * \parametro name: array de char , length: lenght del array char
 * \Return void
 */
void salaryIsValid(int salary)
{
    while(salary < 0)
    {
       system("cls");
       printf("\nError. reingrese Salario: ");
       scanf("%i", &salary);
    }
}











