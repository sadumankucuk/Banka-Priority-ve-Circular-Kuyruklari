using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class PriorityArrayTypedQueueBK : Queue
    {
        public object[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;
        public decimal toplamSure = 0;
        public PriorityArrayTypedQueueBK(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(Musteri o)
        {
            if (count == size)
                throw new Exception("queue dolu");
            if (IsEmpty())
            {
                Queue[++front] = o;
                count++;
            }
            else
            {
                int i;
                Musteri m = (Musteri)o;
                for (i = count-1; i >=0; i--)
                {
                    //Büyükten küçüğe sıralama
                    if (m.IslemSuresi > ((Musteri)Queue[i]).IslemSuresi)
                        Queue[i + 1] = Queue[i];
                    else
                        break;
                }
                Queue[i + 1] = o;
                front++;
                count++;
            }
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
            Object temp = Queue[front];
            Queue[front] =null;
            front--;
            count--;
            return temp;
        }
    }
}
