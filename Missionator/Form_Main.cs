using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Threading;
using Microsoft.Office.Interop.Outlook;

namespace Missionator
{
    public partial class Form_Main : Form
    {
        public List<Mission> missions = new List<Mission>();
        public List<Outlook.AppointmentItem> appointments = new List<AppointmentItem>();
        public Form_Main()
        {
            InitializeComponent();

            dateTimePicker_MaxDateMissions.Value = DateTime.Now.AddMonths(1);
            dateTimePicker_MinDate.Value = DateTime.Now.AddDays(-4);

            dateTimePicker_MinDate.ValueChanged += dateTimePicker_MinDate_ValueChanged;
            dateTimePicker_MaxDateMissions.ValueChanged += dateTimePicker_MaxDateMissions_ValueChanged;
            Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.NameSpace ns = app.GetNamespace("MAPI");
            Outlook.MAPIFolder f = ns.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
         //   Thread.Sleep(5000); 
         //   Microsoft.Office.Interop.Outlook.MailItem mailItem = (Outlook.MailItem)app.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
            toolStripStatusLabel_Name.Text ="חובר כ: " +app.Session.CurrentUser.Name;
            LoadMissions(dateTimePicker_MinDate.Value,dateTimePicker_MaxDateMissions.Value);
   //         List<string> lst = new List<string>();
   //         lst.Add(("shai444@gmail.com"));
        //    AssignMission(DateTime.Now.AddDays(1), "בוsdfא", "asdasasd",lst);
     //       mailItem.Subject = "This is the subject";
        //    mailItem.To = "someone@example.com";
       //     mailItem.Body = "This is the message.";
       //     mailItem.Importance = Outlook.OlImportance.olImportanceLow;
      //      mailItem.Display(false);
          
        }
        private Outlook.Items GetAppointmentsInRange(Outlook.Folder folder, DateTime startTime, DateTime endTime)
        {
            string filter = "[Start] >= '"
                + startTime.ToString("g")
                + "' AND [End] <= '"
                + endTime.ToString("g") + "'";
            //    + " AND [Resources] == 'Missionator'";
          //  Debug.WriteLine(filter);
            try
            {
                Outlook.Items calItems = folder.Items;
                calItems.IncludeRecurrences = false;
                calItems.Sort("[Start]", Type.Missing);
                Outlook.Items restrictItems = calItems.Restrict(filter);
                if (restrictItems.Count > 0)
                {
                    return restrictItems;
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
        }
        public void addRows(Outlook.AppointmentItem item)
        {
            dataGridView_Display.Rows.Add();
            Mission m = OutlookItemToMission(item);
            appointments.Add(item);
            missions.Add(m);
            dataGridView_Display.Rows[dataGridView_Display.Rows.Count - 1].Cells[0].Value = m.Done;
            dataGridView_Display.Rows[dataGridView_Display.Rows.Count - 1].Cells[1].Value = m.Title;
            dataGridView_Display.Rows[dataGridView_Display.Rows.Count - 1].Cells[2].Value = m.DueDate.ToShortDateString();

            string recipients = "";
            foreach (string reci in m.Recipients)
            {
                recipients += reci;
            }
            dataGridView_Display.Rows[dataGridView_Display.Rows.Count - 1].Cells[3].Value =recipients;

            Button postpone = new Button();
            postpone.Text = "בקשה דחייה";
            dataGridView_Display.Rows[dataGridView_Display.Rows.Count - 1].Cells[4].Value = "בקש דחייה";
        
            int daysRemaining = (m.DueDate.Date - DateTime.Now.Date).Days;
            daysRemaining++; // In order to play with the coloring
            if (daysRemaining < 0)
                daysRemaining = 0;
            if (daysRemaining > 7)
                daysRemaining = 7;
            dataGridView_Display.Rows[dataGridView_Display.Rows.Count - 1].DefaultCellStyle.BackColor = Color.FromArgb(200, (int)(255 * ((double)(daysRemaining) / 7.0)), (int)(255 * ((double)daysRemaining / 7.0)));
                 
        }

     
        public void LoadMissions(DateTime min, DateTime max)
        {
            missions = new List<Mission>();
            appointments = new List<AppointmentItem>();
            if (dataGridView_Display.InvokeRequired)
                dataGridView_Display.Invoke(new MethodInvoker(delegate { dataGridView_Display.Rows.Clear(); }));
            else

                dataGridView_Display.Rows.Clear();
        

            Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.NameSpace ns = app.GetNamespace("MAPI");
            Outlook.MAPIFolder f = ns.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
           // Thread.Sleep(5000);
            Outlook.Folder calFolder =
       app.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderCalendar) as Outlook.Folder;

            Outlook.Items items = GetAppointmentsInRange(calFolder, dateTimePicker_MinDate.Value, dateTimePicker_MaxDateMissions.Value);
         //   double val = 0;
            if (items == null)
                return;
         
            for (int i = 0; i < items.Count; i++)
            {
                Outlook.AppointmentItem item = (Outlook.AppointmentItem)items[i + 1];
                if (item.Companies == "Missionator")
                { 
                    if (dataGridView_Display.InvokeRequired)
                    {
                        dataGridView_Display.Invoke(new MethodInvoker(delegate
                        {
                            addRows(item);
                        }));
                    }
                    else
                    {
                        addRows(item);
                    }
                }
                    if (statusStrip_Status.InvokeRequired)
                    {
                        statusStrip_Status.Invoke(new MethodInvoker(delegate
                        {
                            toolStripProgressBar_Progress.Value = (((i + 1) * 100) / items.Count);
                        }));
                    }
                    else
                        toolStripProgressBar_Progress.Value = (((i + 1) * 100) / items.Count);
                System.Windows.Forms.Application.DoEvents();
            }
        }

        public Mission OutlookItemToMission(Outlook.AppointmentItem item)
        {
            Outlook.OlResponseStatus response = item.ResponseStatus;
            bool done = (response == OlResponseStatus.olResponseAccepted);
            List<string> recipients = new List<string>();
           
          
            string[] recipientsNames = item.Mileage.ToString().Split(',');
              recipients =new List<string>(recipientsNames);

             
            
            return new Mission(item.Subject, item.Body, done, item.Start,recipients,item.Organizer);
        }
        void dateTimePicker_MaxDateMissions_ValueChanged(object sender, EventArgs e)
        {
            if (backgroundWorker_Loader.IsBusy)
                backgroundWorker_Loader=new BackgroundWorker();
          //  while (backgroundWorker_Loader.CancellationPending) ;
            backgroundWorker_Loader.RunWorkerAsync();
        }

        void dateTimePicker_MinDate_ValueChanged(object sender, EventArgs e)
        {
            if (backgroundWorker_Loader.IsBusy)
                backgroundWorker_Loader = new BackgroundWorker();
          //  while (backgroundWorker_Loader.CancellationPending) ;
            backgroundWorker_Loader.RunWorkerAsync();
        }
        static string GetRtfUnicodeEscapedString(string s)
        {
            var sb = new StringBuilder();
            foreach (var c in s)
            {
                if (c <= 0x7f)
                    sb.Append(c);
                else
                    sb.Append("\\u" + Convert.ToUInt32(c) + "?");
            }
            return sb.ToString();
        }
        public bool UpdateMissionDate(AppointmentItem appointment,Mission m,string update)
        {
            if (update == "" && m.DueDate == appointment.Start)
                return false;
            Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.NameSpace ns = app.GetNamespace("MAPI");
            Outlook.MAPIFolder f = ns.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
            byte[] origText = (byte[])appointment.RTFBody;

            string s = System.Text.Encoding.UTF8.GetString(origText);
            s = s.Remove(s.LastIndexOf('}'), 1);


            s += @"\line\fs36\cf2 " + DateTime.Now.ToString();
            if (update != "")
                s += @" \line\cf1\fs24 " + GetRtfUnicodeEscapedString(update.Replace("\n", @"\line"));
            if (m.DueDate != appointment.Start)
                s += @" \line\line\fs20\cf3 " + GetRtfUnicodeEscapedString("נקבע מועד הגשה חדש: ") + m.DueDate.ToShortDateString().Replace('/', '.');
            s += @"\line}";
         
         
            appointment.Start = m.DueDate;
            appointment.End = m.DueDate;
          //  System.Buffer.BlockCopy(origText, 0, merged, 0, origText.Length);
           // System.Buffer.BlockCopy(newText, 0, merged, origText.Length, newText.Length);
            appointment.RTFBody =System.Text.Encoding.UTF8.GetBytes(s);
            appointment.Companies = "Missionator";
            string resourceBuilder = "";
            foreach (string recipient in m.Recipients)
            {
                appointment.Recipients.Add(recipient);
                if (m.Recipients.IndexOf(recipient) > 0)
                    resourceBuilder += ",";
                resourceBuilder += recipient;
            }
            appointment.Mileage = resourceBuilder;
            Outlook.Recipients sentTo = appointment.Recipients;
            appointment.Save();





            //Outlook.AppointmentItem newAppointment =
            //      (Outlook.AppointmentItem)
            //  app.CreateItem(Outlook.OlItemType.olAppointmentItem);
            ////  string org = newAppointment.Organizer;
            ////   newAppointment.Resources = "Missionator";
            //newAppointment.Companies = "Missionator";
            //newAppointment.Start = m.DueDate.Date;
            //newAppointment.End = m.DueDate.Date;
            ////  newAppointment.Location = "ConferenceRoom #2345";


            //newAppointment.RTFBody =  System.Text.Encoding.UTF8.GetBytes(s);;

            //newAppointment.AllDayEvent = true;
            //newAppointment.Subject = m.Title;
            //string resourceBuilder = "";
            //foreach (string recipient in m.Recipients)
            //{
            //    newAppointment.Recipients.Add(recipient);
            //    if (m.Recipients.IndexOf(recipient) > 0)
            //        resourceBuilder += ",";
            //    resourceBuilder += recipient;
            //}
            //newAppointment.Resources = resourceBuilder;
            //Outlook.Recipients sentTo = newAppointment.Recipients;
        
            //newAppointment.Save();

            return true;
        }
        public bool AssignMission(Mission m)
        {
          //  try
         //   {
                Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
                Microsoft.Office.Interop.Outlook.NameSpace ns = app.GetNamespace("MAPI");
                Outlook.MAPIFolder f = ns.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
        //        Thread.Sleep(5000); 
                Outlook.AppointmentItem newAppointment =
                    (Outlook.AppointmentItem)
                app.CreateItem(Outlook.OlItemType.olAppointmentItem);
              //  string org = newAppointment.Organizer;
             //   newAppointment.Resources = "Missionator";
                newAppointment.Companies = "Missionator";
                newAppointment.Start = m.DueDate.Date ;
                newAppointment.End = m.DueDate.Date;
              //  newAppointment.Location = "ConferenceRoom #2345";

 
                newAppointment.RTFBody =System.Text.Encoding.UTF8.GetBytes(@"
{\rtf1\ansi\deff0 {\fonttbl {\f0 Arial;}}
{\colortbl;\red0\green0\blue0;\red255\green0\blue0;\red122\green122\blue192;}
\qr\b\fs48" + GetRtfUnicodeEscapedString(m.Title)+@"\b0\line\line

\cf2\fs36
"+DateTime.Now.ToShortDateString()+@":\line
\cf1\fs24
"+GetRtfUnicodeEscapedString(m.Body.Replace("\n",@"\line"))+@"\line\line
\fs20\cf3 " + GetRtfUnicodeEscapedString("נקבע מועד הגשה ל: ") + m.DueDate.ToShortDateString().Replace('/', '.') + @"\cf1\fs24\line
}
");

            

                //newAppointment.RTFBody = @"{\rtf1\ansi\b "+m.Title+@"\b0.}";
                //newAppointment.RTFBody += "<h2><b>" + DateTime.Now.ToShortDateString() + ":</b></h2><br/>";
                //newAppointment.RTFBody += "<body>" + m.Body + "</body>";
             //   newAppointment.RTFBody.Replace("\n", "<br/>");
             
                newAppointment.AllDayEvent = true;
                newAppointment.Subject = m.Title;
                string resourceBuilder = "";
                foreach (string recipient in m.Recipients)
                {
                    newAppointment.Recipients.Add(recipient);
                    if (m.Recipients.IndexOf(recipient) > 0)
                        resourceBuilder += ",";
                    resourceBuilder += recipient;
                }
                newAppointment.Mileage = resourceBuilder;
                Outlook.Recipients sentTo = newAppointment.Recipients;
                //Outlook.Recipient sentInvite = null;
                //sentInvite = sentTo.Add("Holly Holt");
                //sentInvite.Type = (int)Outlook.OlMeetingRecipientType
                //    .olRequired;
                //sentInvite = sentTo.Add("David Junca ");
                //sentInvite.Type = (int)Outlook.OlMeetingRecipientType
                //    .olOptional;
                //sentTo.ResolveAll();
                newAppointment.Save();
             //   newAppointment.Display(true);
       //     }
        //    catch (Exception ex)
            //{
            //    MessageBox.Show("The following error occurred: " + ex.Message);
            //    return false;
            //}
            return true;
        }

        private void backgroundWorker_Loader_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadMissions(dateTimePicker_MinDate.Value, dateTimePicker_MaxDateMissions.Value);
        }

        private bool InsindeForm=false;
        private void Form_Main_MouseLeave(object sender, EventArgs e)
        {
            if (this.GetChildAtPoint(this.PointToClient(MousePosition)) == null)
            {
                Fadeout();
            }
          
       
        }
        private void Fadeout()
        {
            InsindeForm = false;
            while (this.Opacity > 0.8)
            {
                if (InsindeForm)
                {
                    this.Opacity = 1;
                    break;
                }
                this.Opacity -= 0.01;
                System.Windows.Forms.Application.DoEvents();
                Thread.Sleep(30);
            }
        }
        private void Form_Main_MouseEnter(object sender, EventArgs e)
        {
            InsindeForm = true;
            this.Opacity = 1;
        }

        private void button_AddMission_Click(object sender, EventArgs e)
        {
            AddMission newMission = new AddMission();
            if (newMission.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                AssignMission(newMission.currentMission);
                LoadMissions(dateTimePicker_MinDate.Value,dateTimePicker_MaxDateMissions.Value);
            }
        }



        private void dataGridView_Display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                AddMission updateMissionForm = new AddMission(missions[e.RowIndex]);
                if (updateMissionForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    UpdateMissionDate(appointments[e.RowIndex],updateMissionForm.currentMission,updateMissionForm.updateText);
                    LoadMissions(dateTimePicker_MinDate.Value, dateTimePicker_MaxDateMissions.Value);
                }
            }
        }
    }
}
