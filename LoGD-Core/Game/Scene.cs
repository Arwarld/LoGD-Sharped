#region

using System.Collections.ObjectModel;

#endregion

namespace LoGD.Core.Game
{
    public abstract class Scene
    {
        protected Scene(string name, bool allowAnonymous, bool overrideForcedNav)
        {
            Name = name;
            AllowAnonymous = allowAnonymous;
            OverrideForcedNav = overrideForcedNav;
        }

        public bool AllowAnonymous { get; }
        public bool OverrideForcedNav { get; }
        public string Name { get; }
        public abstract string Show(int userId, ReadOnlyDictionary<string, string> getValues, Database db);
    }
}
