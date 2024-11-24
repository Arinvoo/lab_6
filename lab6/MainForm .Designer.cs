using System.Windows.Forms;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private ComboBox comboBoxDatabaseType;
    private TextBox textBoxConnectionString;
    private Button buttonLoadData;
    private ListBox listBoxData;
    private Label labelDbType;
    private Label labelConnectionString;

    private void InitializeComponent()
    {
        this.comboBoxDatabaseType = new ComboBox();
        this.textBoxConnectionString = new TextBox();
        this.buttonLoadData = new Button();
        this.listBoxData = new ListBox();
        this.labelDbType = new Label();
        this.labelConnectionString = new Label();

        this.SuspendLayout();

        // 
        // comboBoxDatabaseType
        // 
        this.comboBoxDatabaseType.FormattingEnabled = true;
        this.comboBoxDatabaseType.Location = new System.Drawing.Point(140, 20);
        this.comboBoxDatabaseType.Name = "comboBoxDatabaseType";
        this.comboBoxDatabaseType.Size = new System.Drawing.Size(200, 24);

        // 
        // textBoxConnectionString
        // 
        this.textBoxConnectionString.Location = new System.Drawing.Point(140, 60);
        this.textBoxConnectionString.Name = "textBoxConnectionString";
        this.textBoxConnectionString.Size = new System.Drawing.Size(400, 22);

        // 
        // buttonLoadData
        // 
        this.buttonLoadData.Location = new System.Drawing.Point(140, 100);
        this.buttonLoadData.Name = "buttonLoadData";
        this.buttonLoadData.Size = new System.Drawing.Size(100, 30);
        this.buttonLoadData.Text = "Load Data";
        this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);

        // 
        // listBoxData
        // 
        this.listBoxData.FormattingEnabled = true;
        this.listBoxData.ItemHeight = 16;
        this.listBoxData.Location = new System.Drawing.Point(20, 150);
        this.listBoxData.Name = "listBoxData";
        this.listBoxData.Size = new System.Drawing.Size(520, 180);

        // 
        // labelDbType
        // 
        this.labelDbType.AutoSize = true;
        this.labelDbType.Location = new System.Drawing.Point(20, 25);
        this.labelDbType.Name = "labelDbType";
        this.labelDbType.Text = "Database Type:";

        // 
        // labelConnectionString
        // 
        this.labelConnectionString.AutoSize = true;
        this.labelConnectionString.Location = new System.Drawing.Point(20, 65);
        this.labelConnectionString.Name = "labelConnectionString";
        this.labelConnectionString.Text = "Connection String:";

        // 
        // MainForm
        // 
        this.ClientSize = new System.Drawing.Size(600, 360);
        this.Controls.Add(this.comboBoxDatabaseType);
        this.Controls.Add(this.textBoxConnectionString);
        this.Controls.Add(this.buttonLoadData);
        this.Controls.Add(this.listBoxData);
        this.Controls.Add(this.labelDbType);
        this.Controls.Add(this.labelConnectionString);
        this.Text = "Database Adapter";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}


