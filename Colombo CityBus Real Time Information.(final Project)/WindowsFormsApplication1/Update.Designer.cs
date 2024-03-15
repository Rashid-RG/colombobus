namespace CityBusManagement
{
    partial class Update
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_BusNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_routeName = new System.Windows.Forms.TextBox();
            this.textBox_newRouteName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Bus Number :";
            // 
            // textBox_BusNo
            // 
            this.textBox_BusNo.Location = new System.Drawing.Point(143, 35);
            this.textBox_BusNo.Name = "textBox_BusNo";
            this.textBox_BusNo.Size = new System.Drawing.Size(100, 20);
            this.textBox_BusNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter route name :";
            // 
            // textBox_routeName
            // 
            this.textBox_routeName.Location = new System.Drawing.Point(143, 80);
            this.textBox_routeName.Name = "textBox_routeName";
            this.textBox_routeName.Size = new System.Drawing.Size(100, 20);
            this.textBox_routeName.TabIndex = 3;
            // 
            // textBox_newRouteName
            // 
            this.textBox_newRouteName.Location = new System.Drawing.Point(143, 127);
            this.textBox_newRouteName.Name = "textBox_newRouteName";
            this.textBox_newRouteName.Size = new System.Drawing.Size(100, 20);
            this.textBox_newRouteName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter New route name :";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(168, 203);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(104, 23);
            this.button_update.TabIndex = 6;
            this.button_update.Text = "Update Route ";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_newRouteName);
            this.Controls.Add(this.textBox_routeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_BusNo);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "Update";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_BusNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_routeName;
        private System.Windows.Forms.TextBox textBox_newRouteName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_update;
    }
}