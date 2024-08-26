namespace POS_Madina
{
    partial class ToastForm
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
            this.components = new System.ComponentModel.Container();
            this.ToastBorder = new System.Windows.Forms.Panel();
            this.IbType = new System.Windows.Forms.Label();
            this.IbMessage = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.toastTimer = new System.Windows.Forms.Timer(this.components);
            this.toastHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ToastBorder
            // 
            this.ToastBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(155)))), ((int)(((byte)(53)))));
            this.ToastBorder.Location = new System.Drawing.Point(-3, 0);
            this.ToastBorder.Name = "ToastBorder";
            this.ToastBorder.Size = new System.Drawing.Size(38, 102);
            this.ToastBorder.TabIndex = 0;
            // 
            // IbType
            // 
            this.IbType.AutoSize = true;
            this.IbType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbType.Location = new System.Drawing.Point(139, 9);
            this.IbType.Name = "IbType";
            this.IbType.Size = new System.Drawing.Size(57, 28);
            this.IbType.TabIndex = 2;
            this.IbType.Text = "Type";
            // 
            // IbMessage
            // 
            this.IbMessage.AutoSize = true;
            this.IbMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbMessage.Location = new System.Drawing.Point(148, 50);
            this.IbMessage.Name = "IbMessage";
            this.IbMessage.Size = new System.Drawing.Size(138, 28);
            this.IbMessage.TabIndex = 3;
            this.IbMessage.Text = "Toast Message";
            // 
            // picIcon
            // 
            this.picIcon.Image = global::POS_Madina.Properties.Resources.tick;
            this.picIcon.Location = new System.Drawing.Point(50, 23);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(49, 55);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // toastTimer
            // 
            this.toastTimer.Enabled = true;
            this.toastTimer.Interval = 10;
            this.toastTimer.Tick += new System.EventHandler(this.toastTimer_Tick);
            // 
            // toastHide
            // 
            this.toastHide.Interval = 10;
            this.toastHide.Tick += new System.EventHandler(this.toastHide_Tick);
            // 
            // ToastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.IbMessage);
            this.Controls.Add(this.IbType);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.ToastBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastForm";
            this.Text = "Toastform";
            this.Load += new System.EventHandler(this.ToastForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ToastBorder;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label IbType;
        private System.Windows.Forms.Label IbMessage;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastHide;
    }
}