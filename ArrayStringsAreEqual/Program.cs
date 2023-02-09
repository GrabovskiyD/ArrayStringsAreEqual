namespace ArrayStringsAreEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] word1 = { "a", "cb" };
            string[] word2 = { "ab", "c" };

            Console.WriteLine(ArrayStringsAreEqual(word1, word2));
        }

        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            #region Using String Builder
            //System.Text.StringBuilder sb1 = new();
            //System.Text.StringBuilder sb2 = new();

            //foreach(string word in word1)
            //{
            //    sb1.Append(word);
            //}
            //foreach (string word in word2)
            //{
            //    sb2.Append(word);
            //}
            //return sb1.ToString().Equals(sb2.ToString());
            #endregion
            #region Usin string.Join()
            return string.Join("", word1) == string.Join("", word2);
            #endregion
        }
    }
}