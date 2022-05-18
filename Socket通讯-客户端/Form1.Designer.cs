namespace Socket通讯_客户端
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textMsg = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Port = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(13, 154);
            this.textMsg.Multiline = true;
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(314, 68);
            this.textMsg.TabIndex = 13;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 11);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(405, 116);
            this.txtLog.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "IP地址：";
            // 
            // text_ip
            // 
            this.text_ip.Location = new System.Drawing.Point(77, 406);
            this.text_ip.Name = "text_ip";
            this.text_ip.Size = new System.Drawing.Size(155, 21);
            this.text_ip.TabIndex = 10;
            this.text_ip.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "端口：";
            // 
            // text_Port
            // 
            this.text_Port.Location = new System.Drawing.Point(297, 404);
            this.text_Port.Name = "text_Port";
            this.text_Port.Size = new System.Drawing.Size(100, 21);
            this.text_Port.TabIndex = 8;
            this.text_Port.Text = "9500";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(430, 404);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_send.Location = new System.Drawing.Point(342, 154);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 68);
            this.btn_send.TabIndex = 14;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 438);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_ip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Port);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "客户端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Port;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_send;
    }
}

