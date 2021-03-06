﻿namespace SBB_Fahrplan
{
    partial class GUISearch
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUISearch));
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabSearchConnection = new System.Windows.Forms.TabPage();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnSearchToLocation = new System.Windows.Forms.Button();
            this.btnSearchFromLocation = new System.Windows.Forms.Button();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtToLocation = new System.Windows.Forms.TextBox();
            this.txtFromLocation = new System.Windows.Forms.TextBox();
            this.tabCreateTimeTable = new System.Windows.Forms.TabPage();
            this.lblTimetableErrors = new System.Windows.Forms.Label();
            this.btnSearchTimetableLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimetableLocation = new System.Windows.Forms.TextBox();
            this.btnCreateTimeTable = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabCtrl.SuspendLayout();
            this.tabSearchConnection.SuspendLayout();
            this.tabCreateTimeTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabSearchConnection);
            this.tabCtrl.Controls.Add(this.tabCreateTimeTable);
            this.tabCtrl.Location = new System.Drawing.Point(-3, 1);
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(773, 238);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabSearchConnection
            // 
            this.tabSearchConnection.Controls.Add(this.dateTimePicker);
            this.tabSearchConnection.Controls.Add(this.lblErrorMessage);
            this.tabSearchConnection.Controls.Add(this.btnSearchToLocation);
            this.tabSearchConnection.Controls.Add(this.btnSearchFromLocation);
            this.tabSearchConnection.Controls.Add(this.btnSearchConnection);
            this.tabSearchConnection.Controls.Add(this.lblTo);
            this.tabSearchConnection.Controls.Add(this.lblFrom);
            this.tabSearchConnection.Controls.Add(this.txtToLocation);
            this.tabSearchConnection.Controls.Add(this.txtFromLocation);
            this.tabSearchConnection.Location = new System.Drawing.Point(4, 25);
            this.tabSearchConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSearchConnection.Name = "tabSearchConnection";
            this.tabSearchConnection.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSearchConnection.Size = new System.Drawing.Size(765, 209);
            this.tabSearchConnection.TabIndex = 0;
            this.tabSearchConnection.Text = "Verbindung suchen";
            this.tabSearchConnection.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(516, 122);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.Value = new System.DateTime(2018, 12, 3, 15, 49, 23, 0);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(40, 164);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(105, 17);
            this.lblErrorMessage.TabIndex = 7;
            this.lblErrorMessage.Text = "Fehlermeldung!";
            this.lblErrorMessage.Visible = false;
            // 
            // btnSearchToLocation
            // 
            this.btnSearchToLocation.Location = new System.Drawing.Point(640, 76);
            this.btnSearchToLocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchToLocation.Name = "btnSearchToLocation";
            this.btnSearchToLocation.Size = new System.Drawing.Size(100, 28);
            this.btnSearchToLocation.TabIndex = 5;
            this.btnSearchToLocation.Text = "Ort suchen";
            this.btnSearchToLocation.UseVisualStyleBackColor = true;
            this.btnSearchToLocation.Click += new System.EventHandler(this.BtnSearchToLocation_Click);
            // 
            // btnSearchFromLocation
            // 
            this.btnSearchFromLocation.Location = new System.Drawing.Point(220, 76);
            this.btnSearchFromLocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchFromLocation.Name = "btnSearchFromLocation";
            this.btnSearchFromLocation.Size = new System.Drawing.Size(100, 28);
            this.btnSearchFromLocation.TabIndex = 2;
            this.btnSearchFromLocation.Text = "Ort suchen";
            this.btnSearchFromLocation.UseVisualStyleBackColor = true;
            this.btnSearchFromLocation.Click += new System.EventHandler(this.BtnSearchFromLocation_Click);
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Enabled = false;
            this.btnSearchConnection.Location = new System.Drawing.Point(569, 164);
            this.btnSearchConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(171, 41);
            this.btnSearchConnection.TabIndex = 6;
            this.btnSearchConnection.Text = "Verbindung suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.BtnSearchConnection_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(458, 27);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 17);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "&Bis: ";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(37, 27);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 17);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "&Von: ";
            // 
            // txtToLocation
            // 
            this.txtToLocation.Location = new System.Drawing.Point(461, 46);
            this.txtToLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToLocation.Name = "txtToLocation";
            this.txtToLocation.Size = new System.Drawing.Size(279, 22);
            this.txtToLocation.TabIndex = 4;
            this.txtToLocation.TextChanged += new System.EventHandler(this.TxtFromToLocation_TextChanged);
            this.txtToLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFromToLocation_KeyDown);
            // 
            // txtFromLocation
            // 
            this.txtFromLocation.Location = new System.Drawing.Point(40, 46);
            this.txtFromLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFromLocation.Name = "txtFromLocation";
            this.txtFromLocation.Size = new System.Drawing.Size(279, 22);
            this.txtFromLocation.TabIndex = 1;
            this.txtFromLocation.TextChanged += new System.EventHandler(this.TxtFromToLocation_TextChanged);
            this.txtFromLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFromToLocation_KeyDown);
            // 
            // tabCreateTimeTable
            // 
            this.tabCreateTimeTable.Controls.Add(this.lblTimetableErrors);
            this.tabCreateTimeTable.Controls.Add(this.btnSearchTimetableLocation);
            this.tabCreateTimeTable.Controls.Add(this.label1);
            this.tabCreateTimeTable.Controls.Add(this.txtTimetableLocation);
            this.tabCreateTimeTable.Controls.Add(this.btnCreateTimeTable);
            this.tabCreateTimeTable.Location = new System.Drawing.Point(4, 25);
            this.tabCreateTimeTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCreateTimeTable.Name = "tabCreateTimeTable";
            this.tabCreateTimeTable.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCreateTimeTable.Size = new System.Drawing.Size(765, 209);
            this.tabCreateTimeTable.TabIndex = 1;
            this.tabCreateTimeTable.Text = "Fahrplan erstellen";
            this.tabCreateTimeTable.UseVisualStyleBackColor = true;
            // 
            // lblTimetableErrors
            // 
            this.lblTimetableErrors.AutoSize = true;
            this.lblTimetableErrors.ForeColor = System.Drawing.Color.Red;
            this.lblTimetableErrors.Location = new System.Drawing.Point(40, 138);
            this.lblTimetableErrors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimetableErrors.Name = "lblTimetableErrors";
            this.lblTimetableErrors.Size = new System.Drawing.Size(105, 17);
            this.lblTimetableErrors.TabIndex = 9;
            this.lblTimetableErrors.Text = "Fehlermeldung!";
            this.lblTimetableErrors.Visible = false;
            // 
            // btnSearchTimetableLocation
            // 
            this.btnSearchTimetableLocation.Location = new System.Drawing.Point(219, 74);
            this.btnSearchTimetableLocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchTimetableLocation.Name = "btnSearchTimetableLocation";
            this.btnSearchTimetableLocation.Size = new System.Drawing.Size(100, 28);
            this.btnSearchTimetableLocation.TabIndex = 2;
            this.btnSearchTimetableLocation.Text = "Ort suchen";
            this.btnSearchTimetableLocation.UseVisualStyleBackColor = true;
            this.btnSearchTimetableLocation.Click += new System.EventHandler(this.BtnSearchTimetableLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ort: ";
            // 
            // txtTimetableLocation
            // 
            this.txtTimetableLocation.Location = new System.Drawing.Point(40, 46);
            this.txtTimetableLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimetableLocation.Name = "txtTimetableLocation";
            this.txtTimetableLocation.Size = new System.Drawing.Size(279, 22);
            this.txtTimetableLocation.TabIndex = 1;
            this.txtTimetableLocation.TextChanged += new System.EventHandler(this.TxtTimetableLocation_TextChanged);
            this.txtTimetableLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTimetableLocation_KeyDown);
            // 
            // btnCreateTimeTable
            // 
            this.btnCreateTimeTable.Enabled = false;
            this.btnCreateTimeTable.Location = new System.Drawing.Point(462, 42);
            this.btnCreateTimeTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateTimeTable.Name = "btnCreateTimeTable";
            this.btnCreateTimeTable.Size = new System.Drawing.Size(277, 31);
            this.btnCreateTimeTable.TabIndex = 3;
            this.btnCreateTimeTable.Text = "Fahrplan erstellen";
            this.btnCreateTimeTable.UseVisualStyleBackColor = true;
            this.btnCreateTimeTable.Click += new System.EventHandler(this.BtnCreateTimetable_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GUISearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 245);
            this.Controls.Add(this.tabCtrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUISearch";
            this.Text = "SBB-Fahrplan";
            this.tabCtrl.ResumeLayout(false);
            this.tabSearchConnection.ResumeLayout(false);
            this.tabSearchConnection.PerformLayout();
            this.tabCreateTimeTable.ResumeLayout(false);
            this.tabCreateTimeTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabSearchConnection;
        private System.Windows.Forms.TabPage tabCreateTimeTable;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtToLocation;
        private System.Windows.Forms.TextBox txtFromLocation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimetableLocation;
        private System.Windows.Forms.Button btnCreateTimeTable;
        private System.Windows.Forms.Button btnSearchToLocation;
        private System.Windows.Forms.Button btnSearchFromLocation;
        private System.Windows.Forms.Button btnSearchTimetableLocation;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTimetableErrors;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

