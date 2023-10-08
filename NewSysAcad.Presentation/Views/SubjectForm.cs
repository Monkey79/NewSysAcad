using NewSysAcad.Business;
using NewSysAcad.Business.Impl;
using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSysAcad.Presentation.Views
{
    public partial class SubjectForm : Form
    {
        private SubjectService _subjectService;
        private List<Subject> _subjects;
        private Subject _subject;
        private Response _response;

        public SubjectForm() {
            InitializeComponent();

            _subjectService = new SubjectServiceImpl();
        }

        private void SubjectForm_Load(object sender, EventArgs e){
            CleanForm();
            GetAllSubject();
        }
        private void GetAllSubject() {
            CleanForm();
            _subjects = _subjectService.GetAllSubjects();
            if (_subjects != null && _subjects.Count > 0) { 
                DGrdSubjects.Columns.Clear();

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Seleccionar";
                checkBoxColumn.Name = "CbxSlcClm"; // Nombre de la columna (opcional)
                DGrdSubjects.Columns.Add(checkBoxColumn);

                DGrdSubjects.AutoGenerateColumns = false;

                DGrdSubjects.Columns.Add("Id", "ID");
                DGrdSubjects.Columns.Add("Code", "Code");
                DGrdSubjects.Columns.Add("Name", "Name");
                DGrdSubjects.Columns.Add("HeadProfessor", "Head Professor");

                DGrdSubjects.Columns["Id"].DataPropertyName = "Id";
                DGrdSubjects.Columns["Code"].DataPropertyName = "Code";
                DGrdSubjects.Columns["Name"].DataPropertyName = "Name";
                DGrdSubjects.Columns["HeadProfessor"].DataPropertyName = "HeadProfessor";

                DGrdSubjects.DataSource = _subjects;
            }

        }
        private void CrCancelBtn_Click(object sender, EventArgs e){
            CleanForm();
            SubjectMainTab.SelectedIndex = 0;
        }

        private void CrSaveBtn_Click(object sender, EventArgs e) {
            int iVal;
            _subject = new Subject();

            if (ValidateForm()) {
                if (int.TryParse(TbxSubjCode.Text, out iVal)) {
                    _subject.Code = iVal;
                }
                _subject.HeadProfessor = TbxHeadProf.Text;
                _subject.Name = TbxSubjName.Text;
                _response = _subjectService.CreateSubject(_subject);

                if (_response.Status.Equals(Response.OK)) {
                    ShowInfoMssg(_response.Message);
                    CleanForm();
                    SubjectMainTab.SelectedIndex = 0;
                }else if (_response.Status.Equals(Response.ERROR)){
                    ShowErrorMssg(_response.Message);
                }
            }                      
        }
        private bool ValidateForm() {
            bool passValidation = true;

            if (TbxSubjName.Text == string.Empty){
                ErrPrvSubject.SetError(TbxSubjName, "ingrese nombre");
                passValidation = false;
            }else {
                ErrPrvSubject.SetError(TbxSubjName, "");
            }

            if (TbxSubjCode.Text == string.Empty) {
                ErrPrvSubject.SetError(TbxSubjCode, "ingrese codigo");
                passValidation = false;
            }else{
                ErrPrvSubject.SetError(TbxSubjCode, "");
            }

            if (TbxHeadProf.Text == string.Empty){
                ErrPrvSubject.SetError(TbxHeadProf, "ingrese jefe de catedra");
                passValidation = false;
            }else {
                ErrPrvSubject.SetError(TbxHeadProf, "");
            }
            return passValidation;
        }
        private void ShowErrorMssg(string mssg) {
            MessageBox.Show(mssg, "curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ShowInfoMssg(string mssg) {
            MessageBox.Show(mssg, "curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CleanForm() {
            TbxSubjName.Clear();
            TbxSubjCode.Clear();
            TbxHeadProf.Clear();
            CrSaveBtn.Visible = true;
            CrUpdateBtn.Visible = false;
            TbxSubjCode.Enabled = true;
        }

        private void SubjectMainTab_SelectedIndexChanged(object sender, EventArgs e) {
            TabPage selectedTabPage = SubjectMainTab.SelectedTab;
            if (selectedTabPage.Text.Equals("Listar")) {
                GetAllSubject();
            }            
        }
        //cuando hago doble-click en un registro de la grilla se seleccionara para su actualizacion
        private void DGrdSubjects_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            CleanForm();
            CrUpdateBtn.Visible = true;
            CrSaveBtn.Visible = false;
            TbxSubjCode.Enabled = false;
            TbxSubjName.Text = Convert.ToString(DGrdSubjects.CurrentRow.Cells["Name"].Value);
            TbxHeadProf.Text = Convert.ToString(DGrdSubjects.CurrentRow.Cells["HeadProfessor"].Value);
            TbxSubjCode.Text = Convert.ToString(DGrdSubjects.CurrentRow.Cells["Code"].Value);
            SubjectMainTab.SelectedIndex = 1;
        }

        private void CrUpdateBtn_Click(object sender, EventArgs e){
            int iVal;
            _subject = new Subject();

            if (ValidateForm()) {
                if (int.TryParse(TbxSubjCode.Text, out iVal)){
                    _subject.Code = iVal;
                }
                _subject.HeadProfessor = TbxHeadProf.Text;
                _subject.Name = TbxSubjName.Text;
                _response = _subjectService.UpdateSubject(_subject);

                if (_response.Status.Equals(Response.OK)) {
                    ShowInfoMssg(_response.Message);
                    CleanForm();
                    SubjectMainTab.SelectedIndex = 0;
                }else if (_response.Status.Equals(Response.ERROR)){
                    ShowErrorMssg(_response.Message);
                }
            }

        }

        private void DGrdSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e){
            if (e.ColumnIndex == DGrdSubjects.Columns["CbxSlcClm"].Index) {
                DataGridViewCheckBoxCell dgVwChBxCll = (DataGridViewCheckBoxCell)DGrdSubjects.Rows[e.RowIndex].Cells["CbxSlcClm"];
                dgVwChBxCll.Value = !Convert.ToBoolean(dgVwChBxCll.Value);
            }
        }

        private void BtnDelSubj_Click(object sender, EventArgs e) {
            List<int> subjCodesToDelete = new List<int>();

            try {
                DialogResult deleteOpt = MessageBox.Show("Desea eliminar la/s materia/s?","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (deleteOpt == DialogResult.OK) {
                    foreach (DataGridViewRow dgRw in DGrdSubjects.Rows) {
                        if (Convert.ToBoolean(dgRw.Cells[0].Value)) {
                            subjCodesToDelete.Add(Convert.ToInt32(dgRw.Cells[2].Value));
                        }                    
                    }
                    _response = _subjectService.DeleteSubjectByCodeBatch(subjCodesToDelete);
                }

            }
            catch(Exception ex){
                ShowErrorMssg(ex.Message);
            }
        }
    }
}
