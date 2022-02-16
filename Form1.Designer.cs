
namespace webSocketChat
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
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_IpAdress = new System.Windows.Forms.TextBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_UploadArchive = new System.Windows.Forms.Button();
            this.txt_ChatMessages = new System.Windows.Forms.RichTextBox();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label_IpAdress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(402, 6);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(154, 27);
            this.txt_User.TabIndex = 18;
            // 
            // txt_IpAdress
            // 
            this.txt_IpAdress.Location = new System.Drawing.Point(112, 6);
            this.txt_IpAdress.Name = "txt_IpAdress";
            this.txt_IpAdress.Size = new System.Drawing.Size(203, 27);
            this.txt_IpAdress.TabIndex = 17;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(330, 9);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(66, 20);
            this.lbl_User.TabIndex = 16;
            this.lbl_User.Text = "Usuário :";
            // 
            // btn_UploadArchive
            // 
            this.btn_UploadArchive.Location = new System.Drawing.Point(864, 519);
            this.btn_UploadArchive.Name = "btn_UploadArchive";
            this.btn_UploadArchive.Size = new System.Drawing.Size(139, 29);
            this.btn_UploadArchive.TabIndex = 15;
            this.btn_UploadArchive.Text = "Enviar Arquivo";
            this.btn_UploadArchive.UseVisualStyleBackColor = true;
            // 
            // txt_ChatMessages
            // 
            this.txt_ChatMessages.Location = new System.Drawing.Point(12, 53);
            this.txt_ChatMessages.Name = "txt_ChatMessages";
            this.txt_ChatMessages.Size = new System.Drawing.Size(975, 444);
            this.txt_ChatMessages.TabIndex = 14;
            this.txt_ChatMessages.Text = "";
            // 
            // btn_SendMessage
            // 
            this.btn_SendMessage.Location = new System.Drawing.Point(750, 519);
            this.btn_SendMessage.Name = "btn_SendMessage";
            this.btn_SendMessage.Size = new System.Drawing.Size(94, 29);
            this.btn_SendMessage.TabIndex = 13;
            this.btn_SendMessage.Text = "Enviar";
            this.btn_SendMessage.UseVisualStyleBackColor = true;
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(12, 520);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(721, 27);
            this.txt_Message.TabIndex = 12;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(574, 9);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(94, 29);
            this.btn_Connect.TabIndex = 11;
            this.btn_Connect.Text = "Conectar";
            this.btn_Connect.UseVisualStyleBackColor = true;
            // 
            // label_IpAdress
            // 
            this.label_IpAdress.AutoSize = true;
            this.label_IpAdress.Location = new System.Drawing.Point(12, 9);
            this.label_IpAdress.Name = "label_IpAdress";
            this.label_IpAdress.Size = new System.Drawing.Size(94, 20);
            this.label_IpAdress.TabIndex = 10;
            this.label_IpAdress.Text = "Endereço IP :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 585);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.txt_IpAdress);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.btn_UploadArchive);
            this.Controls.Add(this.txt_ChatMessages);
            this.Controls.Add(this.btn_SendMessage);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.label_IpAdress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_IpAdress;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_UploadArchive;
        private System.Windows.Forms.RichTextBox txt_ChatMessages;
        private System.Windows.Forms.Button btn_SendMessage;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label_IpAdress;
    }
}

