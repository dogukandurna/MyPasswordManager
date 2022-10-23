
namespace MPM
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exPanel1 = new MPM.ExPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LinkAccountsButton = new MPM.ExButton();
            this.MainSaveButton = new MPM.ExButton();
            this.exPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(665, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(624, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "_";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label6_Click);
            // 
            // exPanel1
            // 
            this.exPanel1.Angle = 360F;
            this.exPanel1.ColorButtom = System.Drawing.Color.Empty;
            this.exPanel1.Colorleft = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.exPanel1.colorright = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.exPanel1.ColorTop = System.Drawing.Color.Empty;
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
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(300, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 450);
            this.panel1.TabIndex = 19;
            // 
            // LinkAccountsButton
            // 
            this.LinkAccountsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.LinkAccountsButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.LinkAccountsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.LinkAccountsButton.BorderRadius = 40;
            this.LinkAccountsButton.BorderSize = 0;
            this.LinkAccountsButton.FlatAppearance.BorderSize = 0;
            this.LinkAccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LinkAccountsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.LinkAccountsButton.ForeColor = System.Drawing.Color.White;
            this.LinkAccountsButton.Location = new System.Drawing.Point(504, 168);
            this.LinkAccountsButton.Name = "LinkAccountsButton";
            this.LinkAccountsButton.Size = new System.Drawing.Size(150, 115);
            this.LinkAccountsButton.TabIndex = 15;
            this.LinkAccountsButton.Text = "LIST ACCOUNTS";
            this.LinkAccountsButton.TextColor = System.Drawing.Color.White;
            this.LinkAccountsButton.UseVisualStyleBackColor = false;
            this.LinkAccountsButton.Click += new System.EventHandler(this.LinkAccountsButton_Click);
            // 
            // MainSaveButton
            // 
            this.MainSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.MainSaveButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.MainSaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(130)))), ((int)(((byte)(162)))));
            this.MainSaveButton.BorderRadius = 40;
            this.MainSaveButton.BorderSize = 0;
            this.MainSaveButton.FlatAppearance.BorderSize = 0;
            this.MainSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainSaveButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.MainSaveButton.ForeColor = System.Drawing.Color.White;
            this.MainSaveButton.Location = new System.Drawing.Point(347, 168);
            this.MainSaveButton.Name = "MainSaveButton";
            this.MainSaveButton.Size = new System.Drawing.Size(150, 115);
            this.MainSaveButton.TabIndex = 13;
            this.MainSaveButton.Text = "CREATE NEW ACCOUNT";
            this.MainSaveButton.TextColor = System.Drawing.Color.White;
            this.MainSaveButton.UseVisualStyleBackColor = false;
            this.MainSaveButton.Click += new System.EventHandler(this.MainSaveButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.ControlBox = false;
            this.Controls.Add(this.LinkAccountsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainSaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.exPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ExPanel exPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ExButton MainSaveButton;
        private ExButton LinkAccountsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}