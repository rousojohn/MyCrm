using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MyCrm.UserControls;
using MetroFramework.Controls;

namespace MyCrm
{
    public partial class MainForm : MetroForm
    {
        private Dictionary<string, MetroUserControl> mapUserControlToTabs = new Dictionary<string, MetroUserControl>() {
            { "membersTabPage", new MembersListUserControl() },
            { "optionsTabPage", new OptionsUserControl() }
        };

        public MainForm()
        {
            InitializeComponent();
            this.StyleManager = this.metroStyleManager1;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = metroStyleManager1.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }


        public void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tab = sender as MetroFramework.Controls.MetroTabControl;
            //tab.SelectedTab.Controls[0].Dispose();
            tab.SelectedTab.Controls.Clear();
            var control = /*(MetroFramework.Controls.MetroUserControl)*/mapUserControlToTabs[tab.SelectedTab.Name];

            

            tab.SelectedTab.Controls.Add(control);
            //tab.SelectedTab.Controls[0].Focus();
        }

        private void MainForm_MyDataChangedEvent(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }

        public T ConvertTo<T>(object input)
        {
            return (T)Convert.ChangeType(input, typeof(T));
        }


        #region Properties
        public MetroThemeStyle ThemeStyle {
            get { return metroStyleManager1.Theme; }
            set { metroStyleManager1.Theme = value; }
        }

        public MetroColorStyle ColorStyle
        {
            get { return metroStyleManager1.Style; }
            set { metroStyleManager1.Style = value; }
        }
        #endregion
    }
}
