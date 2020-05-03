using System;
using System.Collections.Generic;
using System.Text;

namespace RotateArray
{
    class RotateArray
    {
        static void Main(string[] args)
        {
            //rotating the array RIGHT by 1 position
            int[] nums1 = new int[] { 1, 2, 3, 4, 5 };
            int len = 5;
            Console.WriteLine("Elements of the array are ");
            foreach (int num in nums1)
                Console.Write(num);
            Console.WriteLine("\n");
            
            int tempNum1 = nums1[len - 1];
            for (int i = len-1; i > 0; i--)
                nums1[i] = nums1[i - 1];
            
            nums1[0] = tempNum1;
            Console.WriteLine("Elements of the array after being rotated RIGHT ");
            foreach(int num in nums1)
                Console.Write(" " +num);
            Console.WriteLine("\n");

            //rotating the array LEFT by 1 position
            int[] nums2 = new int[] { 1, 2, 3, 4, 5 };
            //int len = 5;
            Console.WriteLine("Elements of the array are ");
            foreach (int num in nums2)
                Console.Write(num);
            Console.WriteLine("\n");

            int tempNum2 = nums2[0];
            for (int i = 0; i < len - 1; i++)
                nums2[i] = nums2[i + 1];

            nums2[len - 1] = tempNum2;
            Console.WriteLine("Elements of the array after being rotated LEFT ");
            foreach (int num in nums2)
                Console.Write(" " + num);
        }
    }
}
