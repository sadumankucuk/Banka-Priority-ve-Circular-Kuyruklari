using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public interface Queue
    {
        void Insert(Musteri o);
        object Remove();
        object Peek();
        Boolean IsEmpty();
        decimal islemTS(decimal islemSuresi);
        decimal OrtamalaITS();
        string Listele();
    }
}
