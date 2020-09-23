namespace LoGD.Core.Game.Templates
{
    public static class Classic
	{
		public static Template Template()
		{
			return new Template("Classic", "<html><head><title>{title}</title><link href=\"templates/Classic.css\" rel=\"stylesheet\" type=\"text/css\">{headscript}{script}</head><body bgcolor='#000000' text='#CCCCCC'><table border='1' cellpadding=5 cellspacing=0 width='100%'><tr><td colspan=2 class='pageheader'><table border=0 cellpadding=0 cellspacing=0 width='100%' class='noborder'><tr><td width='100%' class='noborder'><b>{title}</b></td></tr></table></td></tr><tr><td valign='top' width='100%'>", "<tr><td bgcolor='#330000' align='left'>{copyright}</td></tr></table></body></html>", "<html><head><title>{title}</title><link href=\"templates/Classic.css\" rel=\"stylesheet\" type=\"text/css\">{headscript}{script}</head><body bgcolor='#000000' text='#CCCCCC'><table border='1' cellpadding=5 cellspacing=0 width='100%'><tr><td colspan=2 class='pageheader'><table border=0 cellpadding=0 cellspacing=0 width='100%' class='noborder'><tr><td class='noborder' nowrap=\"true\"><b>{title}</b></td><td width=\"100%\" class='noborder' align='center'>{headerad}</td><td align='right' class='noborder'>{motd}</td></tr></table></td></tr><tr><td width=150 bgcolor='#000066' valign='top' height='100%'>{navad}<table border='0' cellpadding='0' cellspacing='0'>{nav}</table><br>{mail}<br>{petition}</td><td rowspan=2 valign='top' width='100%'><div style=\"float: right\">{verticalad}</div>{bodyad}", "{petitiondisplay}</td></tr><tr><td width=150 bgcolor='#330000' valign='top'>{stats}{paypal}{version}</td></tr><tr><td colspan=2 bgcolor='#330000' align='center'><table border='0' cellpadding='0' cellspacing='0' width='100%' class='noborder'><tr><td class='noborder'>{copyright}{pagegen}<br/></td><td align='right' class='noborder'>{source}{petition}</td></tr></table></td></tr></table></body></html>", "<table cellpadding=2 cellspacing=0 class='charinfo' width='150'>", "<tr><td class='charhead' colspan='2'><b>{title}</b></td></tr>", "<tr><td class='charinfo'><b>{title}</b></td><td class='charinfo'>{value}</td></tr>", "<tr><td class='charhead' colspan='2'><b>{title}</b></td></tr><tr><td class='charinfo' colspan='2'>{value}</td></tr>", "</table>", "<tr><td><span class=\"navhead\">&#151;{title}&#151;</span></td></tr>", "<tr><td><span class=\"navhelp\">{text}<br></span></td></tr>", "<tr><td><a href=\"{link}\"{accesskey}class='nav' {popup}>{text}</a></td></tr>", "<table border='0' cellpadding='5' cellspacing='0' align='right'><tr><td>{petitioncount}</td></tr></table>", "<table cellpadding=2 cellspacing=0><tr><td>{content}</td></tr></table>", "<table border='0' cellpadding='0' cellspacing='0' class='noborder'><tr><td class='noborder'><img src='images/logindragon.gif'></td></tr><tr><td valign='center' align='center' class='noborder'><table border='0'><tr><td align='center'>{username}:</td><td align='center'>{password}:</td></tr><tr><td><input name='name' id=\"name\" accesskey='u' size='10'></td><td><input name='password' id=\"password\" accesskey='p' type='password' size='10'></td></tr><tr><td colspan='2' align='center'><input type='submit' value='{button}' class='button'><br></td></tr></table></td></tr></table>", "<table border='0' cellpadding='0' cellspacing='0' class='noborder'><tr><td class='noborder'><img src='images/logindragon.gif'></td></tr><tr><td valign='center' align='center' class='noborder'><table border='0'><tr><td align='center'><font color='#ff0000'>Server Full!</font></td></tr></table></td></tr></table>", "style:classic",
@"caption {
	white-space: nowrap;
	font-family: Verdana, Arial, Helvetica, sans-serif;
	font-size: 12px;
}

td {
	font-family: Verdana, Arial, Helvetica, sans-serif;
	font-size: 12px;
	border-top: 1px none #666666;
	border-right: 1px solid #666666;
	border-bottom: 1px solid #666666;
	border-left: 1px none #666666;
}
a{
	color: #0099FF;
	text-decoration: none;
}
a.nav {
	text-decoration: none;
	width: 150px;
	height: auto;
	padding: 1px;
	float: left;
	clear: none;
	background-color: #000066;
	border-top: thin solid #000066;
	border-bottom: thin solid #000066;
	border-right: thin none #000066;
	border-left: thin none #000066;
}
a:hover.nav {
	background-color: #003366;
	border-top: thin outset #0000CC;
	border-right: thin none #0000CC;
	border-bottom: thin outset #0000CC;
	border-left: thin none #0000CC;
}
a.navhilite {
	text-decoration: none;
	width: 150px;
	height: auto;
	padding: 1px;
	float: right;
	clear: none;
	color:#FFFF00;
	background-color: #330000;
	border-top: thin solid #330000;
	border-bottom: thin solid #330000;
	border-right: thin none #330000;
	border-left: thin none #330000;
}
a:hover.navhilite {
	background-color: #990000;
	border-top: thin outset #CC0000;
	border-right: thin none #CC0000;
	border-bottom: thin outset #CC0000;
	border-left: thin none #CC0000;
}
a.motd {
	text-decoration: none;
	width: 150px;
	height: auto;
	padding: 1px;
	float: right;
	clear: none;
	color:#FFFF00;
	background-color: #330000;
	border-top: thin solid #330000;
	border-bottom: thin solid #330000;
	border-right: thin none #330000;
	border-left: thin none #330000;
}
a:hover.motd {
	background-color: #990000;
	border-top: thin outset #CC0000;
	border-right: thin none #CC0000;
	border-bottom: thin outset #CC0000;
	border-left: thin none #CC0000;
}
.navhead {
	text-decoration: none;
	width: 150px;
	border: thin #000033;
	height: auto;
	padding: 1px;
	line-height: 18px;
	float: left;
	clear: none;
	background-color: #003366;
	font-weight: bold;
	color: #00CCFF;
	cursor: default;
}
.navhelp {
	text-decoration: none;
	width: 150px;
	height: auto;
	padding: 1px;
	float: left;
	clear: none;
	background-color: #000066;
	border-top: thin solid #000066;
	border-bottom: thin solid #000066;
	border-right: thin none #000066;
	border-left: thin none #000066;
}
table {
	border-top: 1px solid #666666;
	border-right: 1px none #666666;
	border-bottom: 1px none #666666;
	border-left: 1px solid #666666;
}
td.charinfo {
	border-top-width: 1px;
	border-top-style: solid;
	border-top-color: #990000;
	border-right-style: none;
	border-bottom-style: none;
	border-left-style: none;
	cursor: default;
}
td.charhead {
	background-color: #990000; 
	border: none;
	cursor: default;
}
table.charinfo { border: none; }
td.pageheader { background-color: #000066; }
td.noborder { border: none; }
table.noborder { border: none; }
input {
	background-color: #333333;
	border: 1px dotted #999999;
	color: #CCCCCC;
}
.input {
	background-color: #333333;
	border: 1px dotted #999999;
	color: #CCCCCC;
}
select {
	background-color: #333333;
	border: 1px dotted #999999;
	color: #CCCCCC;
}

a.t {
	width: 7px;
	height: 7px;
	border: 1px dotted #0000FF;
	background-color: #9999FF;
	color: #FFFFFF;
	font-size: 7px;
	text-decoration: none;
	padding-left: 1px;
	padding-right: 1px;
}

a.thot {
	width: 7px;
	height: 7px;
	border: 1px dotted #FF0000;
	background-color: #FF9999;
	color: #FFFFFF;
	font-size: 7px;
	text-decoration: none;
	padding-left: 1px;
	padding-right: 1px;
}

div.debug {
	background-color: #FFFFFF;
	color: #000000;
	border: 1px dotted #000000;
	width: auto;
	height: auto;
	font-size: 10px;
}
.navhi { color: #00FF00; }
.colDkBlue	{ color: #0000B0; }
.colDkGreen   { color: #00B000; }
.colDkCyan	{ color: #00B0B0; }
.colDkRed	 { color: #B00000; }
.colDkMagenta { color: #B000CC; }
.colDkYellow  { color: #B0B000; }
.colDkWhite   { color: #B0B0B0; }
.colLtBlue	{ color: #0000FF; }
.colLtGreen   { color: #00FF00; }
.colLtCyan	{ color: #00FFFF; }
.colLtRed	 { color: #FF0000; }
.colLtMagenta { color: #FF00FF; }
.colLtYellow  { color: #FFFF00; }
.colLtWhite   { color: #FFFFFF; }
.colLtBlack   { color: #999999; }
.colDkOrange  { color: #994400; }
.colLtOrange  { color: #FF9900; }
.colBlue  		{ color: #0070FF; }
.colLime  		{ color: #DDFFBB; }
.colBlack  		{ color: #000000; }
.colRose 		{ color: #EEBBEE; }
.colblueviolet 	{ color: #9A5BEE; }
.coliceviolet	{ color: #AABBEE; }
.colLtBrown 	{ color: #F8DB83; }
.colDkBrown 	{ color: #6b563f; }
.colXLtGreen	{ color: #aaff99; }
.colAttention 	{ background-color: #00FF00; color: #FF0000; }
.colWhiteBlack 	{ background-color: #FFFFFF; color: #000000; }
.colBack  		{ background-color: #00FFFF; color: #000000; }
.colbeige  { color: #F5F5DC; }
.colkhaki  { color: #F0E68C; }
.coldarkkhaki  { color: #BDB76B; }
.colaquamarine  { color: #7FFFD4; }
.coldarkseagreen  { color: #8FBC8F; }
.collightsalmon  { color: #FFA07A; }
.colsalmon  { color: #FA8072; }
.colwheat  { color: #F5DEB3; }
.coltan  { color: #D2B48C; }.colLtLinkBlue { color: #0099FF; }
.colDkLinkBlue { color: #006BB3; }
.colDkRust { color: #8D6060; }
.colLtRust { color: #B07878; }
.colMdBlue { color: #0000F0; }
.colMdGrey { color: #DDDDDD; }
.colburlywood { color: #DEB887; }
.trhead  { background-color:#990000; color:#FFFFFF; }
.trlight { background-color:#330000; }
.trdark  { background-color:#000000; }
.trhilight { background-color: #550000; }");
		}
	}
}
	