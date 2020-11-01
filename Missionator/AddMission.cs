using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Interop.Outlook;

namespace Missionator
{
    public partial class AddMission : Form
    {
        private bool updateMission = false;
        public Mission currentMission;
        public string orginizer;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );
        public AddMission()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
            dateTimePicker_dueDate.Value = DateTime.Now.AddDays(7);

            Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.NameSpace ns = app.GetNamespace("MAPI");
            Outlook.MAPIFolder f = ns.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
            listBox_Recipients.Items.Add(app.Session.CurrentUser.Address);
            this.orginizer = app.Session.CurrentUser.Name;
        }
        public AddMission(Mission m)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
            dateTimePicker_dueDate.Value = DateTime.Now.AddDays(7);

            this.updateMission = true;
            Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.NameSpace ns = app.GetNamespace("MAPI");
            Outlook.MAPIFolder f = ns.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
            foreach (string reci in m.Recipients)
            {
                listBox_Recipients.Items.Add(reci);
            }
            this.currentMission = m;
            textBox_Sbuject.Text = m.Title;
            richTextBox_Body.Text = m.Body;
            
            dateTimePicker_dueDate.Value = m.DueDate;
           
            this.orginizer = app.Session.CurrentUser.Name;
            label_Title.Text = "עדכן משימה";
            button_Add.Text = "עדכן";

            EnableButtonsInUpdate(m.Orginizer);
        }
        private void EnableButtonsInUpdate(string orginizer)
        {
            button_Add.Enabled = true;
            button_AddText.Visible = true;
            textBox_Sbuject.Enabled = false;
            richTextBox_Body.ReadOnly = true;
            if (!orginizer.Equals(this.orginizer))
            {
                dateTimePicker_dueDate.Enabled = false;
            }
        }
        private void FindContactEmailByName(string firstName, string lastName)
        {
            Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.NameSpace outlookNameSpace = app.GetNamespace("MAPI");
            Outlook.MAPIFolder f = outlookNameSpace.GetDefaultFolder(OlDefaultFolders.olFolderInbox);

    
            Outlook.MAPIFolder contactsFolder =
                outlookNameSpace.GetDefaultFolder(
                Microsoft.Office.Interop.Outlook.
                OlDefaultFolders.olFolderContacts);

            Outlook.Items contactItems = contactsFolder.Items;

            try
            {
                Outlook.ContactItem contact =
                    (Outlook.ContactItem)contactItems.
                    Find(String.Format("[FirstName]='{0}' and "
                    + "[LastName]='{1}'", firstName, lastName));
                if (contact != null)
                {
                  //  return contact;
                    contact.Display(true);
                }
                else
                {
                    MessageBox.Show("The contact information was not found.");
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listBox_Recipients.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listBox_Recipients.SelectedItems.Count; i++)
                {
                    listBox_Recipients.Items.Remove(listBox_Recipients.Items[i]);
                }

            }
            button_Add.Enabled = validate();
        }

        private void button_AddRecipient_Click(object sender, EventArgs e)
        {
            AddRecipient newRecipient = new AddRecipient();
            if (newRecipient.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox_Recipients.Items.Add(newRecipient.currentContact.Email1Address);
            }
            button_Add.Enabled = validate();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            List<string> recipients = new List<string>();
            foreach (object item in listBox_Recipients.Items)
            {
                recipients.Add(item.ToString());
            }
            if (!updateMission)
            {
                string subject = textBox_Sbuject.Text;
                string body = richTextBox_Body.Text;
                DateTime dueDate = dateTimePicker_dueDate.Value;
               
             
                currentMission = new Mission(subject, body, false, dueDate, recipients, this.orginizer);

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                currentMission.Recipients = recipients;
                if (this.currentMission.DueDate != dateTimePicker_dueDate.Value)
                {
                    DialogResult dialogResult = MessageBox.Show("האם ברצונך לשנות מועד?", "דחייה", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.currentMission.DueDate = dateTimePicker_dueDate.Value;
                       
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void textBox_Sbuject_TextChanged(object sender, EventArgs e)
        {
            if(!updateMission)
            button_Add.Enabled = validate();
           // edited = true;
        }
    
        public bool validate()
        {
            return (textBox_Sbuject.Text != "" && textBox_Sbuject.Text != null && richTextBox_Body.Text != "" && listBox_Recipients.Items.Count > 0);
        }

        private void dateTimePicker_dueDate_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now.Date > dateTimePicker_dueDate.Value)
                MessageBox.Show("שים לב שבחרת מועד מוקדם מהתאריך הנוכחי!");
        }

        private void button_AddText_Click(object sender, EventArgs e)
        {
            richTextBox_Body.ReadOnly = !richTextBox_Body.ReadOnly ;
            if (!richTextBox_Body.ReadOnly)
            {
                richTextBox_Body.Text = updateText;
                richTextBox_Body.Focus();
                button_AddText.Text = "סיימתי";
             

                button_Add.Enabled = false;
        
                textBox_Sbuject.Enabled = false;
           
                if (!orginizer.Equals(this.orginizer))
                {
                    dateTimePicker_dueDate.Enabled = false;
                }
            }
            else
            {
                updateText = richTextBox_Body.Text;
                richTextBox_Body.Text = currentMission.Body + "\n" + updateText;
                button_AddText.Text = "הוסף";
             
                EnableButtonsInUpdate(currentMission.Orginizer);
            }
           
        

          

         
        }
      
        public string updateText="";
  

   
   

    }
}
