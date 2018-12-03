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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIChooseLocation));
            this.btnChooseLocation = new System.Windows.Forms.Button();
            this.listBoxLocations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnChooseLocation
            // 
            this.btnChooseLocation.Location = new System.Drawing.Point(240, 395);
            this.btnChooseLocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseLocation.Name = "btnChooseLocation";
            this.btnChooseLocation.Size = new System.Drawing.Size(100, 41);
            this.btnChooseLocation.TabIndex = 2;
            this.btnChooseLocation.Text = "Ort wählen";
            this.btnChooseLocation.UseVisualStyleBackColor = true;
            this.btnChooseLocation.Click += new System.EventHandler(this.BtnChooseLocation_Click);
            // 
            // listBoxLocations
            // 
            this.listBoxLocations.FormattingEnabled = true;
            this.listBoxLocations.ItemHeight = 16;
            this.listBoxLocations.Location = new System.Drawing.Point(16, 15);
            this.listBoxLocations.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLocations.Name = "listBoxLocations";
            this.listBoxLocations.Size = new System.Drawing.Size(323, 372);
            this.listBoxLocations.TabIndex = 3;
            this.listBoxLocations.DoubleClick += new System.EventHandler(this.ListBoxLocations_DoubleClick);
            this.listBoxLocations.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lixtBoxLocations_KeyDown);
            // 
            // GUIChooseLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 447);
            this.Controls.Add(this.listBoxLocations);
            this.Controls.Add(this.btnChooseLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUIChooseLocation";
            this.Text = "Ort wählen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChooseLocation;
        public System.Windows.Forms.ListBox listBoxLocations;
    }
}