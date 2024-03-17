namespace Ex01
{
    partial class nForm
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
            checkBoxClose = new CheckBox();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // checkBoxClose
            // 
            checkBoxClose.AutoSize = true;
            checkBoxClose.Location = new Point(96, 65);
            checkBoxClose.Name = "checkBoxClose";
            checkBoxClose.Size = new Size(83, 19);
            checkBoxClose.TabIndex = 0;
            checkBoxClose.Text = "checkBox1";
            checkBoxClose.UseVisualStyleBackColor = true;
            checkBoxClose.CheckedChanged += checkBoxClose_CheckedChanged;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(498, 73);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // nForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClose);
            Controls.Add(checkBoxClose);
            Name = "nForm";
            Text = "nForm";
            Load += nForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxClose;
        private Button buttonClose;
    }
}