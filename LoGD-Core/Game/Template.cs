namespace LoGD.Core.Game
{
    public sealed class Template
    {
        internal Template(string name, string popuphead, string popupfoot, string header, string footer,
            string statstart,
            string stathead, string statrow, string statbuff, string statend, string navhead, string navhelp,
            string navitem, string petitioncount, string adwrapper, string login, string loginfull, string collapse)
        {
            Popuphead = popuphead;
            Popupfoot = popupfoot;
            Header = header;
            Footer = footer;
            Statstart = statstart;
            Stathead = stathead;
            Statrow = statrow;
            Statbuff = statbuff;
            Statend = statend;
            Navhead = navhead;
            Navhelp = navhelp;
            Navitem = navitem;
            Petitioncount = petitioncount;
            Adwrapper = adwrapper;
            Login = login;
            Loginfull = loginfull;
            Collapse = collapse;
            Name = name;
        }

        public string Popuphead { get; }
        public string Popupfoot { get; }
        public string Header { get; }
        public string Footer { get; }
        public string Statstart { get; }
        public string Stathead { get; }
        public string Statrow { get; }
        public string Statbuff { get; }
        public string Statend { get; }
        public string Navhead { get; }
        public string Navhelp { get; }
        public string Navitem { get; }
        public string Petitioncount { get; }
        public string Adwrapper { get; }
        public string Login { get; }
        public string Loginfull { get; }
        public string Collapse { get; }
        public string Name { get; }
    }
}
