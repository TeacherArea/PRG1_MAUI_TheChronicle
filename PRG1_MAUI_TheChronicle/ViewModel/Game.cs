using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PRG1_MAUI_TheChronicle.Model;

namespace PRG1_MAUI_TheChronicle.ViewModel
{
    public sealed class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        private readonly Dictionary<string, Scene> _scenes;
        public GameState State { get; } = new();

        private string _currentSceneId = "start";
        public string CurrentSceneId
        {
            get => _currentSceneId;
            set
            {
                if (_currentSceneId == value) return;
                _currentSceneId = value;
                // Talar om för UI:t att relevanta egenskaper ändrats
                OnPropertyChanged(nameof(CurrentScene));
                OnPropertyChanged(nameof(VisibleChoices));
                OnPropertyChanged(nameof(Score));
                OnPropertyChanged(nameof(InventoryDisplay));
            }
        }

        // binding
        public Scene CurrentScene => _scenes[CurrentSceneId];
        public  IEnumerable<Choice> VisibleChoices =>
            CurrentScene.Choices.Where(c => c.IsVisibleWhen?.Invoke(State) ?? true);

        public int Score => State.Score;
        public string InventoryDisplay => State.Inventory.Count == 0
            ? "Inventory: (tomt)"
            : "Inventory: " + string.Join(", ", State.Inventory);

        public ICommand ChooseCommand { get; }

        public Game()
        {
            _scenes = BuildScenes();

            ChooseCommand = new Command<Choice>(choice =>
            {
                choice.Apply?.Invoke(State);
                CurrentSceneId = choice.NextSceneId;
                OnPropertyChanged(nameof(Score));
                OnPropertyChanged(nameof(InventoryDisplay));
                OnPropertyChanged(nameof(VisibleChoices));
            });
        }

        private static Dictionary<string, Scene> BuildScenes()
        {
            var dict = new Dictionary<string, Scene>();

            dict["start"] = new Scene
            {
                Id = "start",
                Text = "Du står vid en port. Ett mynt ligger på marken.",
                Choices = new()
            {
                new Choice {
                    Label = "Plocka upp mynt",
                    NextSceneId = "port",
                    Apply = s => s.Inventory.Add("mynt")
                },
                new Choice {
                    Label = "Ignorera och gå till porten",
                    NextSceneId = "port"
                }
            }
            };

            dict["port"] = new Scene
            {
                Id = "port",
                Text = "Porten är låst. En försäljare erbjuder en nyckel för 1 poäng.",
                Choices = new()
            {
                new Choice {
                    Label = "Växla in mynt mot 1 poäng",
                    NextSceneId = "port",
                    IsVisibleWhen = s => s.Has("mynt"),
                    Apply = s => { s.Inventory.Remove("mynt"); s.Score += 1; }
                },
                new Choice {
                    Label = "Köp nyckel (kräver 1 poäng)",
                    NextSceneId = "hall",
                    IsVisibleWhen = s => s.Score >= 1,
                    Apply = s => s.Score -= 1
                },
                new Choice {
                    Label = "Gå därifrån",
                    NextSceneId = "slut"
                }
            }
            };

            dict["hall"] = new Scene
            {
                Id = "hall",
                Text = "Du låser upp porten och går in i hallen. Och där ...!",
                Choices = new()
            {
                new Choice { Label = "Avsluta", NextSceneId = "slut" }
            }
            };

            dict["slut"] = new Scene
            {
                Id = "slut",
                Text = "Spelet är slut.",
                Choices = new()
                {
                    new Choice {
                    Label = "Spela igen?",
                    NextSceneId = "start"
                }
                }
            };

            return dict;
        }
    }
}
