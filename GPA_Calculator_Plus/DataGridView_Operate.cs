using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;


namespace GPA_Calculator_Plus
{
    /// <summary>
    /// 数据显示、添加、删除、修改等操作
    /// </summary>
    public class DataGridView_Operate
    {
        public static void Init(DataGridView dgv)
        {

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "课程名";
            col1.DataPropertyName = "CourseName";
            col1.Name = "CourseName";
            col1.Width = 150;

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "学分";
            col2.DataPropertyName = "Credit";
            col2.Name = "Credit";
            col2.Width = 50;

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "成绩";
            col3.DataPropertyName = "Grade";
            col3.Name = "Grade";
            col3.Width = 50;

            dgv.Columns.Add(col1);
            dgv.Columns.Add(col2);
            dgv.Columns.Add(col3);

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AutoGenerateColumns = false;

            MainForm.dataBindings = new BindingList<InfoVo>(MainForm.list);
            dgv.DataSource = MainForm.dataBindings;

            dgv.CausesValidation = false; //验证取消，这样用户输错了也不会弹出ErrorText
            //dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        public static void Add(DataGridView dgv, InfoVo info)
        {
            MainForm.dataBindings.Add(info);
        }
        public static void Remove(DataGridView dgv)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    Debug.WriteLine("r.Index=" + r.Index);
                    MainForm.dataBindings.RemoveAt(r.Index);
                }
            }
        }
        /// <summary>
        /// 计算均分
        /// </summary>
        /// <param name="dgv">数据视图</param>
        /// <param name="tb_Output">结果文本框</param>
        public static void CalcGPA(DataGridView dgv, TextBox tb_Output)
        {
            dgv.EndEdit();
            double avg = 0;//均分
            double total_credit = 0; //学分
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    double cur_credit = (double)row.Cells[1].Value;
                    double cur_grade = (double)row.Cells[2].Value;
                    total_credit += cur_credit;
                    avg += cur_credit * cur_grade;
                }
            }
            avg = avg / total_credit;
            if (tb_Output.Text != null)
            {
                tb_Output.Text += "均分：" +
                    Math.Round(avg, 2).ToString() + Environment.NewLine;
                tb_Output.Text += "GPA：" + GPA_CALC.Convert2GPA(avg) +
                    Environment.NewLine;
            }

        }

        public static void ExportData2Excel(DataGridView dgv)
        {
            //MessageBox.Show(dgv.Rows.Count.ToString());
            //注意空行时行数为1 (NewRow)
            dgv.EndEdit(); //停止并保存dgv的所有编辑

            if (dgv.Rows.Count <= 1)
            {
                MessageBox.Show("没有数据可供导出!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "请选择导出路径";
                sfd.Filter = "Excel Workbook 97-2003| *.xls";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != "")
                    {
                        //创建Excel文件对象
                        NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();

                        //添加一个sheet
                        NPOI.SS.UserModel.ISheet sheet1 = book.CreateSheet("sheet1");

                        //给sheet1添加第一行的头部标题
                        NPOI.SS.UserModel.IRow row1 = sheet1.CreateRow(0);
                        row1.CreateCell(0).SetCellValue("课程名称");
                        row1.CreateCell(1).SetCellValue("学分");
                        row1.CreateCell(2).SetCellValue("成绩");
                        //MessageBox.Show("rows:"+dgv.Rows.Count.ToString());
                        for (int i = 0; i < dgv.RowCount; i++)
                        {
                            if (dgv.Rows[i].IsNewRow)
                                continue;
                            NPOI.SS.UserModel.IRow rowtemp = sheet1.CreateRow(i + 1);
                            //MessageBox.Show(dgv.Rows[i].Cells.Count.ToString());
                            if(dgv.Rows[i].Cells[0].Value != null)
                                rowtemp.CreateCell(0).SetCellValue(
                                    dgv.Rows[i].Cells[0].Value.ToString());                            
                            else
                                rowtemp.CreateCell(0).SetCellValue(
                                    "课程" + (i+1).ToString());
                            
                            rowtemp.CreateCell(1).SetCellValue(
                                dgv.Rows[i].Cells[1].Value.ToString());
                            rowtemp.CreateCell(2).SetCellValue(
                                dgv.Rows[i].Cells[2].Value.ToString());
                        }
                        System.IO.FileStream fs =
                               System.IO.File.OpenWrite(sfd.FileName.ToString());
                        try
                        {
                            book.Write(fs);
                            fs.Seek(0, System.IO.SeekOrigin.Begin);
                            MessageBox.Show("导出成功", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message, "导出失败",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        finally
                        {
                            if (fs != null)
                                fs.Close();
                        }

                    }
                }
            }
        }

        public static void ImportExcel2DGV(DataGridView dgv)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择待导入的数据文件";
            ofd.Filter = "Excel Workbook 97-2003|*.xls|Excel Workbook|*.xlsx";
            string filePath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = Path.GetFullPath(ofd.FileName);
                FileStream fs;
                try
                {
                    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    NPOI.HSSF.UserModel.HSSFWorkbook book =
                         new NPOI.HSSF.UserModel.HSSFWorkbook(fs);

                    int sheetCount = book.NumberOfSheets;

                    for (int index = 0; index < sheetCount; index++)
                    {
                        NPOI.SS.UserModel.ISheet sheet = book.GetSheetAt(index);
                        if (sheet == null)
                            continue;

                        NPOI.SS.UserModel.IRow row = sheet.GetRow(0);

                        if (row == null)
                            continue;



                        int firstCellNum = row.FirstCellNum;
                        int lastCellNum = row.LastCellNum;


                        if (firstCellNum == lastCellNum || lastCellNum - firstCellNum < 2)
                            continue;

                        //MainForm.dataBindings.Clear(); //清空表中数据

                        //确定第一行是否是数据行
                        int count = 0; //记录表中数据字段的总数
                        int start_row = 0;
                        for (int i = firstCellNum; i < lastCellNum; i++)
                        {
                            //if(row.GetCell(i) != null)
                            //{
                                //row.GetCell(i).SetCellType(NPOI.SS.UserModel.CellType.String);
                                if (GPA_CALC.isNum(row.GetCell(i).StringCellValue))
                                {
                                    count++;
                                }
                            //}

                        }
                        if (count == 0)
                            start_row = 1;

                        for (int i = start_row; i <= sheet.LastRowNum; i++)
                        {
                            string courseName = sheet.GetRow(i).Cells[0].StringCellValue;
                            //MessageBox.Show(sheet.GetRow(i).Cells.Count.ToString());
                            double credit;
                            double grade;
                            try
                            {
                                sheet.GetRow(i).Cells[1].SetCellType(NPOI.SS.UserModel.CellType.String);
                                sheet.GetRow(i).Cells[2].SetCellType(NPOI.SS.UserModel.CellType.String);
                                credit = Convert.ToDouble(sheet.GetRow(i).Cells[1].StringCellValue);
                                grade = Convert.ToDouble(sheet.GetRow(i).Cells[2].StringCellValue);
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                credit = 0;
                                grade = 0;
                            }
                            //MessageBox.Show(sheet.LastRowNum.ToString());
                            InfoVo info = new InfoVo()
                            { CourseName = courseName, Credit = credit, Grade = grade };

                            //原创的处理InvalidOperationException的方法，当选中新行时会触发使得dataBinding添加异常的一行
                            if (dgv.CurrentRow != null && dgv.CurrentRow.IsNewRow)//别缺少前面的条件了，否则NRE
                                MainForm.dataBindings.RemoveAt(MainForm.dataBindings.Count - 1);
                            //dgv.ClearSelection();

                            MainForm.dataBindings.Add(info);

                        }
                    }
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }

}
