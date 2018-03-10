using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockAFolder
{
    public partial class Form1 : Form
    {
        Boolean loc = true;
        public Form1()
        {
            InitializeComponent();



            this.Location = new System.Drawing.Point(500, 300);


            // this.Location = new System.Drawing.Point(60, 300);


        }



        private void button1_Click(object sender, EventArgs e)
        {

            try
            {



                DialogResult result = folderBrowserDialog2.ShowDialog();
                string folderName = folderBrowserDialog2.SelectedPath;
                Console.WriteLine(folderName);


              
                // String hideOrShow = "+";
                try
                { 
                Process.Start("cmd.exe", "/c attrib +s +h +r \"" + folderName+"\" /s /d");
                    Console.WriteLine("/c attrib +s +h +r \"" + folderName + "\" /s /d");
                    MessageBox.Show("yes do " );
                }
                catch (Exception c)
                { MessageBox.Show("Loc " + c); }



                string folderPath = folderName;
                string adminUserName = Environment.UserName;// getting your adminUserName
                DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                ds.AddAccessRule(fsa);
                Directory.SetAccessControl(folderPath, ds);



                MessageBox.Show("Locked");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }





        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {



                DialogResult result = folderBrowserDialog2.ShowDialog();
                string folderName = folderBrowserDialog2.SelectedPath;
                Console.WriteLine(folderName);



                // String hideOrShow = "+";
                try
                {
                    Process.Start("cmd.exe", "/c attrib -s -h -r \"" + folderName + "\" /s /d");

                }
                catch (Exception c)
                { MessageBox.Show("Loc " + c); }




                string folderPath = folderName;
                string adminUserName = Environment.UserName;// getting your adminUserName
                DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                ds.RemoveAccessRule(fsa);
                Directory.SetAccessControl(folderPath, ds);
                MessageBox.Show("UnLocked");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog2.ShowDialog();
             string path = folderBrowserDialog2.SelectedPath;
            /*  string[] folders = Directory.GetDirectories(path);
             foreach (string subFolder in folders)
             {
                 string folder = Path.Combine(path, subFolder);
                 DirectoryInfo info = new DirectoryInfo(folder);
                 if ((info.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                 {
                     u.Text = path; // do something with your non-hidden folder here
                 }
             }*/
            //   var folders = new DirectoryInfo(path).GetDirectories().Where(x => (x.Attributes & FileAttributes.Hidden) == 0);
            // u.Text = folders.ToString();
            try
            {

                string[] foldersx;

                try { } catch { } finally { 
             foldersx = System.IO.Directory.GetDirectories(@path, "*", System.IO.SearchOption.AllDirectories);

}





                u.Text = "";
            foreach (string subFolder in foldersx)
            {
                //u.Text = u.Text+subFolder+"\n";
                string folder = Path.Combine(subFolder, subFolder);
                    try
                    {


                        DirectoryInfo info = new DirectoryInfo(folder);
                if ((info.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    u.Text = u.Text + subFolder + "\n"; // do something with your non-hidden folder here
                }

                    }
                    catch
                    {
                        u.Text = u.Text +"\t\t\t"+ subFolder + "\n";
                    }
                }
  }
            catch(Exception f) {
                u.Text = u.Text + "\t\t\t" + f + "\n";
            }

            }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog2.ShowDialog();
            string path = folderBrowserDialog2.SelectedPath;


            foreach (string subDir in Directory.GetDirectories(path))
            {
                try
                {
                   

                    try {
                        string[] foldersx = System.IO.Directory.GetDirectories(@subDir, "*", System.IO.SearchOption.AllDirectories);
}
                    catch {

                        u.Text = u.Text + "\t\t\t" + subDir + "\n";
                    }
                    
                }
                catch
                {
                    // swallow, log, whatever
                }
            }
        }

        private void moving(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            //    Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            Console.WriteLine("\n X: {0} \t Y: {1}", Cursor.Position.X , Cursor.Position.Y );
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(Convert.ToInt32(p1.Text), Convert.ToInt32(p2.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loc = false;
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void cloasifucan(object sender, FormClosingEventArgs e)
        {
            if(loc)
            e.Cancel = true;
        }
    }
}
