using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BookunCocugu : Books
{
    private int _sayfaSayisi;

    public int SayfaSayisi
    {
        get { return _sayfaSayisi; }
        set { _sayfaSayisi = value; }
    }
}
