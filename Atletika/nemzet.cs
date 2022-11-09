using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atletika
{
    internal class nemzet
    {

        readonly int id;
        readonly string onev;

        public int Id => id;

        public string Onev => onev;

        public nemzet(int id, string onev)
        {
            this.id = id;
            this.onev = onev;
        }

        public override string ToString()
        {
            return onev;
        }

    }
}
