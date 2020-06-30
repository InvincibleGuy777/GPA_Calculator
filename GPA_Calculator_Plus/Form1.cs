using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Data.OleDb;

namespace GPA_Calculator_Plus
{
    public partial class MainForm : Form
    {
        public static IList<InfoVo> list;
        public static BindingList<InfoVo> dataBindings;

        public static aboutForm aboutForm;
        public static helpForm helpForm;
        public MainForm()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            InitializeComponent();
            EventHandle();
            DragHandle();
            list = new List<InfoVo>();
            DataGridView_Operate.Init(this.dataGridView);
            //MessageBox.Show(GPA_CALC.isNum(".51.6").ToString());
            //MessageBox.Show(GPA_CALC.Convert2GPA(92.5).ToString());
        }

        /// <summary>
        /// 事件委托
        /// </summary>
        void EventHandle()
        {
            this.MouseDown += new MouseEventHandler(MainForm_MouseDown);
            this.exitBtn.Click += new EventHandler(exitBtn_Click);
            this.toolStrip.Paint += new PaintEventHandler(toolStrip_Paint);
            this.textBox_Output.TextChanged += new EventHandler(textBox_TextChanged);
            this.button_Calc.Click += new EventHandler(button_Calc_Click);
            this.dataGridView.DataError += new DataGridViewDataErrorEventHandler(dataGridView_DataError);
            this.dataGridView.CellValidated += new DataGridViewCellEventHandler(dataGridView_CellValidated);
            //this.Invalidate();
        }
        /// <summary>
        /// 窗体拖动设置
        /// </summary>
        void DragHandle()
        {
            //确保在窗体控件上MouseDown时也能拖动
            foreach (Control c in this.Controls)
            {
                c.MouseDown += new MouseEventHandler(MainForm_MouseDown);
                //Debug.WriteLine(c.GetType());
            }
            foreach (Control c in this.panel1.Controls)
            {
                //防止在按钮上拖动
                if (c.GetType() == this.exitBtn.GetType()
                    || c.GetType() == this.miniBtn.GetType())
                    continue;
                c.MouseDown += new MouseEventHandler(MainForm_MouseDown);
                //Debug.WriteLine(c.GetType());
            }
        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        /// <summary>
        /// 使得窗体能被拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            //SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            //if(sender is aboutForm)
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void aboutForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            //SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            //if(sender is aboutForm)
            SendMessage(aboutForm.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void helpForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            //SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            //if(sender is aboutForm)
            SendMessage(helpForm.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            //从最小化回到正常页面会重绘，此句防止toolStrip边框出现
            //this.toolStrip.Paint += new PaintEventHandler(toolStrip_Paint);
        }
        /// <summary>
        /// 重绘toolStrip去掉边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_Paint(object sender, PaintEventArgs e)
        {
            //MessageBox.Show(this.toolStrip.RenderMode.ToString());
            //if ((sender as ToolStrip).RenderMode == ToolStripRenderMode.System)
            {
                Rectangle rect = new Rectangle(0, 0, this.toolStrip.Width - 2, this.toolStrip.Height - 2);
                e.Graphics.SetClip(rect);
                //MessageBox.Show("Done!");
                //取消委托
                //(sender as ToolStrip).Paint -= new PaintEventHandler(toolStrip_Paint);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridView_Operate.Remove(this.dataGridView);
        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.Rows.Count <= 1)
                return;
            DataGridView_Operate.CalcGPA(this.dataGridView, this.textBox_Output);
            this.textBox_Output.Text += "-----Done-----" + Environment.NewLine;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("fuck");
            TextBox tb = (sender as TextBox);

            tb.Focus();
            tb.Select(tb.TextLength, 0);
            tb.ScrollToCaret();
        }

        private void tsb_data_export_Click(object sender, EventArgs e)
        {
            DataGridView_Operate.ExportData2Excel(this.dataGridView);
        }

        private void tsb_data_import_Click(object sender, EventArgs e)
        {
            DataGridView_Operate.ImportExcel2DGV(this.dataGridView);
            //MessageBox.Show("导入成功");
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            dataBindings.Clear();  //注意静态成员不要加this

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                    dataBindings.RemoveAt(row.Index);
            }
        }

        private void dataGridView_DataError(object sender,
            DataGridViewDataErrorEventArgs e)
        {

            DataGridView dgv = sender as DataGridView;
            //MessageBox.Show(e.ColumnIndex.ToString() + "," + dgv.Columns[1].Index.ToString());
            /*
            if (e.ColumnIndex != dgv.Columns[1].Index &&
                e.ColumnIndex != dgv.Columns[2].Index)
            {
                return;
            }
            */

            dgv.Rows[e.RowIndex].ErrorText = "输入数字格式不正确";
            textBox_Output.Text += dgv.Rows[e.RowIndex].ErrorText
                + Environment.NewLine;
            dgv.CancelEdit();
        }
        private void dataGridView_CellValidated(object sender,DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                (sender as DataGridView).Rows[e.RowIndex].ErrorText = string.Empty;
            }
        }
        private void tsb_about_Click(object sender, EventArgs e)
        {
            if ((sender as aboutForm) != null)
            {
                this.Visible = true;
            }
            else
            {
                aboutForm = new aboutForm();
                aboutForm.MouseMove += new MouseEventHandler(aboutForm_MouseDown);
                aboutForm.Show();
            }
        }

        private void tsb_help_Click(object sender, EventArgs e)
        {
            if ((sender as helpForm) != null)
            {
                helpForm.Visible = true;
            }
            else
            {
                helpForm = new helpForm();
                helpForm.MouseMove += new MouseEventHandler(helpForm_MouseDown);
                helpForm.Show();
            }
        }

        //嵌入dll至exe
        System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string dllName = args.Name.Contains(",") ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name.Replace(".dll", "");
            dllName = dllName.Replace(".", "_");
            if (dllName.EndsWith("_resources")) return null;
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(GetType().Namespace + ".Properties.Resources", System.Reflection.Assembly.GetExecutingAssembly());
            byte[] bytes = (byte[])rm.GetObject(dllName);
            return System.Reflection.Assembly.Load(bytes);
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
