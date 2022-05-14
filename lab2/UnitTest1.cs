using NUnit.Framework;
using lab1;

namespace lab2
{
    public class Tests
    {
        [Test]
        public void TestSortMaxElement()
        {
            double res = 20;
            double[] arr = new double[] { 20, 1, 5 };

            SortMaxElem sortMaxElement = new SortMaxElem();
            Assert.AreEqual(res, sortMaxElement.Order(arr));
        }

        [Test]
        public void TestSortMinElement()
        {
            double res = 4;
            double[] arr = new double[] { 4, 7, 13 };

            SortMinElem sortMinElement = new SortMinElem();
            Assert.AreEqual(res, sortMinElement.Order(arr));
        }

        [Test]
        public void TestSortSum()
        {
            double res = 0;
            double[] arr = new double[] { 0, 0, 0 };

            SortSum sortSum = new SortSum();
            Assert.AreEqual(res, sortSum.Order(arr));
        }
        [Test]
        public void TestSortMatrixMaxUp()
        {
            Matrix matrix = new Matrix(new double[][]
            {
                new double[] { 6, 7, 8 },
                new double[] { 3, 4, 5},
                new double[] { 0, 1, 2}
            });
            SortingAlgorithm sortMatrix = new SortingAlgorithm();

            double[][] res = new double[][]
                {
                new double[] { 0, 1, 2 },
                new double[] { 3, 4, 5 },
                new double[] { 6, 7, 8}
                };

            sortMatrix.sortingAlgorithm(matrix, true, new SortMaxElem());

            for (int i = 0; i < res.Length; i++)
            {
                double[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }

        [Test]
        public void TestSortMatrixMaxDowm()
        {
            Matrix matrix = new Matrix(new double[][]
             {
                new double[] { 0, 1, 2 },
                new double[] { 3, 4, 5 },
                new double[] { 6, 7, 8}
             });
            SortingAlgorithm sortMatrix = new SortingAlgorithm();

            double[][] res = new double[][]
                {

                new double[] { 6, 7, 8 },
                new double[] { 3, 4, 5},
                new double[] { 0, 1, 2}
                };

            sortMatrix.sortingAlgorithm(matrix, false, new SortMaxElem());

            for (int i = 0; i < res.Length; i++)
            {
                double[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }
        [Test]
        public void TestSortMatrixMinUp()
        {
            Matrix matrix = new Matrix(new double[][]
            {
                new double[] { 2, 2, 2 },
                new double[] { 1, 1, 3 },
                new double[] { 5, 0, 2}
            });
            SortingAlgorithm sortMatrix = new SortingAlgorithm();

            double[][] res = new double[][]
                {
                new double[] { 5, 0, 2 },
                new double[] { 1, 1, 3},
                new double[] { 2, 2, 2}
                };

            sortMatrix.sortingAlgorithm(matrix, true, new SortMinElem());

            for (int i = 0; i < res.Length; i++)
            {
                double[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }

        [Test]
        public void TestSortMatrixMinDowm()
        {
            Matrix matrix = new Matrix(new double[][]
            {
            new double[] { 5, 0, 2 },
            new double[] { 1, 1, 3},
            new double[] { 2, 2, 2}
            });
            SortingAlgorithm sortMatrix = new SortingAlgorithm();

            double[][] res = new double[][]
                {
                new double[] { 2, 2, 2 },
                new double[] { 1, 1, 3 },
                new double[] { 5, 0, 2}
                };

            sortMatrix.sortingAlgorithm(matrix, false, new SortMinElem());

            for (int i = 0; i < res.Length; i++)
            {
                double[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(res[i][j], matrix[i][j]);
                }
            }
        }
        [Test]
        public void TestSortMatrixSumUp()
        {
            Matrix matrix = new Matrix(new double[][]
            {
            new double[] { 2, 2, 2 },
            new double[] { 0, 0, 0},
            new double[] { 1, 1, 1}
            });
            SortingAlgorithm sortMatrix = new SortingAlgorithm();

            double[][] res = new double[][]
                {
                new double[] { 0, 0, 0 },
                new double[] { 1, 1, 1 },
                new double[] { 2, 2, 2 }
                };

            sortMatrix.sortingAlgorithm(matrix, true, new SortSum());

            for (int i = 0; i < res.Length; i++)
            {
                double[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }

        [Test]
        public void TestSortMatrixSumDown()
        {
            Matrix matrix = new Matrix(new double[][]
            {
            new double[] { 2, 2, 2 },
            new double[] { 0, 0, 0},
            new double[] { 1, 1, 1}
            });
            SortingAlgorithm sortMatrix = new SortingAlgorithm();

            double[][] res = new double[][]
                {
                new double[] { 2, 2, 2 },
                new double[] { 1, 1, 1 },
                new double[] { 0, 0, 0}
                };

            sortMatrix.sortingAlgorithm(matrix, false, new SortSum());

            for (int i = 0; i < res.Length; i++)
            {
                double[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }
    }
}