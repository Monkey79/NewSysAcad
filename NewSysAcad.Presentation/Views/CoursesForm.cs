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
    public partial class CoursesForm : Form
    {
        private CourseService _courseService;
        private SubjectService _subjectService;

        private int _lastCrCodeBySubj;
        private Subject _selectedSubject; //materia seleccionada por combobox de materias
        private Course _courseNew; //curso ha crear
        private Response _courseResp;
        private List<string> _selectedDays;
        private int _clickedCrsCode;

        public CoursesForm() {
            InitializeComponent();

            _courseService = new CourseServiceImpl();
            _subjectService = new SubjectServiceImpl();
            _selectedDays = new List<string>();

            this.FormClosing += LoginFormClosing_Hndl;
        }

        private void LoginFormClosing_Hndl(object sender, FormClosingEventArgs e) {
            //this.Close();
            //Application.Exit();
        }

        private void FormatCourseDGV() {
            CoursesDGV.Columns.Clear();

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Seleccionar";
            checkBoxColumn.Name = "CbxSlcClm"; // Nombre de la columna (opcional)
            CoursesDGV.Columns.Add(checkBoxColumn);

            CoursesDGV.AutoGenerateColumns = false;

            CoursesDGV.Columns.Add("ClmCrsId", "Id");
            CoursesDGV.Columns.Add("ClmCrsCode", "Codigo");
            CoursesDGV.Columns.Add("ClmCrsName", "Materia nombre");
            CoursesDGV.Columns.Add("ClmCrsDesc", "Descripcion");
            CoursesDGV.Columns.Add("ClmCrsMxQt", "Cant Mxm alumnos");
            CoursesDGV.Columns.Add("ClmCrsDays", "Dias cursada");
            CoursesDGV.Columns.Add("ClmCrsClsRm", "Aula");
            CoursesDGV.Columns.Add("ClmCrsHrFrom", "Hora desde");
            CoursesDGV.Columns.Add("ClmCrsHrUntil", "Hora hasta");
            CoursesDGV.Columns.Add("ClmCrsShift", "Turno");
            CoursesDGV.Columns.Add("ClmCrsSbjCode", "Codigo materia");

            CoursesDGV.Columns["ClmCrsId"].DataPropertyName = "Id";
            CoursesDGV.Columns["ClmCrsCode"].DataPropertyName = "Code";
            CoursesDGV.Columns["ClmCrsName"].DataPropertyName = "SubjectName";
            CoursesDGV.Columns["ClmCrsDesc"].DataPropertyName = "Description";
            CoursesDGV.Columns["ClmCrsMxQt"].DataPropertyName = "MaximumQuota";
            CoursesDGV.Columns["ClmCrsDays"].DataPropertyName = "Days";
            CoursesDGV.Columns["ClmCrsClsRm"].DataPropertyName = "ClassRoom";
            CoursesDGV.Columns["ClmCrsHrFrom"].DataPropertyName = "HrFrom";
            CoursesDGV.Columns["ClmCrsHrUntil"].DataPropertyName = "HrUntil";
            CoursesDGV.Columns["ClmCrsShift"].DataPropertyName = "Shift";
            CoursesDGV.Columns["ClmCrsSbjCode"].DataPropertyName = "SubjCode";
            //CoursesDGV.Columns[11].Visible = false;
        }
        private void ListAllCourses() {
            try {
                FormatCourseDGV();
                CoursesDGV.DataSource = _courseService.GetAllCourses();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
        private void ListAllSubjects() { 
            List<Subject> subjects = _subjectService.GetAllSubjects();
            if (subjects.Count > 0){
                SbjLBx.DataSource = subjects;
                SbjLBx.DisplayMember = "CodeAndName";
            }else {
                CrErrPrvd.SetError(SbjLBx, "NO hay materias, primero cree una materia");
                ShowErrorMssg("NO hay materias, primero cree una materia");
            }
        }
        private void CleanCreationForm() {
            CrsNameTBx.Clear();
            CrsMaxQtTBx.Clear();
            CrsDescTBx.Clear();
            CrDaysLBx.ClearSelected();
            CrClRmTBx.Clear();
            CrHrFrmTBx.Clear();
            CrHrUntilTBx.Clear();
            CrsDescTBx.Clear();

            CrSaveBtn.Visible = true;
            BtnCrsUpdt.Visible = false;
        }

        private void CoursesForm_Load(object sender, EventArgs e) {
            CleanCreationForm();
            ListAllSubjects(); 
            ListAllCourses();
        }

        private bool ValidateForm() {
            bool passValidation = true;

            if (CrCodeTxBx.Text == string.Empty) {
                CrErrPrvd.SetError(CrCodeTxBx, "ingrese un codigo para el curso");
                passValidation = false;
            }else {
                CrErrPrvd.SetError(CrCodeTxBx, "");
            }

            if (CrsNameTBx.Text == string.Empty){
                CrErrPrvd.SetError(CrsNameTBx, "ingrese nombre curso");
                passValidation = false;
            }else{
                CrErrPrvd.SetError(CrsNameTBx, "");
            }

            if (CrsMaxQtTBx.Text == string.Empty){
                CrErrPrvd.SetError(CrsMaxQtTBx, "ingrese cant max alumnos");
                passValidation = false;
            }else{
                CrErrPrvd.SetError(CrsMaxQtTBx, "");
            }

            if (CrsDescTBx.Text == string.Empty){
                CrErrPrvd.SetError(CrsDescTBx, "ingrese descripcion del curso");
                passValidation = false;
            }else{
                CrErrPrvd.SetError(CrsDescTBx, "");
            }
            if (CrDaysLBx.CheckedItems.Count <= 0) {
                CrErrPrvd.SetError(CrDaysLBx, "elija algun dia de cursada");
                passValidation = false;
            }else {
                CrErrPrvd.SetError(CrDaysLBx, "");
            }

            if (CrClRmTBx.Text == string.Empty){
                CrErrPrvd.SetError(CrClRmTBx, "ingrese aula");
                passValidation = false;
            }else {
                CrErrPrvd.SetError(CrClRmTBx, "");
            }

            if (CrHrFrmTBx.Text == string.Empty){
                CrErrPrvd.SetError(CrHrFrmTBx, "ingrese hora desde");
                passValidation = false;
            }else{
                CrErrPrvd.SetError(CrHrFrmTBx, "");
            }
            if (CrHrUntilTBx.Text == string.Empty){
                CrErrPrvd.SetError(CrHrUntilTBx, "ingrese hora hasta");
                passValidation = false;
            }else{
                CrErrPrvd.SetError(CrHrUntilTBx, "");
            }
      
            if (CrShftLBx.SelectedItem == null) {
                CrErrPrvd.SetError(CrShftLBx, "elija un turno");
                passValidation = false;
            }else {
                CrErrPrvd.SetError(CrShftLBx, "");
            }
            return passValidation;
        }

        private void CrSaveBtn_Click(object sender, EventArgs e){
            try {
                if (ValidateForm()) {                   
                    int cstValue;
                    _courseNew = new Course();
                   
                    _courseNew.Code = Convert.ToInt32(CrCodeTxBx.Text); //codigo curso                    
                    _courseNew.SubjectName = CrsNameTBx.Text;
                    _courseNew.SubjCode = _selectedSubject.Code; //codigo de la materia de ese curso
                    _courseNew.Description = CrsDescTBx.Text;

                    if (int.TryParse(CrsMaxQtTBx.Text, out cstValue)){
                        _courseNew.MaximumQuota = cstValue;
                    }
                    if (int.TryParse(CrClRmTBx.Text, out cstValue)){
                        _courseNew.ClassRoom = cstValue;
                    }
                    if (int.TryParse(CrHrFrmTBx.Text, out cstValue)){
                        _courseNew.HrFrom = cstValue;
                    }
                    if (int.TryParse(CrHrUntilTBx.Text, out cstValue)){
                        _courseNew.HrUntil = cstValue;
                    }

                    string selectedShift = CrShftLBx.SelectedItem.ToString();
                    switch (selectedShift){
                        case "Morning":
                            _courseNew.Shift = SHIFT.Morning;
                            break;
                        case "Late":
                            _courseNew.Shift = SHIFT.Late;
                            break;
                        case "Night":
                            _courseNew.Shift = SHIFT.Night;
                            break;
                    }
                    Debug.WriteLine(_courseNew);
                    _courseNew.Days = GetDaysByCheckedList();
                    
                    //---------------Call Save Servie------------------------
                    _courseResp = _courseService.CreateCourse(_courseNew); 

                    if (_courseResp.Status.Equals(Response.OK)){
                        ShowInfoMssg(_courseResp.Message);
                        CleanCreationForm();
                        CourseMainTab.SelectedIndex = 0;
                        ListAllCourses();
                    }else if (_courseResp.Status.Equals(Response.ERROR)){
                        ShowErrorMssg(_courseResp.Message);
                    }
                    //-------------------------------------------------------
                }
            }catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }
        private void BtnCrsUpdt_Click(object sender, EventArgs e) {
            try{
                if (ValidateForm()){
                    int cstValue;
                    _courseNew = new Course();

                    _courseNew.Code = Convert.ToInt32(CrCodeTxBx.Text); //codigo curso                    
                    _courseNew.SubjectName = CrsNameTBx.Text;
                    _courseNew.SubjCode = _selectedSubject.Code; //codigo de la materia de ese curso
                    _courseNew.Description = CrsDescTBx.Text;

                    if (int.TryParse(CrsMaxQtTBx.Text, out cstValue)){
                        _courseNew.MaximumQuota = cstValue;
                    }
                    if (int.TryParse(CrClRmTBx.Text, out cstValue)){
                        _courseNew.ClassRoom = cstValue;
                    }
                    if (int.TryParse(CrHrFrmTBx.Text, out cstValue)){
                        _courseNew.HrFrom = cstValue;
                    }
                    if (int.TryParse(CrHrUntilTBx.Text, out cstValue)){
                        _courseNew.HrUntil = cstValue;
                    }

                    string selectedShift = CrShftLBx.SelectedItem.ToString();
                    switch (selectedShift){
                        case "Morning":
                            _courseNew.Shift = SHIFT.Morning;
                            break;
                        case "Late":
                            _courseNew.Shift = SHIFT.Late;
                            break;
                        case "Night":
                            _courseNew.Shift = SHIFT.Night;
                            break;
                    }
                    _courseNew.Days = GetDaysByCheckedList();

                    //---------------Call Update Servie------------------------
                    _courseResp = _courseService.UpdateCourse(_courseNew, _clickedCrsCode);

                    if (_courseResp.Status.Equals(Response.OK)){
                        ShowInfoMssg(_courseResp.Message);
                        CleanCreationForm();
                        CourseMainTab.SelectedIndex = 0;
                        ListAllCourses();
                    }else if (_courseResp.Status.Equals(Response.ERROR)){
                        ShowErrorMssg(_courseResp.Message);
                    }
                    //-------------------------------------------------------
                }
            }catch (Exception ex){
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private int GetDaysByCheckedList() {
            int days = 100000;
            foreach (String str in _selectedDays) {
                if (str.Equals("Lunes"))
                    days += 10000;
                else if(str.Equals("Martes"))
                    days += 1000;
                else if (str.Equals("Miercoles"))
                    days += 100;
                else if (str.Equals("Jueves"))
                    days += 10;
                else if (str.Equals("Viernes"))
                    days += 1;
            }
            return days;
        }
        private void ShowErrorMssg(string mssg) {
            MessageBox.Show(mssg,"curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ShowInfoMssg(string mssg) {
            MessageBox.Show(mssg, "curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //combo box materias
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (SbjLBx.SelectedIndex != -1) {
                _selectedSubject = (Subject)SbjLBx.SelectedItem;
                _lastCrCodeBySubj = _courseService.GetLastCourseCodeBySubjectCode(_selectedSubject.Code);
            }
        }
        //Canel Btn
        private void CrCancelBtn_Click(object sender, EventArgs e) {
            CleanCreationForm();
            CourseMainTab.SelectedIndex = 0;
        }

        //Dias de cursada
        private void CrDaysLBx_SelectedIndexChanged(object sender, EventArgs e){

        }

        private void CrDaysLBx_ItemCheck(object sender, ItemCheckEventArgs e){
            int itemIndex = e.Index;                        
            if (e.NewValue == CheckState.Checked){               
                string selectedItem = CrDaysLBx.Items[itemIndex].ToString();                
                Console.WriteLine($"Seleccionado: {selectedItem}");
                _selectedDays.Add( selectedItem );
            }
            else if (e.NewValue == CheckState.Unchecked){                
                string deselectedItem = CrDaysLBx.Items[itemIndex].ToString();                
                Console.WriteLine($"Deseleccionado: {deselectedItem}");
                _selectedDays.Remove( deselectedItem );
            }
        }

        private void CoursesDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            CleanCreationForm();
            BtnCrsUpdt.Visible = true;
            CrSaveBtn.Visible = false;

            _clickedCrsCode = Convert.ToInt32(CoursesDGV.CurrentRow.Cells["ClmCrsCode"].Value);

            CrCodeTxBx.Text = Convert.ToString(CoursesDGV.CurrentRow.Cells["ClmCrsCode"].Value);
            CrsNameTBx.Text = Convert.ToString(CoursesDGV.CurrentRow.Cells["ClmCrsName"].Value);
            CrsMaxQtTBx.Text = Convert.ToString(CoursesDGV.CurrentRow.Cells["ClmCrsMxQt"].Value);
            CrsDescTBx.Text = Convert.ToString(CoursesDGV.CurrentRow.Cells["ClmCrsDesc"].Value);
            CrClRmTBx.Text = Convert.ToString(CoursesDGV.CurrentRow.Cells["ClmCrsClsRm"].Value);
            CrHrFrmTBx.Text = Convert.ToString(CoursesDGV.CurrentRow.Cells["ClmCrsHrFrom"].Value);
            CrHrUntilTBx.Text = Convert.ToString(CoursesDGV.CurrentRow.Cells["ClmCrsHrUntil"].Value);
              
            /*---dia/s de la cursada----*/
            int test = Convert.ToInt32(CoursesDGV.CurrentRow.Cells["ClmCrsDays"].Value);
            string rstl = test.ToString().Trim();
            for (int i = 1; i <= rstl.Length-1; i++) {
                CrDaysLBx.SetItemChecked(i-1, rstl[i].Equals('1'));
            }

            /*---turno de la cursada----*/
            string itemToSelect = Convert.ToString(CoursesDGV.CurrentRow.Cells["ClmCrsShift"].Value);            
            foreach (object item in CrShftLBx.Items) {
                if (item.ToString() == itemToSelect){
                    CrShftLBx.SelectedItem = item;
                    break;
                }
            }

            /*---materia del curso---*/
            int subjCodeSlctd = Convert.ToInt32(CoursesDGV.CurrentRow.Cells["ClmCrsSbjCode"].Value);
            foreach (Subject subj in SbjLBx.Items) {
                if (subj.Code.Equals(subjCodeSlctd)) {
                    SbjLBx.SelectedItem =subj;
                    break;
                }
            }
            CourseMainTab.SelectedIndex = 1;
        }

        private void CoursesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == CoursesDGV.Columns["CbxSlcClm"].Index) {
                DataGridViewCheckBoxCell dgVwChBxCll = (DataGridViewCheckBoxCell)CoursesDGV.Rows[e.RowIndex].Cells["CbxSlcClm"];
                dgVwChBxCll.Value = !Convert.ToBoolean(dgVwChBxCll.Value);
            }
        }

        private void BtnDltCrs_Click(object sender, EventArgs e) {
            Response resp = null;
            List<int> crsCodeDelete = new List<int>();
            try {
                DialogResult dlgRsl = MessageBox.Show("esta seguro de eliminar el/los curso/?s","eliminar",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlgRsl == DialogResult.OK) {
                    foreach (DataGridViewRow row in CoursesDGV.Rows) {
                        if (Convert.ToBoolean(row.Cells[0].Value)) {
                            crsCodeDelete.Add(Convert.ToInt32(row.Cells[2].Value));
                        }
                    }
                }
                resp = _courseService.DeleteCourseAndTheirEnrollmentsByCode(crsCodeDelete);

                foreach (string mssg in resp.Messages) { 
                    Debug.WriteLine("->"+mssg);
                }
                ListAllSubjects();
                ListAllCourses();
            }
            catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
