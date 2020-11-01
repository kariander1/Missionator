namespace Missionator
{
    partial class AddMission
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
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_Sbuject = new System.Windows.Forms.TextBox();
            this.label_Subject = new System.Windows.Forms.Label();
            this.label_Body = new System.Windows.Forms.Label();
            this.richTextBox_Body = new System.Windows.Forms.RichTextBox();
            this.label_DueDate = new System.Windows.Forms.Label();
            this.dateTimePicker_dueDate = new System.Windows.Forms.DateTimePicker();
            this.label_Recipients = new System.Windows.Forms.Label();
            this.listBox_Recipients = new System.Windows.Forms.ListBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_AddRecipient = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_AddText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Title.Location = new System.Drawing.Point(92, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(140, 29);
            this.label_Title.TabIndex = 17;
            this.label_Title.Text = "הוסף משימה";
            // 
            // textBox_Sbuject
            // 
            this.textBox_Sbuject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_Sbuject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_Sbuject.Location = new System.Drawing.Point(97, 64);
            this.textBox_Sbuject.Name = "textBox_Sbuject";
            this.textBox_Sbuject.Size = new System.Drawing.Size(165, 21);
            this.textBox_Sbuject.TabIndex = 19;
            this.textBox_Sbuject.TextChanged += new System.EventHandler(this.textBox_Sbuject_TextChanged);
            // 
            // label_Subject
            // 
            this.label_Subject.AutoSize = true;
            this.label_Subject.Location = new System.Drawing.Point(30, 67);
            this.label_Subject.Name = "label_Subject";
            this.label_Subject.Size = new System.Drawing.Size(38, 15);
            this.label_Subject.TabIndex = 18;
            this.label_Subject.Text = "כותרת";
            // 
            // label_Body
            // 
            this.label_Body.AutoSize = true;
            this.label_Body.Location = new System.Drawing.Point(30, 91);
            this.label_Body.Name = "label_Body";
            this.label_Body.Size = new System.Drawing.Size(22, 15);
            this.label_Body.TabIndex = 20;
            this.label_Body.Text = "גוף";
            // 
            // richTextBox_Body
            // 
            this.richTextBox_Body.Location = new System.Drawing.Point(97, 91);
            this.richTextBox_Body.Name = "richTextBox_Body";
            this.richTextBox_Body.Size = new System.Drawing.Size(165, 96);
            this.richTextBox_Body.TabIndex = 21;
            this.richTextBox_Body.Text = "";
            this.richTextBox_Body.TextChanged += new System.EventHandler(this.textBox_Sbuject_TextChanged);
         
      
            // 
            // label_DueDate
            // 
            this.label_DueDate.AutoSize = true;
            this.label_DueDate.Location = new System.Drawing.Point(30, 191);
            this.label_DueDate.Name = "label_DueDate";
            this.label_DueDate.Size = new System.Drawing.Size(22, 15);
            this.label_DueDate.TabIndex = 22;
            this.label_DueDate.Text = "יעד";
            // 
            // dateTimePicker_dueDate
            // 
            this.dateTimePicker_dueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dueDate.Location = new System.Drawing.Point(97, 191);
            this.dateTimePicker_dueDate.Name = "dateTimePicker_dueDate";
            this.dateTimePicker_dueDate.Size = new System.Drawing.Size(106, 21);
            this.dateTimePicker_dueDate.TabIndex = 23;
            this.dateTimePicker_dueDate.ValueChanged += new System.EventHandler(this.dateTimePicker_dueDate_ValueChanged);
            // 
            // label_Recipients
            // 
            this.label_Recipients.AutoSize = true;
            this.label_Recipients.Location = new System.Drawing.Point(30, 219);
            this.label_Recipients.Name = "label_Recipients";
            this.label_Recipients.Size = new System.Drawing.Size(38, 15);
            this.label_Recipients.TabIndex = 24;
            this.label_Recipients.Text = "נמענים";
            // 
            // listBox_Recipients
            // 
            this.listBox_Recipients.FormattingEnabled = true;
            this.listBox_Recipients.ItemHeight = 15;
            this.listBox_Recipients.Location = new System.Drawing.Point(97, 218);
            this.listBox_Recipients.Name = "listBox_Recipients";
            this.listBox_Recipients.Size = new System.Drawing.Size(130, 34);
            this.listBox_Recipients.TabIndex = 25;
            // 
            // button_Remove
            // 
            this.button_Remove.AutoSize = true;
            this.button_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Remove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Remove.Image = global::Missionator.Properties.Resources.Awicons_Vista_Artistic_Minus;
            this.button_Remove.Location = new System.Drawing.Point(233, 232);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(18, 20);
            this.button_Remove.TabIndex = 27;
            this.button_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_AddRecipient
            // 
            this.button_AddRecipient.AutoSize = true;
            this.button_AddRecipient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_AddRecipient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddRecipient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_AddRecipient.Image = global::Missionator.Properties.Resources.Awicons_Vista_Artistic_Add;
            this.button_AddRecipient.Location = new System.Drawing.Point(233, 212);
            this.button_AddRecipient.Name = "button_AddRecipient";
            this.button_AddRecipient.Size = new System.Drawing.Size(18, 20);
            this.button_AddRecipient.TabIndex = 26;
            this.button_AddRecipient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddRecipient.UseVisualStyleBackColor = true;
            this.button_AddRecipient.Click += new System.EventHandler(this.button_AddRecipient_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.AutoSize = true;
            this.button_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Image = global::Missionator.Properties.Resources.cancel_512;
            this.button_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Cancel.Location = new System.Drawing.Point(83, 258);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(69, 32);
            this.button_Cancel.TabIndex = 16;
            this.button_Cancel.Text = "בטל";
            this.button_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.AutoSize = true;
            this.button_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.Enabled = false;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Image = global::Missionator.Properties.Resources.tick_128;
            this.button_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Add.Location = new System.Drawing.Point(158, 258);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(69, 32);
            this.button_Add.TabIndex = 15;
            this.button_Add.Text = "הוסף";
            this.button_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_AddText
            // 
            this.button_AddText.AutoSize = true;
            this.button_AddText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_AddText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddText.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_AddText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_AddText.Image = global::Missionator.Properties.Resources.Awicons_Vista_Artistic_Add;
            this.button_AddText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_AddText.Location = new System.Drawing.Point(268, 161);
            this.button_AddText.Name = "button_AddText";
            this.button_AddText.Size = new System.Drawing.Size(42, 26);
            this.button_AddText.TabIndex = 28;
            this.button_AddText.Text = "הוסף";
            this.button_AddText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddText.UseVisualStyleBackColor = true;
            this.button_AddText.Visible = false;
            this.button_AddText.Click += new System.EventHandler(this.button_AddText_Click);
            // 
            // AddMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(331, 302);
            this.Controls.Add(this.button_AddText);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_AddRecipient);
            this.Controls.Add(this.listBox_Recipients);
            this.Controls.Add(this.label_Recipients);
            this.Controls.Add(this.dateTimePicker_dueDate);
            this.Controls.Add(this.label_DueDate);
            this.Controls.Add(this.richTextBox_Body);
            this.Controls.Add(this.label_Body);
            this.Controls.Add(this.textBox_Sbuject);
            this.Controls.Add(this.label_Subject);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMission";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_Sbuject;
        private System.Windows.Forms.Label label_Subject;
        private System.Windows.Forms.Label label_Body;
        private System.Windows.Forms.RichTextBox richTextBox_Body;
        private System.Windows.Forms.Label label_DueDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dueDate;
        private System.Windows.Forms.Label label_Recipients;
        private System.Windows.Forms.ListBox listBox_Recipients;
        private System.Windows.Forms.Button button_AddRecipient;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_AddText;
    }
}