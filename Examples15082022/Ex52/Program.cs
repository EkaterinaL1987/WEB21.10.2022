//Задайте двумерный массив из целых чисел размера NxN. Укажите два числа,означающие строки, которые нужно поменять местами.
#include <iostream>
using namespace std;
 
int main()
{
    srand(time(0)); 
    int n, k, temp;
    cout << "Enter size n="; cin >>n; 
    cout << "k="; cin >>k; 
    
   // объявление двумерного динамического массива
   
   float **a = new float* [n]; 
   for (int i = 0; i < n; i++)
        a[i] = new float [n];  
 
   // заполнение массива случайными числами от 1 до 9
 
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            a[i][j] = rand() % 9 + 1;
 
   // вывод массива на экран
 
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
            cout << a[i][j] << "   ";
        cout << endl;
    }
    cout << endl;
    
    // перестановка столбцов
 
    for (int i = 0; i < n; i++)
    {
    temp=a[i][0];
    a[i][0]=a[i][k-1];
    a[i][k-1]=temp;
    }
    
    // вывод нового массива на экран
 
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
            cout << a[i][j] << "   ";
        cout << endl;
    }
    
// освобождение памяти отводимой под массив:
 
   for (int i = 0; i < n; i++)
       delete [] a[i];
       delete [] a;
system("pause");
return 0;
}