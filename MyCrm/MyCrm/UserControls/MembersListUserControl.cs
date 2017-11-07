using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MyCrm.Classes;
using MongoDB.Driver;

namespace MyCrm.UserControls
{
    public partial class MembersListUserControl : MetroUserControl
    {
        private Member[] membersList = null;
        //private MetroProgressSpinner spinner = new MetroProgressSpinner();// { Width = 100, Height = 100 };

        
        public MembersListUserControl()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;


            InitializeComponent();
            

            //this.Load += (sender, e) => { bw.RunWorkerAsync(); };


            //this.membersGrid.Paint += (sender, e) => { membersList = null; bw.RunWorkerAsync(); };

            this.Paint += MembersListUserControl_Paint;
            this.GotFocus += MembersListUserControl_GotFocus;
        }

        private void MembersListUserControl_GotFocus(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MembersListUserControl_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (this.membersList != null)
                this.membersGrid.DataSource = this.membersList;

            this.metroProgressSpinner1.Hide();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //this.metroProgressSpinner1.Show();
                var collection = Program.CrmDb.GetCollection<Member>("members");

                membersList = collection.Find(FilterDefinition<Member>.Empty).ToListAsync().Result.ToArray();
            }
            catch (Exception ex)
            {
                var x = ex;
            }
        }

        public delegate void myDataChangedDelegate(object sender, EventArgs args);

        public event myDataChangedDelegate MyDataChangedEvent;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }
}
