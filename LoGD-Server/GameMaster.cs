#region

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LoGD.Core;
using LoGD.Core.Game;
using Microsoft.AspNetCore.Http;

#endregion

namespace LoGD.Server
{
    internal sealed class GameMaster
    {
        private static readonly Dictionary<string, Template> TemplateCss = new Dictionary<string, Template>();
        private static readonly Dictionary<string, Scene> Scenes = new Dictionary<string, Scene>();

        private readonly Database _db;

        internal GameMaster(string databaseHost, string databasePort, string databaseUser, string databasePass,
            string databaseDatabase, string databasePrefix)
        {
            LoadTemplates();
            LoadScenes();
            _db = new Database(databaseHost, databasePort, databaseUser, databasePass, databaseDatabase,
                databasePrefix);
        }

        private void LoadTemplates()
        {
            foreach (Template template in CoreElements.GetTemplates()) TemplateCss.Add(template.Name, template);
        }

        private void LoadScenes()
        {
            foreach (Scene scene in CoreElements.GetScenes()) Scenes.Add(scene.Name, scene);
        }

        internal string BuildPage(HttpContext context, string page)
        {
            return BuildPage(context, page, new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()));
        }

        internal string BuildPage(HttpContext context, string page, ReadOnlyDictionary<string, string> getValues)
        {
            if (context.Session.Keys.Contains("loggedin") && context.Session.GetInt32("loggedin") == 1 &&
                context.Session.Keys.Contains("userid"))
            {
                int userid = (int) context.Session.GetInt32("userid");
                if (Scenes.ContainsKey(page))
                {
                    if (Scenes[page].OverrideForcedNav)
                        return Scenes[page].Show(userid, getValues, _db);
                    //check allowednavs in DB
                    //allowed
                    return Scenes[page].Show(userid, getValues, _db);
                }

                return "Badnav";
                //return last page again;
            }

            if (Scenes.ContainsKey(page) && Scenes[page].AllowAnonymous)
                return Scenes[page].Show(-1, getValues, _db);

            return Scenes["home"].Show(-1, getValues, _db);
        }
    }
}
