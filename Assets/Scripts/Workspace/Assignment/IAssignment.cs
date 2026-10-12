namespace Assignment
{
    public interface IAssignment
    {
        #region Lecture

        int LCT01_SequentialSearch1DArray();

        int[] LCT02_SequentialSearch2DArray();

        int LCT03_BinarySearch();

        #endregion

        #region Assignment

        /// <summary>
        /// หาตำแหน่งแรกและตำแหน่งสุดท้ายในลำดับ
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        int[] AS01_FindFirstAndLastElementOfArray(int[] array, int target);

        /// <summary>
        /// หาค่าที่มากที่สุดที่น้อยกว่าค่าที่กำหนด
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        int AS02_FindMaxLessThan(int[] array, int target);

        /// <summary>
        /// หาค่าที่อยู่ในช่วงที่กำหนด
        /// </summary>
        /// <param name="array">Array ที่เรียงลำดับมาแล้ว</param>
        /// <param name="min">ค่าต่ำสุด</param>
        /// <param name="max">ค่าสูงสุด</param>
        int[] AS03_FindRange(int[] array, int min, int max);

        #endregion

        #region Extra

        /// <summary>
        /// ค้นหาเป้าหมายที่สามารถทำลายได้ในเกม RPG
        /// </summary>
        /// <param name="enemyHPs"></param>
        /// <param name="mana"></param>
        int[] EX01_FindTargetEnemies(int[] enemyHPs, int mana);

        #endregion
    }
}
