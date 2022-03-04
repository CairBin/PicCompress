using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicCompress
{
    public partial class MainWindow : Form
    {
        //窗口宽高
        private const int WD_WIDTH = 450;
        private const int WD_HEIGHT = 270;

        //文本框宽
        private const int TXTBOX_WIDTH = 325;

        //进度条宽
        private const int BAR_WIDTH = 406;

        private List<string> lst = new List<string>();


        public MainWindow()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //创建输出目录记录文件，默认为该程序目录
            FileOperator.CreateFile(GetAppPath(), "outpath", GetAppPath());

            //设置窗体
            this.Width = WD_WIDTH;
            this.Height = WD_HEIGHT;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.Text = "PicCompress";
            this.MaximizeBox = false;

            //设置图片目录标签
            this.Label_imgPath.Text = "图片：";
            this.Label_imgPath.Location = new Point(16, 29);

            //设置输出目录标签
            this.Label_outPath.Text = "输出位置：";
            this.Label_outPath.Location = new Point(16, 86);
            
            //设置图片目录文本输入框
            this.Txt_imgPath.Text = String.Empty;   //默认为空
            this.Txt_outPath.Location = new Point(16, 49);
            this.Txt_imgPath.Width = TXTBOX_WIDTH;
            this.Txt_imgPath.ReadOnly = true;

            //设置输出目录文本输入框
            string txt = String.Empty;
            FileOperator.ReadFileFirstLine(GetAppPath()+"outpath",ref txt);
            this.Txt_outPath.Text = txt;
            this.Txt_outPath.Location = new Point(16,106);
            this.Txt_outPath.Width= TXTBOX_WIDTH;
            this.Txt_outPath.ReadOnly = true;

            //设置进度条
            this.compressBar.Width = BAR_WIDTH;
            this.compressBar.Location = new Point(16, 149);
            this.compressBar.Maximum = 0;
            this.compressBar.Maximum = 100;


            //打开图片按钮
            this.Button_openFile.Location = new Point(347, 49);
            this.Button_openFile.Text = "...";

            //输出目录按钮
            this.Button_openPath.Location = new Point(347, 106);
            this.Button_openPath.Text = "...";

            //运行按钮
            this.Button_run.Location = new Point(347, 187);
            this.Button_run.Text = "运行";

            //设置选择框
            this.checkBox1.Text = "快速模式";
            this.checkBox1.CheckState = CheckState.Checked; //默认选中
            this.checkBox1.Location = new Point(270, 187);

            //设置默认目录按钮
            this.Button_setPath.Text = "设为默认输出目录";
            this.Button_setPath.Location = new Point(16, 187);

        }

        //获取当前路径
        private string GetAppPath()
        {
            string str = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            return str;
        }

        private void Button_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Multiselect = true;
            file.Filter = "PNG(*.png)|*.png|JPEG(*.jpg, *.jpeg, *.jpe, *.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif";
            file.ShowDialog();

            for(int i=0; i<file.FileNames.Length; i++)
            {
                lst.Add(file.FileNames[i]);
                this.Txt_imgPath.Text = this.Txt_imgPath.Text+file.FileNames[i]+";";
            }
            
        }

        private void Button_openPath_Click(object sender, EventArgs e)
        {
            //打开目录
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.Txt_outPath.Text = path.SelectedPath + "\\";
        }

        private void Button_run_Click(object sender, EventArgs e)
        {
            if(this.Txt_outPath.Text == String.Empty ||
                this.Txt_imgPath.Text == String.Empty)
            {
                MessageBox.Show("错误：文件或目录不正确！");
                return;
            }
            compressBar.Value = 0;


            if (this.checkBox1.Checked == true)
            {
                MessageBox.Show("hello");
            }
            else
            {
                MessageBox.Show("No");
            }

            
            

        }

        private string GetSysTime()
        {
            string time = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss_ffff");
            return time;
        }

        private void Button_setPath_Click(object sender, EventArgs e)
        {
            string path = this.Txt_outPath.Text;

            if(!File.Exists(GetAppPath()+"outpath"))
            {
                MessageBox.Show("错误：默认目录设置文件不存在");
                this.Close();
            }

            //写入默认目录
            if (FileOperator.WriteFile(GetAppPath() + "outpath",
                this.Txt_outPath.Text))
                MessageBox.Show("设置成功！");
            else
                MessageBox.Show("设置失败！");

        }
    }
}
