namespace HaloMCCPCSaveTransferTool.User_Controls
{
    partial class ImportPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImportMapsButton = new System.Windows.Forms.Button();
            this.ImportGametypesButton = new System.Windows.Forms.Button();
            this.GameTypeList = new System.Windows.Forms.DataGridView();
            this.GameTypeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameTypeCreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameTypeModifiedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameTypeLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MapList = new System.Windows.Forms.DataGridView();
            this.MapNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MapModifiedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MapLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapList)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.ColumnCount = 2;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutPanel.Controls.Add(this.MapList, 0, 0);
            this.LayoutPanel.Controls.Add(this.GameTypeList, 1, 0);
            this.LayoutPanel.Controls.Add(this.ImportMapsButton, 0, 1);
            this.LayoutPanel.Controls.Add(this.ImportGametypesButton, 1, 1);
            this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 2;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.LayoutPanel.Size = new System.Drawing.Size(983, 355);
            this.LayoutPanel.TabIndex = 0;
            // 
            // ImportMapsButton
            // 
            this.ImportMapsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportMapsButton.Location = new System.Drawing.Point(3, 308);
            this.ImportMapsButton.Name = "ImportMapsButton";
            this.ImportMapsButton.Size = new System.Drawing.Size(485, 44);
            this.ImportMapsButton.TabIndex = 0;
            this.ImportMapsButton.Text = "Import Selected Maps";
            this.ImportMapsButton.UseVisualStyleBackColor = true;
            this.ImportMapsButton.Click += new System.EventHandler(this.ImportMapsButton_Click);
            // 
            // ImportGametypesButton
            // 
            this.ImportGametypesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportGametypesButton.Location = new System.Drawing.Point(494, 308);
            this.ImportGametypesButton.Name = "ImportGametypesButton";
            this.ImportGametypesButton.Size = new System.Drawing.Size(486, 44);
            this.ImportGametypesButton.TabIndex = 1;
            this.ImportGametypesButton.Text = "Import Selected Gametypes";
            this.ImportGametypesButton.UseVisualStyleBackColor = true;
            this.ImportGametypesButton.Click += new System.EventHandler(this.ImportGametypesButton_Click);
            // 
            // GameTypeList
            // 
            this.GameTypeList.AllowUserToAddRows = false;
            this.GameTypeList.AllowUserToDeleteRows = false;
            this.GameTypeList.AllowUserToResizeRows = false;
            this.GameTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GameTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameTypeNameColumn,
            this.GameTypeCreatedColumn,
            this.GameTypeModifiedColumn,
            this.GameTypeLocationColumn});
            this.GameTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameTypeList.Location = new System.Drawing.Point(494, 3);
            this.GameTypeList.Name = "GameTypeList";
            this.GameTypeList.RowHeadersVisible = false;
            this.GameTypeList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GameTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GameTypeList.Size = new System.Drawing.Size(486, 299);
            this.GameTypeList.TabIndex = 7;
            // 
            // GameTypeNameColumn
            // 
            this.GameTypeNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GameTypeNameColumn.Frozen = true;
            this.GameTypeNameColumn.HeaderText = "Gametype";
            this.GameTypeNameColumn.Name = "GameTypeNameColumn";
            this.GameTypeNameColumn.ReadOnly = true;
            this.GameTypeNameColumn.Width = 80;
            // 
            // GameTypeCreatedColumn
            // 
            this.GameTypeCreatedColumn.HeaderText = "Created";
            this.GameTypeCreatedColumn.Name = "GameTypeCreatedColumn";
            this.GameTypeCreatedColumn.ReadOnly = true;
            // 
            // GameTypeModifiedColumn
            // 
            this.GameTypeModifiedColumn.HeaderText = "Modified";
            this.GameTypeModifiedColumn.Name = "GameTypeModifiedColumn";
            this.GameTypeModifiedColumn.ReadOnly = true;
            // 
            // GameTypeLocationColumn
            // 
            this.GameTypeLocationColumn.HeaderText = "Location";
            this.GameTypeLocationColumn.Name = "GameTypeLocationColumn";
            this.GameTypeLocationColumn.ReadOnly = true;
            // 
            // MapList
            // 
            this.MapList.AllowUserToAddRows = false;
            this.MapList.AllowUserToDeleteRows = false;
            this.MapList.AllowUserToResizeRows = false;
            this.MapList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MapList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MapList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MapNameColumn,
            this.CreatedDate,
            this.MapModifiedDateColumn,
            this.MapLocationColumn});
            this.MapList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapList.Location = new System.Drawing.Point(3, 3);
            this.MapList.Name = "MapList";
            this.MapList.RowHeadersVisible = false;
            this.MapList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MapList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MapList.Size = new System.Drawing.Size(485, 299);
            this.MapList.TabIndex = 8;
            // 
            // MapNameColumn
            // 
            this.MapNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MapNameColumn.Frozen = true;
            this.MapNameColumn.HeaderText = "Map";
            this.MapNameColumn.Name = "MapNameColumn";
            this.MapNameColumn.ReadOnly = true;
            this.MapNameColumn.Width = 81;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "Created";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // MapModifiedDateColumn
            // 
            this.MapModifiedDateColumn.HeaderText = "Modified";
            this.MapModifiedDateColumn.Name = "MapModifiedDateColumn";
            this.MapModifiedDateColumn.ReadOnly = true;
            // 
            // MapLocationColumn
            // 
            this.MapLocationColumn.HeaderText = "Location";
            this.MapLocationColumn.Name = "MapLocationColumn";
            this.MapLocationColumn.ReadOnly = true;
            // 
            // ImportPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LayoutPanel);
            this.Name = "ImportPanel";
            this.Size = new System.Drawing.Size(983, 355);
            this.LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.Button ImportMapsButton;
        private System.Windows.Forms.Button ImportGametypesButton;
        private System.Windows.Forms.DataGridView GameTypeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameTypeNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameTypeCreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameTypeModifiedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameTypeLocationColumn;
        private System.Windows.Forms.DataGridView MapList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapModifiedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapLocationColumn;
    }
}
