using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture

        public int LCT01_SequentialSearch1DArray()
        {
            int[] array = new int[] { 34, 21, 56, 12, 78, 90, 11, 23 };
            int target = 90;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public int[] LCT02_SequentialSearch2DArray()
        {
            int[,] array = new int[,]
            {
                { 34, 21, 56 },
                { 12, 78, 90 },
                { 11, 23, 45 }
            };
            int target = 23;
            int row = -1;
            int col = -1;

            for (int r = 0; r < array.GetLength(0); r++)
            {
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    if (array[r, c] == target)
                    {
                        row = r;
                        col = c;
                        break;
                    }
                }

                if (row != -1)
                {
                    break;
                }
            }

            return new[] { row, col };
        }

        public int LCT03_BinarySearch()
        {
            int[] array = new int[] { 11, 12, 21, 23, 34, 45, 56, 78, 90 };
            int target = 23;
            int index = -1;

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == target)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return index;
        }

        #endregion

        #region Assignment

        public int[] AS01_FindFirstAndLastElementOfArray(int[] array, int target)
        {
            int first = -1;
            int last = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    if (first == -1)
                    {
                        first = i;
                    }

                    last = i;
                }
            }

            if (first == -1)
            {
                return new int[] { -1 };
            }

            return new int[] { first, last };
        }

        public int AS02_FindMaxLessThan(int[] array, int target)
        {
            int maxValue = 0;
            bool found = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < target)
                {
                    if (!found || array[i] > maxValue)
                    {
                        maxValue = array[i];
                        found = true;
                    }
                }
            }

            if (found)
            {
                return maxValue;
            }

            return -1;
        }

        public int[] AS03_FindRange(int[] array, int min, int max)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= min && array[i] <= max)
                {
                    result.Add(array[i]);
                }
            }

            return result.ToArray();
        }

        #endregion

        #region Extra

        public int[] EX01_FindTargetEnemies(int[] enemyHPs, int mana)
        {
            int[] sortedHPs = (int[])enemyHPs.Clone();

            // เรียงค่า HP จากน้อยไปมาก
            for (int i = 0; i < sortedHPs.Length - 1; i++)
            {
                for (int j = 0; j < sortedHPs.Length - 1 - i; j++)
                {
                    if (sortedHPs[j] > sortedHPs[j + 1])
                    {
                        int temp = sortedHPs[j];
                        sortedHPs[j] = sortedHPs[j + 1];
                        sortedHPs[j + 1] = temp;
                    }
                }
            }

            List<int> result = new List<int>();
            int totalMana = 0;

            for (int i = 0; i < sortedHPs.Length; i++)
            {
                if (sortedHPs[i] >= 0 &&
                    sortedHPs[i] <= mana - totalMana)
                {
                    totalMana += sortedHPs[i];
                    result.Add(sortedHPs[i]);
                }
            }

            return result.ToArray();
        }

        #endregion
    }
}
