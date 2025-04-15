using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LCBFS_Alg
{
    class LCBFSAlg
    {
        private Dothi dt;
        private Queue<int> q;
        private int[] pre;
        private int[] g;
        static readonly int NIL = -5;


        public LCBFSAlg()
        {
            dt = new Dothi();
            dt.readDothi();
            q = new Queue<int>();
            pre = new int[dt.Sodinh];
            g = new int[dt.Sodinh];

            for (int i = 0; i < dt.Sodinh; i++)
            {
                pre[i] = -2;
                g[i] = 0;
            }
            pre[dt.Start] = NIL;
            g[dt.Start] = 0;
            q.Enqueue(dt.Start);
        }

        public bool LCBFSsearch()
        {
            bool kq = false;
            while (q.Count > 0)
            {
                    int s = (int)q.Dequeue();
                    // Duyệt tất cả các trạng thái kề 
                    for (int s1 = 0; s1 < dt.Sodinh; s1++)
                    {
                        // Kiểm tra xem có đường đi từ s đến s1 không
                        if (dt.MaTran[s, s1] > 0)
                        {
                            // Chi phí
                            int cp = g[s] + dt.MaTran[s, s1];
                            // Nếu s1 chưa được gán nhãn HAY nếu g(s) + Cost(s,s1) < g(s1)
                            if (pre[s1] == -2 || cp < g[s1])
                            {
                                // Đặt previous(s1) := s
                                pre[s1] = s;
                                // Đặt g(s1) := g(s) + Cost(s,s1)
                                g[s1] = cp;
                                // Thêm s1 vào Vk+1 nếu chưa nằm trong queue
                                bool trongHangDoi = false;
                                foreach (int it in q)
                                {
                                    if (it == s1)
                                    {
                                        trongHangDoi = true;
                                        break;
                                    }
                                }
                                if (!trongHangDoi)
                                {
                                    q.Enqueue(s1);
                                }
                                // Kiểm tra nếu tìm thấy đích
                                if (s1 == dt.Goal)
                                {
                                    kq = true;
                                    // Không return ngay để tìm được đường đi tối ưu
                                }
                            }
                        }
                    }
       
            }
            return kq;
        }

        public void printG()
        {
            Console.WriteLine("Tong chi phi: {0}", g[dt.Goal]);
        }

        public void printDuongdi()
        {
            if (pre[dt.Goal] == -2)
                Console.WriteLine("KHONG tim duoc duong di ");
            else
            {
                int curr = dt.Goal;
                while (curr != dt.Start)
                {
                    Console.Write("{0}<== ", curr);
                    curr = pre[curr];
                }
                Console.WriteLine("{0} ", dt.Start);
            }
        }
    }
}
