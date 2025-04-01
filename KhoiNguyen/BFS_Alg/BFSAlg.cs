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
            bool kq = false;
            while (!q.Contains(dt.Goal) && q.Count > 0)
            {
                while (!q.Contains(dt.Goal) && (q.Count) > 0)
                {
                    int u = (int)q.Dequeue();
                    for (int v = 0; v < dt.Sodinh; v++)
                    {
                        if (dt.MaTran[u, v] == 1 && pre[v] == -2) //Nếu u,v có đường đi và v chưa được đánh dấu
                        {
                            pre[v] = u;
                            q.Enqueue(v);
                        }
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
