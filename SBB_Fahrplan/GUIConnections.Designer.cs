namespace SBB_Fahrplan
{
    partial class GUIConnections
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
            this.lblFromLocation = new System.Windows.Forms.Label();
            this.lblToLocation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listviewConnections = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clmnHdFromTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHdToTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHdDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblFromLocation
            // 
            this.lblFromLocation.AutoSize = true;
            this.lblFromLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromLocation.Location = new System.Drawing.Point(129, 43);
            this.lblFromLocation.Name = "lblFromLocation";
            this.lblFromLocation.Size = new System.Drawing.Size(70, 25);
            this.lblFromLocation.TabIndex = 0;
            this.lblFromLocation.Text = "label1";
            // 
            // lblToLocation
            // 
            this.lblToLocation.AutoSize = true;
            this.lblToLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToLocation.Location = new System.Drawing.Point(391, 43);
            this.lblToLocation.Name = "lblToLocation";
            this.lblToLocation.Size = new System.Drawing.Size(70, 25);
            this.lblToLocation.TabIndex = 1;
            this.lblToLocation.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Verbindungen";
            // 
            // listviewConnections
            // 
            this.listviewConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnHdFromTime,
            this.clmnHdToTime,
            this.clmnHdDuration});
            this.listviewConnections.Location = new System.Drawing.Point(21, 103);
            this.listviewConnections.Name = "listviewConnections";
            this.listviewConnections.Size = new System.Drawing.Size(539, 249);
            this.listviewConnections.TabIndex = 3;
            this.listviewConnections.UseCompatibleStateImageBehavior = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(485, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // clmnHdFromTime
            // 
            this.clmnHdFromTime.Text = "Von";
            this.clmnHdFromTime.Width = 100;
            // 
            // clmnHdToTime
            // 
            this.clmnHdToTime.Text = "Bis";
            this.clmnHdToTime.Width = 100;
            // 
            // clmnHdDuration
            // 
            this.clmnHdDuration.Text = "Dauer";
            this.clmnHdDuration.Width = 100;
            // 
            // GUIConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 392);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.listviewConnections);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToLocation);
            this.Controls.Add(this.lblFromLocation);
            this.Name = "GUIConnections";
            this.Text = "GUIConnections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromLocation;
        private System.Windows.Forms.Label lblToLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listviewConnections;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader clmnHdFromTime;
        private System.Windows.Forms.ColumnHeader clmnHdToTime;
        private System.Windows.Forms.ColumnHeader clmnHdDuration;
    }
}