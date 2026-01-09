namespace Restaurant
{
    partial class WaiterForm
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
            textBox1 = new TextBox();
            Send = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(447, 23);
            textBox1.TabIndex = 0;
            // 
            // Send
            // 
            Send.Location = new Point(540, 35);
            Send.Name = "Send";
            Send.ScrollBars = ScrollBars.Both;
            Send.Size = new Size(100, 23);
            Send.TabIndex = 1;
            Send.Text = "Send";
            Send.TextAlign = HorizontalAlignment.Center;
            Send.TextChanged += Send_TextChanged;
            // 
            // WaiterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Send);
            Controls.Add(textBox1);
            Name = "WaiterForm";
            Text = "Waiter Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox Send;
    }
}
