string[] array1 = new string[4] {"branch", "checkout","commit","yes"};
 string[] arr = new string[array1.Length];

 void NewArray (string[] arra1, string [] arr)
 {
    int count= 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length<=3)
        {
            count++;
            arr[count]=arra1[i];
        }
    }
 }

