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
            closeButton = new Button();
            entbutton = new Button();
            resultsTextBox = new TextBox();
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
            // closeButton
            // 
            closeButton.Image = (Image)resources.GetObject("closeButton.Image");
            closeButton.Location = new Point(305, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(29, 23);
            closeButton.TabIndex = 0;
            closeButton.Click += closeButton_Click;
            // 
            // entbutton
            // 
            entbutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            entbutton.Location = new Point(142, 299);
            entbutton.Name = "entbutton";
            entbutton.Size = new Size(75, 27);
            entbutton.TabIndex = 5;
            entbutton.Text = "Войти";
            entbutton.UseVisualStyleBackColor = true;
            entbutton.Click += entbutton_Click;
            // 
            // resultsTextBox
            // 
            resultsTextBox.Location = new Point(371, 41);
            resultsTextBox.Multiline = true;
            resultsTextBox.Name = "resultsTextBox";
            resultsTextBox.Size = new Size(292, 248);
            resultsTextBox.TabIndex = 6;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(675, 363);
            Controls.Add(resultsTextBox);
            Controls.Add(entbutton);
            Controls.Add(closeButton);
            Controls.Add(passTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(passLabel);
            Controls.Add(loginLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button closeButton;
        private Button entbutton;
        private TextBox resultsTextBox;
    }
}
