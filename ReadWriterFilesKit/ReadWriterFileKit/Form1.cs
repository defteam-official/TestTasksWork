using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;

namespace ReadWriterFileKit
{
    public partial class Form1 : Form
    {
        private string standartDirPath {get; set;}
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "текстовые файлы |*.txt;*.pdf"
            };

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                string newDirPath = tbNameFolder.Text;

                if(!HasDirDate(newDirPath, standartDirPath))
                {
                    Directory.CreateDirectory($"{standartDirPath}/{newDirPath}");
                }
               
                File.Move(openFile.FileName, $"{standartDirPath}/{newDirPath}/{openFile.SafeFileName}");
                lblStatus.Text = "Файл был перемещен!";
            }
        }

        private string GetDate()
        {
            string date = (DateTime.Now).ToString();
            string[] dateArr = date.Split(' ');
            return dateArr[0];
        }

        private bool HasDirDate(string dir, string standartDirPath)
        {
            string[] dirs = Directory.GetDirectories(standartDirPath);

            foreach (string s in dirs)
            {
                if (dir == s)
                    return true;
            }

            return false;
        }

        private void btnOverviewFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();

            if(openFolder.ShowDialog() == DialogResult.OK)
            {
                standartDirPath = openFolder.SelectedPath;
                
                lblStatus.Text = "Основная папка выбрана!";
                
                tbNameFolder.Enabled = true;
                btnOverviewFile.Enabled = true;
            }

        }

        private void tbNameFolder_Click(object sender, EventArgs e)
        {
            tbNameFolder.Text = "";
            tbNameFolder.ForeColor = Color.Black;
        }
    }


}
