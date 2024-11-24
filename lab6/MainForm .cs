using lab6;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private IDataProvider _dataProvider;

    public MainForm()
    {
        InitializeComponent();
        InitializeDatabaseOptions();
    }

    private void InitializeDatabaseOptions()
    {
        comboBoxDatabaseType.Items.Add("SQLite");
        comboBoxDatabaseType.Items.Add("SQL Server");
        comboBoxDatabaseType.SelectedIndex = 0;
    }

    private void buttonLoadData_Click(object sender, EventArgs e)
    {
        try
        {
            string selectedDb = comboBoxDatabaseType.SelectedItem.ToString();
            string connectionString = textBoxConnectionString.Text;

            if (selectedDb == "SQLite")
            {
                _dataProvider = new SQLiteAdapter(connectionString);
            }
            else if (selectedDb == "SQL Server")
            {
                _dataProvider = new SqlServerAdapter(connectionString);
            }

            List<string> data = _dataProvider.GetData();
            listBoxData.Items.Clear();
            foreach (var item in data)
            {
                listBoxData.Items.Add(item);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
