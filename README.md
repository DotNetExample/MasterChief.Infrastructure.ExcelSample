# Excel 导入导出简单示例
> 项目说明
>
> 1. 目前基于NPOI实现Excel导入导出
> 2. 可以通过IExcelManger接口，扩展其他形式；
> 3. 项目源码：[**MasterChief.DotNet.Infrastructure.Excel**][https://github.com/YanZhiwei/MasterChief/tree/master/MasterChief.DotNet.Infrastructure.Excel]
> 4. Nuget：Install-Package MasterChief.DotNet.Infrastructure.Excel
> 5. 欢迎Star，欢迎PR；

#### 如何使用

1. DataTable导出Excel

   ```c#
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
   ```

​       ![](https://845n1a.dm.files.1drv.com/y4mfwfj5Ba0Y2KQLZoyW7I8f1mw5Z2m6KuAIyOiNPiVwzFMtqXPrHGQ2sCa3Ugl0OpcV-Tr0Y1Qbcf009TqtkwLQPcmaAg0Y7jM5guS7e9GYC_mbPLnBUgxxob4IbYrVoxxGh_Vfad2nwRX0wmI1clxx1cgFd4Xpoc_clXpOjJ8zZ1zj4Q_099E6Sk2ucuzpXJt3KRzYlo1TgCtotELq1roDg?width=745&height=982&cropmode=none)

2. Excel导入DataTable

   ```c#
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
   ```

