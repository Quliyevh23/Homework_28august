#region Task 1: Arrayin icindeki en kicik ededi tapan algoritm

//int[] nums = { 45, 76, 35, 86, 54, 98, 435, 652, 124, 53, 49, 89, 90, 71, 23, 67, 45, 99 };

//for (int i = 0; i < nums.Length; i++)
//{
//    for (int j = 0; j < nums.Length - 1 - i; j++)
//    {

//        if (nums[j] > nums[j + 1])
//        {
//            nums[j] += nums[j + 1];
//            nums[j + 1] = nums[j] - nums[j + 1];
//            nums[j] = nums[j] - nums[j + 1];
//        }
//    }
//}

//Console.WriteLine("En kicik eded = " + nums[0]);

#endregion



#region Task2 Arrayde uzunlugu 4 den boyuk olan sozleri cap et

//string[] words = { "Kitab", "Alma", "Ev", "Magaza", "Eli", "Elektronika", "Robotlashdirilmish" };

//for (int i = 0; i < words.Length; i++)
//{

//    if (words[i].Length > 4)
//    {
//        Console.WriteLine(words[i]);
//    }

//}

#endregion



#region Task3 Ededlerden ibaret arrayde nece reqem oldugunu tap

//int[] nums2 = { 34, 45, 77, 2, 54, 89, 9, 5, 2, 5, 7, 3 }; //7 reqem

//int steps = 0;
//int count = 0;

//for (int i = 0;i < nums2.Length; i++)
//{
//    steps++;
//    if (nums2[i] > 0 && nums2[i] < 10){
//        count++;
//}
//}

//Console.WriteLine("Reqemlerin sayi = " + count);
//Console.WriteLine(steps);

#endregion



#region Task 4 Verilmish sozde 'a' herfi olub olmadigini tap

//Console.WriteLine("Soz daxil Edin: ");
//string word = Console.ReadLine();
//int count = 0;

//for (int i = 0; i < word.Length; i++)
//{
//    if (word[i] == 'a')
//    {
//        count++;   
//    }
//}
//Console.WriteLine("'a' herfi " + count + " dene var");

#endregion
