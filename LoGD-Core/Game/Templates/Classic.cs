﻿namespace LoGD.Core.Game.Templates
{
    internal static class Classic
    {
        public static Template Template()
        {
            return new Template("Classic",
                "<html><head><title>{title}</title><link href=\"templates/Classic.css\" rel=\"stylesheet\" type=\"text/css\">{headscript}{script}</head><body bgcolor='#000000' text='#CCCCCC'><table border='1' cellpadding=5 cellspacing=0 width='100%'><tr><td colspan=2 class='pageheader'><table border=0 cellpadding=0 cellspacing=0 width='100%' class='noborder'><tr><td width='100%' class='noborder'><b>{title}</b></td></tr></table></td></tr><tr><td valign='top' width='100%'>",
                "<tr><td bgcolor='#330000' align='left'>{copyright}</td></tr></table></body></html>",
                "<html><head><title>{title}</title><link href=\"templates/Classic.css\" rel=\"stylesheet\" type=\"text/css\">{headscript}{script}</head><body bgcolor='#000000' text='#CCCCCC'><table border='1' cellpadding=5 cellspacing=0 width='100%'><tr><td colspan=2 class='pageheader'><table border=0 cellpadding=0 cellspacing=0 width='100%' class='noborder'><tr><td class='noborder' nowrap=\"true\"><b>{title}</b></td><td width=\"100%\" class='noborder' align='center'>{headerad}</td><td align='right' class='noborder'>{motd}</td></tr></table></td></tr><tr><td width=150 bgcolor='#000066' valign='top' height='100%'>{navad}<table border='0' cellpadding='0' cellspacing='0'>{nav}</table><br>{mail}<br>{petition}</td><td rowspan=2 valign='top' width='100%'><div style=\"float: right\">{verticalad}</div>{bodyad}",
                "{petitiondisplay}</td></tr><tr><td width=150 bgcolor='#330000' valign='top'>{stats}{paypal}{version}</td></tr><tr><td colspan=2 bgcolor='#330000' align='center'><table border='0' cellpadding='0' cellspacing='0' width='100%' class='noborder'><tr><td class='noborder'>{copyright}{pagegen}<br/></td><td align='right' class='noborder'>{source}{petition}</td></tr></table></td></tr></table></body></html>",
                "<table cellpadding=2 cellspacing=0 class='charinfo' width='150'>",
                "<tr><td class='charhead' colspan='2'><b>{title}</b></td></tr>",
                "<tr><td class='charinfo'><b>{title}</b></td><td class='charinfo'>{value}</td></tr>",
                "<tr><td class='charhead' colspan='2'><b>{title}</b></td></tr><tr><td class='charinfo' colspan='2'>{value}</td></tr>",
                "</table>", "<tr><td><span class=\"navhead\">&#151;{title}&#151;</span></td></tr>",
                "<tr><td><span class=\"navhelp\">{text}<br></span></td></tr>",
                "<tr><td><a href=\"{link}\"{accesskey}class='nav' {popup}>{text}</a></td></tr>",
                "<table border='0' cellpadding='5' cellspacing='0' align='right'><tr><td>{petitioncount}</td></tr></table>",
                "<table cellpadding=2 cellspacing=0><tr><td>{content}</td></tr></table>",
                "<table border='0' cellpadding='0' cellspacing='0' class='noborder'><tr><td class='noborder'><img src='images/logindragon.gif'></td></tr><tr><td valign='center' align='center' class='noborder'><table border='0'><tr><td align='center'>{username}:</td><td align='center'>{password}:</td></tr><tr><td><input name='name' id=\"name\" accesskey='u' size='10'></td><td><input name='password' id=\"password\" accesskey='p' type='password' size='10'></td></tr><tr><td colspan='2' align='center'><input type='submit' value='{button}' class='button'><br></td></tr></table></td></tr></table>",
                "<table border='0' cellpadding='0' cellspacing='0' class='noborder'><tr><td class='noborder'><img src='images/logindragon.gif'></td></tr><tr><td valign='center' align='center' class='noborder'><table border='0'><tr><td align='center'><font color='#ff0000'>Server Full!</font></td></tr></table></td></tr></table>",
                "style:classic");
        }
    }
}
