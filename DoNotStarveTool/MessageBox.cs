using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace DoNotStarveTool
{
    public partial class MessageBox : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;
        string Info;
        Form Parent;
        public MessageBox(string text, Form MyParent)
        {
            InitializeComponent();
            InitMyForm();
            byte[] fontData = Properties.Resources.belisa_plumilla;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.belisa_plumilla.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.belisa_plumilla.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            myFont = new Font(fonts.Families[0], 16.0F);
            Info = text;
            Parent = MyParent;
        }
        private void InitMyForm()
        {
            this.BackColor = Color.Gray;
            // Make the background color of form display transparently. 
            this.TransparencyKey = BackColor;
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {
            //OkButton.Font = myFont;
            //CancelButton.Font = myFont;
            richTextBox1.Text = Info;
            OkButton.Text = "OK";
            CancelButton.Text = "Close";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OkButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Click;
            this.Hide();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            OkButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Over;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            OkButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
            CancelButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Click;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            CancelButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Over;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            CancelButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Normal;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
