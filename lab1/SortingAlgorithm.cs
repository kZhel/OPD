using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class SortingAlgorithm
    {
        public void sortingAlgorithm(Matrix matrix, bool asc, BaseInterface algorithm)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for(int j=0; j < matrix.Rows - 1 - i;j++)
                {
                    if(asc && algorithm.Order(matrix[j]) > algorithm.Order(matrix[j+1])||!asc && algorithm.Order(matrix[j]) < algorithm.Order(matrix[j + 1]))
                    {
                        double[] tmpRow=matrix[j];
                        matrix[j]=matrix[j+1];
                        matrix[j+1]=tmpRow;
                    }
                }
            }

        }
    }
}
