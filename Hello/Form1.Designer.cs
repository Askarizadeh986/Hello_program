namespace Hello
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btn_sayhello = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("IRANSansDN", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtname.Location = new System.Drawing.Point(50, 12);
            this.txtname.Name = "txtname";
            this.txtname.PlaceholderText = "نام خود را وارد کنید";
            this.txtname.Size = new System.Drawing.Size(186, 31);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.MouseLeave += new System.EventHandler(this.txtname_MouseLeave);
            this.txtname.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtname_MouseMove);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("IRANSansDN", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnexit.Location = new System.Drawing.Point(206, 57);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(54, 30);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "خروج";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            this.btnexit.MouseLeave += new System.EventHandler(this.btnexit_MouseLeave);
            this.btnexit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnexit_MouseMove);
            // 
            // btn_sayhello
            // 
            this.btn_sayhello.Enabled = false;
            this.btn_sayhello.Font = new System.Drawing.Font("IRANSansDN", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sayhello.Location = new System.Drawing.Point(12, 57);
            this.btn_sayhello.Name = "btn_sayhello";
            this.btn_sayhello.Size = new System.Drawing.Size(93, 30);
            this.btn_sayhello.TabIndex = 3;
            this.btn_sayhello.Text = "سلام کردن";
            this.btn_sayhello.UseVisualStyleBackColor = true;
            this.btn_sayhello.Click += new System.EventHandler(this.btn_sayhello_Click);
            this.btn_sayhello.MouseLeave += new System.EventHandler(this.btn_sayhello_MouseLeave);
            this.btn_sayhello.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_sayhello_MouseMove);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("IRANSansDN", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnclear.Location = new System.Drawing.Point(111, 57);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(84, 30);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "پاک کردن";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button3_Click);
            this.btnclear.MouseLeave += new System.EventHandler(this.btnclear_MouseLeave);
            this.btnclear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnclear_MouseMove);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(12, 126);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 24);
            this.lblresult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 171);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btn_sayhello);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtname);
            this.Font = new System.Drawing.Font("IRANSansDN", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtname;
        private Button btnexit;
        private Button btn_sayhello;
        private Button btnclear;
        private Label lblresult;
    }
}