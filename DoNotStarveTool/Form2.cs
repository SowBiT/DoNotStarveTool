using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNotStarveTool
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            InitMyForm();
        }
        private void InitMyForm()
        {
            this.BackColor = Color.Gray;
            // Make the background color of form display transparently. 
            this.TransparencyKey = BackColor;
        }
        private void AboutForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_MouseHover(object sender, EventArgs e)
        {
            CancelButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Over;
        }

        private void CancelButton_MouseLeave(object sender, EventArgs e)
        {
            CancelButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Normal;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Normal;
            this.Close();
        }
    }
}
