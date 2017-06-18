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
            this.metroLabel2.Location = new System.Drawing.Point(35, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Style";
            // 
            // styleCombo
            // 
            this.styleCombo.FormattingEnabled = true;
            this.styleCombo.ItemHeight = 23;
            this.styleCombo.Location = new System.Drawing.Point(114, 103);
            this.styleCombo.Name = "styleCombo";
            this.styleCombo.Size = new System.Drawing.Size(138, 29);
            this.styleCombo.TabIndex = 3;
            this.styleCombo.UseSelectable = true;
            this.styleCombo.SelectedIndexChanged += new System.EventHandler(this.styleCombo_SelectedIndexChanged);
            // 
            // OptionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.styleCombo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.themeCombo);
            this.Name = "OptionsUserControl";
            this.Size = new System.Drawing.Size(503, 282);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox themeCombo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox styleCombo;
    }
}
