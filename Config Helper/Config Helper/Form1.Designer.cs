namespace Config_Helper
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfigFeature = new System.Windows.Forms.TextBox();
            this.txtUSState = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHide = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDropDown = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCourtCategory = new System.Windows.Forms.TextBox();
            this.txtConfigAttributeFeature = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbAttributes = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbQuickSelect = new System.Windows.Forms.ComboBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.ckbxAdult = new System.Windows.Forms.CheckBox();
            this.ckbxVeteran = new System.Windows.Forms.CheckBox();
            this.ckbxMentalHealth = new System.Windows.Forms.CheckBox();
            this.ckbxTribal = new System.Windows.Forms.CheckBox();
            this.ckbxJuvenile = new System.Windows.Forms.CheckBox();
            this.ckbxFamilyDependency = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Config Feature";
            // 
            // txtConfigFeature
            // 
            this.txtConfigFeature.Location = new System.Drawing.Point(12, 76);
            this.txtConfigFeature.Name = "txtConfigFeature";
            this.txtConfigFeature.Size = new System.Drawing.Size(262, 20);
            this.txtConfigFeature.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtConfigFeature, "Enter Purpose of Config Feature");
            this.txtConfigFeature.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConfigFeature_KeyUp);
            // 
            // txtUSState
            // 
            this.txtUSState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUSState.Location = new System.Drawing.Point(12, 183);
            this.txtUSState.Name = "txtUSState";
            this.txtUSState.Size = new System.Drawing.Size(77, 20);
            this.txtUSState.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtUSState, "Enter Affected US State (2 Characters)");
            this.txtUSState.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUSState_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "US State";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.Yellow;
            this.txtPath.HideSelection = false;
            this.txtPath.Location = new System.Drawing.Point(12, 297);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(262, 20);
            this.txtPath.TabIndex = 4;
            this.txtPath.Text = "/folder/filename.aspx";
            this.toolTip1.SetToolTip(this.txtPath, "Enter the file path: (i.e. /file/page.aspx)");
            this.txtPath.Enter += new System.EventHandler(this.txtPath_Enter);
            this.txtPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPath_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Config Item";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Path (Required) - /folder/filename.aspx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Show";
            // 
            // txtShow
            // 
            this.txtShow.HideSelection = false;
            this.txtShow.Location = new System.Drawing.Point(12, 343);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(262, 20);
            this.txtShow.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtShow, "Enter name/ID for Field to Show; Comma-separate multiple items");
            this.txtShow.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtShow_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Hide";
            // 
            // txtHide
            // 
            this.txtHide.HideSelection = false;
            this.txtHide.Location = new System.Drawing.Point(12, 389);
            this.txtHide.Name = "txtHide";
            this.txtHide.Size = new System.Drawing.Size(262, 20);
            this.txtHide.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtHide, "Enter name/ID for Field to Hide; Comma-separate multiple items");
            this.txtHide.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHide_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Drop Down";
            // 
            // txtDropDown
            // 
            this.txtDropDown.HideSelection = false;
            this.txtDropDown.Location = new System.Drawing.Point(12, 436);
            this.txtDropDown.Name = "txtDropDown";
            this.txtDropDown.Size = new System.Drawing.Size(262, 20);
            this.txtDropDown.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtDropDown, "Pre-Selected Option Value (i.e. EmergencyState=@USState)");
            this.txtDropDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDropDown_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(9, 467);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Court Category";
            // 
            // txtCourtCategory
            // 
            this.txtCourtCategory.HideSelection = false;
            this.txtCourtCategory.Location = new System.Drawing.Point(12, 483);
            this.txtCourtCategory.Name = "txtCourtCategory";
            this.txtCourtCategory.ReadOnly = true;
            this.txtCourtCategory.Size = new System.Drawing.Size(262, 20);
            this.txtCourtCategory.TabIndex = 8;
            // 
            // txtConfigAttributeFeature
            // 
            this.txtConfigAttributeFeature.Location = new System.Drawing.Point(12, 124);
            this.txtConfigAttributeFeature.Name = "txtConfigAttributeFeature";
            this.txtConfigAttributeFeature.Size = new System.Drawing.Size(262, 20);
            this.txtConfigAttributeFeature.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtConfigAttributeFeature, "Enter Purpose of Config Attribute Feature");
            this.txtConfigAttributeFeature.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConfigAttributeFeature_KeyUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(13, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Config Attribute Feature";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(8, 547);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "Config Attribute Item";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(9, 580);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Tag Name";
            // 
            // txtTagName
            // 
            this.txtTagName.Enabled = false;
            this.txtTagName.HideSelection = false;
            this.txtTagName.Location = new System.Drawing.Point(12, 596);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(262, 20);
            this.txtTagName.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtTagName, "Enter name/ID of Attribute");
            this.txtTagName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTagName_KeyUp);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(9, 629);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = "Attributes";
            // 
            // cmbAttributes
            // 
            this.cmbAttributes.Enabled = false;
            this.cmbAttributes.FormattingEnabled = true;
            this.cmbAttributes.Items.AddRange(new object[] {
            "courtcategory",
            "data-required",
            "data-shownodes",
            "dbtype",
            "id",
            "innerHTML",
            "name",
            "onClick",
            "ShowNodes",
            "style",
            "title",
            "value"});
            this.cmbAttributes.Location = new System.Drawing.Point(12, 646);
            this.cmbAttributes.Name = "cmbAttributes";
            this.cmbAttributes.Size = new System.Drawing.Size(152, 21);
            this.cmbAttributes.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cmbAttributes, "Enter Attribute type or enter custom Attribute");
            this.cmbAttributes.SelectedIndexChanged += new System.EventHandler(this.cmbAttributes_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(9, 681);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "Value";
            // 
            // txtValue
            // 
            this.txtValue.Enabled = false;
            this.txtValue.HideSelection = false;
            this.txtValue.Location = new System.Drawing.Point(12, 697);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(262, 20);
            this.txtValue.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtValue, "Enter Value for Selected Attribute");
            this.txtValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValue_KeyUp);
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(306, 29);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(621, 688);
            this.txtEditor.TabIndex = 44;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(13, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "Quick Select";
            // 
            // cmbQuickSelect
            // 
            this.cmbQuickSelect.FormattingEnabled = true;
            this.cmbQuickSelect.Items.AddRange(new object[] {
            "Add a Feature",
            "Show a Feature",
            "Hide a Feature",
            "Add an Attribute"});
            this.cmbQuickSelect.Location = new System.Drawing.Point(13, 29);
            this.cmbQuickSelect.Name = "cmbQuickSelect";
            this.cmbQuickSelect.Size = new System.Drawing.Size(261, 21);
            this.cmbQuickSelect.TabIndex = 19;
            this.cmbQuickSelect.SelectedIndexChanged += new System.EventHandler(this.cmbQuickSelect_SelectedIndexChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Green;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(306, 732);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(106, 23);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "Copy To Clipboard";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Red;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(821, 732);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(106, 23);
            this.btnClearAll.TabIndex = 20;
            this.btnClearAll.Text = "Reset";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(109, 167);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 13);
            this.label25.TabIndex = 50;
            this.label25.Text = "Court Specific";
            // 
            // ckbxAdult
            // 
            this.ckbxAdult.AutoSize = true;
            this.ckbxAdult.ForeColor = System.Drawing.Color.White;
            this.ckbxAdult.Location = new System.Drawing.Point(112, 185);
            this.ckbxAdult.Name = "ckbxAdult";
            this.ckbxAdult.Size = new System.Drawing.Size(50, 17);
            this.ckbxAdult.TabIndex = 13;
            this.ckbxAdult.Text = "Adult";
            this.ckbxAdult.UseVisualStyleBackColor = true;
            this.ckbxAdult.CheckedChanged += new System.EventHandler(this.ckbxAdult_CheckedChanged);
            // 
            // ckbxVeteran
            // 
            this.ckbxVeteran.AutoSize = true;
            this.ckbxVeteran.ForeColor = System.Drawing.Color.White;
            this.ckbxVeteran.Location = new System.Drawing.Point(112, 208);
            this.ckbxVeteran.Name = "ckbxVeteran";
            this.ckbxVeteran.Size = new System.Drawing.Size(63, 17);
            this.ckbxVeteran.TabIndex = 14;
            this.ckbxVeteran.Text = "Veteran";
            this.ckbxVeteran.UseVisualStyleBackColor = true;
            this.ckbxVeteran.CheckedChanged += new System.EventHandler(this.ckbxVeteran_CheckedChanged);
            // 
            // ckbxMentalHealth
            // 
            this.ckbxMentalHealth.AutoSize = true;
            this.ckbxMentalHealth.ForeColor = System.Drawing.Color.White;
            this.ckbxMentalHealth.Location = new System.Drawing.Point(181, 208);
            this.ckbxMentalHealth.Name = "ckbxMentalHealth";
            this.ckbxMentalHealth.Size = new System.Drawing.Size(92, 17);
            this.ckbxMentalHealth.TabIndex = 17;
            this.ckbxMentalHealth.Text = "Mental Health";
            this.ckbxMentalHealth.UseVisualStyleBackColor = true;
            this.ckbxMentalHealth.CheckedChanged += new System.EventHandler(this.ckbxMentalHealth_CheckedChanged);
            // 
            // ckbxTribal
            // 
            this.ckbxTribal.AutoSize = true;
            this.ckbxTribal.ForeColor = System.Drawing.Color.White;
            this.ckbxTribal.Location = new System.Drawing.Point(112, 231);
            this.ckbxTribal.Name = "ckbxTribal";
            this.ckbxTribal.Size = new System.Drawing.Size(52, 17);
            this.ckbxTribal.TabIndex = 15;
            this.ckbxTribal.Text = "Tribal";
            this.ckbxTribal.UseVisualStyleBackColor = true;
            this.ckbxTribal.CheckedChanged += new System.EventHandler(this.ckbxTribal_CheckedChanged);
            // 
            // ckbxJuvenile
            // 
            this.ckbxJuvenile.AutoSize = true;
            this.ckbxJuvenile.ForeColor = System.Drawing.Color.White;
            this.ckbxJuvenile.Location = new System.Drawing.Point(181, 185);
            this.ckbxJuvenile.Name = "ckbxJuvenile";
            this.ckbxJuvenile.Size = new System.Drawing.Size(65, 17);
            this.ckbxJuvenile.TabIndex = 16;
            this.ckbxJuvenile.Text = "Juvenile";
            this.ckbxJuvenile.UseVisualStyleBackColor = true;
            this.ckbxJuvenile.CheckedChanged += new System.EventHandler(this.ckbxJuvenile_CheckedChanged);
            // 
            // ckbxFamilyDependency
            // 
            this.ckbxFamilyDependency.AutoSize = true;
            this.ckbxFamilyDependency.ForeColor = System.Drawing.Color.White;
            this.ckbxFamilyDependency.Location = new System.Drawing.Point(181, 231);
            this.ckbxFamilyDependency.Name = "ckbxFamilyDependency";
            this.ckbxFamilyDependency.Size = new System.Drawing.Size(119, 17);
            this.ckbxFamilyDependency.TabIndex = 18;
            this.ckbxFamilyDependency.Text = "Family Dependency";
            this.ckbxFamilyDependency.UseVisualStyleBackColor = true;
            this.ckbxFamilyDependency.CheckedChanged += new System.EventHandler(this.ckbxFamilyDependency_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(943, 767);
            this.Controls.Add(this.ckbxFamilyDependency);
            this.Controls.Add(this.ckbxJuvenile);
            this.Controls.Add(this.ckbxTribal);
            this.Controls.Add(this.ckbxMentalHealth);
            this.Controls.Add(this.ckbxVeteran);
            this.Controls.Add(this.ckbxAdult);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.cmbQuickSelect);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cmbAttributes);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtTagName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtConfigAttributeFeature);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCourtCategory);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDropDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHide);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUSState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfigFeature);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfigFeature;
        private System.Windows.Forms.TextBox txtUSState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHide;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDropDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCourtCategory;
        private System.Windows.Forms.TextBox txtConfigAttributeFeature;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTagName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbAttributes;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cmbQuickSelect;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox ckbxAdult;
        private System.Windows.Forms.CheckBox ckbxVeteran;
        private System.Windows.Forms.CheckBox ckbxMentalHealth;
        private System.Windows.Forms.CheckBox ckbxTribal;
        private System.Windows.Forms.CheckBox ckbxJuvenile;
        private System.Windows.Forms.CheckBox ckbxFamilyDependency;
    }
}

