#region
// task1
//using System;
//class HelloWorld 
//{
//    static void Main()
//    {
//        int num = 24;
//        int say = 0;
//        int num1 = 1;
//        int num2 = 1;
//        int n = 0;
//        int numcopy = num;
//        bool f = false;
//        while (num!= 1)
//        {
//            if (num%2!=0)
//            {
//                f = true;
//            }
//            num = num / 2;
//            say+=1;
//        }
//        if (f==true)
//        {
//            n = say + 1;
//            for (int i = 1; i <= n; i++)
//            {
//                num1 = num1 * 2;
//            }
//            Console.WriteLine(num1);
//            for (int i = 1; i <= say; i++)
//            {
//                num2 = num2 * 2;
//            }
//            Console.WriteLine(num2);
//            if (num1 - numcopy < numcopy - num2)
//            {
//                Console.WriteLine("Bu quvvete daha yaxindir:" + " " + n);
//            }
//            else
//            {
//                Console.WriteLine("Bu quvvete daha yaxindirr:" + " " + say);
//            }
//        }
//        else
//        {
//            Console.WriteLine("bu ededin quvvetidir:" + " " + say);
//        }

//    }
//}
#endregion


#region
//task 2
//using System;
//class HelloWorld
//{
//    static void Main()
//    {
//        int num = 45;
//        int cem = 0;
//        int reqem = 0;
//        while (num > 1)
//        {
//            reqem = num % 10;
//            cem = cem + reqem;
//            num = num / 10;
//        }
//        Console.WriteLine(cem);
//    }
//}
#endregion

#region
//task 3
//using System;
//class HelloWorld
//{
//    static void Main()
//    {
//        int num = 12;
//        int i = 2;
//        int k = 0;
//        if (num > 0 && num != 1)
//        {
//            for (i = 2; i < num; i++)
//                if (num % i == 0)
//                {
//                    Console.WriteLine("murekkebdir");
//                    k = 1;
//                    break;
//                }
//            if (k == 0)
//            {
//                Console.WriteLine("sadedir");
//            }
//        }
//        else if (num < 0)
//        {
//            Console.WriteLine("eded menfidir");
//        }
//        else
//        {
//            Console.WriteLine("eded ne sade ne de murekkebdir");
//        }
//    }
//}

#endregion