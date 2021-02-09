using System;

namespace HW_8__06._02_
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Пожалуйста идите попорядку!");
            Console.ForegroundColor = ConsoleColor.White;
            //Pop
            string[] arraystr = new string[] { "1", "2", "3" };
            int[] arrayint = new int[] { 1,2,3 };
            double[] arrayd = new double[] { 1.1, 2.2, 3.3 };
            decimal[] arraydec = new decimal[] { 5.505m, 4.404m, 3.303m, 2.202m, 1.101m };
            float[] arrayfloat = new float[] { 5.5f, 4.4f, 3.3f, 2.2f, 1.1f };


            Console.WriteLine("Метод Pop:\n" +
                "Удаляет последний элемент массива и возвращает этот удалённый элемент");
            Console.Write("Выберите тип массива:\n" +
                "string - нажмите 1;\n" +
                "int - нажмите 2;\n" +
                "double - нажмите 3;\n" +
                "decimal - намите 4;\n" +
                "float - нажмите 5.\t");
            int choicepop = int.Parse(Console.ReadLine());
            
            if(choicepop == 1)
            {
                string lastelement = ArrayHelper<string>.Pop(ref arraystr);
                Console.WriteLine($"\nPop string: {lastelement}");
            }
            else if(choicepop == 2)
            {
                int lastelement = ArrayHelper<int>.Pop(ref arrayint);
                Console.WriteLine($"\nPop int: {lastelement}");
            }
            else if (choicepop == 3)
            {
                double lastelement = ArrayHelper<double>.Pop(ref arrayd);
                Console.WriteLine($"\nPop double: {lastelement}");
            }
            else if(choicepop == 4)
            {
                decimal lastelement = ArrayHelper<decimal>.Pop(ref arraydec);
                Console.WriteLine($"\nPop decimal: {lastelement}");
            }
            else if(choicepop == 5)
            {
                float lastelement = ArrayHelper<float>.Pop(ref arrayfloat);
                Console.WriteLine($"\nPop float: {lastelement}");
            }
            else if(choicepop>=6)
                Console.WriteLine("\nВведен неверный символ!");



            //Push
            string[] addlast = new string[] { "C++", "C#", "C" };
            int[] lastipush = new int[] { 1, 2, 3, 4, 5 };
            double[] lastdpush = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            decimal[] lastdecpush = new decimal[] { 5.505m, 4.404m, 3.303m, 2.202m, 1.101m };
            float[] lastflpush = new float[] { 5.5f, 4.4f, 3.3f, 2.2f, 1.1f };
            

            Console.WriteLine("\nМетод Push:\n" +
                "Добавляет элемент с конца массива и возвращает обновленную длину массива.");
            Console.Write("Выберите тип массива:\n" +
                "string - нажмите 1;\n" +
                "int - нажмите 2;\n" +
                "double - нажмите 3;\n" +
                "decimal - намите 4;\n" +
                "float - нажмите 5.\t");
            int choicepush = int.Parse(Console.ReadLine());

            if (choicepush == 1)
            {
                int addstrpush = ArrayHelper<string>.Push(ref addlast, "Java");
                Console.WriteLine($"\nPush string:  {addstrpush}");
            }
            else if (choicepush == 2)
            {
                int lastintpush = ArrayHelper<int>.Push(ref lastipush, 6);
                Console.WriteLine($"\nPush int: {lastintpush}");
            }
            else if (choicepush == 3)
            {
                double lastdblpush = ArrayHelper<double>.Push(ref lastdpush, 6.6);
                Console.WriteLine($"\nPush double: {lastdblpush}");
            }
            else if (choicepush == 4)
            {
                decimal lastdecimalpush = ArrayHelper<decimal>.Push(ref lastdecpush, 0.101m);
                Console.WriteLine($"\nPush decimal: {lastdecimalpush}");
            }
            else if (choicepush == 5)
            {
                float lstflp = ArrayHelper<float>.Push(ref lastflpush, 0.1f);
            Console.WriteLine($"\nPush float: {lstflp}");
            }
            else if(choicepush >= 6)
                Console.WriteLine("\nВведен неверный символ!");


            //Shift

            string[] firststrelm = new string[] { "C++", "C#", "C" };
            int[] firstintelm = new int[] { 1, 2, 3, 4, 5 };
            double[] firstdblelemn = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
            decimal[] firstdcmelem = new decimal[] { 5.505m, 4.404m, 3.303m, 2.202m, 1.101m };
            float[] fisrtflelem = new float[] { 5.5f, 4.4f, 3.3f, 2.2f, 1.1f };
            

            Console.WriteLine("\nМетод Shift:\n" +
                "Удаляет первый элемент и возвращает этот удалённый элемент.");

            Console.Write("Выберите тип массива:\n" +
                "string - нажмите 1;\n" +
                "int - нажмите 2;\n" +
                "double - нажмите 3;\n" +
                "decimal - намите 4;\n" +
                "float - нажмите 5.\t");
            int choiceshift = int.Parse(Console.ReadLine());

            if (choiceshift == 1)
            {
                string felemnt = ArrayHelper<string>.Shift(ref firststrelm);
                Console.WriteLine($"\nShift str: {felemnt}");
            }
            else if (choiceshift == 2)
            {
                int felementint = ArrayHelper<int>.Shift(ref firstintelm);
                Console.WriteLine($"\nShift int: {felementint}");
            }
            else if (choiceshift == 3)
            {
                double fdblelemnt = ArrayHelper<double>.Shift(ref firstdblelemn);
                Console.WriteLine($"\nShift double: {fdblelemnt}");
            }
            else if (choiceshift == 4)
            {
                decimal firstdcelem = ArrayHelper<decimal>.Shift(ref firstdcmelem);
                Console.WriteLine($"\nShift decimal: {firstdcelem}");
            }
            else if (choiceshift == 5)
            {
                float firstflrelem = ArrayHelper<float>.Shift(ref fisrtflelem);
                Console.WriteLine($"\nShift float: {firstflrelem}");
            }
            else if(choiceshift>=6)
                Console.WriteLine("\nВведен неверный символ!");



            //UnShift


            string[] newarray = new string[] { "C++", "C#", "C" };
            int[] arrayintt = new int[] { 1, 2, 3, 4, 5 };
            double[] arraydouble = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            decimal[] arraydecimal = new decimal[] { 5.505m, 4.404m, 3.303m, 2.202m, 1.101m };
            float[] arrayfloatt = new float[] { 5.5f, 4.4f, 3.3f, 2.2f, 1.1f };
            

            Console.WriteLine("\nМетод UnShift:\n" +
                "Добавляет элемент в начало массива и возвращает обновленную длину массива.");

            Console.Write("Выберите тип массива:\n" +
                "string - нажмите 1;\n" +
                "int - нажмите 2;\n" +
                "double - нажмите 3;\n" +
                "decimal - намите 4;\n" +
                "float - нажмите 5.\t");
            int choiceunshift = int.Parse(Console.ReadLine());

            if (choiceunshift == 1)
            {
                int newelemstr = ArrayHelper<string>.UnShift(ref newarray, "C");
                Console.WriteLine($"\nUnshift string: {newelemstr}");
            }
            else if (choiceunshift == 2)
            {
                int newelemint = ArrayHelper<int>.UnShift(ref arrayintt, 6);
                Console.WriteLine($"\nUnshift int: {newelemint}");
            }
            else if (choiceunshift == 3)
            {
                double newelemdbl = ArrayHelper<double>.UnShift(ref arraydouble, 6.6);
                Console.WriteLine($"\nUnshift double {newelemdbl}");
            }
            else if (choiceunshift == 4)
            {
                decimal newelembl = ArrayHelper<decimal>.UnShift(ref arraydecimal, 0.101m);
                Console.WriteLine($"\nUnshift decimal: {newelembl}");
            }
            else if (choiceunshift == 5)
            {
                float newelemfloat = ArrayHelper<float>.UnShift(ref arrayfloatt, 0.1f);
                Console.WriteLine($"\nUnshift float: {newelemfloat}");
            }
            else if(choiceunshift>=6)
                Console.WriteLine("\nВведен неверный символ!");

            */

            // Slice


            Console.WriteLine("Begin index: ");
            int beginindex = int.Parse(Console.ReadLine());
            Console.WriteLine("End: ");
            int endindex = int.Parse(Console.ReadLine());
            string[] animals = new string[] { "ant", "bison", "camel", "duck", "elephant" };
            foreach (string item in ArrayHelper<string>.Slice(ref animals, beginindex, endindex))
            {
                Console.WriteLine($"{item}   ");
            }


            

        }

    }

    public static class ArrayHelper<T>
    {
        public static T Pop(ref T[] array)
        {
            T lastelement = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return lastelement;
        }

        public static int Push(ref T[] addlast, T newaddlast)
        {
            Array.Resize(ref addlast, addlast.Length + 1);
            addlast[addlast.Length - 1] = newaddlast;
            return addlast.Length -1;

        }

        public static T Shift(ref T[] firstelement)
        {
            T first = firstelement[0];
            for (int i = 0; i < firstelement.Length-1; i++)
            {
                firstelement[i] = firstelement[i + 1];
            }
            Array.Resize(ref firstelement, firstelement.Length - 1);
            return first;
        }


        public static int UnShift(ref T[] newaddelement, T aelemnt)
        {
            Array.Resize(ref newaddelement, newaddelement.Length + 1);
            for (int i = newaddelement.Length-1; i >= 1; i--)
            {
                newaddelement[i] = newaddelement[i - 1];
            }
            newaddelement[0] = aelemnt;
            return newaddelement.Length;
        }



        public static T[] Slice(ref T[] array, int begin_index = 0, int  end_index = 0)
        {
            int len = array.Length;
           

            if (end_index < 0)
            {
                end_index = len + end_index;
            }
            if (begin_index < 0)
            {
                begin_index = array.Length + begin_index;
            }
            if(end_index == 0)
            {
                end_index = array.Length;
            }
           
            int new_len =end_index - begin_index;
            if (new_len < 1)
            {
                return new T[0];
            }
            Console.WriteLine(begin_index);
            Console.WriteLine(end_index);
            Console.WriteLine($"new len = {new_len}");
            T[] sub_array = new T[new_len];
            for (int i = 0; i < new_len; i++)
            {
                sub_array[i] = array[i + (int)begin_index];
            }

            return sub_array;
        }


        
    }
}
