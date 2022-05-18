namespace Socket通讯
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
            this.btn_start = new System.Windows.Forms.Button();
            this.text_Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_ip = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.connected_Client = new System.Windows.Forms.ComboBox();
            this.btn_shake = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.text_Path = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(434, 332);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "开始监听";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // text_Port
            // 
            this.text_Port.Location = new System.Drawing.Point(329, 334);
            this.text_Port.Name = "text_Port";
            this.text_Port.Size = new System.Drawing.Size(74, 21);
            this.text_Port.TabIndex = 1;
            this.text_Port.Text = "9500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "端口：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP地址：";
            // 
            // text_ip
            // 
            this.text_ip.Location = new System.Drawing.Point(80, 338);
            this.text_ip.Name = "text_ip";
            this.text_ip.Size = new System.Drawing.Size(196, 21);
            this.text_ip.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 22);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(497, 116);
            this.txtLog.TabIndex = 5;
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(12, 196);
            this.textMsg.Multiline = true;
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(391, 68);
            this.textMsg.TabIndex = 6;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_send.Location = new System.Drawing.Point(434, 196);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 68);
            this.btn_send.TabIndex = 15;
            this.btn_send.Text = "发送消息";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "已连接的客户端：";
            // 
            // connected_Client
            // 
            this.connected_Client.FormattingEnabled = true;
            this.connected_Client.Location = new System.Drawing.Point(115, 160);
            this.connected_Client.Name = "connected_Client";
            this.connected_Client.Size = new System.Drawing.Size(288, 20);
            this.connected_Client.TabIndex = 16;
            // 
            // btn_shake
            // 
            this.btn_shake.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_shake.Location = new System.Drawing.Point(434, 149);
            this.btn_shake.Name = "btn_shake";
            this.btn_shake.Size = new System.Drawing.Size(75, 36);
            this.btn_shake.TabIndex = 17;
            this.btn_shake.Text = "震动";
            this.btn_shake.UseVisualStyleBackColor = true;
            this.btn_shake.Click += new System.EventHandler(this.Btn_shake_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Select.Location = new System.Drawing.Point(319, 285);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(84, 32);
            this.btn_Select.TabIndex = 18;
            this.btn_Select.Text = "选择文件";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SendFile.Location = new System.Drawing.Point(421, 285);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(88, 32);
            this.btn_SendFile.TabIndex = 19;
            this.btn_SendFile.Text = "发送文件";
            this.btn_SendFile.UseVisualStyleBackColor = true;
            this.btn_SendFile.Click += new System.EventHandler(this.Button3_Click);
            // 
            // text_Path
            // 
            this.text_Path.Location = new System.Drawing.Point(12, 285);
            this.text_Path.Multiline = true;
            this.text_Path.Name = "text_Path";
            this.text_Path.Size = new System.Drawing.Size(287, 32);
            this.text_Path.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 382);
            this.Controls.Add(this.text_Path);
            this.Controls.Add(this.btn_SendFile);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_shake);
            this.Controls.Add(this.connected_Client);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_ip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Port);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "服务器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox text_Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_ip;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox connected_Client;
        private System.Windows.Forms.Button btn_shake;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_SendFile;
        private System.Windows.Forms.TextBox text_Path;
    }
}

