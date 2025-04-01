using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_Alg
{
    class BFSAlg
    {
        private Dothi dt;
        private Queue<int> q;

        private int[] pre;
        static readonly int NIL = -5;


        public BFSAlg()
        {
            dt = new Dothi();
            dt.readDothi();
            q = new Queue<int>();
            pre = new int[dt.Sodinh];

            for (int i = 0; i < dt.Sodinh; i++)
            {
                pre[i] = -2;
            }
            pre[dt.Start] = NIL;
            q.Enqueue(dt.Start);
        }

        public void BFSsearch()
        {
            bool co = false;
            while (!q.Contains(dt.Goal) && q.Count > 0)
            {
                // Duyệt qua tất cả các trạng thái trong hàng đợi q (tức là V_k)
                int current = (int)q.Dequeue();  // Lấy trạng thái hiện tại từ hàng đợi

                // Duyệt qua tất cả các trạng thái kế tiếp của trạng thái current
                foreach (int next in dt.succs(current))  // dt.succs(current) trả về các trạng thái kế tiếp của current
                {
                    if (pre[next] == -2)  // Nếu trạng thái next chưa được thăm
                    {
                        pre[next] = current;  // Gán previous[next] = current
                        q.Enqueue(next);  // Thêm trạng thái next vào hàng đợi
                    }
                }

            }

        }

        public void printDuongdi()
        {
            if (pre[dt.Goal] == -2)
                Console.WriteLine("\n KHONG tim duoc duong di");
            else
            {
                int curr = dt.Goal;
                while (curr != dt.Start)
                {
                    Console.Write("{0}<== ", curr);
                    curr = pre[curr];
                }
                Console.Write("{0} ", dt.Start);
            }
        }

    }
}
