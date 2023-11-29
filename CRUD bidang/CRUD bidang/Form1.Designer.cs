namespace CRUD_bidang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbx_bidang = new ComboBox();
            btn_simpan = new Button();
            SuspendLayout();
            // 
            // cbx_bidang
            // 
            cbx_bidang.FormattingEnabled = true;
            cbx_bidang.Items.AddRange(new object[] { "Bidang1", "Bidang2", "Bidang3" });
            cbx_bidang.Location = new Point(278, 147);
            cbx_bidang.Name = "cbx_bidang";
            cbx_bidang.Size = new Size(242, 40);
            cbx_bidang.TabIndex = 0;
            // 
            // btn_simpan
            // 
            btn_simpan.Location = new Point(328, 244);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(150, 46);
            btn_simpan.TabIndex = 1;
            btn_simpan.Text = "simpan";
            btn_simpan.UseVisualStyleBackColor = true;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_simpan);
            Controls.Add(cbx_bidang);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbx_bidang;
        private Button btn_simpan;
    }
}