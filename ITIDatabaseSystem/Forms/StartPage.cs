using ITIDatabaseSystem.Forms;
namespace ITIDatabaseSystem
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Selectbtn_Click(object sender, EventArgs e)
        {
            var selectForm = new SelectForm();
            selectForm.Show();
            this.Hide();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var deleteForm = new DeleteForm();
            deleteForm.Show();
            this.Hide();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            var insertForm = new InsertForm();
            insertForm.Show();
            this.Hide();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            var updateForm = new UpdateForm();
            updateForm.Show();
            this.Hide();
        }
    }
}
