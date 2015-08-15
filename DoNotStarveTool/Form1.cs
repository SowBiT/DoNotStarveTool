using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Xml;

namespace DoNotStarveTool
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;
        bool SourceSelected = true, DesSelected = false, isShow=false;
        string SourcePath, DesPath;
        int SelectSnap,NewSelectSnap;
        int NumSnap=0;
        int Step;
        MessageBox ThongBao;

        public List<SnapshotItem> SnapItemList = new List<SnapshotItem>();
        public Form1()
        {
            InitializeComponent();
            byte[] fontData = Properties.Resources.belisa_plumilla;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.belisa_plumilla.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.belisa_plumilla.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 16.0F);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button1.Font = myFont;
           // button2.Font = myFont;       
            XoaSnapShotButton.Enabled = false;
            string username = Environment.UserName;
            string Path = "C:\\Users\\"+username+"\\Documents\\Klei\\DoNotStarveTogether";
            SourcePath = @Path;
            TextBoxSourceDir.Text = SourcePath;           
            FolderSelectDialog.SelectedPath = @Path;           
            LoadData();
            LoadSetting();           
            
            
        }
        private void LoadSetting() {
            XmlDocument xmldoc = new XmlDocument();        
            xmldoc.Load(@"settings.xml");                         
            XmlNode SettingNode = xmldoc.SelectSingleNode("//CaiDat[@name='NumSnapShot']");
            NumSnap = int.Parse(SettingNode.Attributes["value"].Value);
            XmlNode SettingNode2 = xmldoc.SelectSingleNode("//CaiDat[@name='DesPath']");
            DesPath = SettingNode2.Attributes["value"].Value;
            if (DesPath != "")
            {
                DesSelected = true;
            }
            TextBoxDesDir.Text = DesPath;
           
            
        }
        public static void CopyFilesRecursively(string source, string target)
        {
            foreach (string dirPath in Directory.GetDirectories(source, "*",SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(source, target));
            foreach (string newPath in Directory.GetFiles(source, "*.*",SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(source, target), true);
        }
        private void button1_Click(object sender, EventArgs e)           
        {     
           
            if (SourceSelected){
                if (DesSelected) {
                    // Bat dau copy thu muc
                    using (InputDataForm InputForm = new InputDataForm())
                    {                        
                        DialogResult Ketqua = InputForm.ShowDialog();
                        if (Ketqua == DialogResult.OK)
                        {
                            string SnapshotName = InputForm.SnapName;
                            string newDesPath = DesPath + "\\" + SnapshotName;
                            if (Directory.Exists(newDesPath))
                            {
                                ShowThongBao("Đã tồn tại snapshot với tên này rồi. Không thể tạo thêm ! Vui lòng chọn tên khác.");
                            } else {
                                SaoLuuSnapShot(SnapshotName);
                                Directory.CreateDirectory(newDesPath);
                                CopyFilesRecursively(SourcePath, newDesPath);
                                ShowThongBao("Đã sao lưu dữ liệu thành công !");
                            }
                        } else {
                            ShowThongBao("Snapshot chưa được lưu !"); 
                        }
                    }
                } else { 
                    // chua chon Des path 
                    ShowThongBao("Chưa chọn thư mục chứa dữ liệu sau khi lưu.");
                    
                }
            } else {
                ShowThongBao("Chưa chọn thư mục cần lưu.");
                
            }
            button1.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Highlight_Click;         
        
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Highlight_Over;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Highlight_Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Khoi phuc SnapShot
            PhucHoiButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Highlight_Click;
            PhucHoiSnapShot();
        }
        public void PhucHoiSnapShot() {
            if (dataGridView1.SelectedRows.Count >= 1)
            {              
                string newBackupPath = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].Value.ToString();
                if (Directory.Exists(newBackupPath))
                {
                    CopyFilesRecursively(newBackupPath, SourcePath);
                    ShowThongBao("Đã khôi phục dữ liệu thành công !");
                } else {
                    ShowThongBao("Thư mục chứa dữ liệu đã mất ! Không thể khôi phục lại dữ liệu.");
                }              
            } else {
                ShowThongBao("Chưa chọn Snapshot cần phục hồi !");
            }
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            PhucHoiButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Highlight_Over;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            PhucHoiButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Highlight_Normal;          
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            PhucHoiButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Highlight_Click;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ButtonSourceSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ChonFolder = FolderSelectDialog;
            DialogResult KetQua = ChonFolder.ShowDialog();
            if (KetQua == DialogResult.OK)
            {
                TextBoxSourceDir.Text = ChonFolder.SelectedPath;
                SourcePath = ChonFolder.SelectedPath;
                SourceSelected = true;
            }
        }

        private void ButtonDesSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ChonFolder = FolderSelectDialog;
            DialogResult KetQua = ChonFolder.ShowDialog();
            if (KetQua == DialogResult.OK)
            {
                TextBoxDesDir.Text = ChonFolder.SelectedPath;
                DesPath = ChonFolder.SelectedPath;
                DesSelected = true;
                /*
                 luu Thong tin Des Path
                 */
                XmlDocument xmldoc = new XmlDocument();               
                xmldoc.Load(@"settings.xml");
                XmlNode newNode = xmldoc.SelectSingleNode("//CaiDat[@name='DesPath']");
                newNode.Attributes["value"].Value = DesPath;
                xmldoc.Save(@"settings.xml");
            }
        }


        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Over;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Normal;
        }
        private void UpdateSetting() {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"settings.xml");
            XmlNode newNode = xmldoc.SelectSingleNode("//CaiDat[@name='NumSnapShot']");
            newNode.Attributes["value"].Value = NumSnap.ToString();
            xmldoc.Save(@"settings.xml");           
        }
        private void SaoLuuSnapShot(string SnapShotName)
        {
            NumSnap += 1;         
            UpdateSetting();

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"data.xml");          
            XmlElement NewNode = xmldoc.CreateElement("Snapshot");
            NewNode.SetAttribute("id", NumSnap.ToString());
            XmlNode SnapID = xmldoc.CreateElement("Snapshot_Ten");
            SnapID.InnerText = SnapShotName;
            XmlNode SnapName = xmldoc.CreateElement("Snapshot_Link");
            SnapName.InnerText = DesPath+"\\"+SnapShotName;
            DateTime now = DateTime.Now;
            string date = now.GetDateTimeFormats('d')[0];
            string time = now.GetDateTimeFormats('t')[0];
            XmlNode SnapDate = xmldoc.CreateElement("Snapshot_Ngay");
            SnapDate.InnerText = date;
            NewNode.AppendChild(SnapID);
            NewNode.AppendChild(SnapName);
            NewNode.AppendChild(SnapDate);
            xmldoc.DocumentElement.AppendChild(NewNode);
            xmldoc.Save(@"data.xml");
            LoadData();
        }

        private void LoadData()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNodeList xmlnode;
            dataGridView1.Rows.Clear();
            int i = 0;         
            xmldoc.Load(@"data.xml");
            xmlnode = xmldoc.GetElementsByTagName("Snapshot");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                XmlNode parentNode = xmlnode[i].ParentNode;
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                string LoadNodeID = xmlnode[i].Attributes["id"].Value.ToString();
                string LoadNodeName = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                string LoadNodeLink = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                string LoadNodeDate = xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                dataGridView1.Rows.Add(LoadNodeID, LoadNodeName, LoadNodeDate, LoadNodeLink);
                            
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RemoveSnapShot();     
        }
        public void RemoveSnapShot() {
            //Remove node            
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(@"data.xml");
                XmlNodeList nodes = xmldoc.SelectNodes("//Snapshot[@id='" + NewSelectSnap + "']");
                XmlNode thisNode = nodes[0].ChildNodes.Item(0);
                string TenNode = thisNode.InnerText;
                XmlNode thisNode2 = nodes[0].ChildNodes.Item(1);
                string LinkNode = thisNode2.InnerText;
                for (int i = nodes.Count - 1; i >= 0; i--)
                {
                    nodes[i].ParentNode.RemoveChild(nodes[i]);
                }
                xmldoc.Save(@"data.xml");
                dataGridView1.Rows.RemoveAt(SelectSnap);
                if (Directory.Exists(LinkNode))
                {
                    Directory.Delete(LinkNode, true);
                }            
                ShowThongBao("Đã xóa Snapshot " + TenNode);
            } 
        }     

        private void XoaSnapShotButton_MouseHover(object sender, EventArgs e)
        {
            XoaSnapShotButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Over;
        }

        private void XoaSnapShotButton_MouseLeave(object sender, EventArgs e)
        {
            XoaSnapShotButton.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Normal;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {           
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                SelectSnap = row.Index;
                NewSelectSnap = int.Parse(row.Cells[0].Value.ToString());
                XoaSnapShotButton.Enabled = true;
                PhucHoiButton.Enabled = true;
               // ShowThongBao("ID Snapshot: "+NewSelectSnap.ToString()+"  Row Index:"+SelectSnap.ToString()+"\nTên Snapshot: " + row.Cells[1].Value.ToString() +"\n"+"Đường dẫn: "+row.Cells[3].Value.ToString());
            }
        }
        public void ShowThongBao(string StrInfo) {
            if(isShow)
            {
                ThongBao.Close();
            }  
                ThongBao = new MessageBox(StrInfo, this);
                ThongBao.Show();
                isShow = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AboutForm newForm = new AboutForm();
            newForm.Show();
        }

        private void TextBoxSourceDir_TextChanged(object sender, EventArgs e)
        {

        }
        private void ButtonSourceSelect_MouseHover(object sender, EventArgs e)
        {
            ButtonSourceSelect.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Over;
        }

        private void ButtonSourceSelect_MouseLeave(object sender, EventArgs e)
        {
            ButtonSourceSelect.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Normal;
        }

        private void ButtonDesSelect_MouseHover(object sender, EventArgs e)
        {
            ButtonDesSelect.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Over;
        }

        private void ButtonDesSelect_MouseLeave(object sender, EventArgs e)
        {
            ButtonDesSelect.BackgroundImage = global::DoNotStarveTool.Properties.Resources.Button_Normal;
        }

       
    }
    public class SnapshotItem
    {
        public int SnapShotID;
        public string SnapShotName;
        public string SnapShotPath;
        public string SnapShotDate;
    }
}
