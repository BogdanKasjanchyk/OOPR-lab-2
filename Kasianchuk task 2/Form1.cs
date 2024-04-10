namespace Kasianchuk_task_2
{
    public partial class Form1 : Form
    {
        Manager manager = new Manager();
        Human human = new Human();
        public Form1()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            manager.Name = "John";
            MessageBox.Show(manager.Name);

            human = manager;
            MessageBox.Show(human.name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            manager.Name = "Sarah";
            manager.Display();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            VisitorPanel visitorPanel = new VisitorPanel();
            visitorPanel.Show();
            this.Hide();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            managerPanel ManagerPanel = new managerPanel();
            ManagerPanel.Show();
            this.Hide();
        }
    }
}