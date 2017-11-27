using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class TurgutluBankasi
    {
        public CircularArrayTypedQueue c = new CircularArrayTypedQueue(20);
        public PriorityArrayTypedQueueKB p = new PriorityArrayTypedQueueKB(20);
        public PriorityArrayTypedQueueBK p2 = new PriorityArrayTypedQueueBK(20);
        Random r = new Random();
        public TurgutluBankasi()
        {
            for (int i = 0; i < 20; i++)
            {
                Musteri m = new Musteri();
                m.MusteriNo = i + 1;
                m.IslemSuresi = r.Next(60, 600);
                c.Insert(m);
                p.Insert(m);
                p2.Insert(m);
            }
        }
        public string KisalanSüreleriBul1()
        {
            string temp = "";
            c.toplamSure = 0;
            for (int i = 0; i < 20; i++)
            {
                p.toplamSure = 0;
                decimal circularToplamSure = c.islemTS(((Musteri)c.Queue[i]).IslemSuresi);
                for (int j = 0; j < 20; j++)
                {
                    decimal priorityToplamSure = p.islemTS(((Musteri)p.Queue[j]).IslemSuresi);
                    if (((Musteri)p.Queue[j]).MusteriNo==i+1)
                    {
                        if(circularToplamSure>priorityToplamSure)
                        {
                            temp += temp += "Müşteri no :             " + ((Musteri)p.Queue[j]).MusteriNo.ToString() +
                                           Environment.NewLine + "İşlem süresi :           " + ((Musteri)p.Queue[j]).IslemSuresi.ToString() + " sn." +
                                           Environment.NewLine + "Kazanç (fark) :        " + (circularToplamSure - priorityToplamSure).ToString() +
                                           Environment.NewLine + "Kazanç (yüzde) :      " + String.Format("{0:0.00}", ((priorityToplamSure * 100) / circularToplamSure)) +
                                           Environment.NewLine + Environment.NewLine;
                        }
                        break;
                    }

                }
            }
            return temp;
        }
        public string KisalanSüreleriBul2()
        {
            string temp = "";
            c.toplamSure = 0;
            for (int i = 0; i < 20; i++)
            {
                p2.toplamSure = 0;
                decimal circularToplamSure = c.islemTS(((Musteri)c.Queue[i]).IslemSuresi);
                for (int j = 0; j < 20; j++)
                {
                    decimal priority2ToplamSure = p2.islemTS(((Musteri)p2.Queue[j]).IslemSuresi);
                    if (((Musteri)p2.Queue[j]).MusteriNo == i + 1)
                    {
                        if(circularToplamSure>priority2ToplamSure)
                        {
                            temp += temp += "Müşteri no :             " + ((Musteri)p2.Queue[j]).MusteriNo.ToString() +
                                          Environment.NewLine + "İşlem süresi :           " + ((Musteri)p2.Queue[j]).IslemSuresi.ToString() + " sn." +
                                          Environment.NewLine + "Kazanç (fark) :        " + (circularToplamSure - priority2ToplamSure).ToString() +
                                          Environment.NewLine + "Kazanç (yüzde) :      " + String.Format("{0:0.00}", ((priority2ToplamSure * 100) / circularToplamSure)) +
                                          Environment.NewLine + Environment.NewLine;
                        }
                        break;
                    }


                }
            }
            return temp;
        }
    }
}
