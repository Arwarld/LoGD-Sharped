namespace LoGD.Core.Game
{
    public class Template
	{
		public Template(string name, string popuphead, string popupfoot, string header, string footer, string statstart, string stathead, string statrow, string statbuff, string statend, string navhead, string navhelp, string navitem, string petitioncount, string adwrapper, string login, string loginfull, string collapse)
		{
			this.popuphead = popuphead;
			this.popupfoot = popupfoot;
			this.header = header;
			this.footer = footer;
			this.statstart = statstart;
			this.stathead = stathead;
			this.statrow = statrow;
			this.statbuff = statbuff;
			this.statend = statend;
			this.navhead = navhead;
			this.navhelp = navhelp;
			this.navitem = navitem;
			this.petitioncount = petitioncount;
			this.adwrapper = adwrapper;
			this.login = login;
			this.loginfull = loginfull;
			this.collapse = collapse;
			this.name = name;
		}
		protected string popuphead;
		protected string popupfoot;
		protected string header;
		protected string footer;
		protected string statstart;
		protected string stathead;
		protected string statrow;
		protected string statbuff;
		protected string statend;
		protected string navhead;
		protected string navhelp;
		protected string navitem;
		protected string petitioncount;
		protected string adwrapper;
		protected string login;
		protected string loginfull;
		protected string collapse;
		protected string name;
		public string Popuphead { get { return popuphead; } }
		public string Popupfoot { get { return popupfoot; } }
		public string Header { get { return header; } }
		public string Footer { get { return footer; } }
		public string Statstart { get { return statstart; } }
		public string Stathead { get { return stathead; } }
		public string Statrow { get { return statrow; } }
		public string Statbuff { get { return statbuff; } }
		public string Statend { get { return statend; } }
		public string Navhead { get { return navhead; } }
		public string Navhelp { get { return navhelp; } }
		public string Navitem { get { return navitem; } }
		public string Petitioncount { get { return petitioncount; } }
		public string Adwrapper { get { return adwrapper; } }
		public string Login { get { return login; } }
		public string Loginfull { get { return loginfull; } }
		public string Collapse { get { return collapse; } }
		public string Name { get { return name; } }
	}
}
