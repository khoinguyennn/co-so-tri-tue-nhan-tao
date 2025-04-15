using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BFS_Alg
{
    class Dothi
    {
        private int i;
        private int j;
        private List<int> ke;
        private int sodinh;
        private int start;
        private int goal;
        private int[,] matran;


        public Dothi()
        {
            this.sodinh = -1;
            this.start = -1;
            this.matran = new int[7, 7];
            this.ke = new List<int>();
            readDothi();
        }


        public void readDothi()
        {
            string textFile = @"D:\khoinguyen\BFS_Alg\BFSinput.txt";
            if (File.Exists(textFile))
            {
                string[] lines = File.ReadAllLines(textFile);
                string line0 = lines[0].Trim();
                this.sodinh = Convert.ToInt32(line0);

                string line1 = lines[1].Trim();
                string[] tam = line1.Split(' ');
                this.start = Convert.ToInt32(tam[0]);
                this.goal = Convert.ToInt32(tam[1]);

                for (int i = 0; i < this.sodinh; i++)
                {
                    string linei = lines[i + 2].Trim();
                    string[] arr = linei.Split(' ');
                    for (int j = 0; j < this.sodinh; j++)
                    {
                        this.matran[i, j] = Convert.ToInt32(arr[j]);
                        //Console.Write(matran[i,j] + " ");
                    }
                    //Console.WriteLine();
                }
            }
        }

        public void printDothi()
        {
            System.Console.WriteLine("So dinh: {0}", sodinh);
            System.Console.WriteLine("Start: {0}; Goal: {1}", start, goal);
            for(int i = 0; i < this.sodinh; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < this.sodinh; j++)
                    Console.Write(this.matran[i, j] + " ");          
            }
            Console.WriteLine("\n");

        }

        // Phương thức trả về các đỉnh kề (succs) của một đỉnh cho trước
        /*public IEnumerable<int> succs(int s)
        {
            List<int> result = new List<int>();

            // Duyệt qua tất cả các cột trong dòng s (tìm các đỉnh kề)
            for (int j = 0; j < sodinh; j++)
            {
                if (matran[s, j] == 1)  // Kiểm tra nếu có cạnh từ s đến j
                {
                    result.Add(j);  // Thêm đỉnh j vào danh sách các đỉnh kề
                }
            }

            return result;
        }*/

        /*public List<int> succs(int s)
        {
            for (i = 0; i < this.sodinh; i++)
            {
                if (matran[s, i] == 1)
                {
                    ke.Add(i);
                }
            }
            return ke;
        }
        *
        */


        public int Sodinh
        {
            get { return sodinh; }
            set { sodinh = value; }
        }

        public int Start
        {
            get { return start; }
            set { start = value; }
        }

        public int Goal
        {
            get { return goal; }
            set { goal = value; }
        }

        public int[,] MaTran
        {
            get { return matran; }
            set { matran = value; }
        }


    }


}
