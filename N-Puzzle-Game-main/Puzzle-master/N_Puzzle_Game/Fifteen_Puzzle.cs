using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_Puzzle_Game
{
    public partial class Fifteen_Puzzle : Form
    {

        string path = "";
        Timer t;
        
        UserControl_Puzzle_Pictures pic;
        public bool b_a_star = false;

        public Fifteen_Puzzle() 
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
          
                panel1.Controls.Clear();
               pic = new UserControl_Puzzle_Pictures(path, 280, 4, 70);
                panel1.Controls.Add(pic);
            
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            int[,] state;
            string s = "";
            int start = DateTime.Now.Minute * 60 * 1000 +
                DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
           if (pic != null && radioButton2.Checked)
            {
                state = get_state(pic.state);
               if (b_a_star && !pic.is_goal())
                {
                    pic.obj_astar = new a_star(4);
                    pic.obj_astar.set_goal(pic.obj_astar.get_destination());
                    pic.obj_astar.solve(get_state(pic.state)); pic.start();
                    s = "A*";
                }

            }
          
        }

        private int[,] get_state(string state) 
        {
            int N = (int)Math.Sqrt(state.Length);
            int[,] rs = new int[N, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    int idx = i * N + j;
                    rs[i, j] = state[idx] - 48;
                }
            return rs;
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            OpenFileDialog choose = new OpenFileDialog();
            choose.Filter =
                "Image Files (JPEG, GIF, PNG , JPG) |*.jpeg; *.gif; *.png; *.jpg";

            if (choose.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(choose.FileName);
                path = choose.FileName;
            }
        }

        private void Fifteen_Puzzle_FormClosed(object sender, FormClosedEventArgs e)
        {    
                Start_Window.__main__.Show();   
        }

        private void t_click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                int x = this.Width + 1;
                if (x <= 624) this.Width = x;
                else t.Stop();
            }
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            t.Start();
        }

        private void Fifteen_Puzzle_Load(object sender, EventArgs e)
        {
            this.Width = 310;
            t = new Timer();
            t.Interval = 5;
            t.Tick += new EventHandler(t_click);
           
            radioButton2.Checked = false;
        }

      

      
    }
}
