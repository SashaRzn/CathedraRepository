namespace CathedraUniversity.Forms
{
	partial class ControlLoadEmployeeEdit
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
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelHeaderParameterName = new System.Windows.Forms.Label();
            this.labelHeaderParameterValue = new System.Windows.Forms.Label();
            this.labelTotalFormalWorkloadText = new System.Windows.Forms.Label();
            this.labelFormalWorkloadText = new System.Windows.Forms.Label();
            this.labelPochNagruzText = new System.Windows.Forms.Label();
            this.labelUnderloadText = new System.Windows.Forms.Label();
            this.labelOverloadText = new System.Windows.Forms.Label();
            this.labelFactText = new System.Windows.Forms.Label();
            this.labelFactOtherTutorText = new System.Windows.Forms.Label();
            this.labelFactPochFondText = new System.Windows.Forms.Label();
            this.labelTotalFormalWorkloadValue = new System.Windows.Forms.Label();
            this.labelPochNagruzValue = new System.Windows.Forms.Label();
            this.labelFormalWorkloadValue = new System.Windows.Forms.Label();
            this.labelUnderloadValue = new System.Windows.Forms.Label();
            this.labelOverloadValue = new System.Windows.Forms.Label();
            this.labelFactValue = new System.Windows.Forms.Label();
            this.labelFactOtherTutorValue = new System.Windows.Forms.Label();
            this.labelFactPochFondValue = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSaveAndClose = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnGeneralMove = new System.Windows.Forms.Button();
            this.btnPochFondMove = new System.Windows.Forms.Button();
            this.btnFactMove = new System.Windows.Forms.Button();
            this.btnFormMove = new System.Windows.Forms.Button();
            this.ctlCourseInWork = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formStudyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalLoadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formLoadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFormFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factLoadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFactFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pochFondLoadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCrossLoadStat = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlCourseInWork)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(15, 65);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(536, 85);
            this.textBoxComment.TabIndex = 13;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInfo.Enabled = false;
            this.textBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo.Location = new System.Drawing.Point(15, 28);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(536, 31);
            this.textBoxInfo.TabIndex = 12;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 12);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(165, 13);
            this.labelInfo.TabIndex = 11;
            this.labelInfo.Text = "Информация о преподавателе:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.57055F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.42945F));
            this.tableLayoutPanel1.Controls.Add(this.labelHeaderParameterName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelHeaderParameterValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTotalFormalWorkloadText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelFormalWorkloadText, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelPochNagruzText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelUnderloadText, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelOverloadText, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelFactText, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelFactOtherTutorText, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelFactPochFondText, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelTotalFormalWorkloadValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPochNagruzValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFormalWorkloadValue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelUnderloadValue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelOverloadValue, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelFactValue, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelFactOtherTutorValue, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelFactPochFondValue, 1, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(571, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 138);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // labelHeaderParameterName
            // 
            this.labelHeaderParameterName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeaderParameterName.AutoSize = true;
            this.labelHeaderParameterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeaderParameterName.Location = new System.Drawing.Point(3, 0);
            this.labelHeaderParameterName.Name = "labelHeaderParameterName";
            this.labelHeaderParameterName.Size = new System.Drawing.Size(303, 17);
            this.labelHeaderParameterName.TabIndex = 0;
            this.labelHeaderParameterName.Text = "Наименование параметра:";
            this.labelHeaderParameterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeaderParameterValue
            // 
            this.labelHeaderParameterValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeaderParameterValue.AutoSize = true;
            this.labelHeaderParameterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeaderParameterValue.Location = new System.Drawing.Point(312, 0);
            this.labelHeaderParameterValue.Name = "labelHeaderParameterValue";
            this.labelHeaderParameterValue.Size = new System.Drawing.Size(130, 17);
            this.labelHeaderParameterValue.TabIndex = 1;
            this.labelHeaderParameterValue.Text = "Значение:";
            this.labelHeaderParameterValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalFormalWorkloadText
            // 
            this.labelTotalFormalWorkloadText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalFormalWorkloadText.AutoSize = true;
            this.labelTotalFormalWorkloadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalFormalWorkloadText.Location = new System.Drawing.Point(3, 17);
            this.labelTotalFormalWorkloadText.Name = "labelTotalFormalWorkloadText";
            this.labelTotalFormalWorkloadText.Size = new System.Drawing.Size(272, 15);
            this.labelTotalFormalWorkloadText.TabIndex = 2;
            this.labelTotalFormalWorkloadText.Text = "Число часов общей нагрузки согласно ставке:";
            // 
            // labelFormalWorkloadText
            // 
            this.labelFormalWorkloadText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFormalWorkloadText.AutoSize = true;
            this.labelFormalWorkloadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormalWorkloadText.Location = new System.Drawing.Point(3, 47);
            this.labelFormalWorkloadText.Name = "labelFormalWorkloadText";
            this.labelFormalWorkloadText.Size = new System.Drawing.Size(213, 15);
            this.labelFormalWorkloadText.TabIndex = 3;
            this.labelFormalWorkloadText.Text = "Число часов формальной нагрузки:";
            // 
            // labelPochNagruzText
            // 
            this.labelPochNagruzText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPochNagruzText.AutoSize = true;
            this.labelPochNagruzText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPochNagruzText.Location = new System.Drawing.Point(3, 32);
            this.labelPochNagruzText.Name = "labelPochNagruzText";
            this.labelPochNagruzText.Size = new System.Drawing.Size(294, 15);
            this.labelPochNagruzText.TabIndex = 4;
            this.labelPochNagruzText.Text = "Почасовой фонд (всего/распределено/осталось):";
            // 
            // labelUnderloadText
            // 
            this.labelUnderloadText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUnderloadText.AutoSize = true;
            this.labelUnderloadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnderloadText.Location = new System.Drawing.Point(3, 62);
            this.labelUnderloadText.Name = "labelUnderloadText";
            this.labelUnderloadText.Size = new System.Drawing.Size(76, 15);
            this.labelUnderloadText.TabIndex = 5;
            this.labelUnderloadText.Text = "Недогрузка:";
            // 
            // labelOverloadText
            // 
            this.labelOverloadText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOverloadText.AutoSize = true;
            this.labelOverloadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOverloadText.Location = new System.Drawing.Point(3, 77);
            this.labelOverloadText.Name = "labelOverloadText";
            this.labelOverloadText.Size = new System.Drawing.Size(76, 15);
            this.labelOverloadText.TabIndex = 6;
            this.labelOverloadText.Text = "Перегрузка:";
            // 
            // labelFactText
            // 
            this.labelFactText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFactText.AutoSize = true;
            this.labelFactText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFactText.Location = new System.Drawing.Point(3, 92);
            this.labelFactText.Name = "labelFactText";
            this.labelFactText.Size = new System.Drawing.Size(175, 15);
            this.labelFactText.TabIndex = 7;
            this.labelFactText.Text = "Фактической нагрузки всего:";
            // 
            // labelFactOtherTutorText
            // 
            this.labelFactOtherTutorText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFactOtherTutorText.AutoSize = true;
            this.labelFactOtherTutorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFactOtherTutorText.Location = new System.Drawing.Point(3, 107);
            this.labelFactOtherTutorText.Name = "labelFactOtherTutorText";
            this.labelFactOtherTutorText.Size = new System.Drawing.Size(206, 15);
            this.labelFactOtherTutorText.TabIndex = 8;
            this.labelFactOtherTutorText.Text = " - в т.ч. на других преподавателях:";
            // 
            // labelFactPochFondText
            // 
            this.labelFactPochFondText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFactPochFondText.AutoSize = true;
            this.labelFactPochFondText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFactPochFondText.Location = new System.Drawing.Point(3, 123);
            this.labelFactPochFondText.Name = "labelFactPochFondText";
            this.labelFactPochFondText.Size = new System.Drawing.Size(145, 15);
            this.labelFactPochFondText.TabIndex = 9;
            this.labelFactPochFondText.Text = " - в т.ч. почасовой фонд";
            // 
            // labelTotalFormalWorkloadValue
            // 
            this.labelTotalFormalWorkloadValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalFormalWorkloadValue.AutoSize = true;
            this.labelTotalFormalWorkloadValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalFormalWorkloadValue.Location = new System.Drawing.Point(312, 17);
            this.labelTotalFormalWorkloadValue.Name = "labelTotalFormalWorkloadValue";
            this.labelTotalFormalWorkloadValue.Size = new System.Drawing.Size(130, 15);
            this.labelTotalFormalWorkloadValue.TabIndex = 10;
            this.labelTotalFormalWorkloadValue.Text = "0";
            this.labelTotalFormalWorkloadValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPochNagruzValue
            // 
            this.labelPochNagruzValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPochNagruzValue.AutoSize = true;
            this.labelPochNagruzValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPochNagruzValue.Location = new System.Drawing.Point(312, 32);
            this.labelPochNagruzValue.Name = "labelPochNagruzValue";
            this.labelPochNagruzValue.Size = new System.Drawing.Size(130, 15);
            this.labelPochNagruzValue.TabIndex = 11;
            this.labelPochNagruzValue.Text = "0";
            this.labelPochNagruzValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFormalWorkloadValue
            // 
            this.labelFormalWorkloadValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFormalWorkloadValue.AutoSize = true;
            this.labelFormalWorkloadValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormalWorkloadValue.Location = new System.Drawing.Point(312, 47);
            this.labelFormalWorkloadValue.Name = "labelFormalWorkloadValue";
            this.labelFormalWorkloadValue.Size = new System.Drawing.Size(130, 15);
            this.labelFormalWorkloadValue.TabIndex = 12;
            this.labelFormalWorkloadValue.Text = "0";
            this.labelFormalWorkloadValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnderloadValue
            // 
            this.labelUnderloadValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnderloadValue.AutoSize = true;
            this.labelUnderloadValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnderloadValue.Location = new System.Drawing.Point(312, 62);
            this.labelUnderloadValue.Name = "labelUnderloadValue";
            this.labelUnderloadValue.Size = new System.Drawing.Size(130, 15);
            this.labelUnderloadValue.TabIndex = 13;
            this.labelUnderloadValue.Text = "0";
            this.labelUnderloadValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOverloadValue
            // 
            this.labelOverloadValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOverloadValue.AutoSize = true;
            this.labelOverloadValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOverloadValue.Location = new System.Drawing.Point(312, 77);
            this.labelOverloadValue.Name = "labelOverloadValue";
            this.labelOverloadValue.Size = new System.Drawing.Size(130, 15);
            this.labelOverloadValue.TabIndex = 14;
            this.labelOverloadValue.Text = "0";
            this.labelOverloadValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFactValue
            // 
            this.labelFactValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFactValue.AutoSize = true;
            this.labelFactValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFactValue.Location = new System.Drawing.Point(312, 92);
            this.labelFactValue.Name = "labelFactValue";
            this.labelFactValue.Size = new System.Drawing.Size(130, 15);
            this.labelFactValue.TabIndex = 15;
            this.labelFactValue.Text = "0";
            this.labelFactValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFactOtherTutorValue
            // 
            this.labelFactOtherTutorValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFactOtherTutorValue.AutoSize = true;
            this.labelFactOtherTutorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFactOtherTutorValue.Location = new System.Drawing.Point(312, 107);
            this.labelFactOtherTutorValue.Name = "labelFactOtherTutorValue";
            this.labelFactOtherTutorValue.Size = new System.Drawing.Size(130, 15);
            this.labelFactOtherTutorValue.TabIndex = 16;
            this.labelFactOtherTutorValue.Text = "0";
            this.labelFactOtherTutorValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFactPochFondValue
            // 
            this.labelFactPochFondValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFactPochFondValue.AutoSize = true;
            this.labelFactPochFondValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFactPochFondValue.Location = new System.Drawing.Point(312, 122);
            this.labelFactPochFondValue.Name = "labelFactPochFondValue";
            this.labelFactPochFondValue.Size = new System.Drawing.Size(130, 16);
            this.labelFactPochFondValue.TabIndex = 17;
            this.labelFactPochFondValue.Text = "0";
            this.labelFactPochFondValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(921, 716);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSaveAndClose
            // 
            this.buttonSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAndClose.Location = new System.Drawing.Point(842, 716);
            this.buttonSaveAndClose.Name = "buttonSaveAndClose";
            this.buttonSaveAndClose.Size = new System.Drawing.Size(73, 23);
            this.buttonSaveAndClose.TabIndex = 17;
            this.buttonSaveAndClose.Text = "OK";
            this.buttonSaveAndClose.UseVisualStyleBackColor = true;
            this.buttonSaveAndClose.Click += new System.EventHandler(this.buttonSaveAndClose_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.btnGeneralMove);
            this.panel.Controls.Add(this.buttonCrossLoadStat);
            this.panel.Controls.Add(this.btnPochFondMove);
            this.panel.Controls.Add(this.btnFactMove);
            this.panel.Controls.Add(this.btnFormMove);
            this.panel.Controls.Add(this.ctlCourseInWork);
            this.panel.Location = new System.Drawing.Point(12, 160);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1012, 536);
            this.panel.TabIndex = 18;
            // 
            // btnGeneralMove
            // 
            this.btnGeneralMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneralMove.Location = new System.Drawing.Point(872, 20);
            this.btnGeneralMove.Name = "btnGeneralMove";
            this.btnGeneralMove.Size = new System.Drawing.Size(132, 56);
            this.btnGeneralMove.TabIndex = 4;
            this.btnGeneralMove.Text = "Перейти фактической и формальной нагрузке";
            this.btnGeneralMove.UseVisualStyleBackColor = true;
            this.btnGeneralMove.Click += new System.EventHandler(this.btnGeneralMove_Click);
            // 
            // btnPochFondMove
            // 
            this.btnPochFondMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPochFondMove.Location = new System.Drawing.Point(872, 232);
            this.btnPochFondMove.Name = "btnPochFondMove";
            this.btnPochFondMove.Size = new System.Drawing.Size(132, 48);
            this.btnPochFondMove.TabIndex = 3;
            this.btnPochFondMove.Text = "Перейти к нагрузке почасового фонда";
            this.btnPochFondMove.UseVisualStyleBackColor = true;
            this.btnPochFondMove.Click += new System.EventHandler(this.btnPochFondMove_Click);
            // 
            // btnFactMove
            // 
            this.btnFactMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFactMove.Location = new System.Drawing.Point(872, 160);
            this.btnFactMove.Name = "btnFactMove";
            this.btnFactMove.Size = new System.Drawing.Size(132, 48);
            this.btnFactMove.TabIndex = 2;
            this.btnFactMove.Text = "Перейти к фактической нагрузке";
            this.btnFactMove.UseVisualStyleBackColor = true;
            this.btnFactMove.Click += new System.EventHandler(this.btnFactMove_Click);
            // 
            // btnFormMove
            // 
            this.btnFormMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormMove.Location = new System.Drawing.Point(872, 92);
            this.btnFormMove.Name = "btnFormMove";
            this.btnFormMove.Size = new System.Drawing.Size(132, 48);
            this.btnFormMove.TabIndex = 1;
            this.btnFormMove.Text = "Перейти к формальной нагрузке";
            this.btnFormMove.UseVisualStyleBackColor = true;
            this.btnFormMove.Click += new System.EventHandler(this.btnFormMove_Click);
            // 
            // ctlCourseInWork
            // 
            this.ctlCourseInWork.AllowUserToAddRows = false;
            this.ctlCourseInWork.AllowUserToDeleteRows = false;
            this.ctlCourseInWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlCourseInWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlCourseInWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.courseNameColumn,
            this.groupsColumn,
            this.semestrColumn,
            this.formStudyColumn,
            this.generalLoadColumn,
            this.formLoadColumn,
            this.ColumnFormFio,
            this.factLoadColumn,
            this.ColumnFactFio,
            this.pochFondLoadColumn});
            this.ctlCourseInWork.Location = new System.Drawing.Point(0, 20);
            this.ctlCourseInWork.MultiSelect = false;
            this.ctlCourseInWork.Name = "ctlCourseInWork";
            this.ctlCourseInWork.ReadOnly = true;
            this.ctlCourseInWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlCourseInWork.Size = new System.Drawing.Size(864, 516);
            this.ctlCourseInWork.TabIndex = 0;
            this.ctlCourseInWork.DoubleClick += new System.EventHandler(this.ctlCourseInWork_DoubleClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Ид";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // courseNameColumn
            // 
            this.courseNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseNameColumn.HeaderText = "Название курса";
            this.courseNameColumn.MinimumWidth = 100;
            this.courseNameColumn.Name = "courseNameColumn";
            this.courseNameColumn.ReadOnly = true;
            // 
            // groupsColumn
            // 
            this.groupsColumn.HeaderText = "Группы";
            this.groupsColumn.Name = "groupsColumn";
            this.groupsColumn.ReadOnly = true;
            // 
            // semestrColumn
            // 
            this.semestrColumn.HeaderText = "Семестр";
            this.semestrColumn.Name = "semestrColumn";
            this.semestrColumn.ReadOnly = true;
            this.semestrColumn.Width = 80;
            // 
            // formStudyColumn
            // 
            this.formStudyColumn.HeaderText = "Форма обучения";
            this.formStudyColumn.Name = "formStudyColumn";
            this.formStudyColumn.ReadOnly = true;
            this.formStudyColumn.Width = 80;
            // 
            // generalLoadColumn
            // 
            this.generalLoadColumn.HeaderText = "Итого фактической и формальной нагрузки";
            this.generalLoadColumn.Name = "generalLoadColumn";
            this.generalLoadColumn.ReadOnly = true;
            this.generalLoadColumn.Width = 80;
            // 
            // formLoadColumn
            // 
            this.formLoadColumn.HeaderText = "Итого формальной нагрузки";
            this.formLoadColumn.Name = "formLoadColumn";
            this.formLoadColumn.ReadOnly = true;
            this.formLoadColumn.Width = 80;
            // 
            // ColumnFormFio
            // 
            this.ColumnFormFio.HeaderText = "Закреплена фактическая";
            this.ColumnFormFio.Name = "ColumnFormFio";
            this.ColumnFormFio.ReadOnly = true;
            // 
            // factLoadColumn
            // 
            this.factLoadColumn.HeaderText = "Итого фактической нагрузки";
            this.factLoadColumn.Name = "factLoadColumn";
            this.factLoadColumn.ReadOnly = true;
            this.factLoadColumn.Width = 80;
            // 
            // ColumnFactFio
            // 
            this.ColumnFactFio.HeaderText = "Закреплена формальная";
            this.ColumnFactFio.Name = "ColumnFactFio";
            this.ColumnFactFio.ReadOnly = true;
            // 
            // pochFondLoadColumn
            // 
            this.pochFondLoadColumn.HeaderText = "Нагрузка в почасовом фонде";
            this.pochFondLoadColumn.Name = "pochFondLoadColumn";
            this.pochFondLoadColumn.ReadOnly = true;
            this.pochFondLoadColumn.Width = 80;
            // 
            // buttonCrossLoadStat
            // 
            this.buttonCrossLoadStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrossLoadStat.Location = new System.Drawing.Point(874, 298);
            this.buttonCrossLoadStat.Name = "buttonCrossLoadStat";
            this.buttonCrossLoadStat.Size = new System.Drawing.Size(132, 48);
            this.buttonCrossLoadStat.TabIndex = 3;
            this.buttonCrossLoadStat.Text = "Статистика перекрестного распределения нагрузки";
            this.buttonCrossLoadStat.UseVisualStyleBackColor = true;
            this.buttonCrossLoadStat.Click += new System.EventHandler(this.buttonCrossLoadStat_Click);
            // 
            // ControlLoadEmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveAndClose);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.labelInfo);
            this.Name = "ControlLoadEmployeeEdit";
            this.Text = "Редактирование нагрузки преподавателя";
            this.Load += new System.EventHandler(this.ControlLoadEmployeeEdit_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlCourseInWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxComment;
		private System.Windows.Forms.TextBox textBoxInfo;
		private System.Windows.Forms.Label labelInfo;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelHeaderParameterName;
		private System.Windows.Forms.Label labelHeaderParameterValue;
		private System.Windows.Forms.Label labelTotalFormalWorkloadText;
		private System.Windows.Forms.Label labelFormalWorkloadText;
		private System.Windows.Forms.Label labelPochNagruzText;
		private System.Windows.Forms.Label labelUnderloadText;
		private System.Windows.Forms.Label labelOverloadText;
		private System.Windows.Forms.Label labelFactText;
		private System.Windows.Forms.Label labelFactOtherTutorText;
		private System.Windows.Forms.Label labelFactPochFondText;
		private System.Windows.Forms.Label labelTotalFormalWorkloadValue;
		private System.Windows.Forms.Label labelPochNagruzValue;
		private System.Windows.Forms.Label labelFormalWorkloadValue;
		private System.Windows.Forms.Label labelUnderloadValue;
		private System.Windows.Forms.Label labelOverloadValue;
		private System.Windows.Forms.Label labelFactValue;
		private System.Windows.Forms.Label labelFactOtherTutorValue;
		private System.Windows.Forms.Label labelFactPochFondValue;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSaveAndClose;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.DataGridView ctlCourseInWork;
		private System.Windows.Forms.Button btnPochFondMove;
		private System.Windows.Forms.Button btnFactMove;
		private System.Windows.Forms.Button btnFormMove;
        private System.Windows.Forms.Button btnGeneralMove;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formStudyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generalLoadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formLoadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFormFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn factLoadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFactFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn pochFondLoadColumn;
        private System.Windows.Forms.Button buttonCrossLoadStat;
	}
}