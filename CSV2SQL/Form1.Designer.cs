namespace CSV2SQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            ofd_CSVFile = new OpenFileDialog();
            lbl_CSVFile = new Label();
            lbl_SQLServer = new Label();
            grp_SQLInfo = new GroupBox();
            txt_SQLServerAddress = new TextBox();
            txt_SQLUserName = new TextBox();
            lbl_SQLUsername = new Label();
            txt_SQLPass = new TextBox();
            lbl_SQLPass = new Label();
            cmb_SQLDatabase = new ComboBox();
            lbl_SQLDatabase = new Label();
            lbl_SQLTable = new Label();
            cmb_SQLTable = new ComboBox();
            grp_SQLInfo.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(197, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // ofd_CSVFile
            // 
            ofd_CSVFile.Filter = "CSV Files|*.csv|All Files|*.*";
            // 
            // lbl_CSVFile
            // 
            lbl_CSVFile.AutoSize = true;
            lbl_CSVFile.Location = new Point(12, 9);
            lbl_CSVFile.Name = "lbl_CSVFile";
            lbl_CSVFile.Size = new Size(101, 15);
            lbl_CSVFile.TabIndex = 1;
            lbl_CSVFile.Text = "Click to select File";
            lbl_CSVFile.Click += lbl_CSVFile_Click;
            // 
            // lbl_SQLServer
            // 
            lbl_SQLServer.AutoSize = true;
            lbl_SQLServer.Location = new Point(6, 19);
            lbl_SQLServer.Name = "lbl_SQLServer";
            lbl_SQLServer.Size = new Size(84, 15);
            lbl_SQLServer.TabIndex = 2;
            lbl_SQLServer.Text = "Server Address";
            // 
            // grp_SQLInfo
            // 
            grp_SQLInfo.Controls.Add(lbl_SQLTable);
            grp_SQLInfo.Controls.Add(cmb_SQLTable);
            grp_SQLInfo.Controls.Add(lbl_SQLDatabase);
            grp_SQLInfo.Controls.Add(cmb_SQLDatabase);
            grp_SQLInfo.Controls.Add(txt_SQLPass);
            grp_SQLInfo.Controls.Add(lbl_SQLPass);
            grp_SQLInfo.Controls.Add(txt_SQLUserName);
            grp_SQLInfo.Controls.Add(lbl_SQLUsername);
            grp_SQLInfo.Controls.Add(txt_SQLServerAddress);
            grp_SQLInfo.Controls.Add(lbl_SQLServer);
            grp_SQLInfo.Location = new Point(12, 45);
            grp_SQLInfo.Name = "grp_SQLInfo";
            grp_SQLInfo.Size = new Size(184, 248);
            grp_SQLInfo.TabIndex = 3;
            grp_SQLInfo.TabStop = false;
            grp_SQLInfo.Text = "SQL Info";
            // 
            // txt_SQLServerAddress
            // 
            txt_SQLServerAddress.Location = new Point(6, 37);
            txt_SQLServerAddress.Name = "txt_SQLServerAddress";
            txt_SQLServerAddress.PlaceholderText = "sql.server.info";
            txt_SQLServerAddress.Size = new Size(170, 23);
            txt_SQLServerAddress.TabIndex = 3;
            // 
            // txt_SQLUserName
            // 
            txt_SQLUserName.Location = new Point(6, 81);
            txt_SQLUserName.Name = "txt_SQLUserName";
            txt_SQLUserName.PlaceholderText = "Username";
            txt_SQLUserName.Size = new Size(170, 23);
            txt_SQLUserName.TabIndex = 5;
            // 
            // lbl_SQLUsername
            // 
            lbl_SQLUsername.AutoSize = true;
            lbl_SQLUsername.Location = new Point(6, 63);
            lbl_SQLUsername.Name = "lbl_SQLUsername";
            lbl_SQLUsername.Size = new Size(60, 15);
            lbl_SQLUsername.TabIndex = 4;
            lbl_SQLUsername.Text = "Username";
            // 
            // txt_SQLPass
            // 
            txt_SQLPass.HideSelection = false;
            txt_SQLPass.Location = new Point(6, 125);
            txt_SQLPass.Name = "txt_SQLPass";
            txt_SQLPass.PasswordChar = '*';
            txt_SQLPass.PlaceholderText = "Password";
            txt_SQLPass.Size = new Size(170, 23);
            txt_SQLPass.TabIndex = 7;
            txt_SQLPass.LostFocus += Txt_SQLPass_LostFocus;
            // 
            // lbl_SQLPass
            // 
            lbl_SQLPass.AutoSize = true;
            lbl_SQLPass.Location = new Point(6, 107);
            lbl_SQLPass.Name = "lbl_SQLPass";
            lbl_SQLPass.Size = new Size(57, 15);
            lbl_SQLPass.TabIndex = 6;
            lbl_SQLPass.Text = "Password";
            // 
            // cmb_SQLDatabase
            // 
            cmb_SQLDatabase.Enabled = false;
            cmb_SQLDatabase.FormattingEnabled = true;
            cmb_SQLDatabase.Location = new Point(6, 169);
            cmb_SQLDatabase.Name = "cmb_SQLDatabase";
            cmb_SQLDatabase.Size = new Size(170, 23);
            cmb_SQLDatabase.TabIndex = 8;
            cmb_SQLDatabase.SelectedIndexChanged += Cmb_SQLDatabase_SelectedIndexChanged;
            // 
            // lbl_SQLDatabase
            // 
            lbl_SQLDatabase.AutoSize = true;
            lbl_SQLDatabase.Location = new Point(6, 151);
            lbl_SQLDatabase.Name = "lbl_SQLDatabase";
            lbl_SQLDatabase.Size = new Size(55, 15);
            lbl_SQLDatabase.TabIndex = 9;
            lbl_SQLDatabase.Text = "Database";
            // 
            // lbl_SQLTable
            // 
            lbl_SQLTable.AutoSize = true;
            lbl_SQLTable.Location = new Point(8, 195);
            lbl_SQLTable.Name = "lbl_SQLTable";
            lbl_SQLTable.Size = new Size(34, 15);
            lbl_SQLTable.TabIndex = 11;
            lbl_SQLTable.Text = "Table";
            // 
            // cmb_SQLTable
            // 
            cmb_SQLTable.Enabled = false;
            cmb_SQLTable.FormattingEnabled = true;
            cmb_SQLTable.Location = new Point(8, 213);
            cmb_SQLTable.Name = "cmb_SQLTable";
            cmb_SQLTable.Size = new Size(170, 23);
            cmb_SQLTable.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grp_SQLInfo);
            Controls.Add(lbl_CSVFile);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            grp_SQLInfo.ResumeLayout(false);
            grp_SQLInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button button1;
        private OpenFileDialog ofd_CSVFile;
        private Label lbl_CSVFile;
        private Label lbl_SQLServer;
        private GroupBox grp_SQLInfo;
        private TextBox txt_SQLPass;
        private Label lbl_SQLPass;
        private TextBox txt_SQLUserName;
        private Label lbl_SQLUsername;
        private TextBox txt_SQLServerAddress;
        private Label lbl_SQLTable;
        private ComboBox cmb_SQLTable;
        private Label lbl_SQLDatabase;
        private ComboBox cmb_SQLDatabase;
    }
}