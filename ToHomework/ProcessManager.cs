using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ToHomework
{
    class ProcessManager
    {
        private int Cheker(Program[] a, int id)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Id == id)
                {
                    Console.WriteLine($"ID процесса {a[i].Id}   {a[i].Name} ");
                    return i;
                }
            }
            return -1;
        }
        private void Escape(Program[] a, int b, int i)
        {
            switch (i)
            {
                case 1:
                    Process[] kill1 = Process.GetProcessesByName(a[b].Name);
                    foreach (Process worker in kill1)
                    {
                        worker.Kill();
                    }
                    break;
                case 2:
                    Process[] kill2 = Process.GetProcessesByName(a[b].Name);
                    foreach (Process worker in kill2)
                    {
                        worker.CloseMainWindow();
                    }
                    break;
            }
        }

        public void RunProcess()
        {
            Program[] ProgramMass = new Program[Process.GetProcesses().Length];
            int a = 0;
            foreach (Process pro in Process.GetProcesses())
            {
                ProgramMass[a] = new Program(pro.Id, pro.ProcessName);
                a++;
            }
            for (int i = 0; i < ProgramMass.Length; i++)
            {
                Console.WriteLine($"ID процесса {ProgramMass[i].Id}   {ProgramMass[i].Name} ");
            }
            Console.Write("ID процесса = ");
            int id = Convert.ToInt32(Console.ReadLine());

            int innum = Cheker(ProgramMass, id);
            if (innum == -1) Console.WriteLine("ID несуществует");
            Console.Write("завершить процесс жестко - 1 / просто закрыть - 1 ");
            int exit = Convert.ToInt32(Console.ReadLine());
            Escape(ProgramMass, innum, exit);
            Console.ReadKey();
        }
    }
}