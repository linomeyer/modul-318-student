namespace SBB_Fahrplan
{
    partial class formSearch
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
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabSearchConnection = new System.Windows.Forms.TabPage();
            this.tabCreateTimeTable = new System.Windows.Forms.TabPage();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.btnCreateTimeTable = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCtrl.SuspendLayout();
            this.tabSearchConnection.SuspendLayout();
            this.tabCreateTimeTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabSearchConnection);
            this.tabCtrl.Controls.Add(this.tabCreateTimeTable);
            this.tabCtrl.Location = new System.Drawing.Point(-2, 3);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(697, 176);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabSearchConnection
            // 
            this.tabSearchConnection.Controls.Add(this.btnSearchConnection);
            this.tabSearchConnection.Controls.Add(this.lblTo);
            this.tabSearchConnection.Controls.Add(this.lblFrom);
            this.tabSearchConnection.Controls.Add(this.txtTo);
            this.tabSearchConnection.Controls.Add(this.txtFrom);
            this.tabSearchConnection.Location = new System.Drawing.Point(4, 25);
            this.tabSearchConnection.Name = "tabSearchConnection";
            this.tabSearchConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchConnection.Size = new System.Drawing.Size(689, 147);
            this.tabSearchConnection.TabIndex = 0;
            this.tabSearchConnection.Text = "Verbindung suchen";
            this.tabSearchConnection.UseVisualStyleBackColor = true;
            // 
            // tabCreateTimeTable
            // 
            this.tabCreateTimeTable.Controls.Add(this.label1);
            this.tabCreateTimeTable.Controls.Add(this.txtLocation);
            this.tabCreateTimeTable.Controls.Add(this.btnCreateTimeTable);
            this.tabCreateTimeTable.Location = new System.Drawing.Point(4, 25);
            this.tabCreateTimeTable.Name = "tabCreateTimeTable";
            this.tabCreateTimeTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateTimeTable.Size = new System.Drawing.Size(689, 147);
            this.tabCreateTimeTable.TabIndex = 1;
            this.tabCreateTimeTable.Text = "Fahrplan erstellen";
            this.tabCreateTimeTable.UseVisualStyleBackColor = true;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(40, 45);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(278, 22);
            this.txtFrom.TabIndex = 0;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(374, 45);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(278, 22);
            this.txtTo.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(40, 22);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 17);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Von: ";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(371, 22);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 17);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Bis: ";
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(374, 86);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(278, 31);
            this.btnSearchConnection.TabIndex = 4;
            this.btnSearchConnection.Text = "Verbindung suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            // 
            // btnCreateTimeTable
            // 
            this.btnCreateTimeTable.Location = new System.Drawing.Point(371, 39);
            this.btnCreateTimeTable.Name = "btnCreateTimeTable";
            this.btnCreateTimeTable.Size = new System.Drawing.Size(278, 31);
            this.btnCreateTimeTable.TabIndex = 5;
            this.btnCreateTimeTable.Text = "Verbindung suchen";
            this.btnCreateTimeTable.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(26, 43);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(278, 22);
            this.txtLocation.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ort";
            // 
            // formSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 169);
            this.Controls.Add(this.tabCtrl);
            this.Name = "formSearch";
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
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnCreateTimeTable;
    }
}

