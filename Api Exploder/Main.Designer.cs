namespace Api_Exploder
{
    partial class Main
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textUrl = new TextBox();
            textBody = new TextBox();
            btnSend = new Button();
            textStatus = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(421, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "API EXPLODER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 43);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 80);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "BODY";
            // 
            // textUrl
            // 
            textUrl.Location = new Point(64, 40);
            textUrl.Name = "textUrl";
            textUrl.Size = new Size(860, 23);
            textUrl.TabIndex = 3;
            // 
            // textBody
            // 
            textBody.Location = new Point(64, 80);
            textBody.Multiline = true;
            textBody.Name = "textBody";
            textBody.Size = new Size(850, 243);
            textBody.TabIndex = 4;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(421, 348);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 5;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += button1_Click;
            // 
            // textStatus
            // 
            textStatus.Location = new Point(54, 471);
            textStatus.Name = "textStatus";
            textStatus.Size = new Size(860, 23);
            textStatus.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 518);
            Controls.Add(btnSend);
            Controls.Add(textBody);
            Controls.Add(textStatus);
            Controls.Add(textUrl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Main";
            Text = "Form1";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textUrl;
        private TextBox textBody;
        private Button btnSend;
        private TextBox textStatus;
    }
}
