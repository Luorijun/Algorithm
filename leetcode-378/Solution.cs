namespace leetcode_378
{
    public class Solution
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            var n = matrix.Length;
            var l = matrix[0][0];
            var r = matrix[n - 1][n - 1];
            while (l < r)
            {
                var c = 0;
                var i = 0;
                var j = n - 1;
                var m = l + ((r - l) >> 1);
                while (i < n && j >= 0)
                    if (matrix[i][j] <= m) i++;
                    else
                    {
                        j--;
                        c += i;
                    }
                if (c >= k) r = m;
                else l = m + 1;
            }
            return l;
        }
    }
}