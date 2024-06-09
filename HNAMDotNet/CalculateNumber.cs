using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet
{
    public class CalculateNumber
    {
        public int Add(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        public int Sub(int Num1, int Num2) { return Num1 - Num2; }

        public int Div(int Num1, int Num2) { return Num1 / Num2; }

        public int Rem(int Num1, int Num2) { return Num1 % Num2; }

        public string ConcatString(string str1, string str2) { return str1 + str2; }

        public string SplitString(string str1)
        {
            try
            {
                //hello,world
                string[] str = str1.Split(",");
                string str3 = string.Empty;
                //foreach (string str2 in str)
                //{
                //    str3 += str2;
                //}
                for (int i = 0; i < str.Length; i++)
                {
                    str3 += str[i];
                }
                return str3;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public string CalculateGrade(int mark)
        {
            try
            {
                string grade = string.Empty;
                if (mark >= 81 && mark <= 100)
                {
                    grade = "grade a";
                }
                else if (mark >= 61 && mark <= 80)
                {
                    grade = "grade b";
                }
                else
                {
                    grade = "grade c";
                }
                return grade;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public string CalculateMark(string grade)
        {
            try
            {
                string mark = string.Empty;
                switch (grade)
                {
                    case "A":
                        mark = "This scores are between 81 and 100";
                        break;
                    case "B":
                        mark = "This scores are between 61 and 80";
                        break;
                    case "C":
                        mark = "This scores are between 40 and 60";
                        break;
                    default:
                        break;
                }
                return mark;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        public void LoopingExp()
        {
            int i = 1;
            while (i < 5)
            {
                if (i == 3)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;

            }
        }

        public void ArraySorting()
        {
            int[,] num = { { 10, 9, 8, 7, 6 }, { 5, 4, 3, 2, 1 }, {11,12,13,14,15 } };
            Console.WriteLine(num[2,2]);
        }
    }
}

