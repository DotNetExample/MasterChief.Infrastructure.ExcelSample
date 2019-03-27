using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using MasterChief.DotNet.Infrastructure.Excel;
using MasterChief.DotNet.Infrastructure.Serializer;
using MasterChief.DotNet4.Utilities.Common;

namespace MasterChief.DotNet.Infrastructure.ExcelSample
{
    public partial class Form1 : Form
    {
        private readonly IExcelManger _excelManger = new NPOIManager();
        private readonly ISerializer _jsonSerializer = new JsonSerializer();

        private string _mockExcelPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnToExcel_Click(object sender, EventArgs e)
        {
            var mockTable = BuilderExcelData();
            _mockExcelPath = $"D:\\ExcelSample{DateTime.Now.FormatDate(12)}.xls";
            _excelManger.ToExcel(mockTable, "员工信息汇总", "员工列表", _mockExcelPath);
            Process.Start(_mockExcelPath);
        }

        private DataTable BuilderExcelData()
        {
            var mockTable = new DataTable();
            mockTable.Columns.Add(new DataColumn {ColumnName = "序号"});
            mockTable.Columns.Add(new DataColumn {ColumnName = "姓名"});
            mockTable.Columns.Add(new DataColumn {ColumnName = "工作单位"});
            mockTable.Columns.Add(new DataColumn {ColumnName = "性别"});
            mockTable.Columns.Add(new DataColumn {ColumnName = "入职时间"});

            for (var i = 0; i < 100; i++)
                mockTable.Rows.Add(i.ToString(), $"张{i}", $"李{i}计算机公司", i % 2 == 0 ? "男" : "女",
                    DateTime.Now.AddDays(i));
            return mockTable;
        }

        private void BtnToDataTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_mockExcelPath))
            {
                MessageBox.Show("请生成模拟测试EXCEL文件");
                return;
            }

            var excleTable = _excelManger.ToDataTable(_mockExcelPath, 0, 1, 2);
            var jsonText = _jsonSerializer.Serialize(excleTable);
            MessageBox.Show(jsonText);
        }
    }
}