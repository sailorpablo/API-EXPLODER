namespace Api_Exploder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textUrl = new TextBox();
            textBody = new RichTextBox();
            btnSend = new Button();
            textStatus = new TextBox();
            label4 = new Label();
            radioBtnSingle = new RadioButton();
            radioBtnMultiple = new RadioButton();
            radioBtnExploder = new RadioButton();
            textBoxMultiple = new TextBox();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            label2.Location = new Point(10, 41);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 70);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "BODY";
            // 
            // textUrl
            // 
            textUrl.Location = new Point(54, 41);
            textUrl.Name = "textUrl";
            textUrl.Size = new Size(850, 23);
            textUrl.TabIndex = 3;
            // 
            // textBody
            // 
            textBody.BackColor = Color.White;
            textBody.Cursor = Cursors.IBeam;
            textBody.Font = new Font("Segoe UI", 9F);
            textBody.Location = new Point(54, 70);
            textBody.Name = "textBody";
            textBody.ScrollBars = RichTextBoxScrollBars.Vertical;
            textBody.Size = new Size(850, 243);
            textBody.TabIndex = 4;
            textBody.Text = "";
            textBody.TextChanged += textBody_TextChanged;
            // 
            // btnSend
            // 
            btnSend.FlatStyle = FlatStyle.System;
            btnSend.Location = new Point(370, 416);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(197, 69);
            btnSend.TabIndex = 5;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += button1_Click;
            // 
            // textStatus
            // 
            textStatus.Location = new Point(127, 491);
            textStatus.Name = "textStatus";
            textStatus.Size = new Size(793, 23);
            textStatus.TabIndex = 3;
            textStatus.TextChanged += textStatus_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(17, 494);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 1;
            label4.Text = "STATUS RESPONSE";
            // 
            // radioBtnSingle
            // 
            radioBtnSingle.AutoSize = true;
            radioBtnSingle.BackColor = Color.White;
            radioBtnSingle.Checked = true;
            radioBtnSingle.Location = new Point(192, 327);
            radioBtnSingle.Name = "radioBtnSingle";
            radioBtnSingle.Size = new Size(57, 19);
            radioBtnSingle.TabIndex = 6;
            radioBtnSingle.TabStop = true;
            radioBtnSingle.Text = "Single";
            radioBtnSingle.UseVisualStyleBackColor = false;
            radioBtnSingle.Click += radioBtnSingle_Click;
            // 
            // radioBtnMultiple
            // 
            radioBtnMultiple.AutoSize = true;
            radioBtnMultiple.BackColor = Color.White;
            radioBtnMultiple.Location = new Point(411, 327);
            radioBtnMultiple.Name = "radioBtnMultiple";
            radioBtnMultiple.Size = new Size(69, 19);
            radioBtnMultiple.TabIndex = 6;
            radioBtnMultiple.TabStop = true;
            radioBtnMultiple.Text = "Multiple";
            radioBtnMultiple.UseVisualStyleBackColor = false;
            radioBtnMultiple.Click += radioBtnMultiple_Click;
            // 
            // radioBtnExploder
            // 
            radioBtnExploder.AutoSize = true;
            radioBtnExploder.BackColor = Color.White;
            radioBtnExploder.Location = new Point(664, 327);
            radioBtnExploder.Name = "radioBtnExploder";
            radioBtnExploder.Size = new Size(81, 19);
            radioBtnExploder.TabIndex = 6;
            radioBtnExploder.TabStop = true;
            radioBtnExploder.Text = "EXPLODER";
            radioBtnExploder.UseVisualStyleBackColor = false;
            radioBtnExploder.Click += radioBtnExploder_Click;
            // 
            // textBoxMultiple
            // 
            textBoxMultiple.Location = new Point(486, 326);
            textBoxMultiple.Name = "textBoxMultiple";
            textBoxMultiple.Size = new Size(100, 23);
            textBoxMultiple.TabIndex = 7;
            textBoxMultiple.Visible = false;
            textBoxMultiple.TextChanged += textBoxMultiple_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(845, 462);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Logs";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(730, 12);
            button2.Name = "button2";
            button2.Size = new Size(174, 23);
            button2.TabIndex = 9;
            button2.Text = "Enviroment Variables";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(713, 17);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 10;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(947, 518);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxMultiple);
            Controls.Add(radioBtnExploder);
            Controls.Add(radioBtnMultiple);
            Controls.Add(radioBtnSingle);
            Controls.Add(btnSend);
            Controls.Add(textBody);
            Controls.Add(textStatus);
            Controls.Add(textUrl);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
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
        private RichTextBox textBody;
        private Button btnSend;
        private TextBox textStatus;
        private Label label4;
        private RadioButton radioBtnSingle;
        private RadioButton radioBtnMultiple;
        private RadioButton radioBtnExploder;
        private TextBox textBoxMultiple;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
