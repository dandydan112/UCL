using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows;

namespace CsvEditor
{
    public partial class MainWindow : Window
    {
        private DataTable dataTable = new DataTable();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (openFileDialog.ShowDialog() == true)
            {
                filePathTextBox.Text = openFileDialog.FileName;
                dataTable.Clear();
                string[] csvLines = File.ReadAllLines(openFileDialog.FileName);
                string[] headers = csvLines[0].Split(',');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(new DataColumn(header));
                }
                for (int i = 1; i < csvLines.Length; i++)
                {
                    string[] data = csvLines[i].Split(',');
                    dataTable.Rows.Add(data);
                }
                dataGrid.ItemsSource = dataTable.DefaultView;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                using StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                var columnHeaders = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                sw.WriteLine(string.Join(",", columnHeaders));
                foreach (DataRow row in dataTable.Rows)
                {
                    var fields = row.ItemArray.Select(field => field.ToString());
                    sw.WriteLine(string.Join(",", fields));
                }
            }
        }
    }
}
