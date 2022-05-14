using System;

namespace lab1
{
	public class Matrix
	{
		private int nRows ;
		private int nCols ;
		private double[][] arr;
		public Matrix(int nR, int nC)
		{
			if (nR > 0 && nC > 0)
			{
				nRows = nR;
				nCols = nC;
				arr = new double[nRows][];
				for (int i = 0; i < nRows; i++)
				{
					arr[i] = new double[nCols];	
					for(int j = 0; j < nCols; j++)
                    {
						arr[i][j] = 0;
                    }
				}
			}
			else
			{
				throw new ArgumentOutOfRangeException();
			}
		}
		public Matrix(double[][] initData)
		{
			this.nRows = initData.GetLength(0);
			this.nCols = initData[0].GetLength(0);
			this.arr = initData;
		}
		public double[] this[int i]
		{
			get { return arr[i]; }
			set { arr[i] = value; }
		}
		public double this[int i, int j]
		{
			get { return arr[i][j]; }
			set { arr[i][j] = value; }
		}
		public int Rows
		{
			get { return nRows; }
		}
		public int Columns
		{
			get { return nCols; }
		}
		
		public static Matrix operator -(Matrix m1, Matrix m2)
		{
			if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
			{
				throw new InvalidOperationException();
			}
			else
			{
				Matrix m3 = new Matrix(m1.Rows, m1.Columns);
				for (int i = 0; i < m1.Rows; i++)
				{
					for (int j = 0; j < m1.Columns; j++)
					{
						m3[i, j] = m1[i, j] - m2[i, j];
					}
				}
				return m3;
			}
		}
		public static explicit operator Matrix(double[][] arr)
		{
			return new Matrix(arr);
		}
		
		public override string ToString()
		{
			string strRes = "";
			for (int i = 0; i < nRows; i++)
			{
				for (int j = 0; j < nCols; j++)
				{
					if (j + 1 == nCols && i + 1 != nRows)
					{
						strRes += arr[i][j] + "; ";
					}
					else
					{
						strRes += arr[i][j] + " ";

					}
				}
			}
			return strRes;
		}
		
	}
}
