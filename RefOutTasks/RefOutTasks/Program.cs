namespace RefOutTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1_Call
            //int[] array = {0,1,2,3,4,5};
            //InsertArray(ref array, 6, 7, 8, 9);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Task2_Call
            //int[] array = { 5,8,3,7,12,1 };
            //SwapArray(ref array);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}            
            #endregion

            #region Task3_Call
            //string name = " Gul gaz";
            //RemoveSpace(ref name);
            //Console.WriteLine(name); 
            #endregion
        }
        #region Task1_Method
        //static void InsertArray(ref int[] arr, params int[] numbers)
        //{
        //    int[] newarr=new int[arr.Length+numbers.Length];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        newarr[i] = arr[i];
        //    }
        //    for (int i = 0;i < numbers.Length; i++)
        //    {
        //        newarr[arr.Length+i] = numbers[i];
        //    }
        //    arr= newarr;
        //} 
        #endregion

        #region Task2_Method
        //static void SwapArray(ref int[] arr)
        //{
        //    int minindex = 0;
        //    int maxindex = 0;
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < arr[minindex])
        //        {
        //            minindex = i;
        //        }
        //        if (arr[i] > arr[maxindex])
        //        {
        //            maxindex = i;
        //        }
        //    }
        //    int temp = arr[maxindex];
        //    arr[maxindex] = arr[minindex];
        //    arr[minindex] = temp;
        //} 
        #endregion

        #region Task3_Method
        //static void RemoveSpace(ref string word)
        //{
        //    char[] chars = new char[word.Length];
        //    int count = 0;
        //    for (int i = 0; i < chars.Length; i++)
        //    {
        //        if (word[i] == ' ')
        //        {
        //            count++;
        //        }
        //        chars[i] = word[i];
        //    }
        //    char[] newchars = new char[chars.Length-count];
        //    int j = 0;
        //    for (int i = 0;i < chars.Length;i++)
        //    {
        //        if (chars[i] != ' ')
        //        {
        //            newchars[j] = chars[i];
        //            j++;
        //        }
        //    }
        //    string newword = "";
        //    for (int i = 0; i < newchars.Length; i++)
        //    {
        //        newword += newchars[i];
        //    }
        //    word= newword;
        //} 
        #endregion
    }
}