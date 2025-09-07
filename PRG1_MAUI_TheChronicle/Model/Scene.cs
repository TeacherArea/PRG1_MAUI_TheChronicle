using System;
using System.Collections.Generic;

namespace PRG1_MAUI_TheChronicle.Model
{
    public sealed class Scene
    {
        public string Id { get; init; } = "";
        public string Text { get; init; } = "";
        public List<Choice> Choices { get; init; } = new();
    }
}
