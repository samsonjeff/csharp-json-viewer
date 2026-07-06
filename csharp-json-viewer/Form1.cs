using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;

namespace csharp_json_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        HttpClient client = new HttpClient();
        List<Users>? users = new List<Users>();
        string url = @"";

        private void Form1_Load(object sender, EventArgs e)
        {
            //activateBtn.Enabled = false;
            loadBtn.Enabled = false;
        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            //loadBtn.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //loadBtn.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            url = textBox1.Text;
        }


        private void activateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(url))
            {
                loadBtn.Enabled = true;
                textBox1.Text = url;
                MessageBox.Show("URL/SRC Activated");
            }
            else
            {
                MessageBox.Show("URL/SRC Invalid!");
                loadBtn.Enabled=false;
            }
        }

        private async void loadBtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !string.IsNullOrEmpty(url))
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string? loadOnline = await client.GetStringAsync(url);
                        List<Users>? userOnline = JsonSerializer.Deserialize<List<Users>>(loadOnline);
                        dataGridView1.DataSource = userOnline;
                        dataGridView1.Columns["Address"].Visible = false;
                        MessageBox.Show("Load! Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (radioButton2.Checked && !string.IsNullOrEmpty(url))
            {
                try
                {
                    string loadLocal = await File.ReadAllTextAsync(url);
                    List<Users>? userLocal = JsonSerializer.Deserialize<List<Users>>(loadLocal);
                    dataGridView1.DataSource = userLocal;
                    //dataGridView1.Columns["Address"].Visible = false;
                    MessageBox.Show("Load! Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                loadBtn.Enabled = false;
                MessageBox.Show("Faild to Load!");
            }


        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //string viewJson = "https://jsonplaceholder.typicode.com/users";
            //textBox1.Text = viewJson;
        }
    }
}
/* paste this link when you are going to run this system inside the text box of the windows form:
https://jsonplaceholder.typicode.com/users
D:\csharp-json-viewer\csharp-json-viewer\json\Users.json
*/
