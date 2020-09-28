using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LoGD.Core;
using LoGD.Core.Game;
using Microsoft.AspNetCore.Http;

namespace LoGD.Server
{
    public class GameMaster
    {
        private static readonly Dictionary<string, Template> templateCSS = new Dictionary<string, Template>();
        private static readonly Dictionary<string, Scene> scenes = new Dictionary<string, Scene>();

        public static readonly ReadOnlyDictionary<string, Template> TemplateCSS =
            new ReadOnlyDictionary<string, Template>(templateCSS);

        private readonly Database db;

        public GameMaster(string databaseHost, string databasePort, string databaseUser, string databasePass,
            string databaseDatabase, string databasePrefix)
        {
            LoadTemplates();
            LoadScenes();
            db = new Database(databaseHost, databasePort, databaseUser, databasePass, databaseDatabase, databasePrefix);
        }

        private void LoadTemplates()
        {
            foreach (Template template in CoreElements.GetTemplates()) templateCSS.Add(template.Name, template);
        }

        private void LoadScenes()
        {
            foreach (Scene scene in CoreElements.GetScenes()) scenes.Add(scene.Name, scene);
        }

        public string BuildPage(HttpContext context, string page)
        {
            return BuildPage(context, page, new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()));
        }

        public string BuildPage(HttpContext context, string page, ReadOnlyDictionary<string, string> getValues)
        {
            if (context.Session.Keys.Contains("loggedin") && context.Session.GetInt32("loggedin") == 1 &&
                context.Session.Keys.Contains("userid"))
            {
                int userid = (int) context.Session.GetInt32("userid");
                if (scenes.ContainsKey(page))
                {
                    if (scenes[page].OverrideForcedNav)
                        return scenes[page].Show(userid, getValues, db);
                    //check allowednavs in DB
                    //allowed
                    return scenes[page].Show(userid, getValues, db);
                }

                return "Badnav";
                //return last page again;
            }

            if (scenes.ContainsKey(page) && scenes[page].AllowAnonymous)
                return scenes[page].Show(-1, getValues, db);

            return scenes["home"].Show(-1, getValues, db);
        }
    }
}