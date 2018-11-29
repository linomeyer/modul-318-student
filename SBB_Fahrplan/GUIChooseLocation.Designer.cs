namespace SBB_Fahrplan
{
    partial class GUIChooseLocation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChooseLocation = new System.Windows.Forms.Button();
            this.listBoxLocations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnChooseLocation
            // 
            this.btnChooseLocation.Location = new System.Drawing.Point(180, 321);
            this.btnChooseLocation.Name = "btnChooseLocation";
            this.btnChooseLocation.Size = new System.Drawing.Size(75, 33);
            this.btnChooseLocation.TabIndex = 2;
            this.btnChooseLocation.Text = "Ort wählen";
            this.btnChooseLocation.UseVisualStyleBackColor = true;
            this.btnChooseLocation.Click += new System.EventHandler(this.BtnChooseLocation_Click);
            // 
            // listBoxLocations
            // 
            this.listBoxLocations.FormattingEnabled = true;
            this.listBoxLocations.Location = new System.Drawing.Point(12, 12);
            this.listBoxLocations.Name = "listBoxLocations";
            this.listBoxLocations.Size = new System.Drawing.Size(243, 303);
            this.listBoxLocations.TabIndex = 3;
            this.listBoxLocations.DoubleClick += new System.EventHandler(this.ListBoxLocations_DoubleClick);
            // 
            // GUIChooseLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 363);
            this.Controls.Add(this.listBoxLocations);
            this.Controls.Add(this.btnChooseLocation);
            this.Name = "GUIChooseLocation";
            this.Text = "Ort wählen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChooseLocation;
        public System.Windows.Forms.ListBox listBoxLocations;
    }
}