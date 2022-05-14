using lab1;
namespace lab1
{
    public class Program
    {
        static void Main()
        {
            Matrix matrix = new Matrix(new double[][]
            {
                new double[] { 2, 3, 5, 7, 9 },
                new double[] { 1, 2, 4, 6, 1 },
                new double[] { 0, 22, 0, 0, 0 }
            });

            SortingAlgorithm sorter = new SortingAlgorithm();
            while (true)
            {
                Console.WriteLine("Выберите тип сортировки:");
                Console.WriteLine("1 – По сумме элементов строк матрицы");
                Console.WriteLine("2 – По максимальному элементу в строке матрицы");
                Console.WriteLine("3 – По минимальному элементу в строке матрицы");
                Console.WriteLine("0 - Выход из программы");
                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1': sorter.sortingAlgorithm(matrix, chooseSign(), new SortSum()); break;
                    case '2': sorter.sortingAlgorithm(matrix, chooseSign(), new SortMaxElem()); break;
                    case '3': sorter.sortingAlgorithm(matrix, chooseSign(), new SortMinElem()); break;
                    case '0': return;
                    default: break;
                }
                for (int i = 0; i < matrix.Rows; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        Console.Write(matrix[i][j].ToString() + " ");
                    }
                    Console.WriteLine();
                }
            }


            bool chooseSign()
            {
                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("1 – По возрастанию");
                    Console.WriteLine("2 – По убыванию");
                    Console.WriteLine("");

                    switch (char.ToLower(Console.ReadKey(true).KeyChar))
                    {
                        case '1': return true;
                        case '2': return false;
                        default: break;
                    }
                }
            }
        }
    }
}

