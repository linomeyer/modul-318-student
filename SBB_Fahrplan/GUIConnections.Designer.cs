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
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridConnections = new System.Windows.Forms.DataGridView();
            this.clmnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFromLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnToLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromLocation
            // 
            this.lblFromLocation.AutoSize = true;
            this.lblFromLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromLocation.Location = new System.Drawing.Point(172, 53);
            this.lblFromLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromLocation.Name = "lblFromLocation";
            this.lblFromLocation.Size = new System.Drawing.Size(87, 29);
            this.lblFromLocation.TabIndex = 0;
            this.lblFromLocation.Text = "label1";
            // 
            // lblToLocation
            // 
            this.lblToLocation.AutoSize = true;
            this.lblToLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToLocation.Location = new System.Drawing.Point(521, 53);
            this.lblToLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToLocation.Name = "lblToLocation";
            this.lblToLocation.Size = new System.Drawing.Size(87, 29);
            this.lblToLocation.TabIndex = 1;
            this.lblToLocation.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Verbindungen";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(647, 441);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridConnections
            // 
            this.dataGridConnections.AllowUserToAddRows = false;
            this.dataGridConnections.AllowUserToDeleteRows = false;
            this.dataGridConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnDeparture,
            this.clmnFromLocation,
            this.clmnToLocation,
            this.clmnPlatform,
            this.clmnDuration});
            this.dataGridConnections.Location = new System.Drawing.Point(27, 128);
            this.dataGridConnections.Name = "dataGridConnections";
            this.dataGridConnections.RowTemplate.Height = 24;
            this.dataGridConnections.Size = new System.Drawing.Size(720, 306);
            this.dataGridConnections.TabIndex = 5;
            // 
            // clmnDeparture
            // 
            this.clmnDeparture.HeaderText = "Abfahrt";
            this.clmnDeparture.Name = "clmnDeparture";
            // 
            // clmnFromLocation
            // 
            this.clmnFromLocation.HeaderText = "Von";
            this.clmnFromLocation.Name = "clmnFromLocation";
            // 
            // clmnToLocation
            // 
            this.clmnToLocation.HeaderText = "Nach";
            this.clmnToLocation.Name = "clmnToLocation";
            // 
            // clmnPlatform
            // 
            this.clmnPlatform.HeaderText = "Gleis";
            this.clmnPlatform.Name = "clmnPlatform";
            // 
            // clmnDuration
            // 
            this.clmnDuration.HeaderText = "Dauer";
            this.clmnDuration.Name = "clmnDuration";
            // 
            // GUIConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 482);
            this.Controls.Add(this.dataGridConnections);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToLocation);
            this.Controls.Add(this.lblFromLocation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUIConnections";
            this.Text = "GUIConnections";
            this.Load += new System.EventHandler(this.FormOnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromLocation;
        private System.Windows.Forms.Label lblToLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridConnections;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFromLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnToLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDuration;
    }
}