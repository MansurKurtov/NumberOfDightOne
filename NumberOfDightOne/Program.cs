namespace NumberOfDightOne
{
    /// <summary>
    /// Given an integer n, count the total number of digit 1 appearing in all non-negative integers less than or equal to n
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var prg = new Program();
            var result = prg.CountDigitOne(13); //6
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int CountDigitOne(int n)
        {
            int res = 0;
            for (long k = 1; k <= n; k *= 10)
            {
                long r = n / k, m = n % k;
                var t = (int)(r % 10 == 1 ? m + 1 : 0);
                res = (int)(res + (r + 8) / 10 * k + t);
            }
            return res;
        }
    }
}
