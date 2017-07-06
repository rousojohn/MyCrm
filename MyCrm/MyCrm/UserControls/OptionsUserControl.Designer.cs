namespace MyCrm.UserControls
{
    partial class OptionsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.themeCombo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.styleCombo = new MetroFramework.Controls.MetroComboBox();
            this.passTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.passConfTxt = new MetroFramework.Controls.MetroTextBox();
            this.showPassLnk = new MetroFramework.Controls.MetroLink();
            this.showPassConfLnk = new MetroFramework.Controls.MetroLink();
            this.savePass = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // themeCombo
            // 
            this.themeCombo.FormattingEnabled = true;
            this.themeCombo.ItemHeight = 23;
            this.themeCombo.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.themeCombo.Location = new System.Drawing.Point(114, 40);
            this.themeCombo.Name = "themeCombo";
            this.themeCombo.Size = new System.Drawing.Size(138, 29);
            this.themeCombo.TabIndex = 0;
            this.themeCombo.UseSelectable = true;
            this.themeCombo.SelectedIndexChanged += new System.EventHandler(this.themeCombo_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Theme";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Style";
            // 
            // styleCombo
            // 
            this.styleCombo.FormattingEnabled = true;
            this.styleCombo.ItemHeight = 23;
            this.styleCombo.Location = new System.Drawing.Point(114, 82);
            this.styleCombo.Name = "styleCombo";
            this.styleCombo.Size = new System.Drawing.Size(138, 29);
            this.styleCombo.TabIndex = 3;
            this.styleCombo.UseSelectable = true;
            this.styleCombo.SelectedIndexChanged += new System.EventHandler(this.styleCombo_SelectedIndexChanged);
            // 
            // passTxt
            // 
            // 
            // 
            // 
            this.passTxt.CustomButton.Image = null;
            this.passTxt.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.passTxt.CustomButton.Name = "";
            this.passTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passTxt.CustomButton.TabIndex = 1;
            this.passTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passTxt.CustomButton.UseSelectable = true;
            this.passTxt.CustomButton.Visible = false;
            this.passTxt.Lines = new string[0];
            this.passTxt.Location = new System.Drawing.Point(432, 45);
            this.passTxt.MaxLength = 32767;
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passTxt.SelectedText = "";
            this.passTxt.SelectionLength = 0;
            this.passTxt.SelectionStart = 0;
            this.passTxt.ShortcutsEnabled = true;
            this.passTxt.Size = new System.Drawing.Size(138, 23);
            this.passTxt.TabIndex = 4;
            this.passTxt.UseSelectable = true;
            this.passTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(349, 45);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Password";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(311, 81);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(115, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Confirm Password";
            // 
            // passConfTxt
            // 
            // 
            // 
            // 
            this.passConfTxt.CustomButton.AccessibleName = "showBtn";
            this.passConfTxt.CustomButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.passConfTxt.CustomButton.Image = null;
            this.passConfTxt.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.passConfTxt.CustomButton.Name = "";
            this.passConfTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passConfTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passConfTxt.CustomButton.TabIndex = 1;
            this.passConfTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passConfTxt.CustomButton.UseSelectable = true;
            this.passConfTxt.CustomButton.Visible = false;
            this.passConfTxt.Lines = new string[0];
            this.passConfTxt.Location = new System.Drawing.Point(432, 77);
            this.passConfTxt.MaxLength = 32767;
            this.passConfTxt.Name = "passConfTxt";
            this.passConfTxt.PasswordChar = '*';
            this.passConfTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passConfTxt.SelectedText = "";
            this.passConfTxt.SelectionLength = 0;
            this.passConfTxt.SelectionStart = 0;
            this.passConfTxt.ShortcutsEnabled = true;
            this.passConfTxt.ShowClearButton = true;
            this.passConfTxt.Size = new System.Drawing.Size(138, 23);
            this.passConfTxt.TabIndex = 7;
            this.passConfTxt.UseSelectable = true;
            this.passConfTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passConfTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // showPassLnk
            // 
            this.showPassLnk.Location = new System.Drawing.Point(576, 45);
            this.showPassLnk.Name = "showPassLnk";
            this.showPassLnk.Size = new System.Drawing.Size(51, 23);
            this.showPassLnk.TabIndex = 8;
            this.showPassLnk.Text = "Show";
            this.showPassLnk.UseSelectable = true;
            this.showPassLnk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPassLnk_MouseDown);
            this.showPassLnk.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPassLnk_MouseUp);
            // 
            // showPassConfLnk
            // 
            this.showPassConfLnk.Location = new System.Drawing.Point(582, 77);
            this.showPassConfLnk.Name = "showPassConfLnk";
            this.showPassConfLnk.Size = new System.Drawing.Size(41, 23);
            this.showPassConfLnk.TabIndex = 9;
            this.showPassConfLnk.Text = "Show";
            this.showPassConfLnk.UseSelectable = true;
            this.showPassConfLnk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPassLnk_MouseDown);
            this.showPassConfLnk.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPassLnk_MouseUp);
            // 
            // savePass
            // 
            this.savePass.Highlight = true;
            this.savePass.Location = new System.Drawing.Point(494, 126);
            this.savePass.Name = "savePass";
            this.savePass.Size = new System.Drawing.Size(75, 23);
            this.savePass.TabIndex = 10;
            this.savePass.Text = "Save";
            this.savePass.UseSelectable = true;
            // 
            // OptionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.savePass);
            this.Controls.Add(this.showPassConfLnk);
            this.Controls.Add(this.showPassLnk);
            this.Controls.Add(this.passConfTxt);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.styleCombo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.themeCombo);
            this.Name = "OptionsUserControl";
            this.Size = new System.Drawing.Size(661, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox themeCombo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox styleCombo;
        private MetroFramework.Controls.MetroTextBox passTxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox passConfTxt;
        private MetroFramework.Controls.MetroLink showPassLnk;
        private MetroFramework.Controls.MetroLink showPassConfLnk;
        private MetroFramework.Controls.MetroButton savePass;
    }
}
