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

namespace POS_System
{
    public partial class StartupMenu : Form
    {

        string UserWinName = Environment.UserName;
        string ProgramDirectory;

        public StartupMenu()
        {
            InitializeComponent();
            this.CenterToScreen();
            ProgramDirectory = "C:\\Users\\" + UserWinName + "\\AppData\\Roaming\\POS\\";
        
        }

        private void CreateNew_Click(object sender, EventArgs e)
        {
            //Launch CreateBusiness
            CreateBusiness CreateBusiness = new CreateBusiness();
            CreateBusiness.Show();

            this.Hide();
        }

        private void StartupMenu_Load(object sender, EventArgs e)
        {
            //Recheck directories every second.
            Timer timer = new Timer();
            timer.Interval = (100); // 1 secs
            timer.Tick += new EventHandler(CheckDirectories);
            timer.Start();
        }

        private void CheckDirectories(object sender, EventArgs e)
        {
            //Checks for existing directories. If not, disable LoadExisting and DeleteExisting.
            var AvailableDirectories = Directory.GetDirectories(ProgramDirectory);
            if (String.Join("", AvailableDirectories) == "")
            {
                LoadExisting.Enabled = false;
                DeleteExisting.Enabled = false;
            }
        }

        private void LoadExisting_Click(object sender, EventArgs e)
        {
            //Launch LoadPOS
            LoadPOS LoadPOS = new LoadPOS();
            LoadPOS.Show();

            this.Hide();
        }


        private void DeleteExisting_Click(object sender, EventArgs e)
        {
            RemoveBusiness RemoveBusiness = new RemoveBusiness();
            RemoveBusiness.Show();

            this.Hide();
        }
    }
}
