using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG1_MAUI_TheChronicle.Model
{
    public sealed class Choice
    {
        public string Label { get; init; } = "";
        public string NextSceneId { get; init; } = "";
        public Func<GameState, bool>? IsVisibleWhen { get; init; }
        public Action<GameState>? Apply { get; init; }
    }
}
