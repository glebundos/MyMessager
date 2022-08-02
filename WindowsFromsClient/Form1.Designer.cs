namespace WindowsFromsClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessagesLB = new System.Windows.Forms.ListBox();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.MessageTB = new System.Windows.Forms.TextBox();
            this.UserNameLABEL = new System.Windows.Forms.Label();
            this.MessageLABEL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(722, 418);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(99, 58);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = " Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessagesLB
            // 
            this.MessagesLB.FormattingEnabled = true;
            this.MessagesLB.Location = new System.Drawing.Point(12, 29);
            this.MessagesLB.Name = "MessagesLB";
            this.MessagesLB.Size = new System.Drawing.Size(809, 342);
            this.MessagesLB.TabIndex = 1;
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(12, 418);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(171, 20);
            this.UserNameTB.TabIndex = 2;
            // 
            // MessageTB
            // 
            this.MessageTB.Location = new System.Drawing.Point(12, 456);
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.Size = new System.Drawing.Size(602, 20);
            this.MessageTB.TabIndex = 3;
            this.MessageTB.Text = " ";
            // 
            // UserNameLABEL
            // 
            this.UserNameLABEL.AutoSize = true;
            this.UserNameLABEL.Location = new System.Drawing.Point(12, 402);
            this.UserNameLABEL.Name = "UserNameLABEL";
            this.UserNameLABEL.Size = new System.Drawing.Size(103, 13);
            this.UserNameLABEL.TabIndex = 4;
            this.UserNameLABEL.Text = "Имя пользователя";
            // 
            // MessageLABEL
            // 
            this.MessageLABEL.AutoSize = true;
            this.MessageLABEL.Location = new System.Drawing.Point(12, 440);
            this.MessageLABEL.Name = "MessageLABEL";
            this.MessageLABEL.Size = new System.Drawing.Size(97, 13);
            this.MessageLABEL.TabIndex = 5;
            this.MessageLABEL.Text = "Текст сообщения";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 496);
            this.Controls.Add(this.MessageLABEL);
            this.Controls.Add(this.UserNameLABEL);
            this.Controls.Add(this.MessageTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.MessagesLB);
            this.Controls.Add(this.SendButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ListBox MessagesLB;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.TextBox MessageTB;
        private System.Windows.Forms.Label UserNameLABEL;
        private System.Windows.Forms.Label MessageLABEL;
        private System.Windows.Forms.Timer timer1;
    }
}

