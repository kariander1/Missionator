using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Missionator
{
    public partial class AddRecipient : Form
    {
        private Outlook.Items contactItems;
        public Outlook.ContactItem currentContact;
        public AddRecipient()
        {
            InitializeComponent();

            Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.NameSpace outlookNameSpace = app.GetNamespace("MAPI");
            Outlook.MAPIFolder f = outlookNameSpace.GetDefaultFolder(OlDefaultFolders.olFolderInbox);


            Outlook.MAPIFolder contactsFolder =
                outlookNameSpace.GetDefaultFolder(
                Microsoft.Office.Interop.Outlook.
                OlDefaultFolders.olFolderContacts);

         contactItems = contactsFolder.Items;

        //    listBox_Contacts.Items.Add(app.Session.CurrentUser.Name);
            foreach (object item in contactItems)
            {
                listBox_Contacts.Items.Add(((ContactItem)item).FullName);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (listBox_Contacts.Items.Contains(textBox_Input.Text))
            {
                currentContact = (ContactItem)contactItems[listBox_Contacts.Items.IndexOf(textBox_Input.Text) + 1];
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void listBox_Contacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Input.Text = listBox_Contacts.SelectedItem.ToString();
        
        }
    }
}
