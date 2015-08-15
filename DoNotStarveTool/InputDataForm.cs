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
    public partial class InputDataForm : Form
    {
        public DialogResult myResult;
        public string ReturnValue2 { get; set; }
        public string SnapName {
            get { return InputName.Text;  }          
        }
        public InputDataForm()
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
        private void InputDataForm_Load(object sender, EventArgs e)
        {
            InputName.Focus();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            InputName.Focus();
        }

        private void InputName_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = global::DoNotStarveTool.Properties.Resources.TextBox_Highlight;
        }
    }
}
