namespace VideoSoftwareIndexer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvVideoSoftware = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bAddSoftware = new System.Windows.Forms.Button();
            this.bRemoveSoftware = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bAddCon = new System.Windows.Forms.Button();
            this.bRemoveCon = new System.Windows.Forms.Button();
            this.dgvCon = new System.Windows.Forms.DataGridView();
            this.cConDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRemovePro = new System.Windows.Forms.Button();
            this.bAddPro = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPro = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCommit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideoSoftware)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVideoSoftware
            // 
            this.dgvVideoSoftware.AllowUserToAddRows = false;
            this.dgvVideoSoftware.AllowUserToDeleteRows = false;
            this.dgvVideoSoftware.AllowUserToResizeColumns = false;
            this.dgvVideoSoftware.AllowUserToResizeRows = false;
            this.dgvVideoSoftware.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvVideoSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideoSoftware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cName,
            this.cIcon});
            this.dgvVideoSoftware.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVideoSoftware.Location = new System.Drawing.Point(3, 69);
            this.dgvVideoSoftware.MultiSelect = false;
            this.dgvVideoSoftware.Name = "dgvVideoSoftware";
            this.dgvVideoSoftware.RowHeadersVisible = false;
            this.dgvVideoSoftware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVideoSoftware.Size = new System.Drawing.Size(260, 348);
            this.dgvVideoSoftware.TabIndex = 0;
            this.dgvVideoSoftware.SelectionChanged += new System.EventHandler(this.dgvVideoSoftware_SelectionChanged);
            // 
            // cID
            // 
            this.cID.DataPropertyName = "ID";
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Width = 43;
            // 
            // cName
            // 
            this.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cName.DataPropertyName = "Name";
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            this.cName.Width = 60;
            // 
            // cIcon
            // 
            this.cIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cIcon.DataPropertyName = "SoftwareIcon";
            this.cIcon.HeaderText = "Icon";
            this.cIcon.Name = "cIcon";
            this.cIcon.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bAddSoftware);
            this.groupBox1.Controls.Add(this.bRemoveSoftware);
            this.groupBox1.Controls.Add(this.dgvVideoSoftware);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 420);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video software";
            // 
            // bAddSoftware
            // 
            this.bAddSoftware.AllowDrop = true;
            this.bAddSoftware.BackgroundImage = global::VideoSoftwareIndexer.Properties.Resources.add32DarkGreen;
            this.bAddSoftware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bAddSoftware.Location = new System.Drawing.Point(6, 31);
            this.bAddSoftware.Name = "bAddSoftware";
            this.bAddSoftware.Size = new System.Drawing.Size(32, 32);
            this.bAddSoftware.TabIndex = 2;
            this.bAddSoftware.UseVisualStyleBackColor = true;
            this.bAddSoftware.Click += new System.EventHandler(this.bAddSoftware_Click);
            // 
            // bRemoveSoftware
            // 
            this.bRemoveSoftware.AllowDrop = true;
            this.bRemoveSoftware.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bRemoveSoftware.BackgroundImage")));
            this.bRemoveSoftware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bRemoveSoftware.Location = new System.Drawing.Point(48, 31);
            this.bRemoveSoftware.Name = "bRemoveSoftware";
            this.bRemoveSoftware.Size = new System.Drawing.Size(32, 32);
            this.bRemoveSoftware.TabIndex = 1;
            this.bRemoveSoftware.UseVisualStyleBackColor = true;
            this.bRemoveSoftware.Click += new System.EventHandler(this.bRemoveSoftware_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bAddCon);
            this.groupBox2.Controls.Add(this.bRemoveCon);
            this.groupBox2.Controls.Add(this.dgvCon);
            this.groupBox2.Location = new System.Drawing.Point(284, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 420);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Software cons";
            // 
            // bAddCon
            // 
            this.bAddCon.AllowDrop = true;
            this.bAddCon.BackgroundImage = global::VideoSoftwareIndexer.Properties.Resources.add32DarkGreen;
            this.bAddCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bAddCon.Location = new System.Drawing.Point(6, 31);
            this.bAddCon.Name = "bAddCon";
            this.bAddCon.Size = new System.Drawing.Size(32, 32);
            this.bAddCon.TabIndex = 2;
            this.bAddCon.UseVisualStyleBackColor = true;
            this.bAddCon.Click += new System.EventHandler(this.bAddCon_Click);
            // 
            // bRemoveCon
            // 
            this.bRemoveCon.AllowDrop = true;
            this.bRemoveCon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bRemoveCon.BackgroundImage")));
            this.bRemoveCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bRemoveCon.Location = new System.Drawing.Point(48, 31);
            this.bRemoveCon.Name = "bRemoveCon";
            this.bRemoveCon.Size = new System.Drawing.Size(32, 32);
            this.bRemoveCon.TabIndex = 1;
            this.bRemoveCon.UseVisualStyleBackColor = true;
            this.bRemoveCon.Click += new System.EventHandler(this.bRemoveCon_Click);
            // 
            // dgvCon
            // 
            this.dgvCon.AllowUserToAddRows = false;
            this.dgvCon.AllowUserToDeleteRows = false;
            this.dgvCon.AllowUserToOrderColumns = true;
            this.dgvCon.AllowUserToResizeColumns = false;
            this.dgvCon.AllowUserToResizeRows = false;
            this.dgvCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cConDescription});
            this.dgvCon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCon.Location = new System.Drawing.Point(3, 69);
            this.dgvCon.MultiSelect = false;
            this.dgvCon.Name = "dgvCon";
            this.dgvCon.RowHeadersVisible = false;
            this.dgvCon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCon.Size = new System.Drawing.Size(260, 348);
            this.dgvCon.TabIndex = 0;
            this.dgvCon.SelectionChanged += new System.EventHandler(this.dgvCon_SelectionChanged);
            // 
            // cConDescription
            // 
            this.cConDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cConDescription.DataPropertyName = "Description";
            this.cConDescription.HeaderText = "Description";
            this.cConDescription.Name = "cConDescription";
            this.cConDescription.ReadOnly = true;
            // 
            // bRemovePro
            // 
            this.bRemovePro.AllowDrop = true;
            this.bRemovePro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bRemovePro.BackgroundImage")));
            this.bRemovePro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bRemovePro.Location = new System.Drawing.Point(48, 31);
            this.bRemovePro.Name = "bRemovePro";
            this.bRemovePro.Size = new System.Drawing.Size(32, 32);
            this.bRemovePro.TabIndex = 1;
            this.bRemovePro.UseVisualStyleBackColor = true;
            this.bRemovePro.Click += new System.EventHandler(this.bRemovePro_Click);
            // 
            // bAddPro
            // 
            this.bAddPro.AllowDrop = true;
            this.bAddPro.BackgroundImage = global::VideoSoftwareIndexer.Properties.Resources.add32DarkGreen;
            this.bAddPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bAddPro.Location = new System.Drawing.Point(6, 31);
            this.bAddPro.Name = "bAddPro";
            this.bAddPro.Size = new System.Drawing.Size(32, 32);
            this.bAddPro.TabIndex = 2;
            this.bAddPro.UseVisualStyleBackColor = true;
            this.bAddPro.Click += new System.EventHandler(this.bAddPro_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPro);
            this.groupBox3.Controls.Add(this.bAddPro);
            this.groupBox3.Controls.Add(this.bRemovePro);
            this.groupBox3.Location = new System.Drawing.Point(556, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 420);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Software pros";
            // 
            // dgvPro
            // 
            this.dgvPro.AllowUserToAddRows = false;
            this.dgvPro.AllowUserToDeleteRows = false;
            this.dgvPro.AllowUserToOrderColumns = true;
            this.dgvPro.AllowUserToResizeColumns = false;
            this.dgvPro.AllowUserToResizeRows = false;
            this.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvPro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPro.Location = new System.Drawing.Point(3, 69);
            this.dgvPro.MultiSelect = false;
            this.dgvPro.Name = "dgvPro";
            this.dgvPro.RowHeadersVisible = false;
            this.dgvPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPro.Size = new System.Drawing.Size(260, 348);
            this.dgvPro.TabIndex = 3;
            this.dgvPro.SelectionChanged += new System.EventHandler(this.dgvPro_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bCommit
            // 
            this.bCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCommit.Location = new System.Drawing.Point(18, 444);
            this.bCommit.Name = "bCommit";
            this.bCommit.Size = new System.Drawing.Size(799, 33);
            this.bCommit.TabIndex = 5;
            this.bCommit.Text = "COMMIT CHANGES";
            this.bCommit.UseVisualStyleBackColor = true;
            this.bCommit.Click += new System.EventHandler(this.bCommit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 489);
            this.Controls.Add(this.bCommit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video editing software indexer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideoSoftware)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVideoSoftware;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bRemoveSoftware;
        private System.Windows.Forms.Button bAddSoftware;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bAddCon;
        private System.Windows.Forms.Button bRemoveCon;
        private System.Windows.Forms.DataGridView dgvCon;
        private System.Windows.Forms.Button bRemovePro;
        private System.Windows.Forms.Button bAddPro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cConDescription;
        private System.Windows.Forms.DataGridView dgvPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewImageColumn cIcon;
        private System.Windows.Forms.Button bCommit;
    }
}

