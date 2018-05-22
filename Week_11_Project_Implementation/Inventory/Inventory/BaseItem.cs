using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    abstract class BaseItem
    {
        int strength { get; set; }
        int stamina { get; set; }
        int intellect { get; set; }
        int agility { get; set; }
    }
}
