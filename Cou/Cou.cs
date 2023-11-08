using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonno.Cou;
public readonly struct Cou<L, R>
{
    readonly L _l;
    readonly R _r;

    public Cou(L l, R r)
    {
        _l = l;
        _r = r;
    }

    public void Deconstruct(out L l, out R r)
    {
        l = _l;
        r = _r;
    }
}
