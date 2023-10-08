namespace NewSysAcad.Presentation.Views
{
    partial class SubjectForm
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
            this.SubjectMainTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGrdSubjects = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CrCancelBtn = new System.Windows.Forms.Button();
            this.CrSaveBtn = new System.Windows.Forms.Button();
            this.TbxSubjCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxHeadProf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxSubjName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrPrvSubject = new System.Windows.Forms.ErrorProvider(this.components);
            this.CrUpdateBtn = new System.Windows.Forms.Button();
            this.BtnDelSubj = new System.Windows.Forms.Button();
            this.SubjectMainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGrdSubjects)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPrvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectMainTab
            // 
            this.SubjectMainTab.Controls.Add(this.tabPage1);
            this.SubjectMainTab.Controls.Add(this.tabPage2);
            this.SubjectMainTab.Location = new System.Drawing.Point(31, 55);
            this.SubjectMainTab.Name = "SubjectMainTab";
            this.SubjectMainTab.SelectedIndex = 0;
            this.SubjectMainTab.Size = new System.Drawing.Size(1204, 517);
            this.SubjectMainTab.TabIndex = 1;
            this.SubjectMainTab.SelectedIndexChanged += new System.EventHandler(this.SubjectMainTab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGrdSubjects);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1196, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGrdSubjects
            // 
            this.DGrdSubjects.AllowUserToAddRows = false;
            this.DGrdSubjects.AllowUserToDeleteRows = false;
            this.DGrdSubjects.AllowUserToOrderColumns = true;
            this.DGrdSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrdSubjects.Location = new System.Drawing.Point(6, 17);
            this.DGrdSubjects.Name = "DGrdSubjects";
            this.DGrdSubjects.ReadOnly = true;
            this.DGrdSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGrdSubjects.Size = new System.Drawing.Size(1184, 451);
            this.DGrdSubjects.TabIndex = 0;
            this.DGrdSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGrdSubjects_CellContentClick);
            this.DGrdSubjects.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGrdSubjects_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CrUpdateBtn);
            this.tabPage2.Controls.Add(this.CrCancelBtn);
            this.tabPage2.Controls.Add(this.CrSaveBtn);
            this.tabPage2.Controls.Add(this.TbxSubjCode);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.TbxHeadProf);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.TbxSubjName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1196, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create/Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CrCancelBtn
            // 
            this.CrCancelBtn.Location = new System.Drawing.Point(569, 129);
            this.CrCancelBtn.Name = "CrCancelBtn";
            this.CrCancelBtn.Size = new System.Drawing.Size(113, 50);
            this.CrCancelBtn.TabIndex = 18;
            this.CrCancelBtn.Text = "Cancelar";
            this.CrCancelBtn.UseVisualStyleBackColor = true;
            this.CrCancelBtn.Click += new System.EventHandler(this.CrCancelBtn_Click);
            // 
            // CrSaveBtn
            // 
            this.CrSaveBtn.Location = new System.Drawing.Point(363, 129);
            this.CrSaveBtn.Name = "CrSaveBtn";
            this.CrSaveBtn.Size = new System.Drawing.Size(113, 50);
            this.CrSaveBtn.TabIndex = 17;
            this.CrSaveBtn.Text = "Guardar";
            this.CrSaveBtn.UseVisualStyleBackColor = true;
            this.CrSaveBtn.Click += new System.EventHandler(this.CrSaveBtn_Click);
            // 
            // TbxSubjCode
            // 
            this.TbxSubjCode.Location = new System.Drawing.Point(627, 17);
            this.TbxSubjCode.Name = "TbxSubjCode";
            this.TbxSubjCode.Size = new System.Drawing.Size(141, 20);
            this.TbxSubjCode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo Materia:";
            // 
            // TbxHeadProf
            // 
            this.TbxHeadProf.Location = new System.Drawing.Point(374, 17);
            this.TbxHeadProf.Name = "TbxHeadProf";
            this.TbxHeadProf.Size = new System.Drawing.Size(141, 20);
            this.TbxHeadProf.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jefe de Catedra";
            // 
            // TbxSubjName
            // 
            this.TbxSubjName.Location = new System.Drawing.Point(111, 17);
            this.TbxSubjName.Name = "TbxSubjName";
            this.TbxSubjName.Size = new System.Drawing.Size(141, 20);
            this.TbxSubjName.TabIndex = 1;
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
            // ErrPrvSubject
            // 
            this.ErrPrvSubject.ContainerControl = this;
            // 
            // CrUpdateBtn
            // 
            this.CrUpdateBtn.Location = new System.Drawing.Point(363, 130);
            this.CrUpdateBtn.Name = "CrUpdateBtn";
            this.CrUpdateBtn.Size = new System.Drawing.Size(113, 50);
            this.CrUpdateBtn.TabIndex = 19;
            this.CrUpdateBtn.Text = "Actualizar";
            this.CrUpdateBtn.UseVisualStyleBackColor = true;
            this.CrUpdateBtn.Click += new System.EventHandler(this.CrUpdateBtn_Click);
            // 
            // BtnDelSubj
            // 
            this.BtnDelSubj.Location = new System.Drawing.Point(35, 575);
            this.BtnDelSubj.Name = "BtnDelSubj";
            this.BtnDelSubj.Size = new System.Drawing.Size(75, 33);
            this.BtnDelSubj.TabIndex = 2;
            this.BtnDelSubj.Text = "Eliminar";
            this.BtnDelSubj.UseVisualStyleBackColor = true;
            this.BtnDelSubj.Click += new System.EventHandler(this.BtnDelSubj_Click);
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 610);
            this.Controls.Add(this.BtnDelSubj);
            this.Controls.Add(this.SubjectMainTab);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            this.SubjectMainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGrdSubjects)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPrvSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SubjectMainTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGrdSubjects;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CrCancelBtn;
        private System.Windows.Forms.Button CrSaveBtn;
        private System.Windows.Forms.TextBox TbxSubjCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxHeadProf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxSubjName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrPrvSubject;
        private System.Windows.Forms.Button CrUpdateBtn;
        private System.Windows.Forms.Button BtnDelSubj;
    }
}