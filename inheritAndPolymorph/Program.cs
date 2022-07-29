using System;

namespace inheritAndPolymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkItem myWI1 = new ChangeItem();
            WorkItem myWI2 = new ChangeRequest ();
        }
    }
}
