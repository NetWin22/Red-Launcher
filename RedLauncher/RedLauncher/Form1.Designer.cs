namespace RedLauncher
{
    partial class RedLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedLauncher));
            splitter1 = new Splitter();
            label1 = new Label();
            RunBtn = new Button();
            ModifyBtn = new Button();
            RemoveBtn = new Button();
            TreeView1 = new TreeView();
            CreateBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            GroupBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.FromArgb(28, 28, 28);
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(205, 236);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(211, 31);
            label1.Name = "label1";
            label1.Size = new Size(264, 37);
            label1.TabIndex = 1;
            label1.Text = "Run an application.";
            // 
            // RunBtn
            // 
            RunBtn.BackColor = Color.FromArgb(18, 18, 18);
            RunBtn.FlatAppearance.BorderColor = Color.FromArgb(28, 28, 28);
            RunBtn.FlatAppearance.BorderSize = 2;
            RunBtn.FlatStyle = FlatStyle.Flat;
            RunBtn.ForeColor = SystemColors.ButtonHighlight;
            RunBtn.Location = new Point(12, 54);
            RunBtn.Name = "RunBtn";
            RunBtn.Size = new Size(180, 29);
            RunBtn.TabIndex = 2;
            RunBtn.Text = "Run it!";
            RunBtn.UseVisualStyleBackColor = false;
            RunBtn.Click += RunBtn_Click;
            // 
            // ModifyBtn
            // 
            ModifyBtn.BackColor = Color.FromArgb(18, 18, 18);
            ModifyBtn.FlatAppearance.BorderColor = Color.FromArgb(28, 28, 28);
            ModifyBtn.FlatAppearance.BorderSize = 2;
            ModifyBtn.FlatStyle = FlatStyle.Flat;
            ModifyBtn.ForeColor = SystemColors.ButtonHighlight;
            ModifyBtn.Location = new Point(12, 89);
            ModifyBtn.Name = "ModifyBtn";
            ModifyBtn.Size = new Size(180, 29);
            ModifyBtn.TabIndex = 3;
            ModifyBtn.Text = "Modify it!";
            ModifyBtn.UseVisualStyleBackColor = false;
            ModifyBtn.Click += ModifyBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.BackColor = Color.FromArgb(36, 0, 0);
            RemoveBtn.FlatAppearance.BorderColor = Color.FromArgb(28, 28, 28);
            RemoveBtn.FlatAppearance.BorderSize = 2;
            RemoveBtn.FlatStyle = FlatStyle.Flat;
            RemoveBtn.ForeColor = SystemColors.ButtonHighlight;
            RemoveBtn.Location = new Point(12, 124);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(180, 29);
            RemoveBtn.TabIndex = 4;
            RemoveBtn.Text = "Remove it!";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // TreeView1
            // 
            TreeView1.BackColor = Color.FromArgb(36, 36, 36);
            TreeView1.BorderStyle = BorderStyle.None;
            TreeView1.ForeColor = SystemColors.Info;
            TreeView1.Location = new Point(211, 71);
            TreeView1.Name = "TreeView1";
            TreeView1.Size = new Size(363, 153);
            TreeView1.TabIndex = 5;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.FromArgb(18, 18, 18);
            CreateBtn.FlatAppearance.BorderColor = Color.FromArgb(28, 28, 28);
            CreateBtn.FlatAppearance.BorderSize = 2;
            CreateBtn.FlatStyle = FlatStyle.Flat;
            CreateBtn.ForeColor = SystemColors.ButtonHighlight;
            CreateBtn.Location = new Point(12, 195);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(180, 29);
            CreateBtn.TabIndex = 6;
            CreateBtn.Text = "Create new...";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "FileDialog";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(205, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 28);
            panel1.TabIndex = 7;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 20, 20);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(305, 0);
            button1.Name = "button1";
            button1.Size = new Size(79, 28);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(28, 28, 28);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(28, 28, 28);
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(49, 12);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 9;
            label2.Text = "Red Launcher";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(28, 28, 28);
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(49, 30);
            label3.Name = "label3";
            label3.Size = new Size(74, 13);
            label3.TabIndex = 10;
            label3.Text = "Open Source";
            // 
            // GroupBtn
            // 
            GroupBtn.BackColor = Color.FromArgb(18, 18, 18);
            GroupBtn.FlatAppearance.BorderColor = Color.FromArgb(28, 28, 28);
            GroupBtn.FlatAppearance.BorderSize = 2;
            GroupBtn.FlatStyle = FlatStyle.Flat;
            GroupBtn.ForeColor = SystemColors.ButtonHighlight;
            GroupBtn.Location = new Point(12, 159);
            GroupBtn.Name = "GroupBtn";
            GroupBtn.Size = new Size(180, 29);
            GroupBtn.TabIndex = 11;
            GroupBtn.Text = "Make a new group...";
            GroupBtn.UseVisualStyleBackColor = false;
            GroupBtn.Click += GroupBtn_Click;
            // 
            // RedLauncher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(589, 236);
            Controls.Add(GroupBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(CreateBtn);
            Controls.Add(TreeView1);
            Controls.Add(RemoveBtn);
            Controls.Add(ModifyBtn);
            Controls.Add(RunBtn);
            Controls.Add(label1);
            Controls.Add(splitter1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RedLauncher";
            Text = "RedLauncher";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Splitter splitter1;
        private Label label1;
        private Button RunBtn;
        private Button ModifyBtn;
        private Button RemoveBtn;
        private TreeView TreeView1;
        private Button CreateBtn;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button GroupBtn;
    }
}
