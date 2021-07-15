using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamilton_Tevin_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tevin Hamilton 
             *  05/25/2018
             * Final Project
             * */
            Console.Clear();
            Console.WriteLine("Welcome new user to the program count the calories,\r\ntoday we will calulate your calories and find out if your over or not\r\n\r\nHow Many meals have you eaten today");
            string userMealsString = Console.ReadLine();
            int userMeals;
            while (!(int.TryParse(userMealsString, out userMeals)))
            {
                Console.WriteLine("\r\nPlease don't leave this blank\r\n");
                userMealsString = Console.ReadLine();
            }
            int[] cal = GetCalories(userMeals);
            int caloriesTotal = TotalCalories(cal);

            Console.WriteLine("How Many calories are you trying to eat in a day");
            string userCalDayString = Console.ReadLine();
            int userCalDay;
            while (!(int.TryParse(userCalDayString, out userCalDay)))
            {
                Console.WriteLine("please dont leave blank\r\nHow Many calories are you trying to eat in a day\r\n");
                userCalDayString = Console.ReadLine();
            }
            int userDifference = CaloriesLeft(userCalDay, caloriesTotal);
            if (userCalDay < caloriesTotal)
            {
                Console.WriteLine($"you have over eaten by {userDifference} calories today ");
            }
            else if (userCalDay>caloriesTotal)
            {
                Console.WriteLine($"you still have {userDifference} left to consume today");
            }
            /*test test test
             * meals 3 
             * meal 1= 800
             * meal 2 = 1000
             * meal 3 =1200
             * calories they want to consume 2500
             * final output = you have over eaten by 500 calories today 
             * */


        }
        public static int[] GetCalories(int um)
        {
            int numMeals = 1;
            int[] userCalories = new int[um];
            for (int i = 0; i < um; i++)
            {
                Console.WriteLine($"How many calories were in meal #{numMeals++}");
                string userNumCal = Console.ReadLine();
                while (!(int.TryParse(userNumCal, out userCalories[i])))
                {
                    Console.WriteLine("please don't leave blank\r\nHow many calories were in your meal\r\n");
                    userNumCal = Console.ReadLine();
                }
                
            }
            return userCalories;
        }
        public static int TotalCalories(int[] ca)
        {
            int calTotal = 0;
            for (int i = 0; i < ca.Length; i++)
            {
                calTotal+= ca[i];
            }
            return calTotal;
        }
        public static int CaloriesLeft(int ud, int ct)
        {
            if (ud<ct)
            {
                int calMath1 = ct - ud;
                return calMath1;
            }
            else
            {
                int calmath2 = ud - ct;
                return calmath2;
            } 
        }
    }
}
