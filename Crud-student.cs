namespace CRUD_DotNet
{
    public partial class CrudStudent : Form
    {
        public CrudStudent()
        {
            InitializeComponent();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FormStudent form = new FormStudent();
            form.ShowDialog();
        }


    }
}
