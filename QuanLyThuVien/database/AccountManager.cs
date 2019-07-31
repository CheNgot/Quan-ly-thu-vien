using QLTV.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace QLTV.database
{
    class AccountManager
    {
        public static string TITTLE_ACCOUNTS = "Accounts";
        public static string TITTLE_ACCOUNT = "Account";
        public static string nameFile = @"../../accounts.xml";
        public static string usernameAttribute = "username";
        public static string passwordAttribute = "password";
        public static string typeAccountAttribute = "typeAccount";
        public static string maNhanVienAttribute = "maNhanVien";

        public List<Account> GetAccounts()
        {
            var xmlDocument = XDocument.Load(nameFile);
            List<Account> accounts = new List<Account>();
            accounts = xmlDocument.Root
                .Descendants(TITTLE_ACCOUNT)
                .Select(node => new Account
                {
                    username = node.Element(usernameAttribute).Value,
                    password = node.Element(passwordAttribute).Value,
                    typeAccount = node.Element(typeAccountAttribute).Value,
                    maNhanVien = (node.Element(maNhanVienAttribute).Value)
                }).ToList();

            return accounts;
        }

        public void saveAccount(Account account)
        {
            XDocument doc = XDocument.Load(nameFile);
            XElement school = doc.Element(TITTLE_ACCOUNTS);
            school.Add(new XElement(TITTLE_ACCOUNT,
                       new XElement(usernameAttribute, account.username),
                       new XElement(passwordAttribute, account.password),
                       new XElement(typeAccountAttribute, account.typeAccount),
                       new XElement(maNhanVienAttribute, account.maNhanVien)));
            doc.Save(nameFile);
        }

        public void saveListAccount(List<Account> accounts)
        {
            List<Account> currentDocGias = GetAccounts();
            for (int i = 0; i<accounts.Count; i++)
            {
                bool flag = false;
                foreach (var account in currentDocGias)
                {
                    if (accounts[i].username == account.username || account.maNhanVien == accounts[i].maNhanVien)
                    {
                        flag = true;
                        break;
                    }
               }
                if (flag == false) saveAccount(accounts[i]);
            }
        }

        public void removeAccount(string username)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(nameFile);
            XmlNode node = doc.SelectSingleNode("/" + TITTLE_ACCOUNTS + "/" + TITTLE_ACCOUNT +
                "[username='" + username + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(nameFile);
        }
    }
}