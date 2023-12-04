namespace largest_3_same_digit_number_in_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string num = "6777133339"; // 42352338, 2300019, 6777133339
            var ans = solution.LargestGoodInteger(num);
            Console.WriteLine(ans); 
        }
    }

    public class Solution
    {
        public string LargestGoodInteger(string num)
        {
            // time - O(N), Space - O(1)
            // will iterarte over num, ll take 3 pointer i, j and K and check num[i] == num[j] &&  num[j] == num[k]
            string ans = "";
            for (int i = 0; i < num.Length; i++)
            {
                int j = i + 1;
                int k = j + 1;

                if (j < num.Length && k < num.Length && num[i] == num[j] && num[j] == num[k])
                {
                    string substr = num[i].ToString() + num[j].ToString() + num[k].ToString();
                    int numberSubStr = Convert.ToInt32(substr);
                    int numberAns = string.IsNullOrWhiteSpace(ans) ? 0 : Convert.ToInt32(ans);
                    ans = Math.Max(numberSubStr, numberAns).ToString();
                }
            }
            if (ans == "0") ans = "000";
            return  ans;
        }
    }
}
