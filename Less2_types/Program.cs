namespace Less2_types
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
        //    if(10)//помилка
        //    {

        //    }

            int[] arr = { 4, 5, 4, 5, 7,7,8, 2, 3, 8, 2 }; //3
            int counter;
            int countUnique = 0;
            for(int i=0;i<arr.Length;i++)
            {
                counter = 0;
                for(int j = 0;j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                }

                if(counter==1)
                {
                    countUnique++;
                }
            }

            if (countUnique>0)
            {
                int k = 0;
                int[] newArr = new int[countUnique];
                for (int i = 0; i < arr.Length; i++)
                {
                    counter = 0;
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            counter++;
                        }
                    }

                    if (counter == 1)
                    {
                        newArr[k] = arr[i];
                        Console.WriteLine(newArr[k]);
                        k++;
                    }
                }
            }

            

        }
    }
}
