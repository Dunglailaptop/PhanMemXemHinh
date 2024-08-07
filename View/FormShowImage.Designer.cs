namespace PhanMemXemHinh.View
{
    partial class FormShowImage
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
            panel1 = new Panel();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            panel3 = new Panel();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            panel2 = new Panel();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureEdit1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 506);
            panel1.TabIndex = 0;
            // 
            // pictureEdit1
            // 
            pictureEdit1.Dock = DockStyle.Fill;
            pictureEdit1.Location = new Point(86, 0);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit1.Size = new Size(568, 506);
            pictureEdit1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(simpleButton1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(654, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(84, 506);
            panel3.TabIndex = 1;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(44, 191);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(37, 138);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = ">";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(simpleButton2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(86, 506);
            panel2.TabIndex = 0;
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new Point(3, 191);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(37, 138);
            simpleButton2.TabIndex = 1;
            simpleButton2.Text = "<";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // FormShowImage
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 506);
            Controls.Add(panel1);
            Name = "FormShowImage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormShowImage";
            Load += FormShowImage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private Panel panel3;
        private Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}