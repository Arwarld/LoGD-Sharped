using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace LoGD.Game.Scenes
{
    public static class Home
    {
        public static string Show(ISession context, ReadOnlyDictionary<string, string> getValues, Database db)
        {
            return "home";
        }
        public static bool AllowAnonymous()
        {
            return true;
        }
        public static bool OverrideForcedNav()
        {
            return false;
        }
    }
}
