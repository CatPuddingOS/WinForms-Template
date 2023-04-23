namespace Winforms_demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SidePanel_left = new Panel();
            b_DarkMode = new Button();
            Login_Panel = new Panel();
            Login_RememberMe = new CheckBox();
            Login_Send = new Button();
            Login_Label = new Label();
            Login_PassWord = new TextBox();
            Login_Username = new TextBox();
            MovementPanel_top = new Panel();
            b_quit = new Button();
            SidePanel_left.SuspendLayout();
            Login_Panel.SuspendLayout();
            MovementPanel_top.SuspendLayout();
            SuspendLayout();
            // 
            // SidePanel_left
            // 
            SidePanel_left.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SidePanel_left.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SidePanel_left.BackColor = Color.FromArgb(99, 99, 99);
            SidePanel_left.Controls.Add(b_DarkMode);
            SidePanel_left.Controls.Add(Login_Panel);
            SidePanel_left.Location = new Point(-3, -1);
            SidePanel_left.Name = "SidePanel_left";
            SidePanel_left.Size = new Size(405, 870);
            SidePanel_left.TabIndex = 0;
            // 
            // b_DarkMode
            // 
            b_DarkMode.BackColor = Color.Transparent;
            b_DarkMode.BackgroundImageLayout = ImageLayout.Center;
            b_DarkMode.FlatAppearance.BorderSize = 0;
            b_DarkMode.FlatStyle = FlatStyle.Flat;
            b_DarkMode.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_DarkMode.ForeColor = SystemColors.ActiveCaption;
            b_DarkMode.Image = (Image)resources.GetObject("b_DarkMode.Image");
            b_DarkMode.Location = new Point(37, 802);
            b_DarkMode.Name = "b_DarkMode";
            b_DarkMode.Size = new Size(123, 43);
            b_DarkMode.TabIndex = 8;
            b_DarkMode.Text = "Dark Mode";
            b_DarkMode.TextAlign = ContentAlignment.MiddleRight;
            b_DarkMode.TextImageRelation = TextImageRelation.ImageBeforeText;
            b_DarkMode.UseVisualStyleBackColor = false;
            b_DarkMode.Click += b_DarkMode_Click;
            // 
            // Login_Panel
            // 
            Login_Panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Login_Panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Login_Panel.BackColor = Color.FromArgb(225, 227, 225);
            Login_Panel.Controls.Add(Login_RememberMe);
            Login_Panel.Controls.Add(Login_Send);
            Login_Panel.Controls.Add(Login_Label);
            Login_Panel.Controls.Add(Login_PassWord);
            Login_Panel.Controls.Add(Login_Username);
            Login_Panel.Location = new Point(43, 69);
            Login_Panel.Name = "Login_Panel";
            Login_Panel.Size = new Size(318, 435);
            Login_Panel.TabIndex = 0;
            // 
            // Login_RememberMe
            // 
            Login_RememberMe.FlatAppearance.BorderSize = 0;
            Login_RememberMe.FlatStyle = FlatStyle.Flat;
            Login_RememberMe.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Login_RememberMe.ForeColor = SystemColors.ActiveCaptionText;
            Login_RememberMe.Location = new Point(67, 183);
            Login_RememberMe.Name = "Login_RememberMe";
            Login_RememberMe.Size = new Size(163, 24);
            Login_RememberMe.TabIndex = 3;
            Login_RememberMe.Text = "Keep me signed in";
            Login_RememberMe.UseVisualStyleBackColor = true;
            // 
            // Login_Send
            // 
            Login_Send.BackColor = Color.FromArgb(99, 99, 99);
            Login_Send.FlatAppearance.BorderSize = 0;
            Login_Send.FlatStyle = FlatStyle.Flat;
            Login_Send.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Login_Send.ForeColor = SystemColors.ActiveCaptionText;
            Login_Send.Location = new Point(105, 229);
            Login_Send.Name = "Login_Send";
            Login_Send.Size = new Size(105, 44);
            Login_Send.TabIndex = 6;
            Login_Send.Text = "Login";
            Login_Send.UseVisualStyleBackColor = false;
            // 
            // Login_Label
            // 
            Login_Label.BackColor = Color.Transparent;
            Login_Label.Font = new Font("Segoe UI Variable Display", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Login_Label.ForeColor = SystemColors.ActiveCaptionText;
            Login_Label.Location = new Point(90, 31);
            Login_Label.Name = "Login_Label";
            Login_Label.Size = new Size(134, 55);
            Login_Label.TabIndex = 5;
            Login_Label.Text = "Login";
            Login_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login_PassWord
            // 
            Login_PassWord.BackColor = Color.Silver;
            Login_PassWord.BorderStyle = BorderStyle.None;
            Login_PassWord.ForeColor = SystemColors.ActiveCaptionText;
            Login_PassWord.Location = new Point(67, 161);
            Login_PassWord.Name = "Login_PassWord";
            Login_PassWord.Size = new Size(177, 16);
            Login_PassWord.TabIndex = 4;
            Login_PassWord.UseSystemPasswordChar = true;
            // 
            // Login_Username
            // 
            Login_Username.BackColor = Color.Silver;
            Login_Username.BorderStyle = BorderStyle.None;
            Login_Username.ForeColor = SystemColors.ActiveCaptionText;
            Login_Username.Location = new Point(67, 124);
            Login_Username.Name = "Login_Username";
            Login_Username.Size = new Size(177, 16);
            Login_Username.TabIndex = 3;
            // 
            // MovementPanel_top
            // 
            MovementPanel_top.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MovementPanel_top.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MovementPanel_top.BackColor = Color.FromArgb(99, 99, 99);
            MovementPanel_top.Controls.Add(b_quit);
            MovementPanel_top.Location = new Point(0, -1);
            MovementPanel_top.Name = "MovementPanel_top";
            MovementPanel_top.Size = new Size(1341, 35);
            MovementPanel_top.TabIndex = 2;
            MovementPanel_top.MouseDown += MovementPanel_top_MouseDown;
            // 
            // b_quit
            // 
            b_quit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            b_quit.AutoSize = true;
            b_quit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            b_quit.BackColor = Color.FromArgb(99, 99, 99);
            b_quit.FlatAppearance.BorderSize = 0;
            b_quit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            b_quit.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            b_quit.FlatStyle = FlatStyle.Flat;
            b_quit.Font = new Font("Segoe UI Variable Display", 15F, FontStyle.Regular, GraphicsUnit.Point);
            b_quit.ForeColor = Color.DarkRed;
            b_quit.Location = new Point(1307, -2);
            b_quit.Name = "b_quit";
            b_quit.Size = new Size(34, 37);
            b_quit.TabIndex = 1;
            b_quit.Text = "X";
            b_quit.UseVisualStyleBackColor = false;
            b_quit.Click += b_quit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 227, 225);
            ClientSize = new Size(1340, 868);
            Controls.Add(MovementPanel_top);
            Controls.Add(SidePanel_left);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            SidePanel_left.ResumeLayout(false);
            Login_Panel.ResumeLayout(false);
            Login_Panel.PerformLayout();
            MovementPanel_top.ResumeLayout(false);
            MovementPanel_top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SidePanel_left;
        private Button b_quit;
        private Panel MovementPanel_top;
        private Panel Login_Panel;
        private TextBox Login_Username;
        private Label Login_Label;
        private TextBox Login_PassWord;
        private Button Login_Send;
        private Button b_DarkMode;
        private CheckBox Login_RememberMe;
    }
}