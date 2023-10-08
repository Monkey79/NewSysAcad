namespace NewSysAcad.Presentation.Views
{
    partial class CoursesForm
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
            this.CourseMainTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CoursesDGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnCrsUpdt = new System.Windows.Forms.Button();
            this.SbjLBx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CrCancelBtn = new System.Windows.Forms.Button();
            this.CrSaveBtn = new System.Windows.Forms.Button();
            this.CrShftLBx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CrHrUntilTBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CrHrFrmTBx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CrClRmTBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CrDaysLBx = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CrsMaxQtTBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CrsDescTBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CrsNameTBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CrErrPrvd = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnDltCrs = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CrCodeTxBx = new System.Windows.Forms.TextBox();
            this.CourseMainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrErrPrvd)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseMainTab
            // 
            this.CourseMainTab.Controls.Add(this.tabPage1);
            this.CourseMainTab.Controls.Add(this.tabPage2);
            this.CourseMainTab.Location = new System.Drawing.Point(12, 12);
            this.CourseMainTab.Name = "CourseMainTab";
            this.CourseMainTab.SelectedIndex = 0;
            this.CourseMainTab.Size = new System.Drawing.Size(1204, 500);
            this.CourseMainTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CoursesDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1196, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CoursesDGV
            // 
            this.CoursesDGV.AllowUserToAddRows = false;
            this.CoursesDGV.AllowUserToDeleteRows = false;
            this.CoursesDGV.AllowUserToOrderColumns = true;
            this.CoursesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoursesDGV.Location = new System.Drawing.Point(3, 3);
            this.CoursesDGV.Name = "CoursesDGV";
            this.CoursesDGV.ReadOnly = true;
            this.CoursesDGV.Size = new System.Drawing.Size(1190, 468);
            this.CoursesDGV.TabIndex = 0;
            this.CoursesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoursesDGV_CellContentClick);
            this.CoursesDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoursesDGV_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CrCodeTxBx);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.BtnCrsUpdt);
            this.tabPage2.Controls.Add(this.SbjLBx);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.CrCancelBtn);
            this.tabPage2.Controls.Add(this.CrSaveBtn);
            this.tabPage2.Controls.Add(this.CrShftLBx);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.CrHrUntilTBx);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.CrHrFrmTBx);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.CrClRmTBx);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.CrDaysLBx);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.CrsMaxQtTBx);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.CrsDescTBx);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.CrsNameTBx);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1196, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create/Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnCrsUpdt
            // 
            this.BtnCrsUpdt.Location = new System.Drawing.Point(176, 200);
            this.BtnCrsUpdt.Name = "BtnCrsUpdt";
            this.BtnCrsUpdt.Size = new System.Drawing.Size(113, 50);
            this.BtnCrsUpdt.TabIndex = 21;
            this.BtnCrsUpdt.Text = "Actualizar";
            this.BtnCrsUpdt.UseVisualStyleBackColor = true;
            this.BtnCrsUpdt.Click += new System.EventHandler(this.BtnCrsUpdt_Click);
            // 
            // SbjLBx
            // 
            this.SbjLBx.FormattingEnabled = true;
            this.SbjLBx.Location = new System.Drawing.Point(969, 52);
            this.SbjLBx.Name = "SbjLBx";
            this.SbjLBx.Size = new System.Drawing.Size(193, 21);
            this.SbjLBx.TabIndex = 20;
            this.SbjLBx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(925, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Materia";
            // 
            // CrCancelBtn
            // 
            this.CrCancelBtn.Location = new System.Drawing.Point(588, 200);
            this.CrCancelBtn.Name = "CrCancelBtn";
            this.CrCancelBtn.Size = new System.Drawing.Size(113, 50);
            this.CrCancelBtn.TabIndex = 18;
            this.CrCancelBtn.Text = "Cancelar";
            this.CrCancelBtn.UseVisualStyleBackColor = true;
            this.CrCancelBtn.Click += new System.EventHandler(this.CrCancelBtn_Click);
            // 
            // CrSaveBtn
            // 
            this.CrSaveBtn.Location = new System.Drawing.Point(176, 200);
            this.CrSaveBtn.Name = "CrSaveBtn";
            this.CrSaveBtn.Size = new System.Drawing.Size(113, 50);
            this.CrSaveBtn.TabIndex = 17;
            this.CrSaveBtn.Text = "Guardar";
            this.CrSaveBtn.UseVisualStyleBackColor = true;
            this.CrSaveBtn.Click += new System.EventHandler(this.CrSaveBtn_Click);
            // 
            // CrShftLBx
            // 
            this.CrShftLBx.FormattingEnabled = true;
            this.CrShftLBx.Items.AddRange(new object[] {
            "Morning",
            "Late",
            "Night"});
            this.CrShftLBx.Location = new System.Drawing.Point(507, 87);
            this.CrShftLBx.Name = "CrShftLBx";
            this.CrShftLBx.Size = new System.Drawing.Size(121, 21);
            this.CrShftLBx.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Turno:";
            // 
            // CrHrUntilTBx
            // 
            this.CrHrUntilTBx.Location = new System.Drawing.Point(732, 89);
            this.CrHrUntilTBx.Name = "CrHrUntilTBx";
            this.CrHrUntilTBx.Size = new System.Drawing.Size(141, 20);
            this.CrHrUntilTBx.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hr hasta:";
            // 
            // CrHrFrmTBx
            // 
            this.CrHrFrmTBx.Location = new System.Drawing.Point(732, 52);
            this.CrHrFrmTBx.Name = "CrHrFrmTBx";
            this.CrHrFrmTBx.Size = new System.Drawing.Size(141, 20);
            this.CrHrFrmTBx.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(673, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hr desde:";
            // 
            // CrClRmTBx
            // 
            this.CrClRmTBx.Location = new System.Drawing.Point(500, 52);
            this.CrClRmTBx.Name = "CrClRmTBx";
            this.CrClRmTBx.Size = new System.Drawing.Size(141, 20);
            this.CrClRmTBx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Aula:";
            // 
            // CrDaysLBx
            // 
            this.CrDaysLBx.FormattingEnabled = true;
            this.CrDaysLBx.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.CrDaysLBx.Location = new System.Drawing.Point(313, 58);
            this.CrDaysLBx.Name = "CrDaysLBx";
            this.CrDaysLBx.Size = new System.Drawing.Size(120, 94);
            this.CrDaysLBx.TabIndex = 7;
            this.CrDaysLBx.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CrDaysLBx_ItemCheck);
            this.CrDaysLBx.SelectedIndexChanged += new System.EventHandler(this.CrDaysLBx_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dias";
            // 
            // CrsMaxQtTBx
            // 
            this.CrsMaxQtTBx.Location = new System.Drawing.Point(394, 17);
            this.CrsMaxQtTBx.Name = "CrsMaxQtTBx";
            this.CrsMaxQtTBx.Size = new System.Drawing.Size(141, 20);
            this.CrsMaxQtTBx.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cant alumnos:";
            // 
            // CrsDescTBx
            // 
            this.CrsDescTBx.Location = new System.Drawing.Point(116, 63);
            this.CrsDescTBx.Multiline = true;
            this.CrsDescTBx.Name = "CrsDescTBx";
            this.CrsDescTBx.Size = new System.Drawing.Size(141, 53);
            this.CrsDescTBx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Materia descripcion:";
            // 
            // CrsNameTBx
            // 
            this.CrsNameTBx.Location = new System.Drawing.Point(111, 17);
            this.CrsNameTBx.Name = "CrsNameTBx";
            this.CrsNameTBx.Size = new System.Drawing.Size(141, 20);
            this.CrsNameTBx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia nombre:";
            // 
            // CrErrPrvd
            // 
            this.CrErrPrvd.ContainerControl = this;
            // 
            // BtnDltCrs
            // 
            this.BtnDltCrs.Location = new System.Drawing.Point(16, 518);
            this.BtnDltCrs.Name = "BtnDltCrs";
            this.BtnDltCrs.Size = new System.Drawing.Size(99, 37);
            this.BtnDltCrs.TabIndex = 1;
            this.BtnDltCrs.Text = "Eliminar";
            this.BtnDltCrs.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(568, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Codigo Curso:";
            // 
            // CrCodeTxBx
            // 
            this.CrCodeTxBx.Location = new System.Drawing.Point(648, 17);
            this.CrCodeTxBx.Name = "CrCodeTxBx";
            this.CrCodeTxBx.Size = new System.Drawing.Size(100, 20);
            this.CrCodeTxBx.TabIndex = 23;
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 558);
            this.Controls.Add(this.BtnDltCrs);
            this.Controls.Add(this.CourseMainTab);
            this.Name = "CoursesForm";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.CoursesForm_Load);
            this.CourseMainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoursesDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrErrPrvd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CourseMainTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView CoursesDGV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox CrsNameTBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CrsDescTBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CrsMaxQtTBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox CrDaysLBx;
        private System.Windows.Forms.TextBox CrClRmTBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CrHrUntilTBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CrHrFrmTBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CrShftLBx;
        private System.Windows.Forms.Button CrCancelBtn;
        private System.Windows.Forms.Button CrSaveBtn;
        private System.Windows.Forms.ErrorProvider CrErrPrvd;
        private System.Windows.Forms.ComboBox SbjLBx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnDltCrs;
        private System.Windows.Forms.Button BtnCrsUpdt;
        private System.Windows.Forms.TextBox CrCodeTxBx;
        private System.Windows.Forms.Label label10;
    }
}