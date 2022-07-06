using System.Xml.Linq;

namespace Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
            txtname.Text = "";
            txtname.Focus();
        }



        private void btn_sayhello_Click(object sender, EventArgs e)
        {
            string s;
            s = " سلام "+ txtname.Text;
            lblresult.Text= s;
         
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (txtname.Text == "")
                btn_sayhello.Enabled = false;
            else
                btn_sayhello.Enabled = true;
            btnclear.Enabled = Convert.ToBoolean(txtname.Text.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnexit.Focus();
            txtname_TextChanged(null, null);
        }

        private void btnexit_MouseMove(object sender, MouseEventArgs e)
        {
            btnexit.BackColor = Color.Red;
        }

        private void btnexit_MouseLeave(object sender, EventArgs e)
        {
            btnexit.BackColor = Color.White;
        }

        private void btn_sayhello_MouseMove(object sender, MouseEventArgs e)
        {
            btn_sayhello.BackColor = Color.Lime;
        }

        private void btn_sayhello_MouseLeave(object sender, EventArgs e)
        {
            btn_sayhello.BackColor = Color.White;

        }

        private void btnclear_MouseMove(object sender, MouseEventArgs e)
        {
            btnclear.BackColor = Color.Yellow;
        }

        private void btnclear_MouseLeave(object sender, EventArgs e)
        {
            btnclear.BackColor = Color.White;
        }

        private void txtname_MouseMove(object sender, MouseEventArgs e)
        {
            txtname.ForeColor = Color.Red;


        }

        private void txtname_MouseLeave(object sender, EventArgs e)
        {
            txtname.ForeColor = Color.Black;
        }
    }
}