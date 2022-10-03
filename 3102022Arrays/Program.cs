using _3102022Arrays;
using System;

namespace f
{

    class Program
    {

        static void Main(String[] args)
        {

// main part task 1
            List<int> list = new List<int>();
            GenerateNum(-5, 20, 20, list);
            list.ForEach(num => Console.WriteLine(num + ", "));
            Console.WriteLine(String.Format("Median {0}", GetArithmeticMed(list).ToString()));
            Console.WriteLine(String.Format("Smallest number {0}", GetSmallest(list).ToString()));
            Console.WriteLine(String.Format("Subdividable by 2 : {0}",Subdividable(list,2)));

            // main part task 2

            List<User> users_test = new List<User>();
            users_test.Add(new User("Dm23", "31fa24521"));
            users_test.Add(new User("Adam", "3124521"));
            users_test.Add(new User("Lis", "313212222"));
            users_test.Sort();
            users_test.ForEach(user => Console.WriteLine(user.ToString()));

            // methods part task 1
            void GenerateNum(int start, int end, int amount, List<int> list)
            {
                for (int i = 1; i < amount; i++)
                {
                    Random rand = new Random();
                    int num = rand.Next(end) + start;
                    list.Add(num);
                }
            }

            double GetArithmeticMed(List<int> list)
            {
                double result = 0;
                int sum = 0;

                for (int i = 0; i < list.Count; i++)
                {
                    sum = sum + list[i];
                }

                result = sum / list.Count;
                return result;
            }

            int GetSmallest(List<int> list)
            {
                int result = list[0];
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] < result)
                    {
                        result = list[i];
                    }
                }
                return result;
            }

            int Subdividable(List<int> list, int dividing)
            {
                int result = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % dividing == 0)
                    {
                        result++;
                    }
                }
                return result;
            }

             

        }

        private static object GetArithmeticMed()
        {
            throw new NotImplementedException();
        }
    }
}