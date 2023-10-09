namespace ClassTasks2_method_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Resadinderecesi = 0;
            int Aydaninderecesi = 0;

            for(int i = 0;i <4;i++)
            {
                Console.Write("Resadin xalini daxil edin");
                int Resadinxali = int .Parse(Console.ReadLine());
                Console.Write("Aydan xalini daxil edin");
                int Aydaninxali = int.Parse(Console.ReadLine());
                int Results = GetCompetition(Resadinxali, Aydaninxali,ref Resadinderecesi, ref Aydaninderecesi);

                Console.WriteLine(Results);
            }
        }


        public static int GetCompetition(int num1,int num2,ref int num3, ref int num4)
        {
            if(num1 > num2)
            {
                num3 += 1;
                return num3;

            }

            else if (num1 < num2)
            {
                num4 += 1;
            }
            return num4;
        }
    }
}