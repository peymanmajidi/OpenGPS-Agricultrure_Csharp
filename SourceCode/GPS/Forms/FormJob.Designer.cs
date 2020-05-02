namespace AgOpenGPS
{
    partial class FormJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJob));
            this.btnJobOpen = new System.Windows.Forms.Button();
            this.btnJobNew = new System.Windows.Forms.Button();
            this.btnDeleteAB = new System.Windows.Forms.Button();
            this.btnJobResume = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInField = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJobOpen
            // 
            this.btnJobOpen.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnJobOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnJobOpen.Image")));
            this.btnJobOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobOpen.Location = new System.Drawing.Point(347, 229);
            this.btnJobOpen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnJobOpen.Name = "btnJobOpen";
            this.btnJobOpen.Size = new System.Drawing.Size(561, 77);
            this.btnJobOpen.TabIndex = 3;
            this.btnJobOpen.Text = "Open";
            this.btnJobOpen.UseVisualStyleBackColor = true;
            this.btnJobOpen.Click += new System.EventHandler(this.btnJobOpen_Click);
            // 
            // btnJobNew
            // 
            this.btnJobNew.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnJobNew.Image = ((System.Drawing.Image)(resources.GetObject("btnJobNew.Image")));
            this.btnJobNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobNew.Location = new System.Drawing.Point(347, 126);
            this.btnJobNew.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnJobNew.Name = "btnJobNew";
            this.btnJobNew.Size = new System.Drawing.Size(561, 77);
            this.btnJobNew.TabIndex = 2;
            this.btnJobNew.Text = "New";
            this.btnJobNew.UseVisualStyleBackColor = true;
            this.btnJobNew.Click += new System.EventHandler(this.btnJobNew_Click);
            // 
            // btnDeleteAB
            // 
            this.btnDeleteAB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteAB.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.btnDeleteAB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteAB.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnDeleteAB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAB.Location = new System.Drawing.Point(347, 435);
            this.btnDeleteAB.Name = "btnDeleteAB";
            this.btnDeleteAB.Size = new System.Drawing.Size(561, 77);
            this.btnDeleteAB.TabIndex = 4;
            this.btnDeleteAB.Text = "Cancel";
            // 
            // btnJobResume
            // 
            this.btnJobResume.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnJobResume.Image = ((System.Drawing.Image)(resources.GetObject("btnJobResume.Image")));
            this.btnJobResume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobResume.Location = new System.Drawing.Point(347, 23);
            this.btnJobResume.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnJobResume.Name = "btnJobResume";
            this.btnJobResume.Size = new System.Drawing.Size(561, 77);
            this.btnJobResume.TabIndex = 1;
            this.btnJobResume.Text = "Resume";
            this.btnJobResume.UseVisualStyleBackColor = true;
            this.btnJobResume.Click += new System.EventHandler(this.btnJobResume_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(21, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Field Used:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(23, 461);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 37);
            this.textBox1.TabIndex = 88;
            // 
            // btnInField
            // 
            this.btnInField.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInField.Image = global::AgOpenGPS.Properties.Resources.AutoManualIsAuto;
            this.btnInField.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInField.Location = new System.Drawing.Point(347, 332);
            this.btnInField.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnInField.Name = "btnInField";
            this.btnInField.Size = new System.Drawing.Size(561, 77);
            this.btnInField.TabIndex = 89;
            this.btnInField.Text = "Drive In";
            this.btnInField.UseVisualStyleBackColor = true;
            this.btnInField.Click += new System.EventHandler(this.btnInField_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-83, -56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 535);
            this.panel1.TabIndex = 92;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AgOpenGPS.Properties.Resources.flag_logo;
            this.pictureBox2.Location = new System.Drawing.Point(244, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            // 
            // FormJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(943, 535);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteAB);
            this.Controls.Add(this.btnInField);
            this.Controls.Add(this.btnJobResume);
            this.Controls.Add(this.btnJobNew);
            this.Controls.Add(this.btnJobOpen);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJob";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Start a field";
            this.Load += new System.EventHandler(this.FormJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJobOpen;
        private System.Windows.Forms.Button btnJobNew;
        private System.Windows.Forms.Button btnJobResume;
        private System.Windows.Forms.Button btnDeleteAB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnInField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}