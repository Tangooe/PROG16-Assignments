using AddressBook.Ojbects;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System;

namespace AddressBook.Classes
{
    class ContactListManager
    {
        static Form1 addressBook = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public static void AddContactToList(List<Contact> contacts)
        {
            var contact = new Contact
            {
                Name = addressBook.txtFullName.Text,
                Address = addressBook.txtAddress.Text,
                AreaCode = addressBook.txtAreaCode.Text,
                City = addressBook.txtCity.Text,
                Phone = addressBook.txtPhone.Text,
                Email = addressBook.txtEmail.Text
            };

            contacts.Add(contact);
            addressBook.lstContacts.Items.Add(contact.Name);
        }

        public static void PopulateListbox(List<Contact> contacts)
        {
            addressBook.lstContacts.Items.Clear();

            foreach (Contact contact in contacts)
            {
                addressBook.lstContacts.Items.Add(contact.Name);
            }
        }

        public static void RemoveItemFromList(List<Contact> contacts)
        {
            contacts.RemoveAt(addressBook.lstContacts.SelectedIndex);

            ContactListManager.PopulateListbox(contacts);
        }

        public static void SearchContacts(List<Contact> contacts, string searchFilter)
        {
            var matches = new List<Contact>();

            foreach (Contact c in contacts)
            {
                foreach (PropertyInfo propertyInfo in c.GetType().GetProperties())
                {
                    if (propertyInfo.CanRead)
                    {
                        var firstValue = propertyInfo.GetValue(c, null).ToString();

                        if (firstValue.ToLower().Contains(searchFilter.ToLower()))
                        {
                            matches.Add(c);
                            break;
                        }
                    }
                }
            }

            PopulateListbox(matches);
        }

        public static void EditContact(List<Contact> contacts)
        {
            var index = addressBook.lstContacts.SelectedIndex;

            contacts[index].Name = addressBook.txtFullName.Text;
            contacts[index].Address = addressBook.txtAddress.Text;
            contacts[index].City = addressBook.txtCity.Text;
            contacts[index].AreaCode = addressBook.txtAreaCode.Text;
            contacts[index].Phone = addressBook.txtPhone.Text;
            contacts[index].Email = addressBook.txtEmail.Text;
        }

        public static void SelectContact(List<Contact> contacts)
        {
            var index = addressBook.lstContacts.SelectedIndex;

            try
            {
                addressBook.txtFullName.Text = contacts[index].Name;
                addressBook.txtAddress.Text = contacts[index].Address;
                addressBook.txtAreaCode.Text = contacts[index].AreaCode;
                addressBook.txtCity.Text = contacts[index].City;
                addressBook.txtPhone.Text = contacts[index].Phone;
                addressBook.txtEmail.Text = contacts[index].Email;

            }
            catch(Exception)
            {
                //GenerateLogfile
            }
        }
    }
}
