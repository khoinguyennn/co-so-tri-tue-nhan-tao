using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCS
{
    class UCSAlg
    {
        private Dothi g;
        private HDUT OPEN;
        private Element[] CLOSE;
        private static readonly int NIL = -5;

        public UCSAlg()
        {
            g = new UCS.Dothi();
            OPEN = new HDUT();
            CLOSE = new Element[g.Sodinh];  // Khởi tạo mảng CLOSE với kích thước đúng

            // Khởi tạo tất cả phần tử trong mảng CLOSE
            for (int i = 0; i < g.Sodinh; i++)
            {
                CLOSE[i] = new Element();  // Khởi tạo mỗi phần tử trong mảng CLOSE
            }

            // Khởi tạo phần tử startElmt và thêm vào OPEN
            Element startElmt = new Element(g.Start, 0, NIL);
            OPEN.enQueue(startElmt);
        }

        public bool UCS_Search()
        {
            while (!OPEN.isEmpty())
            {
                Element X = OPEN.deQueue();

                // Nếu tìm đến Goal, trả về true
                if (X.Tendinh == g.Goal)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Tim duoc duong di!");
                    return true;
                }
                else
                {
                    // Duyệt tất cả các đỉnh kề
                    for (int J = 0; J < g.Sodinh; J++)
                    {
                        // Kiểm tra nếu có cạnh từ u đến v
                        if (g.Matran[X.Tendinh, J] > 0)
                        {
                           // Console.WriteLine("Dinh sau J={0}", J);
                            int newG = X.G + g.Matran[X.Tendinh, J];

                            // Nếu v chưa được duyệt hoặc tìm được đường đi ngắn hơn, cập nhật thông tin
                            if (CLOSE[J].Pre == -2 || newG < CLOSE[J].G)
                            {
                                Element e = new Element(J, newG, X.Tendinh);
                                OPEN.enQueue(e);
                                CLOSE[J] = e;  // Cập nhật CLOSE[v]
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Không tìm được đường đi.");
            return false;
        }

        public void printDuongdi()
        {
            Console.WriteLine("Tong chi phi: = {0}", CLOSE[g.Goal].G);
            // Kiểm tra xem Goal có được duyệt chưa (nếu chưa thì không tìm được đường đi)
            if (CLOSE[g.Goal].Pre == -2)
            {
                Console.WriteLine("Khong tim duoc duong di");
                return;
            }

            // In đường đi từ Goal về Start
            int CURR = g.Goal;
            Console.WriteLine();
            while (CURR != g.Start)
            {
                Console.Write("{0} <= ", CURR);
                CURR = CLOSE[CURR].Pre;
            }
            Console.WriteLine("{0}", g.Start);  // In Start sau cùng
            Console.ReadLine(); 
        }



    }
}
