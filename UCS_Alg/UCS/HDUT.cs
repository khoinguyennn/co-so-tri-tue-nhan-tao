using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCS
{
    class HDUT
    {
        private int front;
        private int rear;
        private int noItems;
        private Element[] arr;
        static readonly int MAX = 1000;

        public HDUT()
        {
            this.front = -1;
            this.rear = -1;
            this.noItems = 0;
            this.arr = new Element[MAX];
        }

        public void enQueue(Element x)
        {
            if (this.noItems == MAX)
                this.rear = 0;
            else
                this.rear++;

            this.arr[rear] = x;
            this.noItems++;
        }

        public Element deQueue()
        {
           // Element elmt = new Element(0, 0, -5);
            if (noItems == 0)
                throw new InvalidOperationException("Hang doi rong");

            // Tìm phần tử có G nhỏ nhất
            int PTNhoNhat = front + 1;
            for (int i = front + 1; i <= rear; i++)
            {
                if (arr[i].G < arr[PTNhoNhat].G)
                {
                    PTNhoNhat = i;
                }
            }

            // Đổi chỗ phần tử nhỏ nhất lên đầu hàng đợi
            Element tam = arr[front + 1];
            arr[front + 1] = arr[PTNhoNhat];
            arr[PTNhoNhat] = tam;

            // Lấy phần tử đầu hàng đợi ra
            Element result = arr[++front];
            noItems--;

            return result;
        }

        public void printHangdoi()
        {
            if (isEmpty())
            {
                Console.WriteLine("Hang doi rong.");
                return;
            }

            Console.WriteLine("Cac phan tu trong hang doi:");

            for (int i = front + 1; i <= rear; i++)
            {
                arr[i].printElmt();
                Console.WriteLine(); // In mỗi phần tử trên một dòng cho rõ
            }
        }


        public bool isEmpty()
        {
            if (this.noItems == 0)
                return true;
            else
                return false;
        }

        public bool isNull()
        {
            if (this.noItems == MAX)
                return true;
            else
                return false;
        }
    }
}
