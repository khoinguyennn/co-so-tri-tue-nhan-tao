using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UCS
{
    class Dothi
    {
        private int sodinh;
        private int start;
        private int goal;
        private int[,] matran;

        
        public Dothi()
        {
            this.Sodinh = -1;
            this.Start = -1;
            this.Matran = new int[12, 12];
            readDothi();
        }

        public void readDothi()
        {
            string textFile = @"D:\khoinguyen\UCS\UCS\UCSinput.txt";
            if (File.Exists(textFile))
            {
                string[] lines = File.ReadAllLines(textFile);
                string line0 = lines[0].Trim();
                this.Sodinh = Convert.ToInt16(line0);

                string line1 = lines[1].Trim();
                string[] tam = line1.Split(' ');
                this.Start = Convert.ToInt16(tam[0]);
                this.Goal = Convert.ToInt16(tam[1]);

                for (int i = 0; i < this.Sodinh; i++)
                {
                    string linei = lines[i + 2].Trim();
                    string[] arr = linei.Split(' ');
                    for (int j = 0; j < this.Sodinh; j++)
                    {
                        this.Matran[i, j] = Convert.ToInt32(arr[j]);
                    }
                }
            }
        }

        public void printDothi()
        {
            System.Console.WriteLine("So dinh: {0}", Sodinh);
            System.Console.WriteLine("Start: {0}; Goal: {1}", Start, Goal);
            for (int i = 0; i < Sodinh; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < this.Sodinh; j++)
                {
                    Console.Write(this.Matran[i, j] + " ");
                }
            }
        }


        public int Sodinh
        {
            get
            {
                return sodinh;
            }

            set
            {
                sodinh = value;
            }
        }

        public int Start
        {
            get
            {
                return start;
            }

            set
            {
                start = value;
            }
        }

        public int Goal
        {
            get
            {
                return goal;
            }

            set
            {
                goal = value;
            }
        }

        public int[,] Matran
        {
            get
            {
                return matran;
            }

            set
            {
                matran = value;
            }
        }
    }
}

