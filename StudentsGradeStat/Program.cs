using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGradeStat
{
    class Program
    {
        public struct GRADESTATE
        {
            public int A;
            public int B;
            public int C;
            public int D;
            public int E;
        };//结构体初始化做的不太好
        static void Main(string[] args)
        {
            int intAcountStudent;
            int[] intGrade = new int[100];
            GRADESTATE gradeState = new GRADESTATE();

            //接收班级总人数
            Console.Write("请输入班级人数：students = ");
            intAcountStudent = Int32.Parse(Console.ReadLine());

            //输入成绩
            for (int i = 1; i <= intAcountStudent; i++)
            {
                Console.WriteLine("请输入第{0}个成绩", i);
                intGrade[i - 1] = Int32.Parse(Console.ReadLine());
            }

            //统计
            int maxScore = intGrade[0];
            int minScore = intGrade[0];
            for (int j = 0; j < intAcountStudent; j++)
            {
                if (maxScore < intGrade[j])
                {
                    maxScore = intGrade[j];
                }
                if (minScore > intGrade[j])
                {
                    minScore = intGrade[j];
                }
                if (intGrade[j] >= 0 && intGrade[j] <= 30)
                {
                    gradeState.E++;
                }
                if (intGrade[j] >= 31 && intGrade[j] <= 59)
                {
                    gradeState.D++;
                }
                if (intGrade[j] >= 60 && intGrade[j] <= 79)
                {
                    gradeState.C++;
                }
                if (intGrade[j] >= 80 && intGrade[j] <= 89)
                {
                    gradeState.B++;
                }
                if (intGrade[j] >= 90 && intGrade[j] <= 100)
                {
                    gradeState.A++;
                }
            }
                  
            Console.WriteLine("共{0,2:d}人，其中最大成绩{1,2:d},最小成绩{2,2:d}", intAcountStudent, maxScore, minScore);
            Console.WriteLine("成绩区间 0~30 的总人数有{0,2:d}人，占比为{1:f2}%", gradeState.E, (double)gradeState.E / intAcountStudent * 100);
            Console.WriteLine("成绩区间 31~59 的总人数有{0,2:d}人，占比为{1:f2}%", gradeState.D, (double)gradeState.D / intAcountStudent * 100);
            Console.WriteLine("成绩区间 60~79 的总人数有{0,2:d}人，占比为{1:f2}%", gradeState.C, (double)gradeState.C / intAcountStudent * 100);
            Console.WriteLine("成绩区间 80~89 的总人数有{0,2:d}人，占比为{1:f2}%", gradeState.B, (double)gradeState.B / intAcountStudent * 100);
            Console.WriteLine("成绩区间 90~100 的总人数有{0,2:d}人，占比为{1:f2}%", gradeState.A, gradeState.A * 100.0 / intAcountStudent );
            Console.ReadLine();
        }
    }
}
