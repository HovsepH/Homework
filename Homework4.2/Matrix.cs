using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
    class Matrix
    {
        int[,] matrix;
        public int Rows { get; }
        public int Columns { get; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;

            Columns = columns;

            matrix = new int[Rows, Columns];

            SetElementsDefault();
        }

        public int this[int row, int column]
        {
            get
            {
                if (CheckRowAndColumn(row, column))
                    return matrix[row, column];
                else
                    return -1;
            }

            set
            {
                if (CheckRowAndColumn(row, column))
                    this[row, column] = value;
            }
        }

        private void SetElementsDefault()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrix[i, j] = i * j;
                }
            }
        }

        private bool CheckRowAndColumn(int row, int column)
        {
            return (row >= 0 && row < Rows) && (column >= 0 && column < Columns);
        }

    }
}
