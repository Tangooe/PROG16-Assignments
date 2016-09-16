using AddressBook.Classes;
using AddressBook.Ojbects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        bool needToSave = false;

        string filepath = Properties.Settings.Default.Filepath;
      
        List<Contact> contacts = new List<Contact>();

        #region - Form1 -

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(filepath == null || filepath == "")
            {
                filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Address Book\AddressBook.xml";
            }

            contacts = XmlData.LoadData(contacts,filepath);

            needToSave = false;

            ContactListManager.PopulateListbox(contacts);
        }

        private void txtContactForm_TextChanged(object sender, EventArgs e)
        {
            if (Form1.ActiveForm.AcceptButton != btnAdd)
            {
                Form1.ActiveForm.AcceptButton = btnAdd;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (Form1.ActiveForm.AcceptButton != btnSearch)
            {
                Form1.ActiveForm.AcceptButton = btnSearch;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(needToSave)
            {
                var title = "Attention";
                var content = "Do you want to save this address book before closing?";

                var dialog = MessageBox.Show(this, content, title, MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    XmlData.SaveData(contacts, filepath);
                }
                else if (dialog == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }        
        }

        #endregion

        #region - Controls -

        private void btnAddContact(object sender, EventArgs e)
        {
            if (StringValidation.CheckValidation() == true)
            {
                ContactListManager.AddContactToList(contacts);

                needToSave = true;

                ClearForm();
            }
            else
            {
                //MessageBox.Show("You didn't fill in all the fields correctly!", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ContactListManager.RemoveItemFromList(contacts);

            ClearForm();

            needToSave = true;
        }

        private void btnEditContact(object sender, EventArgs e)
        {
            if (StringValidation.CheckValidation() == true)
            {
                ContactListManager.EditContact(contacts);


                needToSave = true;

                ContactListManager.PopulateListbox(contacts);
            }
            else
            {
                MessageBox.Show("You didn't fill in all the fields correctly!", "Error", MessageBoxButtons.OK);
            }
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactListManager.SelectContact(contacts);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text.Trim();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                ContactListManager.SearchContacts(contacts,txtSearch.Text);
            }
            else
            {
                ContactListManager.PopulateListbox(contacts);
            }
        }

        #endregion

        #region - Menu Strip -

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
            contacts.Clear();

            ContactListManager.PopulateListbox(contacts);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            openFileDialog.DefaultExt = ".xml";

            contacts = XmlData.LoadData(contacts, openFileDialog.FileName);

            ContactListManager.PopulateListbox(contacts);

            needToSave = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlData.SaveData(contacts, filepath);

            needToSave = false;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdAddressBook.ShowDialog();

            XmlData.SaveData(contacts, sfdAddressBook.FileName);

            needToSave = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string version = Application.ProductVersion;
            string product = Application.ProductName;
            string company = Application.CompanyName;

            string text = product + " Verison: " + version + "\n By: " + company;
            string title = "About";
            MessageBox.Show(text, title, MessageBoxButtons.OK);
        }

        #endregion

        #region - Methods -

        private void ClearForm()
        {
            txtFullName.Text = "";
            txtAddress.Text = "";
            txtAreaCode.Text = "";
            txtCity.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        #endregion
    }
}
