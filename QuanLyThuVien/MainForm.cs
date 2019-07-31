using QLTV.database;
using QLTV.model;
using QuanLyThuVien.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class MainForm : Form
    {
        private AccountManager accountManager = new AccountManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            List<Account> accounts = accountManager.GetAccounts();
            for(int i = 0; i < accounts.Count; i++)
            {
                if(accounts[i].username == textBoxUserName.Text)
                {
                    if(accounts[i].password == textBoxPassword.Text)
                    {
                        string stringTypeAccount = accounts[i].typeAccount;
                        switch (stringTypeAccount)
                        {
                            case TypeAcccount.ADMIN:
                                AdminForm adminForm = new AdminForm(accounts[i]);
                                adminForm.Show();
                                break;
                            case TypeAcccount.THU_THU:
                                ThuThuForm thuThuForm = new ThuThuForm(accounts[i]);
                                thuThuForm.Show();
                                break;
                            case TypeAcccount.THU_QUY:
                                ThuQuyForm thuQuyForm = new ThuQuyForm(accounts[i]);
                                thuQuyForm.Show();
                                break;
                            case TypeAcccount.THU_KHO:
                                ThuKhoForm thuKhoForm = new ThuKhoForm(accounts[i]);
                                thuKhoForm.Show();
                                break;
                        }
                        // do something
                        return;
                    } 
                }
            }
            labelNotifyError.Show();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}