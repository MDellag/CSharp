#ifndef EMPLEADOS_H_INCLUDED
#define EMPLEADOS_H_INCLUDED


typedef struct 
{
    int id;
    char name[51];
    char lastName[51];
    
    float salary;
    int sector;
    int isEmpty;

}Employee;


void _initEmployees(Employee list[], int length);


#endif // EMPLEADOS_H_INCLUDED
