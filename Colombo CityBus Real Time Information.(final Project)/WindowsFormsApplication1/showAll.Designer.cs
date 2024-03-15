namespace CityBusManagement
{
    partial class showAll
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
            this.btn_show = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtBox_busNo = new System.Windows.Forms.TextBox();
            this.Bus_No = new System.Windows.Forms.Label();
            this.listBox_details = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(392, 20);
            this.btn_show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(112, 35);
            this.btn_show.TabIndex = 1;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(81, 103);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(356, 35);
            this.progressBar1.TabIndex = 2;
            // 
            // txtBox_busNo
            // 
            this.txtBox_busNo.Location = new System.Drawing.Point(128, 20);
            this.txtBox_busNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_busNo.Name = "txtBox_busNo";
            this.txtBox_busNo.Size = new System.Drawing.Size(148, 26);
            this.txtBox_busNo.TabIndex = 3;
            // 
            // Bus_No
            // 
            this.Bus_No.AutoSize = true;
            this.Bus_No.Location = new System.Drawing.Point(18, 28);
            this.Bus_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bus_No.Name = "Bus_No";
            this.Bus_No.Size = new System.Drawing.Size(65, 20);
            this.Bus_No.TabIndex = 4;
            this.Bus_No.Text = "Bus No.";
            // 
            // listBox_details
            // 
            this.listBox_details.ForeColor = System.Drawing.SystemColors.Highlight;
            this.listBox_details.FormattingEnabled = true;
            this.listBox_details.ItemHeight = 20;
            this.listBox_details.Location = new System.Drawing.Point(66, 193);
            this.listBox_details.Name = "listBox_details";
            this.listBox_details.Size = new System.Drawing.Size(210, 304);
            this.listBox_details.TabIndex = 6;
            // 
            // showAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 505);
            this.Controls.Add(this.listBox_details);
            this.Controls.Add(this.Bus_No);
            this.Controls.Add(this.txtBox_busNo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_show);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "showAll";
            this.Text = "showAll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtBox_busNo;
        private System.Windows.Forms.Label Bus_No;
        private System.Windows.Forms.ListBox listBox_details;
    }
}