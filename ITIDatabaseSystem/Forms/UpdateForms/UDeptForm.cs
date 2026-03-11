using ITIDatabaseSystem.Context;
using ITIDatabaseSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ITIDatabaseSystem.Forms.UpdateForms
{
    public partial class UDeptForm : Form
    {
        AppDBContext db = new AppDBContext();
        public UDeptForm()
        {
            InitializeComponent();
            FillDeptList();
            loclbl.Hide();
            mgrlbl.Hide();
            namelbl.Hide();
            Updatelbl.Hide();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            var updForm = new UpdateForm();
            updForm.Show();
            this.Hide();
        }

        private void FillDeptList()
        {
            Deptlist.DataSource = db.Departments
                .Select(d => new
                {
                    DeptName = d.Dept_Name,
                    d.Dept_ID
                })
                .ToList();

            Deptlist.DisplayMember = "DeptName";
            Deptlist.ValueMember = "Dept_ID";
        }
        private void Deptlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            loclbl.Hide();
            mgrlbl.Hide();
            namelbl.Hide();
            Updatelbl.Hide();

            IDtxt.Text = db.Departments
            .Where(ent => ent.Dept_ID == Convert.ToInt32(Deptlist.SelectedValue))
            .Select(ent => ent.Dept_ID)
            .FirstOrDefault()
            .ToString();

            Nametxt.Text = db.Departments
            .Where(ent => ent.Dept_ID == Convert.ToInt32(Deptlist.SelectedValue))
            .Select(ent => ent.Dept_Name)
            .FirstOrDefault()
            .ToString();

            Locationtxt.Text = db.Departments
            .Where(ent => ent.Dept_ID == Convert.ToInt32(Deptlist.SelectedValue))
            .Select(ent => ent.Dept_Location)
            .FirstOrDefault()
            .ToString();

            Mgrtxt.Text = db.Departments
            .Where(ent => ent.Dept_ID == Convert.ToInt32(Deptlist.SelectedValue))
            .Select(ent => ent.ManagerID)
            .FirstOrDefault()
            .ToString();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            loclbl.Hide();
            mgrlbl.Hide();
            namelbl.Hide();
            Updatelbl.Hide();

            var toUpdate = db.Departments.FirstOrDefault(ent => ent.Dept_ID == Convert.ToInt32(Deptlist.SelectedValue));

            bool op1 = toUpdate.Dept_Name == Nametxt.Text;
            bool op2 = toUpdate.Dept_Location == Locationtxt.Text;
            bool op3 = toUpdate.ManagerID.ToString() == Mgrtxt.Text;


            if (!Validations.CheckName(Nametxt.Text))
            {
                namelbl.Show();
                return;
            }


            if (!Validations.CheckNumber(Mgrtxt.Text))
            {
                mgrlbl.Show();
                return;
            }



            if (string.IsNullOrWhiteSpace(Nametxt.Text) || string.IsNullOrWhiteSpace(Mgrtxt.Text))
            {
                Updatelbl.ForeColor = Color.Red;
                Updatelbl.Text = "Fields cant't be empty.";
                Updatelbl.Show();
                return;
            }

            if (!op1 || !op2 || !op3)
            {
                toUpdate.Dept_Name = Nametxt.Text;
                toUpdate.Dept_Location = Locationtxt.Text;
                toUpdate.ManagerID = Convert.ToInt32(Mgrtxt.Text);

                db.SaveChanges();

                Updatelbl.ForeColor = Color.White;
                Updatelbl.Text = "1 Row Updated Successfully.";
                Updatelbl.Show();
            }
            else
            {
                Updatelbl.ForeColor = Color.Red;
                Updatelbl.Text = "Update any data first.";
                Updatelbl.Show();
            }
        }
    }
}
