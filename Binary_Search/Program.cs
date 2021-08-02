using System;
using System.Collections.Generic;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da lista de números a ser gerada");
            var listLenght = int.Parse(Console.ReadLine());
            List<int> numericList = new();
            Random randNum = new Random(2021);
            for (int i = 0; i <= listLenght; i++)
                numericList.Add(randNum.Next(1, 100));
            numericList.Sort();
            numericList.ForEach(x => Console.Write(x + ","));
            Console.WriteLine();
            Console.WriteLine("Digite o número a ser encontrado na lista");
            var numberToFind = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o índice inicial para começar a pesquisa");
            var startIndex = int.Parse(Console.ReadLine());
            var result = BinarySearch(numericList, numberToFind, startIndex, numericList.Count - 1);
            if (result is null)
                Console.WriteLine("O número não foi encontrado na lista");
            else
                Console.WriteLine($"O número informado se encontra no índice { result}");
            Console.ReadKey();


        }
        public static int? BinarySearch(List<int> pList, int pItem, int pBegin, int pEnd)
        {
            if (pBegin <= pEnd)
            {
                int m = (pBegin + pEnd) / 2;
                if (pList[m] == pItem)
                    return m;
                if (pItem < pList[m])
                    return BinarySearch(pList, pItem, pBegin, m - 1);
                else
                    return BinarySearch(pList, pItem, m + 1, pEnd);
            }
            return null;
        }
    }
}
