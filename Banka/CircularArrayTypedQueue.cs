using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class CircularArrayTypedQueue : Queue
    {
        public object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public decimal toplamSure = 0;
        public CircularArrayTypedQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(Musteri o)
        {
            if (count == size)
                throw new Exception("queue dolu");
            if (front == -1)
                front = 0;
            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = o;
            }
            else
                Queue[++rear] = o;
            count++;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public decimal islemTS(decimal islemSuresi)
        {
            return toplamSure += islemSuresi;
        }

        public string Listele()
        {
            string temp = "";
            for (int i = 0; i < 20; i++)
            {
                temp += "Müşteri no :             " + ((Musteri)Queue[i]).MusteriNo.ToString() + Environment.NewLine + "İşlem süresi :           " + 
                        ((Musteri)Queue[i]).IslemSuresi.ToString() + " sn." + Environment.NewLine + "İşinin bitme süresi :  " + 
                        islemTS(((Musteri)Queue[i]).IslemSuresi) + " sn." + Environment.NewLine + Environment.NewLine;
            }
            return temp;
        }

        public decimal OrtamalaITS()
        {

            return toplamSure / 20;
        }

        public object Peek()
        {
            return Queue[front];
        }

        public object Remove()
        {
            if (IsEmpty())
                throw new Exception("queue boş");
            object temp = Queue[front];
            Queue[front] = null;
            if (front == size - 1)
                front = 0;
            else
                front++;
            count--;
            return temp;
            
        }
    }
}
