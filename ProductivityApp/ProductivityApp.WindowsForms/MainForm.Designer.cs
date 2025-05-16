namespace ProductivityApp.WindowsForms
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
            btnReady = new Button();
            pbReadyImage = new PictureBox();
            tbReadyMessage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbReadyImage).BeginInit();
            SuspendLayout();
            // 
            // btnReady
            // 
            btnReady.Location = new Point(901, 261);
            btnReady.Name = "btnReady";
            btnReady.Size = new Size(227, 141);
            btnReady.TabIndex = 0;
            btnReady.Text = "I'm Ready!";
            btnReady.UseVisualStyleBackColor = true;
            btnReady.Click += btnReady_Click;
            // 
            // pbReadyImage
            // 
            pbReadyImage.Location = new Point(323, 39);
            pbReadyImage.Name = "pbReadyImage";
            pbReadyImage.Size = new Size(504, 504);
            pbReadyImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbReadyImage.TabIndex = 1;
            pbReadyImage.TabStop = false;
            // 
            // tbReadyMessage
            // 
            tbReadyMessage.Location = new Point(323, 561);
            tbReadyMessage.Name = "tbReadyMessage";
            tbReadyMessage.Size = new Size(504, 43);
            tbReadyMessage.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 672);
            Controls.Add(tbReadyMessage);
            Controls.Add(pbReadyImage);
            Controls.Add(btnReady);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbReadyImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReady;
        private PictureBox pbReadyImage;
        private TextBox tbReadyMessage;
    }
}
