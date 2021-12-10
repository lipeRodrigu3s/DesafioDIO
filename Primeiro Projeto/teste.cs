using System;

namespace teste;
class teste
{
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode(int v)
    {
        int v = base.GetHashCode(v);
        return v;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
