namespace Missionator
{
    partial class Form_Main
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
            this.statusStrip_Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Name = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar_Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.dataGridView_Display = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_MaxDateMissions = new System.Windows.Forms.DateTimePicker();
            this.label_MaxDate = new System.Windows.Forms.Label();
            this.label_MinDate = new System.Windows.Forms.Label();
            this.dateTimePicker_MinDate = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker_Loader = new System.ComponentModel.BackgroundWorker();
            this.button_AddMission = new System.Windows.Forms.Button();
            this.Col_image = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_cluster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_machineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_comments = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statusStrip_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip_Status
            // 
            this.statusStrip_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Name,
            this.toolStripProgressBar_Progress});
            this.statusStrip_Status.Location = new System.Drawing.Point(0, 310);
            this.statusStrip_Status.Name = "statusStrip_Status";
            this.statusStrip_Status.Padding = new System.Windows.Forms.Padding(16, 0, 1, 0);
            this.statusStrip_Status.Size = new System.Drawing.Size(635, 22);
            this.statusStrip_Status.TabIndex = 0;
            this.statusStrip_Status.Text = "statusStrip_Name";
            // 
            // toolStripStatusLabel_Name
            // 
            this.toolStripStatusLabel_Name.Name = "toolStripStatusLabel_Name";
            this.toolStripStatusLabel_Name.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel_Name.Text = "מחובר כ:";
            // 
            // toolStripProgressBar_Progress
            // 
            this.toolStripProgressBar_Progress.Name = "toolStripProgressBar_Progress";
            this.toolStripProgressBar_Progress.Size = new System.Drawing.Size(400, 16);
            // 
            // dataGridView_Display
            // 
            this.dataGridView_Display.AllowUserToAddRows = false;
            this.dataGridView_Display.AllowUserToDeleteRows = false;
            this.dataGridView_Display.AllowUserToOrderColumns = true;
            this.dataGridView_Display.AllowUserToResizeRows = false;
            this.dataGridView_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Display.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_image,
            this.Col_cluster,
            this.Col_machineName,
            this.Col_IP,
            this.Col_comments});
            this.dataGridView_Display.Location = new System.Drawing.Point(14, 35);
            this.dataGridView_Display.MultiSelect = false;
            this.dataGridView_Display.Name = "dataGridView_Display";
            this.dataGridView_Display.ReadOnly = true;
            this.dataGridView_Display.RowHeadersVisible = false;
            this.dataGridView_Display.Size = new System.Drawing.Size(618, 245);
            this.dataGridView_Display.TabIndex = 2;
            this.dataGridView_Display.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Display_CellContentClick);
            // 
            // dateTimePicker_MaxDateMissions
            // 
            this.dateTimePicker_MaxDateMissions.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_MaxDateMissions.Location = new System.Drawing.Point(523, 8);
            this.dateTimePicker_MaxDateMissions.Name = "dateTimePicker_MaxDateMissions";
            this.dateTimePicker_MaxDateMissions.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker_MaxDateMissions.TabIndex = 3;
            // 
            // label_MaxDate
            // 
            this.label_MaxDate.AutoSize = true;
            this.label_MaxDate.Location = new System.Drawing.Point(435, 9);
            this.label_MaxDate.Name = "label_MaxDate";
            this.label_MaxDate.Size = new System.Drawing.Size(82, 15);
            this.label_MaxDate.TabIndex = 4;
            this.label_MaxDate.Text = "הצג משימות עד:";
            // 
            // label_MinDate
            // 
            this.label_MinDate.AutoSize = true;
            this.label_MinDate.Location = new System.Drawing.Point(251, 12);
            this.label_MinDate.Name = "label_MinDate";
            this.label_MinDate.Size = new System.Drawing.Size(77, 15);
            this.label_MinDate.TabIndex = 6;
            this.label_MinDate.Text = "הצג משימות מ:";
            // 
            // dateTimePicker_MinDate
            // 
            this.dateTimePicker_MinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_MinDate.Location = new System.Drawing.Point(334, 7);
            this.dateTimePicker_MinDate.Name = "dateTimePicker_MinDate";
            this.dateTimePicker_MinDate.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker_MinDate.TabIndex = 5;
            // 
            // backgroundWorker_Loader
            // 
            this.backgroundWorker_Loader.WorkerSupportsCancellation = true;
            this.backgroundWorker_Loader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Loader_DoWork);
            // 
            // button_AddMission
            // 
            this.button_AddMission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AddMission.Image = global::Missionator.Properties.Resources.Awicons_Vista_Artistic_Add;
            this.button_AddMission.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_AddMission.Location = new System.Drawing.Point(568, 284);
            this.button_AddMission.Name = "button_AddMission";
            this.button_AddMission.Size = new System.Drawing.Size(55, 23);
            this.button_AddMission.TabIndex = 7;
            this.button_AddMission.Text = "הוסף";
            this.button_AddMission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddMission.UseVisualStyleBackColor = true;
            this.button_AddMission.Click += new System.EventHandler(this.button_AddMission_Click);
            // 
            // Col_image
            // 
            this.Col_image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Col_image.FillWeight = 20F;
            this.Col_image.HeaderText = "בוצע?";
            this.Col_image.Name = "Col_image";
            this.Col_image.ReadOnly = true;
            this.Col_image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_image.Width = 42;
            // 
            // Col_cluster
            // 
            this.Col_cluster.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_cluster.HeaderText = "משימה";
            this.Col_cluster.Name = "Col_cluster";
            this.Col_cluster.ReadOnly = true;
            // 
            // Col_machineName
            // 
            this.Col_machineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_machineName.FillWeight = 145F;
            this.Col_machineName.HeaderText = "תאריך";
            this.Col_machineName.Name = "Col_machineName";
            this.Col_machineName.ReadOnly = true;
            // 
            // Col_IP
            // 
            this.Col_IP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_IP.HeaderText = "נמענים";
            this.Col_IP.Name = "Col_IP";
            this.Col_IP.ReadOnly = true;
            // 
            // Col_comments
            // 
            this.Col_comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_comments.FillWeight = 150F;
            this.Col_comments.HeaderText = "בקש דחיה";
            this.Col_comments.Name = "Col_comments";
            this.Col_comments.ReadOnly = true;
            this.Col_comments.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_comments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 332);
            this.Controls.Add(this.button_AddMission);
            this.Controls.Add(this.label_MinDate);
            this.Controls.Add(this.dateTimePicker_MinDate);
            this.Controls.Add(this.label_MaxDate);
            this.Controls.Add(this.dateTimePicker_MaxDateMissions);
            this.Controls.Add(this.dataGridView_Display);
            this.Controls.Add(this.statusStrip_Status);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "משימטור";
            this.MouseEnter += new System.EventHandler(this.Form_Main_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form_Main_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Form_Main_MouseEnter);
            this.statusStrip_Status.ResumeLayout(false);
            this.statusStrip_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Name;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_Progress;
        private System.Windows.Forms.DataGridView dataGridView_Display;
        private System.Windows.Forms.DateTimePicker dateTimePicker_MaxDateMissions;
        private System.Windows.Forms.Label label_MaxDate;
        private System.Windows.Forms.Label label_MinDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_MinDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Loader;
        private System.Windows.Forms.Button button_AddMission;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_cluster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_machineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IP;
        private System.Windows.Forms.DataGridViewButtonColumn Col_comments;
    }
}

