
namespace MPM
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.exButton1 = new MPM.ExButton();
            this.exPanel1 = new MPM.ExPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exTextBox1 = new MPM.ExTextBox();
            this.exTextBox2 = new MPM.ExTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.exPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(664, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(360, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(360, 203);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // exButton1
            // 
            this.exButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.exButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.exButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.exButton1.BorderRadius = 40;
            this.exButton1.BorderSize = 0;
            this.exButton1.FlatAppearance.BorderSize = 0;
            this.exButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.exButton1.ForeColor = System.Drawing.Color.White;
            this.exButton1.Location = new System.Drawing.Point(407, 288);
            this.exButton1.Name = "exButton1";
            this.exButton1.Size = new System.Drawing.Size(225, 40);
            this.exButton1.TabIndex = 2;
            this.exButton1.Text = "Login";
            this.exButton1.TextColor = System.Drawing.Color.White;
            this.exButton1.UseVisualStyleBackColor = false;
            this.exButton1.Click += new System.EventHandler(this.exButton1_Click);
            // 
            // exPanel1
            // 
            this.exPanel1.Angle = 360F;
            this.exPanel1.ColorButtom = System.Drawing.Color.Transparent;
            this.exPanel1.Colorleft = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.exPanel1.colorright = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.exPanel1.ColorTop = System.Drawing.Color.Transparent;
            this.exPanel1.Controls.Add(this.pictureBox1);
            this.exPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.exPanel1.Location = new System.Drawing.Point(0, 0);
            this.exPanel1.Name = "exPanel1";
            this.exPanel1.Size = new System.Drawing.Size(300, 450);
            this.exPanel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // exTextBox1
            // 
            this.exTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.exTextBox1.BorderColor = System.Drawing.Color.White;
            this.exTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.exTextBox1.BorderRadius = 0;
            this.exTextBox1.BorderSize = 2;
            this.exTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.exTextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.exTextBox1.Location = new System.Drawing.Point(407, 127);
            this.exTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.exTextBox1.Multiline = false;
            this.exTextBox1.Name = "exTextBox1";
            this.exTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.exTextBox1.PasswordChar = false;
            this.exTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.exTextBox1.PlaceholderText = "";
            this.exTextBox1.Size = new System.Drawing.Size(225, 39);
            this.exTextBox1.TabIndex = 0;
            this.exTextBox1.Texts = "Username";
            this.exTextBox1.UnderlinedStyle = true;
            this.exTextBox1.Click += new System.EventHandler(this.exTextBox1_Click);
            this.exTextBox1.Leave += new System.EventHandler(this.exTextBox1_Leave);
            // 
            // exTextBox2
            // 
            this.exTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.exTextBox2.BorderColor = System.Drawing.Color.White;
            this.exTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.exTextBox2.BorderRadius = 0;
            this.exTextBox2.BorderSize = 2;
            this.exTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.exTextBox2.ForeColor = System.Drawing.Color.LightGray;
            this.exTextBox2.Location = new System.Drawing.Point(407, 203);
            this.exTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.exTextBox2.Multiline = false;
            this.exTextBox2.Name = "exTextBox2";
            this.exTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.exTextBox2.PasswordChar = true;
            this.exTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.exTextBox2.PlaceholderText = "";
            this.exTextBox2.Size = new System.Drawing.Size(225, 39);
            this.exTextBox2.TabIndex = 1;
            this.exTextBox2.Texts = "Password";
            this.exTextBox2.UnderlinedStyle = true;
            this.exTextBox2.Click += new System.EventHandler(this.exTextBox2_Click);
            this.exTextBox2.Leave += new System.EventHandler(this.exTextBox2_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(623, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "_";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exTextBox2);
            this.Controls.Add(this.exTextBox1);
            this.Controls.Add(this.exButton1);
            this.Controls.Add(this.exPanel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.exPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ExPanel exPanel1;
        private ExButton exButton1;
        private ExTextBox exTextBox1;
        private ExTextBox exTextBox2;
        private System.Windows.Forms.Label label2;
    }
}

