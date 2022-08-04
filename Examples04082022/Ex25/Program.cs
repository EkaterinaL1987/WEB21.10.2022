// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int powx(int n, int p)
{
   if (p==0) return 1;
   if (p==1) return n;
   return powx(n, p/2)*powx(n, p - p/2);
}