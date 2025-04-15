using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LCBFS_Alg
{
    class Dothi
    {
        private int sodinh; //Số đỉnh của dồ thị
        private int start; //Đỉnh bắt đầu
        private int goal; //Đỉnh kết thúc
        private int[,] matran; //Ma trận trọng số

        public Dothi()
        {
            this.sodinh = -1;
            this.start = -1;
            this.matran = new int[12, 12]; 
            readDothi(); //Gọi phương thức đọc file .txt
        }

        public void readDothi() //Đọc file từ ổ đĩa
        {
            string textFile = @"D:\khoinguyen\LCBFS_Alg\LCBFSinput.txt";
            if (File.Exists(textFile))
            {
                //Đọc tập tin dữ liệu theo từng dòng
                //Mỗi dòng lưu vào mảng line[]
                string[] lines = File.ReadAllLines(textFile);
                string line0 = lines[0].Trim();  //Dòng thứ nhất cho biết số đỉnh
                this.sodinh = Convert.ToInt32(line0);  //Chuyển kiểu dữ liệu

                string line1 = lines[1].Trim();
                string[] tam = line1.Split(' ');
                this.start = Convert.ToInt32(tam[0]); //Dòng thứ 2 cho biết đỉnh Start và Goal
                this.goal = Convert.ToInt32(tam[1]);

                for (int i = 0; i < this.sodinh; i++)  //Dòng thứ 3 trở về sau cho biết ma trận kề
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


        public void printDothi() //Hiển thị nội dung đã đọc hoặc nội dung của đồ thị
        {
            System.Console.WriteLine("So dinh: {0}", sodinh);
            System.Console.WriteLine("Start: {0}; Goal: {1}", start, goal);
            for (int i = 0; i < this.sodinh; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < this.sodinh; j++)
                    Console.Write(this.matran[i, j] + " ");
            }
            Console.WriteLine("\n");

        }


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
