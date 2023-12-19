namespace Exercitii6;

class Program
{
    /* static void Main(string[] args)
     {
         *//*Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
 metoda care va calcula volumul acestuia precum si o metoda tipareste.*//*
         int lungime = 30;
         int latime = 20;
         int inaltime = 150;

         Console.WriteLine("Volumul dulapului este: " + CalculareVolumDulap(lungime, latime, inaltime));
 */







    /* static int CalculareVolumDulap(int lungime, int latime, int inaltime)
     {
         int calculareVolum = lungime * latime * inaltime;

         return calculareVolum;

     }*/


    /*Scrieti un program care va modela un autoturism. Un autoturism va avea o marca
(string), un numar de inmatriculare (string), precum si o capacitate
cilindrica(int).*/

    /*    static void Main(string[] args)
        {
            string marca = "Mercedes";
            string numarImatriculare = "TM23DDD";
            int capacitateCilindrica = 2000;
        }*/


    /* Gigel a găsit un șir cu n numere naturale.În fiecare zi Gigel parcurge șirul și
         * când găsește o pereche de elemente consecutive egale o elimină din șir și se oprește.
         * Determinați în câte zile va elimina Gigel elemente din șir și care sunt valorile din șir după eliminări.*/


    static void Main(string[] args)
    {
        int[] num = { 1, 2, 2, 4, 5, 6, 7 };
        
        CalculareSir(num);

    }

    static void CalculareSir(int[] num)
    {

        int lungimeNoua = 0;

        for (int i = 0; i < num.Length -1; i++) {

            if (num[i] != num[i + 1])
            {
                num[lungimeNoua] = num[i];
                lungimeNoua++;
            }
            else
            {
                i++; 
            }
        }

        num[lungimeNoua] = num[num.Length - 1];
        Array.Resize(ref num, lungimeNoua + 1);



        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    }
}

