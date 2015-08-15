namespace DoNotStarveTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.PhucHoiButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FolderSelectDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.TextBoxSourceDir = new System.Windows.Forms.TextBox();
            this.TextBoxDesDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonDesSelect = new System.Windows.Forms.Button();
            this.ButtonSourceSelect = new System.Windows.Forms.Button();
            this.XoaSnapShotButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SnapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NodeLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.snapshotItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapshotItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Highlight_Normal;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Name = "button1";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // PhucHoiButton
            // 
            this.PhucHoiButton.BackColor = System.Drawing.Color.Transparent;
            this.PhucHoiButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Highlight_Normal;
            resources.ApplyResources(this.PhucHoiButton, "PhucHoiButton");
            this.PhucHoiButton.FlatAppearance.BorderSize = 0;
            this.PhucHoiButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PhucHoiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PhucHoiButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PhucHoiButton.Name = "PhucHoiButton";
            this.PhucHoiButton.UseCompatibleTextRendering = true;
            this.PhucHoiButton.UseVisualStyleBackColor = false;
            this.PhucHoiButton.Click += new System.EventHandler(this.button2_Click);
            this.PhucHoiButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.PhucHoiButton.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.PhucHoiButton.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Normal;
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // TextBoxSourceDir
            // 
            this.TextBoxSourceDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(123)))), ((int)(((byte)(90)))));
            this.TextBoxSourceDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.TextBoxSourceDir, "TextBoxSourceDir");
            this.TextBoxSourceDir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextBoxSourceDir.Name = "TextBoxSourceDir";
            // 
            // TextBoxDesDir
            // 
            this.TextBoxDesDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(123)))), ((int)(((byte)(90)))));
            this.TextBoxDesDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.TextBoxDesDir, "TextBoxDesDir");
            this.TextBoxDesDir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextBoxDesDir.Name = "TextBoxDesDir";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ButtonDesSelect
            // 
            this.ButtonDesSelect.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDesSelect.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Normal;
            resources.ApplyResources(this.ButtonDesSelect, "ButtonDesSelect");
            this.ButtonDesSelect.FlatAppearance.BorderSize = 0;
            this.ButtonDesSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonDesSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonDesSelect.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonDesSelect.Name = "ButtonDesSelect";
            this.ButtonDesSelect.UseVisualStyleBackColor = false;
            this.ButtonDesSelect.Click += new System.EventHandler(this.ButtonDesSelect_Click);
            this.ButtonDesSelect.MouseLeave += new System.EventHandler(this.ButtonDesSelect_MouseLeave);
            this.ButtonDesSelect.MouseHover += new System.EventHandler(this.ButtonDesSelect_MouseHover);
            // 
            // ButtonSourceSelect
            // 
            this.ButtonSourceSelect.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSourceSelect.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Normal;
            resources.ApplyResources(this.ButtonSourceSelect, "ButtonSourceSelect");
            this.ButtonSourceSelect.FlatAppearance.BorderSize = 0;
            this.ButtonSourceSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonSourceSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonSourceSelect.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonSourceSelect.Name = "ButtonSourceSelect";
            this.ButtonSourceSelect.UseVisualStyleBackColor = false;
            this.ButtonSourceSelect.Click += new System.EventHandler(this.ButtonSourceSelect_Click);
            this.ButtonSourceSelect.MouseLeave += new System.EventHandler(this.ButtonSourceSelect_MouseLeave);
            this.ButtonSourceSelect.MouseHover += new System.EventHandler(this.ButtonSourceSelect_MouseHover);
            // 
            // XoaSnapShotButton
            // 
            this.XoaSnapShotButton.BackColor = System.Drawing.Color.Transparent;
            this.XoaSnapShotButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Normal;
            resources.ApplyResources(this.XoaSnapShotButton, "XoaSnapShotButton");
            this.XoaSnapShotButton.FlatAppearance.BorderSize = 0;
            this.XoaSnapShotButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.XoaSnapShotButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.XoaSnapShotButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.XoaSnapShotButton.Name = "XoaSnapShotButton";
            this.XoaSnapShotButton.UseVisualStyleBackColor = false;
            this.XoaSnapShotButton.Click += new System.EventHandler(this.button5_Click);
            this.XoaSnapShotButton.MouseLeave += new System.EventHandler(this.XoaSnapShotButton_MouseLeave);
            this.XoaSnapShotButton.MouseHover += new System.EventHandler(this.XoaSnapShotButton_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DoNotStarveTool.Properties.Resources.logo2;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnapID,
            this.Column1,
            this.Column2,
            this.NodeLink});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SnapID
            // 
            resources.ApplyResources(this.SnapID, "SnapID");
            this.SnapID.Name = "SnapID";
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // NodeLink
            // 
            resources.ApplyResources(this.NodeLink, "NodeLink");
            this.NodeLink.Name = "NodeLink";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::DoNotStarveTool.Properties.Resources.logo_Wilson;
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DoNotStarveTool.Properties.Resources.tools;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::DoNotStarveTool.Properties.Resources.TextBox_Normal;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::DoNotStarveTool.Properties.Resources.TextBox_Normal;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(123)))), ((int)(((byte)(90)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBoxSourceDir_TextChanged);
            // 
            // snapshotItemBindingSource
            // 
            this.snapshotItemBindingSource.DataSource = typeof(DoNotStarveTool.SnapshotItem);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Background_2;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.XoaSnapShotButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSourceSelect);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TextBoxSourceDir);
            this.Controls.Add(this.PhucHoiButton);
            this.Controls.Add(this.ButtonDesSelect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxDesDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapshotItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PhucHoiButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog FolderSelectDialog;
        private System.Windows.Forms.TextBox TextBoxSourceDir;
        private System.Windows.Forms.TextBox TextBoxDesDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonDesSelect;
        private System.Windows.Forms.Button ButtonSourceSelect;
        private System.Windows.Forms.Button XoaSnapShotButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource snapshotItemBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnapID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NodeLink;
    }
}

