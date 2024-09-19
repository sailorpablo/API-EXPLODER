namespace Api_Exploder.Forms
{
    partial class EnvVarForm
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
            panel2 = new Panel();
            listBoxVariable = new ListBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(listBoxVariable);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 201);
            panel2.TabIndex = 0;
            // 
            // listBoxVariable
            // 
            listBoxVariable.FormattingEnabled = true;
            listBoxVariable.ItemHeight = 15;
            listBoxVariable.Location = new Point(3, 3);
            listBoxVariable.Name = "listBoxVariable";
            listBoxVariable.Size = new Size(723, 184);
            listBoxVariable.TabIndex = 0;
            // 
            // EnvVarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 450);
            Controls.Add(panel2);
            Name = "EnvVarForm";
            Text = "Form1";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ListBox listBoxVariable;
    }
}