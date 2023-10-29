
#region Task1 
//Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//Console.WriteLine(CheckDivision(105));
//string CheckDivision(int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        return "bolunur";
//    }
//    return "bolunmur";
//}


//int num = int.Parse(Console.ReadLine());
//if (num%3==0 && num%7==0)
//{
//    Console.WriteLine("bolunur");
//}
//else
//{
//    Console.WriteLine("bolunmur");
//}

#endregion

#region Task2 
//n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//Console.WriteLine(Sum(22, 26));
//int Sum(int n, int m)
//{
//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        return n + m;
//    }
//    return 0;
//}


//int n=int.Parse(Console.ReadLine());
//int m=int.Parse(Console.ReadLine());
//int sum = 0;
//if (n%2==0 && m%2==0)
//{
//    sum = n + m;
//    Console.WriteLine(sum);
//}
//else
//{
//    Console.WriteLine("ikisi ve ya ikisinden biri tek ededdir...");
//}

#endregion

#region Task3
//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin

//Console.WriteLine(CountOddNum(6, 15));
//int CountOddNum(int n, int m)
//{
//    int count = 0;
//    for (int i = n; i <= m; i++)
//        if (i % 2 == 1)
//        {
//            return count++;
//        }
//    return 0;
//}


//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());
//int count = 0;
//for (int i=n; i<=m; i++)
//{
//    if (i%2==1)
//    { 
//        count++; 
//    }   
//}
//Console.WriteLine(count);


#endregion

#region Task4
//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.


using System.ComponentModel.Design;

int SumOddNum(int n, int m)
{
    int sum = 0;
    for (int i = n; i <= m; i++)
    {
        if (i%2 == 1)
            return sum+=i;
    }
    return 0;
}



//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i=n; i<=m;i++)
//{
//    if(i%2==1) 
//    { 
//        sum+=i;
//    }
//}
//Console.WriteLine(sum);

#endregion