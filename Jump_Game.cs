namespace LeetCode_Practicing.Easy
{
    public class Jump_Game
    {
        public bool canJump(int[] arr)
        {
           if (arr == null || arr.Length == 0) return false;
           int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) return false;
                if (i>0 && arr[i - 1] <= arr[i]) j=i;                                         
                if (arr[j] >= (arr.Length-1) - j) return true;
            }
            return false;
        }
    }
}
