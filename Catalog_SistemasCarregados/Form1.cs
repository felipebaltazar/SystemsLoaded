using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Catalog_SistemasCarregados
{
    public partial class Form1 : Form
    {
        private const string SYSTEMINFO = @"C:\ProgramData\Procad\Promob Catalog (500)\Config\SystemInfo.config";

        public Form1()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var x = Screen.PrimaryScreen.Bounds.Width;
            var y = Screen.PrimaryScreen.Bounds.Height;

            Size = new Size(Convert.ToInt32(this.Width), Convert.ToInt32(this.Height));
            Location = new Point(x - Convert.ToInt32(this.Width), y - Convert.ToInt32(this.Height) - 30);
            
            SystemInfoLoad();
        }

        public void SystemInfoLoad()
        {
            SystemInfoDataGrid.Rows.Clear();

            if (File.Exists(SYSTEMINFO))
            {
                var xmlDoc = XDocument.Load(SYSTEMINFO);
                var sytemInfoCollection = xmlDoc.Descendants()
                    .Where(d=> d.Name.LocalName.Equals("SystemInfo",StringComparison.OrdinalIgnoreCase));

                foreach (var node in sytemInfoCollection)
                {
                    var directory = node.Elements()
                        .FirstOrDefault(d => d.Name.LocalName.Equals("Directory", StringComparison.OrdinalIgnoreCase))?
                        .Value;

                    var lastAccess = node.Elements()
                        .FirstOrDefault(d => d.Name.LocalName.Equals("LastAccess", StringComparison.OrdinalIgnoreCase))?
                        .Value;

                    var isActive = node.Elements()
                        .FirstOrDefault(d => d.Name.LocalName.Equals("IsActive", StringComparison.OrdinalIgnoreCase))?
                        .Value;

                    SystemInfoDataGrid.Rows.Add(directory, lastAccess, isActive);                    
                }
            }
        }
        
        public void SaveFile()
        {
            var xmlDoc = new XDocument();
            var arrayOfSystemInfoElement = new XElement("ArrayOfSystemInfo");

            foreach (DataGridViewRow row in SystemInfoDataGrid.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (File.Exists($@"{row.Cells[0].Value.ToString()}\System\Repository\Registro.sys"))
                    {
                        var systemInfoElement = new XElement("SystemInfo");
                        var directoryElement = new XElement("Directory");
                        var lastAccessElement = new XElement("LastAccess");
                        var isActiveElement = new XElement("IsActive");

                        directoryElement.Add(row.Cells[0].Value.ToString());
                        lastAccessElement.Add(row.Cells[1].Value.ToString());
                        isActiveElement.Add(row.Cells[2].Value.ToString());

                        systemInfoElement.Add(directoryElement, lastAccessElement, isActiveElement);
                        arrayOfSystemInfoElement.Add(systemInfoElement);
                    }
                }
            }

            xmlDoc.Add(arrayOfSystemInfoElement);
            xmlDoc.Save(SYSTEMINFO);
        }

        private void ViewCellEndEdit(object sender, DataGridViewCellEventArgs e) =>
            SaveFile();

        private void ViewCellLeave(object sender, DataGridViewCellEventArgs e) =>
            SaveFile();

        private void ToolStripMenuItemMinimizeClick(object sender, EventArgs e) =>
            Hide();

        private void ToolStripMenuItemExitClick(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Application.Exit();
            notifyIcon1.Dispose();
        }

        private void NotifyIconMouseDoubleClick(object sender, MouseEventArgs e)
        {
            SystemInfoLoad();
            Show();
        }        

        private void ViewDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void ViewDragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if(files != null)
            {
                var fileToAdd = files.LastOrDefault();
                if(string.IsNullOrEmpty(fileToAdd))
                    SystemInfoDataGrid.Rows.Add(fileToAdd);
            }            
        }        
    }
}
