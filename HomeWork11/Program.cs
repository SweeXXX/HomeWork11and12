using HomeWork;
using HomeWork11.Classes;
using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Home
{
    class Program
    {
        static string[]? TakeText(string p2)
        {
            try
            {

                //StreamWriter writer = new StreamWriter(p1, true);
                StreamReader reader = new StreamReader(p2);
                string[] t = reader.ReadToEnd().Replace(" ", "").Split("\n");
                //writer.WriteLine(t);
                //Console.WriteLine(n);
                //writer.Close();
                reader.Close();
                return t;
            }
            catch
            {
                Console.WriteLine("Чел, ты кринж, реальна..");
                return null;
            }

        }
        static void WriteText(string p1, string text)
        {
            try
            {

                StreamWriter writer = new StreamWriter(p1, true);
                writer.WriteLine(text);
                //Console.WriteLine(n);
                writer.Close();
            }
            catch
            {
                Console.WriteLine("Чел, ты кринж, реальна..");
            }

        }
        static bool CheackGroup(List<Student> groups, int count)
        {
            HashSet<string> groupSet = new HashSet<string>();
            foreach(var group in groups)
            {
                groupSet.Add(group.GetNumberOfGroup);
            }
            if (groupSet.Count >= count)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Creator CA = new CreateActive("Активчик ;)");
            //var file = new FileInfo("TextFile1.txt");
            string path = "Сюда пишем на.txt";
            string fullPath = Path.GetFullPath(path);
            //Console.WriteLine(fullPath);
            //C:\Users\Никита\Desktop\fakk\HomeWork11\HomeWork11\Text\TextFile1.txt
            //Console.WriteLine(file.DirectoryName);
            string[] t = TakeText(@"C:\Users\Никита\Desktop\fakk\HomeWork11\HomeWork11\TextFile1.txt");
            string[] t1 = t[1].Split(",");
            string[] t2 = t[2].Split(",");
            string[] t3 = t[3].Split(",");
            string[] t4 = t[4].Split(",");
            string[] t5 = t[5].Split(",");
            string[] t6 = t[6].Split(",");
            string[] t7 = t[7].Split(",");
            string[] t8 = t[8].Split(",");
            List<Student> students = new List<Student>();
            Student Nikita = CA.CreateStudent(t1[0], t1[1]); students.Add(Nikita);
            Student Vitaliy = CA.CreateStudent(t2[0], t2[1]); students.Add(Vitaliy);
            Student Samira = CA.CreateStudent(t3[0], t3[1]); students.Add(Samira);
            Student Adelina = CA.CreateStudent(t4[0], t4[1]); students.Add(Adelina);//4
            Student Mariam = CA.CreateStudent(t5[0], t5[1]); students.Add(Mariam);
            Student Victoria = CA.CreateStudent(t6[0], t6[1]); students.Add(Victoria);

            CA = new CreatePassive("Пассивчик)))");//Меняю создателя)
            Student Oleg = CA.CreateStudent(t7[0], t7[1]); students.Add(Oleg);
            Student Maksim = CA.CreateStudent(t8[0], t8[1]); students.Add(Maksim);//8
            //students.Reverse();
            string[] TPol = TakeText($@".\..\..\{fullPath}");
            int countS = int.Parse(TPol[0].Replace(" ", "").Split(",")[2]);
            int countG = int.Parse(TPol[0].Replace(" ", "").Split(",")[3]);
            int countA = 0;
            int half = 3;//то, на сколько делим количество участников
            int HH = countS / half;

            students.Remove(students.First());
            
            if(CheackGroup(students, countG))
            {
                foreach (var st in students)
                {
                    if (st.GetPorA == "A" && countS > 0 && HH > 0)
                    {
                        WriteText(@"C:\Users\Никита\Desktop\fakk\HomeWork11\HomeWork11\Сюда пишем на.txt", st.GetTitle);

                        countA++;
                        countS--;
                        HH--;
                    }

                    if (st.GetPorA == "P" && countS > 0)
                    {
                        WriteText(@"C:\Users\Никита\Desktop\fakk\HomeWork11\HomeWork11\Сюда пишем на.txt", st.GetTitle);
                        countS--;
                    }
                }
            }
            else
            {
                Console.WriteLine("У нас не хватает групп((");
            }
            
        }
    }

}