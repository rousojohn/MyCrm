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
using MetroFramework;

namespace MyCrm.UserControls
{
    public partial class OptionsUserControl : MetroUserControl
    {
        public OptionsUserControl()
        {
            InitializeComponent();
            //this.themeCombo.SelectedIndex = (Program.MainForm.Theme == MetroFramework.MetroThemeStyle.Light) ? 0 : 1;
            foreach (var item in Enum.GetValues(typeof(MetroColorStyle)))
            {
                styleCombo.Items.Add(item);
            }
        }

        private void themeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.MainForm.ThemeStyle = (sender as MetroComboBox).SelectedIndex == 0 ?  MetroFramework.MetroThemeStyle.Light : MetroFramework.MetroThemeStyle.Dark;
        }

        private void styleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = sender as MetroComboBox;
            Program.MainForm.ColorStyle = ((MetroColorStyle?)combo.SelectedItem).HasValue ? ((MetroColorStyle?)combo.SelectedItem).Value : MetroColorStyle.Default;
        }
    }
}
