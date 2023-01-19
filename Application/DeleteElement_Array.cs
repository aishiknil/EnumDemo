// using System;
// using System.Text;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Application
// {
//     public class DeleteElements_Array
//     {
//         // static void Main(string[] args)
//         // {
//         //     int[] Arr1 = new int[] { 1, 2, 3, 4, 5 };
//         //  Console.WriteLine(Array.FindIndex(Arr1, item => item == 3));

//         // }
//         public static void Main()
//         {
//             // int[] nums = { 1, 2, 3, 4, 5 };
//             // foreach (var item in nums)
//             //     Console.WriteLine(item);
//             int[] arr = new int[6] { 10, 20, 30, 40, 50, 60 };
//             int len = arr.Length; System.Console.WriteLine("Array elements are:");
//             foreach (var i in arr)
//                  System.Console.WriteLine(i);
//             // var listArr = arr.ToList();
//             Console.WriteLine("Enter the element to delete:");
//             int num = Convert.ToInt32(Console.ReadLine());
//             // listArr.Remove(4);
//             if ((arr.Contains(num)) == true)
//             {
//                 int index = Array.IndexOf(arr, num);
//                 Console.WriteLine("index of num:" + index);

//                 for (int i = index; i < (arr.Length)-1; i++)
//                 {
//                     arr[i] = arr[i + 1];
//                 }
//                 System.Console.WriteLine("Displaying the array after Deletion:-");
//                 for(int i = 0;i<arr.Length-1;i++)
//                     System.Console.WriteLine(arr[i]);
//             }
//         }
//     }
// }