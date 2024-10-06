namespace Api_Exploder.Forms
{
    partial class LogsForm
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
            splitContainer1 = new SplitContainer();
            btnRecentReq = new Button();
            richTextBoxCentral = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnRecentReq);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(richTextBoxCentral);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 171;
            splitContainer1.TabIndex = 0;
            // 
            // btnRecentReq
            // 
            btnRecentReq.Location = new Point(35, 46);
            btnRecentReq.Name = "btnRecentReq";
            btnRecentReq.Size = new Size(75, 23);
            btnRecentReq.TabIndex = 0;
            btnRecentReq.Text = "Recent Req";
            btnRecentReq.UseVisualStyleBackColor = true;
            btnRecentReq.Click += btnRecentReq_Click;
            // 
            // richTextBoxCentral
            // 
            richTextBoxCentral.Location = new Point(15, 46);
            richTextBoxCentral.Name = "richTextBoxCentral";
            richTextBoxCentral.Size = new Size(598, 371);
            richTextBoxCentral.TabIndex = 0;
            richTextBoxCentral.Text = "";
            // 
            // LogsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "LogsForm";
            Text = "LogsForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnRecentReq;
        private RichTextBox richTextBoxCentral;
    }
}