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
    public partial class Start_Window : Form
    {
        public static Start_Window __main__;
        bool Eight = false, Fifteen = false, twentyfour ;
        public Start_Window()
        {
            InitializeComponent();
            __main__ = this;
        }

        private void Start_Window_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbx_size.SelectedItem.ToString())
            {
                case "3 * 3":
                   
                    List<string> lst1 = new List<string>() { "A*"};
                  
                    Eight = true; Fifteen = false; twentyfour = false;
                    break;
                case "4 * 4":
                 
                    List<string> lst2 = new List<string>() { "A*" };
                
                    Eight = false; Fifteen = true; twentyfour =false;
                    break;
                case "5 * 5":

                    List<string> lst3 = new List<string>() { "A*" };

                    Eight = false; Fifteen = false; twentyfour = true;

                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eight_Puzzle _8 = new Eight_Puzzle();
            Fifteen_Puzzle _15 = new Fifteen_Puzzle();
            
            twentyfour_Puzzle _24 = new twentyfour_Puzzle();
            if (Eight)
            {

                _8.b_a_star = true;
                _8.Show();
                __main__.Hide();
            }
            else if (Fifteen)
            {
                _15.b_a_star = true;
                _15.Show();
                __main__.Hide();
            }
            else if(twentyfour)
                    {
                
                    _24.b_a_star = true;
                    _24.Show();
                    __main__.Hide();
                
            }
            

        }
    }
}
