#region

using System;
using LoGD.Core.Game.Data.Lib;
using MySql.Data.MySqlClient;

#endregion

namespace LoGD.Core.Game.Data
{
    public class Paylog : DatabaseRow<int, Paylog>
    {
        public Paylog(DatabaseTable<int, Paylog> parent) : base(parent)
        {
        }

        public Paylog(DatabaseTable<int, Paylog> parent, MySqlDataReader reader) : base(parent, reader)
        {
        }

        public int PayId
        {
            get => (int) Values["payid"];
            set => ChangeValue("payid", value);
        }

        public string Info
        {
            get => (string) Values["info"];
            set => ChangeValue("info", value);
        }

        public string Response
        {
            get => (string) Values["response"];
            set => ChangeValue("response", value);
        }

        public string TxnId
        {
            get => (string) Values["txnid"];
            set => ChangeValue("txnid", value);
        }

        public float Amount
        {
            get => (float) Values["amount"];
            set => ChangeValue("amount", value);
        }

        public string Name
        {
            get => (string) Values["name"];
            set => ChangeValue("name", value);
        }

        public uint AcctId
        {
            get => (uint) Values["acctid"];
            set => ChangeValue("acctid", value);
        }

        public byte Processed
        {
            get => (byte) Values["processed"];
            set => ChangeValue("processed", value);
        }

        public byte Filed
        {
            get => (byte) Values["filed"];
            set => ChangeValue("filed", value);
        }

        public float TxFee
        {
            get => (float) Values["txfee"];
            set => ChangeValue("txfee", value);
        }

        public DateTime Processdate
        {
            get => (DateTime) Values["processdate"];
            set => ChangeValue("processdate", value);
        }
    }
}
