﻿namespace SBB_Fahrplan
{
    partial class GUIResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIResults));
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
            this.lblTimeTableLocation = new System.Windows.Forms.Label();
            this.dataGridTimetable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromLocation
            // 
            this.lblFromLocation.AutoSize = true;
            this.lblFromLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFromLocation.Location = new System.Drawing.Point(22, 53);
            this.lblFromLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromLocation.Name = "lblFromLocation";
            this.lblFromLocation.Size = new System.Drawing.Size(47, 25);
            this.lblFromLocation.TabIndex = 0;
            this.lblFromLocation.Text = "von";
            this.lblFromLocation.Visible = false;
            // 
            // lblToLocation
            // 
            this.lblToLocation.AutoSize = true;
            this.lblToLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblToLocation.Location = new System.Drawing.Point(385, 53);
            this.lblToLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToLocation.Name = "lblToLocation";
            this.lblToLocation.Size = new System.Drawing.Size(40, 25);
            this.lblToLocation.TabIndex = 1;
            this.lblToLocation.Text = "bis";
            this.lblToLocation.Visible = false;
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
            this.btnCancel.Location = new System.Drawing.Point(765, 486);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridConnections
            // 
            this.dataGridConnections.AllowUserToAddRows = false;
            this.dataGridConnections.AllowUserToDeleteRows = false;
            this.dataGridConnections.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnDeparture,
            this.clmnFromLocation,
            this.clmnToLocation,
            this.clmnPlatform,
            this.clmnDuration});
            this.dataGridConnections.Location = new System.Drawing.Point(27, 128);
            this.dataGridConnections.Name = "dataGridConnections";
            this.dataGridConnections.RowTemplate.Height = 24;
            this.dataGridConnections.Size = new System.Drawing.Size(858, 351);
            this.dataGridConnections.TabIndex = 5;
            this.dataGridConnections.Visible = false;
            // 
            // clmnDeparture
            // 
            this.clmnDeparture.HeaderText = "Abfahrt";
            this.clmnDeparture.Name = "clmnDeparture";
            this.clmnDeparture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clmnFromLocation
            // 
            this.clmnFromLocation.HeaderText = "Von";
            this.clmnFromLocation.Name = "clmnFromLocation";
            this.clmnFromLocation.Width = 150;
            // 
            // clmnToLocation
            // 
            this.clmnToLocation.HeaderText = "Nach";
            this.clmnToLocation.Name = "clmnToLocation";
            this.clmnToLocation.Width = 150;
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
            // lblTimeTableLocation
            // 
            this.lblTimeTableLocation.AutoSize = true;
            this.lblTimeTableLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTimeTableLocation.Location = new System.Drawing.Point(27, 53);
            this.lblTimeTableLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeTableLocation.Name = "lblTimeTableLocation";
            this.lblTimeTableLocation.Size = new System.Drawing.Size(42, 25);
            this.lblTimeTableLocation.TabIndex = 6;
            this.lblTimeTableLocation.Text = "Ort";
            this.lblTimeTableLocation.Visible = false;
            // 
            // dataGridTimetable
            // 
            this.dataGridTimetable.AllowUserToAddRows = false;
            this.dataGridTimetable.AllowUserToDeleteRows = false;
            this.dataGridTimetable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridTimetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.clmnTrain,
            this.clmnLin});
            this.dataGridTimetable.Location = new System.Drawing.Point(27, 128);
            this.dataGridTimetable.Name = "dataGridTimetable";
            this.dataGridTimetable.RowTemplate.Height = 24;
            this.dataGridTimetable.Size = new System.Drawing.Size(858, 351);
            this.dataGridTimetable.TabIndex = 7;
            this.dataGridTimetable.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Abfahrt";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Von";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nach";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // clmnTrain
            // 
            this.clmnTrain.HeaderText = "Bahn";
            this.clmnTrain.Name = "clmnTrain";
            this.clmnTrain.Width = 70;
            // 
            // clmnLin
            // 
            this.clmnLin.HeaderText = "Linie";
            this.clmnLin.Name = "clmnLin";
            // 
            // GUIResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 533);
            this.Controls.Add(this.dataGridTimetable);
            this.Controls.Add(this.lblTimeTableLocation);
            this.Controls.Add(this.dataGridConnections);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToLocation);
            this.Controls.Add(this.lblFromLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUIResults";
            this.Text = "Verbindungen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimetable)).EndInit();
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
        private System.Windows.Forms.Label lblTimeTableLocation;
        private System.Windows.Forms.DataGridView dataGridTimetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTrain;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLin;
    }
}