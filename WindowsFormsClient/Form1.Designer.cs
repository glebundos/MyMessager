namespace WindowsFormsClient
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
            this.components = new System.ComponentModel.Container();
            this.MessagesLB = new System.Windows.Forms.ListBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.MessageTB = new System.Windows.Forms.TextBox();
            this.UserNameLABEL = new System.Windows.Forms.Label();
            this.MessageLABEL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MessagesLB
            // 
            this.MessagesLB.FormattingEnabled = true;
            this.MessagesLB.ItemHeight = 15;
            this.MessagesLB.Location = new System.Drawing.Point(12, 12);
            this.MessagesLB.Name = "MessagesLB";
            this.MessagesLB.Size = new System.Drawing.Size(793, 349);
            this.MessagesLB.TabIndex = 0;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(701, 401);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(104, 65);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(12, 401);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(246, 23);
            this.UserNameTB.TabIndex = 2;
            // 
            // MessageTB
            // 
            this.MessageTB.Location = new System.Drawing.Point(12, 443);
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.Size = new System.Drawing.Size(354, 23);
            this.MessageTB.TabIndex = 3;
            // 
            // UserNameLABEL
            // 
            this.UserNameLABEL.AutoSize = true;
            this.UserNameLABEL.Location = new System.Drawing.Point(12, 383);
            this.UserNameLABEL.Name = "UserNameLABEL";
            this.UserNameLABEL.Size = new System.Drawing.Size(109, 15);
            this.UserNameLABEL.TabIndex = 4;
            this.UserNameLABEL.Text = "Имя пользователя";
            // 
            // MessageLABEL
            // 
            this.MessageLABEL.AutoSize = true;
            this.MessageLABEL.Location = new System.Drawing.Point(12, 425);
            this.MessageLABEL.Name = "MessageLABEL";
            this.MessageLABEL.Size = new System.Drawing.Size(103, 15);
            this.MessageLABEL.TabIndex = 5;
            this.MessageLABEL.Text = "Текст сообщения";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 478);
            this.Controls.Add(this.MessageLABEL);
            this.Controls.Add(this.UserNameLABEL);
            this.Controls.Add(this.MessageTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessagesLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox MessagesLB;
        private Button SendButton;
        private TextBox UserNameTB;
        private TextBox MessageTB;
        private Label UserNameLABEL;
        private Label MessageLABEL;
        private System.Windows.Forms.Timer timer1;
    }
}