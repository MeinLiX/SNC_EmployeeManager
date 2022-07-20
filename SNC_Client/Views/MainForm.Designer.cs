namespace SNC_Client.Views
{
    partial class MainForm
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
            this.materialCardHeader = new MaterialSkin.Controls.MaterialCard();
            this.materialLabelHeader = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonDelete = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonEdit = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.materialCardHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCardHeader
            // 
            this.materialCardHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardHeader.Controls.Add(this.materialLabelHeader);
            this.materialCardHeader.Controls.Add(this.materialButtonAdd);
            this.materialCardHeader.Controls.Add(this.materialButtonDelete);
            this.materialCardHeader.Controls.Add(this.materialButtonEdit);
            this.materialCardHeader.Depth = 0;
            this.materialCardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCardHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardHeader.Location = new System.Drawing.Point(3, 24);
            this.materialCardHeader.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardHeader.Name = "materialCardHeader";
            this.materialCardHeader.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardHeader.Size = new System.Drawing.Size(794, 50);
            this.materialCardHeader.TabIndex = 0;
            // 
            // materialLabelHeader
            // 
            this.materialLabelHeader.AutoSize = true;
            this.materialLabelHeader.Depth = 0;
            this.materialLabelHeader.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelHeader.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabelHeader.Location = new System.Drawing.Point(17, 12);
            this.materialLabelHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelHeader.Name = "materialLabelHeader";
            this.materialLabelHeader.Size = new System.Drawing.Size(171, 24);
            this.materialLabelHeader.TabIndex = 1;
            this.materialLabelHeader.Text = "Employes manager";
            // 
            // materialButtonAdd
            // 
            this.materialButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAdd.Depth = 0;
            this.materialButtonAdd.HighEmphasis = true;
            this.materialButtonAdd.Icon = null;
            this.materialButtonAdd.Location = new System.Drawing.Point(568, 6);
            this.materialButtonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAdd.Name = "materialButtonAdd";
            this.materialButtonAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAdd.Size = new System.Drawing.Size(64, 36);
            this.materialButtonAdd.TabIndex = 0;
            this.materialButtonAdd.Text = "Add";
            this.materialButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAdd.UseAccentColor = false;
            this.materialButtonAdd.UseVisualStyleBackColor = true;
            this.materialButtonAdd.Click += new System.EventHandler(this.materialButtonAdd_Click);
            // 
            // materialButtonDelete
            // 
            this.materialButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonDelete.Depth = 0;
            this.materialButtonDelete.HighEmphasis = true;
            this.materialButtonDelete.Icon = null;
            this.materialButtonDelete.Location = new System.Drawing.Point(712, 6);
            this.materialButtonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDelete.Name = "materialButtonDelete";
            this.materialButtonDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonDelete.Size = new System.Drawing.Size(73, 36);
            this.materialButtonDelete.TabIndex = 0;
            this.materialButtonDelete.Text = "Delete";
            this.materialButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDelete.UseAccentColor = false;
            this.materialButtonDelete.UseVisualStyleBackColor = true;
            this.materialButtonDelete.Click += new System.EventHandler(this.materialButtonDelete_Click);
            // 
            // materialButtonEdit
            // 
            this.materialButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonEdit.Depth = 0;
            this.materialButtonEdit.HighEmphasis = true;
            this.materialButtonEdit.Icon = null;
            this.materialButtonEdit.Location = new System.Drawing.Point(640, 6);
            this.materialButtonEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonEdit.Name = "materialButtonEdit";
            this.materialButtonEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonEdit.Size = new System.Drawing.Size(64, 36);
            this.materialButtonEdit.TabIndex = 0;
            this.materialButtonEdit.Text = "Edit";
            this.materialButtonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonEdit.UseAccentColor = false;
            this.materialButtonEdit.UseVisualStyleBackColor = true;
            this.materialButtonEdit.Click += new System.EventHandler(this.materialButtonEdit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 74);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(794, 423);
            this.dataGridView.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.materialCardHeader);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialCardHeader.ResumeLayout(false);
            this.materialCardHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCardHeader;
        private MaterialSkin.Controls.MaterialButton materialButtonAdd;
        private MaterialSkin.Controls.MaterialButton materialButtonDelete;
        private MaterialSkin.Controls.MaterialButton materialButtonEdit;
        private DataGridView dataGridView;
        private MaterialSkin.Controls.MaterialLabel materialLabelHeader;
    }
}