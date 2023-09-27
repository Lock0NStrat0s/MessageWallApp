namespace MessageWall
{
    partial class Dashboard
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
            this._lblMessage = new System.Windows.Forms.Label();
            this._txtbMessage = new System.Windows.Forms.TextBox();
            this._lstbMessages = new System.Windows.Forms.ListBox();
            this._lblListBoxMessages = new System.Windows.Forms.Label();
            this._btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblMessage
            // 
            this._lblMessage.AutoSize = true;
            this._lblMessage.Location = new System.Drawing.Point(120, 62);
            this._lblMessage.Name = "_lblMessage";
            this._lblMessage.Size = new System.Drawing.Size(135, 36);
            this._lblMessage.TabIndex = 0;
            this._lblMessage.Text = "Message";
            // 
            // _txtbMessage
            // 
            this._txtbMessage.Location = new System.Drawing.Point(272, 57);
            this._txtbMessage.Name = "_txtbMessage";
            this._txtbMessage.Size = new System.Drawing.Size(444, 41);
            this._txtbMessage.TabIndex = 1;
            // 
            // _lstbMessages
            // 
            this._lstbMessages.FormattingEnabled = true;
            this._lstbMessages.ItemHeight = 36;
            this._lstbMessages.Location = new System.Drawing.Point(126, 194);
            this._lstbMessages.Name = "_lstbMessages";
            this._lstbMessages.Size = new System.Drawing.Size(589, 508);
            this._lstbMessages.TabIndex = 3;
            // 
            // _lblListBoxMessages
            // 
            this._lblListBoxMessages.AutoSize = true;
            this._lblListBoxMessages.Location = new System.Drawing.Point(120, 155);
            this._lblListBoxMessages.Name = "_lblListBoxMessages";
            this._lblListBoxMessages.Size = new System.Drawing.Size(150, 36);
            this._lblListBoxMessages.TabIndex = 3;
            this._lblListBoxMessages.Text = "Messages";
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(774, 57);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(154, 68);
            this._btnAdd.TabIndex = 2;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 735);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._lblListBoxMessages);
            this.Controls.Add(this._lstbMessages);
            this.Controls.Add(this._txtbMessage);
            this.Controls.Add(this._lblMessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblMessage;
        private System.Windows.Forms.TextBox _txtbMessage;
        private System.Windows.Forms.ListBox _lstbMessages;
        private System.Windows.Forms.Label _lblListBoxMessages;
        private System.Windows.Forms.Button _btnAdd;
    }
}

