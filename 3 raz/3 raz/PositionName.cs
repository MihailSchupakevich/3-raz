using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_raz
{
    internal class PositionName
    {
        int PositionId;
        String Name;

        public void setAll(int PositionId, String Name)
        {
            this.PositionId = PositionId; this.Name = Name;
        }
    }
}
