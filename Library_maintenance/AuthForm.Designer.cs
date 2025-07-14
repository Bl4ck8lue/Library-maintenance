namespace Library_maintenance
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            titleLabel = new Label();
            loginLabel = new Label();
            passLabel = new Label();
            loginTextBox = new TextBox();
            passTextBox = new TextBox();
            enterButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(93, 41);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(161, 31);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Авторизация";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(33, 140);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(65, 23);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Логин";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passLabel.Location = new Point(33, 201);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(75, 23);
            passLabel.TabIndex = 2;
            passLabel.Text = "Пароль";
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginTextBox.Location = new Point(137, 134);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(197, 29);
            loginTextBox.TabIndex = 3;
            // 
            // passTextBox
            // 
            passTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passTextBox.Location = new Point(137, 195);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(197, 29);
            passTextBox.TabIndex = 4;
            // 
            // enterButton
            // 
            enterButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            enterButton.Location = new Point(137, 286);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(75, 31);
            enterButton.TabIndex = 5;
            enterButton.Text = "Войти";
            enterButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(306, 12);
            button1.Name = "button1";
            button1.Size = new Size(28, 23);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 353);
            Controls.Add(button1);
            Controls.Add(enterButton);
            Controls.Add(passTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(passLabel);
            Controls.Add(loginLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label loginLabel;
        private Label passLabel;
        private TextBox loginTextBox;
        private TextBox passTextBox;
        private Button enterButton;
        private Button button1;
    }
}
