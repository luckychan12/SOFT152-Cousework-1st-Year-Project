namespace SOFT152_Coursework
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblSelectLocation = new System.Windows.Forms.Label();
            this.CboSelectLocation = new System.Windows.Forms.ComboBox();
            this.DgvDisplayData = new System.Windows.Forms.DataGridView();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysOfFrost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmOfRain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursOfSunshine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblHeaderStreetName = new System.Windows.Forms.Label();
            this.LblHeaderCounty = new System.Windows.Forms.Label();
            this.LblHeaderPostCode = new System.Windows.Forms.Label();
            this.LblHeaderLatitude = new System.Windows.Forms.Label();
            this.LblHeaderLongitude = new System.Windows.Forms.Label();
            this.LblSelectYear = new System.Windows.Forms.Label();
            this.CboSelectYear = new System.Windows.Forms.ComboBox();
            this.LblHeaderYearComment = new System.Windows.Forms.Label();
            this.BtnAddYear = new System.Windows.Forms.Button();
            this.BtnAddLocation = new System.Windows.Forms.Button();
            this.BtnNextFinalYear = new System.Windows.Forms.Button();
            this.BtnPreviousFinalYear = new System.Windows.Forms.Button();
            this.BtnPreviousYear = new System.Windows.Forms.Button();
            this.BtnNextYear = new System.Windows.Forms.Button();
            this.LblYearDisplay = new System.Windows.Forms.Label();
            this.GrpBxYearComment = new System.Windows.Forms.GroupBox();
            this.TxtCommentDisplay = new System.Windows.Forms.TextBox();
            this.GrpBxLocation = new System.Windows.Forms.GroupBox();
            this.LblHeaderLocationName = new System.Windows.Forms.Label();
            this.TxtLocNameDisplay = new System.Windows.Forms.TextBox();
            this.TxtStrtNameDisplay = new System.Windows.Forms.TextBox();
            this.TxtCountyDisplay = new System.Windows.Forms.TextBox();
            this.TxtPostCodeDisplay = new System.Windows.Forms.TextBox();
            this.TxtLatitudeDisplay = new System.Windows.Forms.TextBox();
            this.TxtLongitudeDisplay = new System.Windows.Forms.TextBox();
            this.BtnSaveChanges = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYearSearch = new System.Windows.Forms.Button();
            this.BtnLocSearch = new System.Windows.Forms.Button();
            this.btnEnableEditing = new System.Windows.Forms.Button();
            this.btnShowStats = new System.Windows.Forms.Button();
            this.GrpAnalysisData = new System.Windows.Forms.GroupBox();
            this.LblRcdMinTemp = new System.Windows.Forms.Label();
            this.LblRcdMaxTemp = new System.Windows.Forms.Label();
            this.LblRMinTemp = new System.Windows.Forms.Label();
            this.LblRMaxTemp = new System.Windows.Forms.Label();
            this.LvlHeaderRecordStats = new System.Windows.Forms.Label();
            this.LblAvgSunshine = new System.Windows.Forms.Label();
            this.LblAvgRain = new System.Windows.Forms.Label();
            this.LblAvgFrost = new System.Windows.Forms.Label();
            this.LblAvgMinTemp = new System.Windows.Forms.Label();
            this.LblAvgMaxTemp = new System.Windows.Forms.Label();
            this.LblHeaderSun = new System.Windows.Forms.Label();
            this.LblHeaderRain = new System.Windows.Forms.Label();
            this.LblHeaderFrost = new System.Windows.Forms.Label();
            this.LblHeaderMinTemp = new System.Windows.Forms.Label();
            this.LblAvgHMaxTemp = new System.Windows.Forms.Label();
            this.LblHeaderAverages = new System.Windows.Forms.Label();
            this.CboScope = new System.Windows.Forms.ComboBox();
            this.LblHeaderViewMode = new System.Windows.Forms.Label();
            this.GrpGraphs = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboProperty = new System.Windows.Forms.ComboBox();
            this.LblHeaderGraphStat = new System.Windows.Forms.Label();
            this.GrpSideBox = new System.Windows.Forms.GroupBox();
            this.LblAnalysisSettings = new System.Windows.Forms.Label();
            this.BtnChangeSelectedFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblGraphSettings = new System.Windows.Forms.Label();
            this.lblcurrentFilePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblHeaderInfo = new System.Windows.Forms.Label();
            this.GrpMain = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDisplayData)).BeginInit();
            this.GrpBxYearComment.SuspendLayout();
            this.GrpBxLocation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GrpAnalysisData.SuspendLayout();
            this.GrpSideBox.SuspendLayout();
            this.GrpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblSelectLocation
            // 
            this.LblSelectLocation.AutoSize = true;
            this.LblSelectLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelectLocation.Location = new System.Drawing.Point(8, 10);
            this.LblSelectLocation.Name = "LblSelectLocation";
            this.LblSelectLocation.Size = new System.Drawing.Size(60, 13);
            this.LblSelectLocation.TabIndex = 3;
            this.LblSelectLocation.Text = "Location:";
            // 
            // CboSelectLocation
            // 
            this.CboSelectLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSelectLocation.FormattingEnabled = true;
            this.CboSelectLocation.Items.AddRange(new object[] {
            "No data - please Select a file"});
            this.CboSelectLocation.Location = new System.Drawing.Point(11, 25);
            this.CboSelectLocation.Name = "CboSelectLocation";
            this.CboSelectLocation.Size = new System.Drawing.Size(96, 21);
            this.CboSelectLocation.TabIndex = 4;
            this.CboSelectLocation.SelectedIndexChanged += new System.EventHandler(this.CboSelectLocation_SelectedIndexChanged);
            // 
            // DgvDisplayData
            // 
            this.DgvDisplayData.AllowUserToAddRows = false;
            this.DgvDisplayData.AllowUserToDeleteRows = false;
            this.DgvDisplayData.AllowUserToResizeColumns = false;
            this.DgvDisplayData.AllowUserToResizeRows = false;
            this.DgvDisplayData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDisplayData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvDisplayData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDisplayData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDisplayData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDisplayData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.MaxTemp,
            this.MinTemp,
            this.DaysOfFrost,
            this.mmOfRain,
            this.HoursOfSunshine});
            this.DgvDisplayData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvDisplayData.EnableHeadersVisualStyles = false;
            this.DgvDisplayData.GridColor = System.Drawing.SystemColors.Control;
            this.DgvDisplayData.Location = new System.Drawing.Point(150, 76);
            this.DgvDisplayData.Name = "DgvDisplayData";
            this.DgvDisplayData.ReadOnly = true;
            this.DgvDisplayData.RowHeadersVisible = false;
            this.DgvDisplayData.RowHeadersWidth = 90;
            this.DgvDisplayData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvDisplayData.Size = new System.Drawing.Size(482, 305);
            this.DgvDisplayData.TabIndex = 8;
            this.DgvDisplayData.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DgvDisplayData_CellBeginEdit);
            this.DgvDisplayData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDisplayData_CellEndEdit);
            // 
            // Month
            // 
            this.Month.FillWeight = 121.8274F;
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Month.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MaxTemp
            // 
            this.MaxTemp.FillWeight = 95.63451F;
            this.MaxTemp.HeaderText = "MaxTemp";
            this.MaxTemp.Name = "MaxTemp";
            this.MaxTemp.ReadOnly = true;
            this.MaxTemp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MinTemp
            // 
            this.MinTemp.FillWeight = 95.63451F;
            this.MinTemp.HeaderText = "MinTemp";
            this.MinTemp.Name = "MinTemp";
            this.MinTemp.ReadOnly = true;
            this.MinTemp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DaysOfFrost
            // 
            this.DaysOfFrost.FillWeight = 95.63451F;
            this.DaysOfFrost.HeaderText = "Days of frost";
            this.DaysOfFrost.Name = "DaysOfFrost";
            this.DaysOfFrost.ReadOnly = true;
            this.DaysOfFrost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mmOfRain
            // 
            this.mmOfRain.FillWeight = 95.63451F;
            this.mmOfRain.HeaderText = "mm of rain";
            this.mmOfRain.Name = "mmOfRain";
            this.mmOfRain.ReadOnly = true;
            this.mmOfRain.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HoursOfSunshine
            // 
            this.HoursOfSunshine.FillWeight = 95.63451F;
            this.HoursOfSunshine.HeaderText = "Hours of sunshine";
            this.HoursOfSunshine.Name = "HoursOfSunshine";
            this.HoursOfSunshine.ReadOnly = true;
            this.HoursOfSunshine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LblHeaderStreetName
            // 
            this.LblHeaderStreetName.AutoSize = true;
            this.LblHeaderStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderStreetName.Location = new System.Drawing.Point(6, 47);
            this.LblHeaderStreetName.Name = "LblHeaderStreetName";
            this.LblHeaderStreetName.Size = new System.Drawing.Size(49, 15);
            this.LblHeaderStreetName.TabIndex = 11;
            this.LblHeaderStreetName.Text = "Street:";
            // 
            // LblHeaderCounty
            // 
            this.LblHeaderCounty.AutoSize = true;
            this.LblHeaderCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderCounty.Location = new System.Drawing.Point(6, 97);
            this.LblHeaderCounty.Name = "LblHeaderCounty";
            this.LblHeaderCounty.Size = new System.Drawing.Size(54, 15);
            this.LblHeaderCounty.TabIndex = 13;
            this.LblHeaderCounty.Text = "County:";
            // 
            // LblHeaderPostCode
            // 
            this.LblHeaderPostCode.AutoSize = true;
            this.LblHeaderPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderPostCode.Location = new System.Drawing.Point(6, 133);
            this.LblHeaderPostCode.Name = "LblHeaderPostCode";
            this.LblHeaderPostCode.Size = new System.Drawing.Size(72, 15);
            this.LblHeaderPostCode.TabIndex = 15;
            this.LblHeaderPostCode.Text = "PostCode:";
            // 
            // LblHeaderLatitude
            // 
            this.LblHeaderLatitude.AutoSize = true;
            this.LblHeaderLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderLatitude.Location = new System.Drawing.Point(6, 174);
            this.LblHeaderLatitude.Name = "LblHeaderLatitude";
            this.LblHeaderLatitude.Size = new System.Drawing.Size(63, 15);
            this.LblHeaderLatitude.TabIndex = 17;
            this.LblHeaderLatitude.Text = "Latitude:";
            // 
            // LblHeaderLongitude
            // 
            this.LblHeaderLongitude.AutoSize = true;
            this.LblHeaderLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderLongitude.Location = new System.Drawing.Point(8, 215);
            this.LblHeaderLongitude.Name = "LblHeaderLongitude";
            this.LblHeaderLongitude.Size = new System.Drawing.Size(75, 15);
            this.LblHeaderLongitude.TabIndex = 19;
            this.LblHeaderLongitude.Text = "Longitude:";
            // 
            // LblSelectYear
            // 
            this.LblSelectYear.AutoSize = true;
            this.LblSelectYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelectYear.Location = new System.Drawing.Point(242, 10);
            this.LblSelectYear.Name = "LblSelectYear";
            this.LblSelectYear.Size = new System.Drawing.Size(37, 13);
            this.LblSelectYear.TabIndex = 5;
            this.LblSelectYear.Text = "Year:";
            // 
            // CboSelectYear
            // 
            this.CboSelectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSelectYear.FormattingEnabled = true;
            this.CboSelectYear.Items.AddRange(new object[] {
            "No data"});
            this.CboSelectYear.Location = new System.Drawing.Point(245, 25);
            this.CboSelectYear.Name = "CboSelectYear";
            this.CboSelectYear.Size = new System.Drawing.Size(99, 21);
            this.CboSelectYear.TabIndex = 6;
            this.CboSelectYear.SelectedIndexChanged += new System.EventHandler(this.CboSelectYear_SelectedIndexChanged);
            // 
            // LblHeaderYearComment
            // 
            this.LblHeaderYearComment.AutoSize = true;
            this.LblHeaderYearComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderYearComment.Location = new System.Drawing.Point(6, 12);
            this.LblHeaderYearComment.Name = "LblHeaderYearComment";
            this.LblHeaderYearComment.Size = new System.Drawing.Size(103, 15);
            this.LblHeaderYearComment.TabIndex = 9;
            this.LblHeaderYearComment.Text = "Year comment:";
            // 
            // BtnAddYear
            // 
            this.BtnAddYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddYear.Location = new System.Drawing.Point(414, 17);
            this.BtnAddYear.Name = "BtnAddYear";
            this.BtnAddYear.Size = new System.Drawing.Size(58, 35);
            this.BtnAddYear.TabIndex = 28;
            this.BtnAddYear.Text = "Add new year";
            this.BtnAddYear.UseVisualStyleBackColor = true;
            this.BtnAddYear.Visible = false;
            this.BtnAddYear.Click += new System.EventHandler(this.BtnAddYear_Click);
            // 
            // BtnAddLocation
            // 
            this.BtnAddLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddLocation.Location = new System.Drawing.Point(178, 17);
            this.BtnAddLocation.Name = "BtnAddLocation";
            this.BtnAddLocation.Size = new System.Drawing.Size(57, 35);
            this.BtnAddLocation.TabIndex = 29;
            this.BtnAddLocation.Text = "Add new location";
            this.BtnAddLocation.UseVisualStyleBackColor = true;
            this.BtnAddLocation.Visible = false;
            this.BtnAddLocation.Click += new System.EventHandler(this.BtnAddLocation_Click);
            // 
            // BtnNextFinalYear
            // 
            this.BtnNextFinalYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextFinalYear.Location = new System.Drawing.Point(445, 389);
            this.BtnNextFinalYear.Name = "BtnNextFinalYear";
            this.BtnNextFinalYear.Size = new System.Drawing.Size(39, 23);
            this.BtnNextFinalYear.TabIndex = 30;
            this.BtnNextFinalYear.Text = ">|";
            this.BtnNextFinalYear.UseVisualStyleBackColor = true;
            this.BtnNextFinalYear.Click += new System.EventHandler(this.BtnNextFinalYear_Click);
            // 
            // BtnPreviousFinalYear
            // 
            this.BtnPreviousFinalYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreviousFinalYear.Location = new System.Drawing.Point(179, 389);
            this.BtnPreviousFinalYear.Name = "BtnPreviousFinalYear";
            this.BtnPreviousFinalYear.Size = new System.Drawing.Size(39, 23);
            this.BtnPreviousFinalYear.TabIndex = 31;
            this.BtnPreviousFinalYear.Text = "|<";
            this.BtnPreviousFinalYear.UseVisualStyleBackColor = true;
            this.BtnPreviousFinalYear.Click += new System.EventHandler(this.BtnPreviousFinalYear_Click);
            // 
            // BtnPreviousYear
            // 
            this.BtnPreviousYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreviousYear.Location = new System.Drawing.Point(233, 389);
            this.BtnPreviousYear.Name = "BtnPreviousYear";
            this.BtnPreviousYear.Size = new System.Drawing.Size(39, 23);
            this.BtnPreviousYear.TabIndex = 33;
            this.BtnPreviousYear.Text = "<";
            this.BtnPreviousYear.UseVisualStyleBackColor = true;
            this.BtnPreviousYear.Click += new System.EventHandler(this.BtnPreviousYear_Click);
            // 
            // BtnNextYear
            // 
            this.BtnNextYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextYear.Location = new System.Drawing.Point(390, 389);
            this.BtnNextYear.Name = "BtnNextYear";
            this.BtnNextYear.Size = new System.Drawing.Size(39, 23);
            this.BtnNextYear.TabIndex = 32;
            this.BtnNextYear.Text = ">";
            this.BtnNextYear.UseVisualStyleBackColor = true;
            this.BtnNextYear.Click += new System.EventHandler(this.BtnNextYear_Click);
            // 
            // LblYearDisplay
            // 
            this.LblYearDisplay.AutoSize = true;
            this.LblYearDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYearDisplay.Location = new System.Drawing.Point(314, 392);
            this.LblYearDisplay.Name = "LblYearDisplay";
            this.LblYearDisplay.Size = new System.Drawing.Size(40, 16);
            this.LblYearDisplay.TabIndex = 34;
            this.LblYearDisplay.Text = "- - - -";
            // 
            // GrpBxYearComment
            // 
            this.GrpBxYearComment.Controls.Add(this.TxtCommentDisplay);
            this.GrpBxYearComment.Controls.Add(this.LblHeaderYearComment);
            this.GrpBxYearComment.Location = new System.Drawing.Point(10, 265);
            this.GrpBxYearComment.Name = "GrpBxYearComment";
            this.GrpBxYearComment.Size = new System.Drawing.Size(131, 85);
            this.GrpBxYearComment.TabIndex = 35;
            this.GrpBxYearComment.TabStop = false;
            // 
            // TxtCommentDisplay
            // 
            this.TxtCommentDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCommentDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtCommentDisplay.Location = new System.Drawing.Point(10, 30);
            this.TxtCommentDisplay.Multiline = true;
            this.TxtCommentDisplay.Name = "TxtCommentDisplay";
            this.TxtCommentDisplay.ReadOnly = true;
            this.TxtCommentDisplay.Size = new System.Drawing.Size(110, 49);
            this.TxtCommentDisplay.TabIndex = 11;
            this.TxtCommentDisplay.Text = "- - - - - - - - - - - - - -\r\n- - - - - - - - - - - - - -\r\n- - - - - - - - - - - -" +
    " - -";
            this.TxtCommentDisplay.TextChanged += new System.EventHandler(this.TxtCommentDisplay_TextChanged);
            this.TxtCommentDisplay.Enter += new System.EventHandler(this.TxtCommentDisplay_Enter);
            // 
            // GrpBxLocation
            // 
            this.GrpBxLocation.Controls.Add(this.LblHeaderLocationName);
            this.GrpBxLocation.Controls.Add(this.TxtLocNameDisplay);
            this.GrpBxLocation.Controls.Add(this.TxtStrtNameDisplay);
            this.GrpBxLocation.Controls.Add(this.TxtCountyDisplay);
            this.GrpBxLocation.Controls.Add(this.TxtPostCodeDisplay);
            this.GrpBxLocation.Controls.Add(this.TxtLatitudeDisplay);
            this.GrpBxLocation.Controls.Add(this.TxtLongitudeDisplay);
            this.GrpBxLocation.Controls.Add(this.LblHeaderStreetName);
            this.GrpBxLocation.Controls.Add(this.LblHeaderCounty);
            this.GrpBxLocation.Controls.Add(this.LblHeaderPostCode);
            this.GrpBxLocation.Controls.Add(this.LblHeaderLatitude);
            this.GrpBxLocation.Controls.Add(this.LblHeaderLongitude);
            this.GrpBxLocation.Location = new System.Drawing.Point(10, 10);
            this.GrpBxLocation.Name = "GrpBxLocation";
            this.GrpBxLocation.Size = new System.Drawing.Size(131, 253);
            this.GrpBxLocation.TabIndex = 36;
            this.GrpBxLocation.TabStop = false;
            // 
            // LblHeaderLocationName
            // 
            this.LblHeaderLocationName.AutoSize = true;
            this.LblHeaderLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderLocationName.Location = new System.Drawing.Point(7, 11);
            this.LblHeaderLocationName.Name = "LblHeaderLocationName";
            this.LblHeaderLocationName.Size = new System.Drawing.Size(71, 16);
            this.LblHeaderLocationName.TabIndex = 26;
            this.LblHeaderLocationName.Text = "Location:";
            // 
            // TxtLocNameDisplay
            // 
            this.TxtLocNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLocNameDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtLocNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLocNameDisplay.Location = new System.Drawing.Point(9, 29);
            this.TxtLocNameDisplay.Name = "TxtLocNameDisplay";
            this.TxtLocNameDisplay.ReadOnly = true;
            this.TxtLocNameDisplay.Size = new System.Drawing.Size(106, 14);
            this.TxtLocNameDisplay.TabIndex = 25;
            this.TxtLocNameDisplay.Text = "- - - - - - - - - - - - - -";
            this.TxtLocNameDisplay.TextChanged += new System.EventHandler(this.TxtLocNameDisplay_TextChanged);
            this.TxtLocNameDisplay.Enter += new System.EventHandler(this.TxtLocNameDisplay_Enter);
            // 
            // TxtStrtNameDisplay
            // 
            this.TxtStrtNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtStrtNameDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtStrtNameDisplay.Location = new System.Drawing.Point(9, 65);
            this.TxtStrtNameDisplay.Multiline = true;
            this.TxtStrtNameDisplay.Name = "TxtStrtNameDisplay";
            this.TxtStrtNameDisplay.ReadOnly = true;
            this.TxtStrtNameDisplay.Size = new System.Drawing.Size(106, 30);
            this.TxtStrtNameDisplay.TabIndex = 24;
            this.TxtStrtNameDisplay.Text = "- - - - - - - - - - - - - -";
            this.TxtStrtNameDisplay.TextChanged += new System.EventHandler(this.TxtStrtNameDisplay_TextChanged);
            this.TxtStrtNameDisplay.Enter += new System.EventHandler(this.TxtStrtNameDisplay_Enter);
            // 
            // TxtCountyDisplay
            // 
            this.TxtCountyDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCountyDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtCountyDisplay.Location = new System.Drawing.Point(9, 115);
            this.TxtCountyDisplay.MaximumSize = new System.Drawing.Size(110, 0);
            this.TxtCountyDisplay.Name = "TxtCountyDisplay";
            this.TxtCountyDisplay.ReadOnly = true;
            this.TxtCountyDisplay.Size = new System.Drawing.Size(110, 13);
            this.TxtCountyDisplay.TabIndex = 23;
            this.TxtCountyDisplay.Text = "- - - - - - - - - - - - - -";
            this.TxtCountyDisplay.TextChanged += new System.EventHandler(this.TxtCountyDisplay_TextChanged);
            this.TxtCountyDisplay.Enter += new System.EventHandler(this.TxtCountyDisplay_Enter);
            // 
            // TxtPostCodeDisplay
            // 
            this.TxtPostCodeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPostCodeDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtPostCodeDisplay.Location = new System.Drawing.Point(9, 151);
            this.TxtPostCodeDisplay.MaximumSize = new System.Drawing.Size(110, 0);
            this.TxtPostCodeDisplay.Name = "TxtPostCodeDisplay";
            this.TxtPostCodeDisplay.ReadOnly = true;
            this.TxtPostCodeDisplay.Size = new System.Drawing.Size(110, 13);
            this.TxtPostCodeDisplay.TabIndex = 22;
            this.TxtPostCodeDisplay.Text = "- - - - - - - - - - - - - -";
            this.TxtPostCodeDisplay.TextChanged += new System.EventHandler(this.TxtPostCodeDisplay_TextChanged);
            this.TxtPostCodeDisplay.Enter += new System.EventHandler(this.TxtPostCodeDisplay_Enter);
            // 
            // TxtLatitudeDisplay
            // 
            this.TxtLatitudeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLatitudeDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtLatitudeDisplay.Location = new System.Drawing.Point(9, 192);
            this.TxtLatitudeDisplay.MaximumSize = new System.Drawing.Size(110, 0);
            this.TxtLatitudeDisplay.Name = "TxtLatitudeDisplay";
            this.TxtLatitudeDisplay.ReadOnly = true;
            this.TxtLatitudeDisplay.Size = new System.Drawing.Size(110, 13);
            this.TxtLatitudeDisplay.TabIndex = 21;
            this.TxtLatitudeDisplay.Text = "- - - - - - - - - - - - - -";
            this.TxtLatitudeDisplay.TextChanged += new System.EventHandler(this.TxtLatitudeDisplay_TextChanged);
            this.TxtLatitudeDisplay.Enter += new System.EventHandler(this.TxtLatitudeDisplay_Enter);
            // 
            // TxtLongitudeDisplay
            // 
            this.TxtLongitudeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLongitudeDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtLongitudeDisplay.Location = new System.Drawing.Point(9, 233);
            this.TxtLongitudeDisplay.MinimumSize = new System.Drawing.Size(110, 0);
            this.TxtLongitudeDisplay.Name = "TxtLongitudeDisplay";
            this.TxtLongitudeDisplay.ReadOnly = true;
            this.TxtLongitudeDisplay.Size = new System.Drawing.Size(110, 13);
            this.TxtLongitudeDisplay.TabIndex = 20;
            this.TxtLongitudeDisplay.Text = "- - - - - - - - - - - - - -";
            this.TxtLongitudeDisplay.TextChanged += new System.EventHandler(this.TxtLongitudeDisplay_TextChanged);
            this.TxtLongitudeDisplay.Enter += new System.EventHandler(this.TxtLongitudeDisplay_Enter);
            // 
            // BtnSaveChanges
            // 
            this.BtnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveChanges.Location = new System.Drawing.Point(10, 387);
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.Size = new System.Drawing.Size(134, 25);
            this.BtnSaveChanges.TabIndex = 37;
            this.BtnSaveChanges.Text = "Save Changes";
            this.BtnSaveChanges.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSaveChanges.UseVisualStyleBackColor = true;
            this.BtnSaveChanges.Visible = false;
            this.BtnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYearSearch);
            this.groupBox1.Controls.Add(this.BtnLocSearch);
            this.groupBox1.Controls.Add(this.BtnAddLocation);
            this.groupBox1.Controls.Add(this.BtnAddYear);
            this.groupBox1.Controls.Add(this.CboSelectYear);
            this.groupBox1.Controls.Add(this.LblSelectYear);
            this.groupBox1.Controls.Add(this.CboSelectLocation);
            this.groupBox1.Controls.Add(this.LblSelectLocation);
            this.groupBox1.Location = new System.Drawing.Point(150, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 60);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // btnYearSearch
            // 
            this.btnYearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearSearch.Location = new System.Drawing.Point(350, 17);
            this.btnYearSearch.Name = "btnYearSearch";
            this.btnYearSearch.Size = new System.Drawing.Size(58, 35);
            this.btnYearSearch.TabIndex = 32;
            this.btnYearSearch.Text = "Search Year";
            this.btnYearSearch.UseVisualStyleBackColor = true;
            this.btnYearSearch.Click += new System.EventHandler(this.btnYearSearch_Click);
            // 
            // BtnLocSearch
            // 
            this.BtnLocSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLocSearch.Location = new System.Drawing.Point(113, 17);
            this.BtnLocSearch.Name = "BtnLocSearch";
            this.BtnLocSearch.Size = new System.Drawing.Size(57, 35);
            this.BtnLocSearch.TabIndex = 31;
            this.BtnLocSearch.Text = "Search Location";
            this.BtnLocSearch.UseVisualStyleBackColor = true;
            this.BtnLocSearch.Click += new System.EventHandler(this.BtnLocSearch_Click);
            // 
            // btnEnableEditing
            // 
            this.btnEnableEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableEditing.Location = new System.Drawing.Point(10, 356);
            this.btnEnableEditing.Name = "btnEnableEditing";
            this.btnEnableEditing.Size = new System.Drawing.Size(134, 25);
            this.btnEnableEditing.TabIndex = 7;
            this.btnEnableEditing.Text = "Enable editing";
            this.btnEnableEditing.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnableEditing.UseVisualStyleBackColor = true;
            this.btnEnableEditing.Click += new System.EventHandler(this.btnEnableEditing_Click);
            // 
            // btnShowStats
            // 
            this.btnShowStats.Location = new System.Drawing.Point(494, 388);
            this.btnShowStats.Name = "btnShowStats";
            this.btnShowStats.Size = new System.Drawing.Size(132, 24);
            this.btnShowStats.TabIndex = 39;
            this.btnShowStats.Text = "Show Analysis Tools";
            this.btnShowStats.UseVisualStyleBackColor = true;
            this.btnShowStats.Click += new System.EventHandler(this.btnShowAnalysisTools_Click);
            // 
            // GrpAnalysisData
            // 
            this.GrpAnalysisData.Controls.Add(this.LblRcdMinTemp);
            this.GrpAnalysisData.Controls.Add(this.LblRcdMaxTemp);
            this.GrpAnalysisData.Controls.Add(this.LblRMinTemp);
            this.GrpAnalysisData.Controls.Add(this.LblRMaxTemp);
            this.GrpAnalysisData.Controls.Add(this.LvlHeaderRecordStats);
            this.GrpAnalysisData.Controls.Add(this.LblAvgSunshine);
            this.GrpAnalysisData.Controls.Add(this.LblAvgRain);
            this.GrpAnalysisData.Controls.Add(this.LblAvgFrost);
            this.GrpAnalysisData.Controls.Add(this.LblAvgMinTemp);
            this.GrpAnalysisData.Controls.Add(this.LblAvgMaxTemp);
            this.GrpAnalysisData.Controls.Add(this.LblHeaderSun);
            this.GrpAnalysisData.Controls.Add(this.LblHeaderRain);
            this.GrpAnalysisData.Controls.Add(this.LblHeaderFrost);
            this.GrpAnalysisData.Controls.Add(this.LblHeaderMinTemp);
            this.GrpAnalysisData.Controls.Add(this.LblAvgHMaxTemp);
            this.GrpAnalysisData.Controls.Add(this.LblHeaderAverages);
            this.GrpAnalysisData.Location = new System.Drawing.Point(667, 3);
            this.GrpAnalysisData.Name = "GrpAnalysisData";
            this.GrpAnalysisData.Size = new System.Drawing.Size(235, 342);
            this.GrpAnalysisData.TabIndex = 40;
            this.GrpAnalysisData.TabStop = false;
            // 
            // LblRcdMinTemp
            // 
            this.LblRcdMinTemp.AutoSize = true;
            this.LblRcdMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRcdMinTemp.Location = new System.Drawing.Point(132, 290);
            this.LblRcdMinTemp.Name = "LblRcdMinTemp";
            this.LblRcdMinTemp.Size = new System.Drawing.Size(94, 16);
            this.LblRcdMinTemp.TabIndex = 50;
            this.LblRcdMinTemp.Text = "- - - - - - - - - -";
            // 
            // LblRcdMaxTemp
            // 
            this.LblRcdMaxTemp.AutoSize = true;
            this.LblRcdMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRcdMaxTemp.Location = new System.Drawing.Point(132, 258);
            this.LblRcdMaxTemp.Name = "LblRcdMaxTemp";
            this.LblRcdMaxTemp.Size = new System.Drawing.Size(94, 16);
            this.LblRcdMaxTemp.TabIndex = 49;
            this.LblRcdMaxTemp.Text = "- - - - - - - - - -";
            // 
            // LblRMinTemp
            // 
            this.LblRMinTemp.AutoSize = true;
            this.LblRMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRMinTemp.Location = new System.Drawing.Point(22, 289);
            this.LblRMinTemp.Name = "LblRMinTemp";
            this.LblRMinTemp.Size = new System.Drawing.Size(76, 16);
            this.LblRMinTemp.TabIndex = 48;
            this.LblRMinTemp.Text = "MinTemp:";
            // 
            // LblRMaxTemp
            // 
            this.LblRMaxTemp.AutoSize = true;
            this.LblRMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRMaxTemp.Location = new System.Drawing.Point(22, 257);
            this.LblRMaxTemp.Name = "LblRMaxTemp";
            this.LblRMaxTemp.Size = new System.Drawing.Size(80, 16);
            this.LblRMaxTemp.TabIndex = 47;
            this.LblRMaxTemp.Text = "MaxTemp:";
            // 
            // LvlHeaderRecordStats
            // 
            this.LvlHeaderRecordStats.AutoSize = true;
            this.LvlHeaderRecordStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvlHeaderRecordStats.Location = new System.Drawing.Point(21, 218);
            this.LvlHeaderRecordStats.Name = "LvlHeaderRecordStats";
            this.LvlHeaderRecordStats.Size = new System.Drawing.Size(117, 20);
            this.LvlHeaderRecordStats.TabIndex = 46;
            this.LvlHeaderRecordStats.Text = "Record stats:";
            // 
            // LblAvgSunshine
            // 
            this.LblAvgSunshine.AutoSize = true;
            this.LblAvgSunshine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvgSunshine.Location = new System.Drawing.Point(132, 193);
            this.LblAvgSunshine.Name = "LblAvgSunshine";
            this.LblAvgSunshine.Size = new System.Drawing.Size(94, 16);
            this.LblAvgSunshine.TabIndex = 45;
            this.LblAvgSunshine.Text = "- - - - - - - - - -";
            // 
            // LblAvgRain
            // 
            this.LblAvgRain.AutoSize = true;
            this.LblAvgRain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvgRain.Location = new System.Drawing.Point(132, 165);
            this.LblAvgRain.Name = "LblAvgRain";
            this.LblAvgRain.Size = new System.Drawing.Size(94, 16);
            this.LblAvgRain.TabIndex = 44;
            this.LblAvgRain.Text = "- - - - - - - - - -";
            // 
            // LblAvgFrost
            // 
            this.LblAvgFrost.AutoSize = true;
            this.LblAvgFrost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvgFrost.Location = new System.Drawing.Point(132, 133);
            this.LblAvgFrost.Name = "LblAvgFrost";
            this.LblAvgFrost.Size = new System.Drawing.Size(94, 16);
            this.LblAvgFrost.TabIndex = 43;
            this.LblAvgFrost.Text = "- - - - - - - - - -";
            // 
            // LblAvgMinTemp
            // 
            this.LblAvgMinTemp.AutoSize = true;
            this.LblAvgMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvgMinTemp.Location = new System.Drawing.Point(132, 104);
            this.LblAvgMinTemp.Name = "LblAvgMinTemp";
            this.LblAvgMinTemp.Size = new System.Drawing.Size(94, 16);
            this.LblAvgMinTemp.TabIndex = 42;
            this.LblAvgMinTemp.Text = "- - - - - - - - - -";
            // 
            // LblAvgMaxTemp
            // 
            this.LblAvgMaxTemp.AutoSize = true;
            this.LblAvgMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvgMaxTemp.Location = new System.Drawing.Point(132, 72);
            this.LblAvgMaxTemp.Name = "LblAvgMaxTemp";
            this.LblAvgMaxTemp.Size = new System.Drawing.Size(94, 16);
            this.LblAvgMaxTemp.TabIndex = 41;
            this.LblAvgMaxTemp.Text = "- - - - - - - - - -";
            // 
            // LblHeaderSun
            // 
            this.LblHeaderSun.AutoSize = true;
            this.LblHeaderSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderSun.Location = new System.Drawing.Point(22, 192);
            this.LblHeaderSun.Name = "LblHeaderSun";
            this.LblHeaderSun.Size = new System.Drawing.Size(98, 16);
            this.LblHeaderSun.TabIndex = 39;
            this.LblHeaderSun.Text = "Hours of sun:";
            // 
            // LblHeaderRain
            // 
            this.LblHeaderRain.AutoSize = true;
            this.LblHeaderRain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderRain.Location = new System.Drawing.Point(22, 164);
            this.LblHeaderRain.Name = "LblHeaderRain";
            this.LblHeaderRain.Size = new System.Drawing.Size(83, 16);
            this.LblHeaderRain.TabIndex = 38;
            this.LblHeaderRain.Text = "mm of rain:";
            // 
            // LblHeaderFrost
            // 
            this.LblHeaderFrost.AutoSize = true;
            this.LblHeaderFrost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderFrost.Location = new System.Drawing.Point(22, 132);
            this.LblHeaderFrost.Name = "LblHeaderFrost";
            this.LblHeaderFrost.Size = new System.Drawing.Size(99, 16);
            this.LblHeaderFrost.TabIndex = 37;
            this.LblHeaderFrost.Text = "Days of frost:";
            // 
            // LblHeaderMinTemp
            // 
            this.LblHeaderMinTemp.AutoSize = true;
            this.LblHeaderMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderMinTemp.Location = new System.Drawing.Point(22, 103);
            this.LblHeaderMinTemp.Name = "LblHeaderMinTemp";
            this.LblHeaderMinTemp.Size = new System.Drawing.Size(76, 16);
            this.LblHeaderMinTemp.TabIndex = 36;
            this.LblHeaderMinTemp.Text = "MinTemp:";
            // 
            // LblAvgHMaxTemp
            // 
            this.LblAvgHMaxTemp.AutoSize = true;
            this.LblAvgHMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvgHMaxTemp.Location = new System.Drawing.Point(22, 71);
            this.LblAvgHMaxTemp.Name = "LblAvgHMaxTemp";
            this.LblAvgHMaxTemp.Size = new System.Drawing.Size(80, 16);
            this.LblAvgHMaxTemp.TabIndex = 35;
            this.LblAvgHMaxTemp.Text = "MaxTemp:";
            // 
            // LblHeaderAverages
            // 
            this.LblHeaderAverages.AutoSize = true;
            this.LblHeaderAverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderAverages.Location = new System.Drawing.Point(21, 32);
            this.LblHeaderAverages.Name = "LblHeaderAverages";
            this.LblHeaderAverages.Size = new System.Drawing.Size(125, 20);
            this.LblHeaderAverages.TabIndex = 34;
            this.LblHeaderAverages.Text = "Average stats:";
            // 
            // CboScope
            // 
            this.CboScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboScope.FormattingEnabled = true;
            this.CboScope.Items.AddRange(new object[] {
            "All Locations",
            "Selected Location",
            "Selected Year"});
            this.CboScope.Location = new System.Drawing.Point(81, 87);
            this.CboScope.Name = "CboScope";
            this.CboScope.Size = new System.Drawing.Size(137, 21);
            this.CboScope.TabIndex = 34;
            this.CboScope.SelectedIndexChanged += new System.EventHandler(this.CboScope_SelectedIndexChanged);
            // 
            // LblHeaderViewMode
            // 
            this.LblHeaderViewMode.AutoSize = true;
            this.LblHeaderViewMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderViewMode.Location = new System.Drawing.Point(14, 88);
            this.LblHeaderViewMode.Name = "LblHeaderViewMode";
            this.LblHeaderViewMode.Size = new System.Drawing.Size(57, 16);
            this.LblHeaderViewMode.TabIndex = 1;
            this.LblHeaderViewMode.Text = "Scope:";
            // 
            // GrpGraphs
            // 
            this.GrpGraphs.Location = new System.Drawing.Point(10, 425);
            this.GrpGraphs.Name = "GrpGraphs";
            this.GrpGraphs.Size = new System.Drawing.Size(643, 261);
            this.GrpGraphs.TabIndex = 42;
            this.GrpGraphs.TabStop = false;
            this.GrpGraphs.Paint += new System.Windows.Forms.PaintEventHandler(this.GrpGraphs_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 180);
            this.label3.MaximumSize = new System.Drawing.Size(210, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "(For the selected scope)";
            // 
            // CboProperty
            // 
            this.CboProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProperty.FormattingEnabled = true;
            this.CboProperty.Items.AddRange(new object[] {
            "MaxTemp",
            "MinTemp",
            "Days of Frost",
            "mm of rain",
            "Hours of sunshine"});
            this.CboProperty.Location = new System.Drawing.Point(81, 155);
            this.CboProperty.Name = "CboProperty";
            this.CboProperty.Size = new System.Drawing.Size(137, 21);
            this.CboProperty.TabIndex = 52;
            this.CboProperty.SelectedIndexChanged += new System.EventHandler(this.CboProperty_SelectedIndexChanged);
            // 
            // LblHeaderGraphStat
            // 
            this.LblHeaderGraphStat.AutoSize = true;
            this.LblHeaderGraphStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderGraphStat.Location = new System.Drawing.Point(12, 156);
            this.LblHeaderGraphStat.Name = "LblHeaderGraphStat";
            this.LblHeaderGraphStat.Size = new System.Drawing.Size(61, 16);
            this.LblHeaderGraphStat.TabIndex = 51;
            this.LblHeaderGraphStat.Text = "Viewing: ";
            // 
            // GrpSideBox
            // 
            this.GrpSideBox.Controls.Add(this.LblAnalysisSettings);
            this.GrpSideBox.Controls.Add(this.CboScope);
            this.GrpSideBox.Controls.Add(this.LblHeaderViewMode);
            this.GrpSideBox.Controls.Add(this.BtnChangeSelectedFile);
            this.GrpSideBox.Controls.Add(this.label3);
            this.GrpSideBox.Controls.Add(this.label2);
            this.GrpSideBox.Controls.Add(this.CboProperty);
            this.GrpSideBox.Controls.Add(this.LblHeaderGraphStat);
            this.GrpSideBox.Controls.Add(this.LblGraphSettings);
            this.GrpSideBox.Controls.Add(this.lblcurrentFilePath);
            this.GrpSideBox.Controls.Add(this.label1);
            this.GrpSideBox.Controls.Add(this.LblHeaderInfo);
            this.GrpSideBox.Location = new System.Drawing.Point(667, 351);
            this.GrpSideBox.Name = "GrpSideBox";
            this.GrpSideBox.Size = new System.Drawing.Size(235, 334);
            this.GrpSideBox.TabIndex = 43;
            this.GrpSideBox.TabStop = false;
            // 
            // LblAnalysisSettings
            // 
            this.LblAnalysisSettings.AutoSize = true;
            this.LblAnalysisSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnalysisSettings.Location = new System.Drawing.Point(12, 59);
            this.LblAnalysisSettings.Name = "LblAnalysisSettings";
            this.LblAnalysisSettings.Size = new System.Drawing.Size(173, 18);
            this.LblAnalysisSettings.TabIndex = 55;
            this.LblAnalysisSettings.Text = "Analysis tool settings:";
            // 
            // BtnChangeSelectedFile
            // 
            this.BtnChangeSelectedFile.Location = new System.Drawing.Point(15, 304);
            this.BtnChangeSelectedFile.Name = "BtnChangeSelectedFile";
            this.BtnChangeSelectedFile.Size = new System.Drawing.Size(123, 24);
            this.BtnChangeSelectedFile.TabIndex = 40;
            this.BtnChangeSelectedFile.Text = "Change Selected file";
            this.BtnChangeSelectedFile.UseVisualStyleBackColor = true;
            this.BtnChangeSelectedFile.Click += new System.EventHandler(this.BtnChangeSelectedFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 122);
            this.label2.MaximumSize = new System.Drawing.Size(210, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 53;
            // 
            // LblGraphSettings
            // 
            this.LblGraphSettings.AutoSize = true;
            this.LblGraphSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGraphSettings.Location = new System.Drawing.Point(12, 127);
            this.LblGraphSettings.Name = "LblGraphSettings";
            this.LblGraphSettings.Size = new System.Drawing.Size(180, 18);
            this.LblGraphSettings.TabIndex = 52;
            this.LblGraphSettings.Text = "Graph display settings:";
            // 
            // lblcurrentFilePath
            // 
            this.lblcurrentFilePath.AutoSize = true;
            this.lblcurrentFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrentFilePath.Location = new System.Drawing.Point(12, 233);
            this.lblcurrentFilePath.MaximumSize = new System.Drawing.Size(210, 0);
            this.lblcurrentFilePath.Name = "lblcurrentFilePath";
            this.lblcurrentFilePath.Size = new System.Drawing.Size(84, 16);
            this.lblcurrentFilePath.TabIndex = 51;
            this.lblcurrentFilePath.Text = "-------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current file path:";
            // 
            // LblHeaderInfo
            // 
            this.LblHeaderInfo.AutoSize = true;
            this.LblHeaderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderInfo.Location = new System.Drawing.Point(65, 25);
            this.LblHeaderInfo.Name = "LblHeaderInfo";
            this.LblHeaderInfo.Size = new System.Drawing.Size(90, 24);
            this.LblHeaderInfo.TabIndex = 3;
            this.LblHeaderInfo.Text = "Settings:";
            // 
            // GrpMain
            // 
            this.GrpMain.Controls.Add(this.btnShowStats);
            this.GrpMain.Controls.Add(this.BtnSaveChanges);
            this.GrpMain.Controls.Add(this.GrpBxYearComment);
            this.GrpMain.Controls.Add(this.LblYearDisplay);
            this.GrpMain.Controls.Add(this.groupBox1);
            this.GrpMain.Controls.Add(this.GrpBxLocation);
            this.GrpMain.Controls.Add(this.BtnPreviousYear);
            this.GrpMain.Controls.Add(this.BtnNextYear);
            this.GrpMain.Controls.Add(this.BtnPreviousFinalYear);
            this.GrpMain.Controls.Add(this.BtnNextFinalYear);
            this.GrpMain.Controls.Add(this.DgvDisplayData);
            this.GrpMain.Controls.Add(this.btnEnableEditing);
            this.GrpMain.Location = new System.Drawing.Point(10, 3);
            this.GrpMain.Name = "GrpMain";
            this.GrpMain.Size = new System.Drawing.Size(643, 420);
            this.GrpMain.TabIndex = 44;
            this.GrpMain.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 698);
            this.Controls.Add(this.GrpMain);
            this.Controls.Add(this.GrpSideBox);
            this.Controls.Add(this.GrpGraphs);
            this.Controls.Add(this.GrpAnalysisData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDisplayData)).EndInit();
            this.GrpBxYearComment.ResumeLayout(false);
            this.GrpBxYearComment.PerformLayout();
            this.GrpBxLocation.ResumeLayout(false);
            this.GrpBxLocation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrpAnalysisData.ResumeLayout(false);
            this.GrpAnalysisData.PerformLayout();
            this.GrpSideBox.ResumeLayout(false);
            this.GrpSideBox.PerformLayout();
            this.GrpMain.ResumeLayout(false);
            this.GrpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblSelectLocation;
        private System.Windows.Forms.ComboBox CboSelectLocation;
        private System.Windows.Forms.DataGridView DgvDisplayData;
        private System.Windows.Forms.Label LblHeaderStreetName;
        private System.Windows.Forms.Label LblHeaderCounty;
        private System.Windows.Forms.Label LblHeaderPostCode;
        private System.Windows.Forms.Label LblHeaderLatitude;
        private System.Windows.Forms.Label LblHeaderLongitude;
        private System.Windows.Forms.Label LblSelectYear;
        private System.Windows.Forms.ComboBox CboSelectYear;
        private System.Windows.Forms.Label LblHeaderYearComment;
        private System.Windows.Forms.Button BtnAddYear;
        private System.Windows.Forms.Button BtnAddLocation;
        private System.Windows.Forms.Button BtnNextFinalYear;
        private System.Windows.Forms.Button BtnPreviousFinalYear;
        private System.Windows.Forms.Button BtnPreviousYear;
        private System.Windows.Forms.Button BtnNextYear;
        private System.Windows.Forms.Label LblYearDisplay;
        private System.Windows.Forms.GroupBox GrpBxYearComment;
        private System.Windows.Forms.GroupBox GrpBxLocation;
        private System.Windows.Forms.Button BtnSaveChanges;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCommentDisplay;
        private System.Windows.Forms.TextBox TxtCountyDisplay;
        private System.Windows.Forms.TextBox TxtPostCodeDisplay;
        private System.Windows.Forms.TextBox TxtLatitudeDisplay;
        private System.Windows.Forms.TextBox TxtLongitudeDisplay;
        private System.Windows.Forms.TextBox TxtStrtNameDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysOfFrost;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmOfRain;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursOfSunshine;
        private System.Windows.Forms.TextBox TxtLocNameDisplay;
        private System.Windows.Forms.Label LblHeaderLocationName;
        private System.Windows.Forms.Button btnYearSearch;
        private System.Windows.Forms.Button BtnLocSearch;
        private System.Windows.Forms.Button btnEnableEditing;
        private System.Windows.Forms.Button btnShowStats;
        private System.Windows.Forms.GroupBox GrpAnalysisData;
        private System.Windows.Forms.GroupBox GrpGraphs;
        private System.Windows.Forms.GroupBox GrpSideBox;
        private System.Windows.Forms.Label LblHeaderViewMode;
        private System.Windows.Forms.GroupBox GrpMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblHeaderInfo;
        private System.Windows.Forms.ComboBox CboScope;
        private System.Windows.Forms.Label LblHeaderAverages;
        private System.Windows.Forms.Label LvlHeaderRecordStats;
        private System.Windows.Forms.Label LblAvgSunshine;
        private System.Windows.Forms.Label LblAvgRain;
        private System.Windows.Forms.Label LblAvgFrost;
        private System.Windows.Forms.Label LblAvgMinTemp;
        private System.Windows.Forms.Label LblAvgMaxTemp;
        private System.Windows.Forms.Label LblHeaderSun;
        private System.Windows.Forms.Label LblHeaderRain;
        private System.Windows.Forms.Label LblHeaderFrost;
        private System.Windows.Forms.Label LblHeaderMinTemp;
        private System.Windows.Forms.Label LblAvgHMaxTemp;
        private System.Windows.Forms.Label LblRcdMinTemp;
        private System.Windows.Forms.Label LblRcdMaxTemp;
        private System.Windows.Forms.Label LblRMinTemp;
        private System.Windows.Forms.Label LblRMaxTemp;
        private System.Windows.Forms.Label lblcurrentFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblGraphSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboProperty;
        private System.Windows.Forms.Label LblHeaderGraphStat;
        private System.Windows.Forms.Button BtnChangeSelectedFile;
        private System.Windows.Forms.Label LblAnalysisSettings;
    }
}

