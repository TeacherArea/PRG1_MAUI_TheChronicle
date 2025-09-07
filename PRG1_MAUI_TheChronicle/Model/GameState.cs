using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG1_MAUI_TheChronicle.Model
{
    public sealed class GameState
    {
        public int Score { get; set; }
        public HashSet<string> Inventory { get; } = new();
        public bool Has(string item) => Inventory.Contains(item);
    }
}
