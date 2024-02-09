using System;
using System.Data;
using System.IO;
using System.Windows;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SimpleCsvEditor
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
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                dataTable = new DataTable();
                using (TextFieldParser parser = new TextFieldParser(openFileDialog.FileName))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(";");
                    bool isFirstRow = true;
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();

                        // Justerer kolonneantallet baseret på den første række eller efterfølgende rækker med flere felter

                        if (isFirstRow)
                        {
                            for (int i = 0; i < fields.Length; i++)
                            {
                                dataTable.Columns.Add($"Column{i + 1}");
                            }
                            isFirstRow = false;
                        }
                        else if (fields.Length > dataTable.Columns.Count)
                        {
                            // Tilføjer ekstra kolonner hvis nødvendigt
                            int additionalColumnsNeeded = fields.Length - dataTable.Columns.Count;
                            for (int i = 0; i < additionalColumnsNeeded; i++)
                            {
                                dataTable.Columns.Add($"Column{dataTable.Columns.Count + 1}");
                            }
                        }

                        dataTable.Rows.Add(fields);
                    }
                }
                csvDataGrid.ItemsSource = dataTable.DefaultView;
            }
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };
            if (saveFileDialog.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false))
                {
                    // Skriver kolonneoverskrifter
                    var columnHeaders = new string[dataTable.Columns.Count];
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        columnHeaders[i] = dataTable.Columns[i].ColumnName;
                    }
                    sw.WriteLine(string.Join(",", columnHeaders));

                    // Skriver rækkerne
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var fields = new string[dataTable.Columns.Count];
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            fields[i] = row[i].ToString();
                        }
                        sw.WriteLine(string.Join(",", fields));
                    }
                }
            }
        }
    }
}
