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

namespace iTunesLibraryBackup
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            //C:\Users\Brad\Documents\My Games
            //driveLabel.Text + @"Users\" + nameLabel.Text + @"\Music\iTunes";
            nameLabel.Text = Environment.UserName.ToString(); //displays the current user
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            string primaryDrive = allDrives[0].ToString();
            driveLabel.Text = primaryDrive;// displays primary drive in window

            // Check that the lastbackup.txt file doesn't already exist. If it doesn't exist, create 
            // DANGER: System.IO.File.Create will overwrite the file if it already exists. 
            // This could happen even with random file names, although it is unlikely. 
            string bupPathString = primaryDrive + @"Users\" + nameLabel.Text + @"\Documents\iTunesLibraryBackup";


            string bupPathStringAndFile = primaryDrive + @"Users\" + nameLabel.Text + @"\Documents\iTunesLibraryBackup\lastbackup.txt";
            // Create the subfolder. You can verify in File Explorer that you have this 
            // structure in the C: drive. 

            try
            {
                if (!System.IO.Directory.Exists(bupPathString))//folder does not exist
                {
                    System.IO.Directory.CreateDirectory(bupPathString); //create folder
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

            if (!System.IO.File.Exists(bupPathStringAndFile)) //if the file does not exist...
            {
                try
                {
                    using (System.IO.FileStream fs = System.IO.File.Create(bupPathStringAndFile))//create file
                    {
                        lastBackupVariable.Text = "none";
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The process failed: {0}", e.ToString());
                }
            }
            else //this runs if the file exists
            {
                lastBackupVariable.Text = System.IO.File.ReadAllText(primaryDrive + @"Users\" + nameLabel.Text + @"\Documents\iTunesLibraryBackup\lastbackup.txt");
                return;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            string primaryDrive = allDrives[0].ToString();
            string fileName = "iTunes Library.itl";
            //string targeFileName = "dateLibrary.txt";
            string targeFileName = ("iTunes Library " + nameLabel.Text + " " + DateTime.Now.ToString("MM-dd-yyyy h-mm-ss tt") + ".itl");
            string sourcePath = driveLabel.Text + @"Users\" + nameLabel.Text + @"\Music\iTunes";
            string targetPath = primaryDrive + @"Users\" + nameLabel.Text + @"\Documents\iTunesLibraryBackup"; //firstbackup  primaryDrive + @"Users\" + nameLabel.Text + @"\Documents\iTunesLibraryBackup\lastbackup.txt
            //string backupPath = @"C:\iTunesBackupFolder";

            // Use Path class to manipulate file and directory paths. 
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, targeFileName);

            //does the actual copying to a file
            System.IO.File.Copy(sourceFile, destFile, true);

            //also copy to a new location in case of folder deletion
            // Create a new target folder, if necessary. 
            /*if (!System.IO.Directory.Exists(backupPath))
            {
                System.IO.Directory.CreateDirectory(backupPath);
            }

            string backupFile = System.IO.Path.Combine(backupPath, targeFileName);
            System.IO.File.Copy(sourceFile, backupFile, true);*/

            lastBackupVariable.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm");
            //lastBackupVariable.Text = System.IO.File.ReadAllText(primaryDrive + @"Program Files\FileCopyApp\lastbackup.txt");
            //need to store the last backup info in a file
            System.IO.File.WriteAllText(targetPath + @"\lastbackup.txt", lastBackupVariable.Text);
                //(driveLabel.Text + @"FileCopyApp\lastbackup.txt", lastBackupVariable.Text);

            MessageBox.Show("Done!");
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            string primaryDrive = allDrives[0].ToString();
            OpenFileDialog d = new OpenFileDialog();
            d.InitialDirectory = primaryDrive + @"Users\" + nameLabel.Text + @"\Documents\iTunesLibraryBackup";
            d.Filter = "iTunes Files (.itl)|*.itl|All Files (*.*)|*.*";
            d.Title = "Find a backup file.";
            DialogResult result = d.ShowDialog();

            // need to check filetype to only get iTunes filetypes


            //store filename for below
            string restoreBackupFile = d.FileName.ToString();


            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("File not restored.");
            }

            else
            {
                //filename selected above
                //string restoreBackupFile = d.FileName.ToString(); 
                string oldLibraryName = "iTunes Library.itl";
                string oldLibraryPath = driveLabel.Text + @"Users\" + nameLabel.Text + @"\Music\iTunes";
                string backupPath = primaryDrive + @"Users\" + nameLabel.Text + @"\Documents\iTunesLibraryBackup;";

                // Use Path class to manipulate file and directory paths. 
                string sourceFile = System.IO.Path.Combine(backupPath, restoreBackupFile);
                string destFile = System.IO.Path.Combine(oldLibraryPath, oldLibraryName);

                //does the actual copying to a file
                System.IO.File.Copy(sourceFile, destFile, true);



                MessageBox.Show("Done restoring!");
            }
        }

        private void restoreExplainLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
