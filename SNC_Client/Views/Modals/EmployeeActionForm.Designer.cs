namespace SNC_Client.Views.Modals
{
    partial class EmployeeActionForm
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
            this.materialButtonCancel = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonAction = new MaterialSkin.Controls.MaterialButton();
            this.materialCardHeader = new MaterialSkin.Controls.MaterialCard();
            this.materialLabelHeader = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox2FirstName = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox2LastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox2Patronymic = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialMaskedTextBoxPhoneNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialTextBox2Email = new MaterialSkin.Controls.MaterialTextBox2();
            this.dateTimePickerLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxLastUpdate = new System.Windows.Forms.GroupBox();
            this.groupBoxCreated = new System.Windows.Forms.GroupBox();
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.materialTextBox2DRFO = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCardHeader.SuspendLayout();
            this.groupBoxLastUpdate.SuspendLayout();
            this.groupBoxCreated.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialButtonCancel
            // 
            this.materialButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCancel.Depth = 0;
            this.materialButtonCancel.HighEmphasis = true;
            this.materialButtonCancel.Icon = null;
            this.materialButtonCancel.Location = new System.Drawing.Point(398, 253);
            this.materialButtonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCancel.Name = "materialButtonCancel";
            this.materialButtonCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCancel.Size = new System.Drawing.Size(77, 36);
            this.materialButtonCancel.TabIndex = 7;
            this.materialButtonCancel.Text = "Cancel";
            this.materialButtonCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonCancel.UseAccentColor = false;
            this.materialButtonCancel.UseVisualStyleBackColor = true;
            this.materialButtonCancel.Click += new System.EventHandler(this.materialButtonCancel_Click);
            // 
            // materialButtonAction
            // 
            this.materialButtonAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAction.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAction.Depth = 0;
            this.materialButtonAction.HighEmphasis = true;
            this.materialButtonAction.Icon = null;
            this.materialButtonAction.Location = new System.Drawing.Point(316, 253);
            this.materialButtonAction.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAction.Name = "materialButtonAction";
            this.materialButtonAction.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAction.Size = new System.Drawing.Size(74, 36);
            this.materialButtonAction.TabIndex = 6;
            this.materialButtonAction.Text = "Action";
            this.materialButtonAction.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonAction.UseAccentColor = false;
            this.materialButtonAction.UseVisualStyleBackColor = true;
            this.materialButtonAction.Click += new System.EventHandler(this.materialButtonAction_Click);
            // 
            // materialCardHeader
            // 
            this.materialCardHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardHeader.Controls.Add(this.materialLabelHeader);
            this.materialCardHeader.Depth = 0;
            this.materialCardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCardHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardHeader.Location = new System.Drawing.Point(3, 0);
            this.materialCardHeader.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardHeader.Name = "materialCardHeader";
            this.materialCardHeader.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardHeader.Size = new System.Drawing.Size(494, 50);
            this.materialCardHeader.TabIndex = 1;
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
            this.materialLabelHeader.Size = new System.Drawing.Size(148, 24);
            this.materialLabelHeader.TabIndex = 0;
            this.materialLabelHeader.Text = "Employee action";
            // 
            // materialTextBox2FirstName
            // 
            this.materialTextBox2FirstName.AnimateReadOnly = false;
            this.materialTextBox2FirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox2FirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox2FirstName.Depth = 0;
            this.materialTextBox2FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2FirstName.HideSelection = true;
            this.materialTextBox2FirstName.Hint = "First Name";
            this.materialTextBox2FirstName.LeadingIcon = null;
            this.materialTextBox2FirstName.Location = new System.Drawing.Point(27, 67);
            this.materialTextBox2FirstName.MaxLength = 32767;
            this.materialTextBox2FirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2FirstName.Name = "materialTextBox2FirstName";
            this.materialTextBox2FirstName.PasswordChar = '\0';
            this.materialTextBox2FirstName.PrefixSuffixText = null;
            this.materialTextBox2FirstName.ReadOnly = false;
            this.materialTextBox2FirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox2FirstName.SelectedText = "";
            this.materialTextBox2FirstName.SelectionLength = 0;
            this.materialTextBox2FirstName.SelectionStart = 0;
            this.materialTextBox2FirstName.ShortcutsEnabled = true;
            this.materialTextBox2FirstName.Size = new System.Drawing.Size(145, 48);
            this.materialTextBox2FirstName.TabIndex = 0;
            this.materialTextBox2FirstName.TabStop = false;
            this.materialTextBox2FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox2FirstName.TrailingIcon = null;
            this.materialTextBox2FirstName.UseSystemPasswordChar = false;
            // 
            // materialTextBox2LastName
            // 
            this.materialTextBox2LastName.AnimateReadOnly = false;
            this.materialTextBox2LastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox2LastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox2LastName.Depth = 0;
            this.materialTextBox2LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2LastName.HideSelection = true;
            this.materialTextBox2LastName.Hint = "Last Name";
            this.materialTextBox2LastName.LeadingIcon = null;
            this.materialTextBox2LastName.Location = new System.Drawing.Point(178, 67);
            this.materialTextBox2LastName.MaxLength = 32767;
            this.materialTextBox2LastName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2LastName.Name = "materialTextBox2LastName";
            this.materialTextBox2LastName.PasswordChar = '\0';
            this.materialTextBox2LastName.PrefixSuffixText = null;
            this.materialTextBox2LastName.ReadOnly = false;
            this.materialTextBox2LastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox2LastName.SelectedText = "";
            this.materialTextBox2LastName.SelectionLength = 0;
            this.materialTextBox2LastName.SelectionStart = 0;
            this.materialTextBox2LastName.ShortcutsEnabled = true;
            this.materialTextBox2LastName.Size = new System.Drawing.Size(146, 48);
            this.materialTextBox2LastName.TabIndex = 1;
            this.materialTextBox2LastName.TabStop = false;
            this.materialTextBox2LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox2LastName.TrailingIcon = null;
            this.materialTextBox2LastName.UseSystemPasswordChar = false;
            // 
            // materialTextBox2Patronymic
            // 
            this.materialTextBox2Patronymic.AnimateReadOnly = false;
            this.materialTextBox2Patronymic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox2Patronymic.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox2Patronymic.Depth = 0;
            this.materialTextBox2Patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2Patronymic.HideSelection = true;
            this.materialTextBox2Patronymic.Hint = "Patronymic";
            this.materialTextBox2Patronymic.LeadingIcon = null;
            this.materialTextBox2Patronymic.Location = new System.Drawing.Point(330, 67);
            this.materialTextBox2Patronymic.MaxLength = 32767;
            this.materialTextBox2Patronymic.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2Patronymic.Name = "materialTextBox2Patronymic";
            this.materialTextBox2Patronymic.PasswordChar = '\0';
            this.materialTextBox2Patronymic.PrefixSuffixText = null;
            this.materialTextBox2Patronymic.ReadOnly = false;
            this.materialTextBox2Patronymic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox2Patronymic.SelectedText = "";
            this.materialTextBox2Patronymic.SelectionLength = 0;
            this.materialTextBox2Patronymic.SelectionStart = 0;
            this.materialTextBox2Patronymic.ShortcutsEnabled = true;
            this.materialTextBox2Patronymic.Size = new System.Drawing.Size(145, 48);
            this.materialTextBox2Patronymic.TabIndex = 2;
            this.materialTextBox2Patronymic.TabStop = false;
            this.materialTextBox2Patronymic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox2Patronymic.TrailingIcon = null;
            this.materialTextBox2Patronymic.UseSystemPasswordChar = false;
            // 
            // materialMaskedTextBoxPhoneNumber
            // 
            this.materialMaskedTextBoxPhoneNumber.AllowPromptAsInput = true;
            this.materialMaskedTextBoxPhoneNumber.AnimateReadOnly = false;
            this.materialMaskedTextBoxPhoneNumber.AsciiOnly = false;
            this.materialMaskedTextBoxPhoneNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBoxPhoneNumber.BeepOnError = false;
            this.materialMaskedTextBoxPhoneNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxPhoneNumber.Depth = 0;
            this.materialMaskedTextBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBoxPhoneNumber.HidePromptOnLeave = false;
            this.materialMaskedTextBoxPhoneNumber.HideSelection = true;
            this.materialMaskedTextBoxPhoneNumber.Hint = "Phone Number";
            this.materialMaskedTextBoxPhoneNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBoxPhoneNumber.LeadingIcon = null;
            this.materialMaskedTextBoxPhoneNumber.Location = new System.Drawing.Point(254, 124);
            this.materialMaskedTextBoxPhoneNumber.Mask = "+000000000000";
            this.materialMaskedTextBoxPhoneNumber.MaxLength = 32767;
            this.materialMaskedTextBoxPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBoxPhoneNumber.Name = "materialMaskedTextBoxPhoneNumber";
            this.materialMaskedTextBoxPhoneNumber.PasswordChar = '\0';
            this.materialMaskedTextBoxPhoneNumber.PrefixSuffixText = null;
            this.materialMaskedTextBoxPhoneNumber.PromptChar = '_';
            this.materialMaskedTextBoxPhoneNumber.ReadOnly = false;
            this.materialMaskedTextBoxPhoneNumber.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBoxPhoneNumber.ResetOnPrompt = true;
            this.materialMaskedTextBoxPhoneNumber.ResetOnSpace = true;
            this.materialMaskedTextBoxPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBoxPhoneNumber.SelectedText = "";
            this.materialMaskedTextBoxPhoneNumber.SelectionLength = 0;
            this.materialMaskedTextBoxPhoneNumber.SelectionStart = 0;
            this.materialMaskedTextBoxPhoneNumber.ShortcutsEnabled = true;
            this.materialMaskedTextBoxPhoneNumber.Size = new System.Drawing.Size(221, 36);
            this.materialMaskedTextBoxPhoneNumber.SkipLiterals = true;
            this.materialMaskedTextBoxPhoneNumber.TabIndex = 4;
            this.materialMaskedTextBoxPhoneNumber.TabStop = false;
            this.materialMaskedTextBoxPhoneNumber.Text = "+";
            this.materialMaskedTextBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBoxPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxPhoneNumber.TrailingIcon = null;
            this.materialMaskedTextBoxPhoneNumber.UseSystemPasswordChar = false;
            this.materialMaskedTextBoxPhoneNumber.UseTallSize = false;
            this.materialMaskedTextBoxPhoneNumber.ValidatingType = null;
            // 
            // materialTextBox2Email
            // 
            this.materialTextBox2Email.AnimateReadOnly = false;
            this.materialTextBox2Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox2Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox2Email.Depth = 0;
            this.materialTextBox2Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2Email.HideSelection = true;
            this.materialTextBox2Email.Hint = "Email";
            this.materialTextBox2Email.LeadingIcon = null;
            this.materialTextBox2Email.Location = new System.Drawing.Point(27, 124);
            this.materialTextBox2Email.MaxLength = 32767;
            this.materialTextBox2Email.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2Email.Name = "materialTextBox2Email";
            this.materialTextBox2Email.PasswordChar = '\0';
            this.materialTextBox2Email.PrefixSuffixText = null;
            this.materialTextBox2Email.ReadOnly = false;
            this.materialTextBox2Email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox2Email.SelectedText = "";
            this.materialTextBox2Email.SelectionLength = 0;
            this.materialTextBox2Email.SelectionStart = 0;
            this.materialTextBox2Email.ShortcutsEnabled = true;
            this.materialTextBox2Email.Size = new System.Drawing.Size(221, 36);
            this.materialTextBox2Email.TabIndex = 3;
            this.materialTextBox2Email.TabStop = false;
            this.materialTextBox2Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox2Email.TrailingIcon = null;
            this.materialTextBox2Email.UseSystemPasswordChar = false;
            this.materialTextBox2Email.UseTallSize = false;
            // 
            // dateTimePickerLastUpdate
            // 
            this.dateTimePickerLastUpdate.Enabled = false;
            this.dateTimePickerLastUpdate.Location = new System.Drawing.Point(6, 22);
            this.dateTimePickerLastUpdate.Name = "dateTimePickerLastUpdate";
            this.dateTimePickerLastUpdate.Size = new System.Drawing.Size(209, 23);
            this.dateTimePickerLastUpdate.TabIndex = 0;
            // 
            // groupBoxLastUpdate
            // 
            this.groupBoxLastUpdate.Controls.Add(this.dateTimePickerLastUpdate);
            this.groupBoxLastUpdate.Location = new System.Drawing.Point(27, 232);
            this.groupBoxLastUpdate.Name = "groupBoxLastUpdate";
            this.groupBoxLastUpdate.Size = new System.Drawing.Size(221, 57);
            this.groupBoxLastUpdate.TabIndex = 5;
            this.groupBoxLastUpdate.TabStop = false;
            this.groupBoxLastUpdate.Text = "Last Update";
            // 
            // groupBoxCreated
            // 
            this.groupBoxCreated.Controls.Add(this.dateTimePickerCreated);
            this.groupBoxCreated.Location = new System.Drawing.Point(27, 169);
            this.groupBoxCreated.Name = "groupBoxCreated";
            this.groupBoxCreated.Size = new System.Drawing.Size(221, 57);
            this.groupBoxCreated.TabIndex = 5;
            this.groupBoxCreated.TabStop = false;
            this.groupBoxCreated.Text = "Created";
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Enabled = false;
            this.dateTimePickerCreated.Location = new System.Drawing.Point(6, 22);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(209, 23);
            this.dateTimePickerCreated.TabIndex = 0;
            // 
            // materialTextBox2DRFO
            // 
            this.materialTextBox2DRFO.AnimateReadOnly = false;
            this.materialTextBox2DRFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox2DRFO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox2DRFO.Depth = 0;
            this.materialTextBox2DRFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2DRFO.HideSelection = true;
            this.materialTextBox2DRFO.Hint = "DRFO";
            this.materialTextBox2DRFO.LeadingIcon = null;
            this.materialTextBox2DRFO.Location = new System.Drawing.Point(316, 169);
            this.materialTextBox2DRFO.MaxLength = 32767;
            this.materialTextBox2DRFO.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2DRFO.Name = "materialTextBox2DRFO";
            this.materialTextBox2DRFO.PasswordChar = '\0';
            this.materialTextBox2DRFO.PrefixSuffixText = null;
            this.materialTextBox2DRFO.ReadOnly = false;
            this.materialTextBox2DRFO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox2DRFO.SelectedText = "";
            this.materialTextBox2DRFO.SelectionLength = 0;
            this.materialTextBox2DRFO.SelectionStart = 0;
            this.materialTextBox2DRFO.ShortcutsEnabled = true;
            this.materialTextBox2DRFO.Size = new System.Drawing.Size(159, 48);
            this.materialTextBox2DRFO.TabIndex = 5;
            this.materialTextBox2DRFO.TabStop = false;
            this.materialTextBox2DRFO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox2DRFO.TrailingIcon = null;
            this.materialTextBox2DRFO.UseSystemPasswordChar = false;
            this.materialTextBox2DRFO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox2DRFO_KeyPress);
            // 
            // EmployeeActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 298);
            this.Controls.Add(this.groupBoxCreated);
            this.Controls.Add(this.groupBoxLastUpdate);
            this.Controls.Add(this.materialMaskedTextBoxPhoneNumber);
            this.Controls.Add(this.materialTextBox2Patronymic);
            this.Controls.Add(this.materialTextBox2DRFO);
            this.Controls.Add(this.materialTextBox2LastName);
            this.Controls.Add(this.materialTextBox2Email);
            this.Controls.Add(this.materialTextBox2FirstName);
            this.Controls.Add(this.materialCardHeader);
            this.Controls.Add(this.materialButtonAction);
            this.Controls.Add(this.materialButtonCancel);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "EmployeeActionForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeActionForm";
            this.materialCardHeader.ResumeLayout(false);
            this.materialCardHeader.PerformLayout();
            this.groupBoxLastUpdate.ResumeLayout(false);
            this.groupBoxCreated.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonCancel;
        private MaterialSkin.Controls.MaterialButton materialButtonAction;
        private MaterialSkin.Controls.MaterialCard materialCardHeader;
        private MaterialSkin.Controls.MaterialLabel materialLabelHeader;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox2FirstName;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox2LastName;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox2Patronymic;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBoxPhoneNumber;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox2Email;
        private DateTimePicker dateTimePickerLastUpdate;
        private GroupBox groupBoxLastUpdate;
        private GroupBox groupBoxCreated;
        private DateTimePicker dateTimePickerCreated;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox2DRFO;
    }
}