using System.Collections.ObjectModel;

namespace LoGD.Core.Game
{
    public abstract class Scene
    {
        public Scene(string name, bool allowAnonymous, bool overrideForcedNav)
        {
            Name = name;
            AllowAnonymous = allowAnonymous;
            OverrideForcedNav = overrideForcedNav;
        }
        public abstract string Show(int userID, ReadOnlyDictionary<string, string> getValues, Database db);
        public bool AllowAnonymous { get; }
        public bool OverrideForcedNav { get; }
        public string Name { get; }
    }
}
