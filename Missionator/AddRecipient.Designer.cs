namespace Missionator
{
    partial class AddRecipient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.listBox_Contacts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(40, 11);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(158, 21);
            this.textBox_Input.TabIndex = 0;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 14);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(26, 15);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "מייל";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(204, 10);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(40, 23);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "הוסף";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // listBox_Contacts
            // 
            this.listBox_Contacts.FormattingEnabled = true;
            this.listBox_Contacts.ItemHeight = 15;
            this.listBox_Contacts.Location = new System.Drawing.Point(15, 38);
            this.listBox_Contacts.Name = "listBox_Contacts";
            this.listBox_Contacts.Size = new System.Drawing.Size(226, 109);
            this.listBox_Contacts.TabIndex = 3;
            this.listBox_Contacts.SelectedIndexChanged += new System.EventHandler(this.listBox_Contacts_SelectedIndexChanged);
            // 
            // AddRecipient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 157);
            this.Controls.Add(this.listBox_Contacts);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_Input);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddRecipient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecipient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ListBox listBox_Contacts;
    }
}