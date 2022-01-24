using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materials
{
   // [Serializable]
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text ="Subject";
            
        }
        public subjects subjects;
        public event EventHandler savebtnDown ;
       
        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            savebtnDown(sender,e);
            this.Close();
        }
        private void btn_donotsave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            GlobalClass.cancelClicked = true;
           

        }
    }
}
