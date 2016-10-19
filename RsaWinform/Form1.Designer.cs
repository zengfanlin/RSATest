namespace RsaWinform
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
            this.txtPK = new System.Windows.Forms.TextBox();
            this.txtSK = new System.Windows.Forms.TextBox();
            this.txtContext = new System.Windows.Forms.TextBox();
            this.txtSed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDsed = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnDs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPK
            // 
            this.txtPK.Location = new System.Drawing.Point(472, 12);
            this.txtPK.Multiline = true;
            this.txtPK.Name = "txtPK";
            this.txtPK.Size = new System.Drawing.Size(689, 80);
            this.txtPK.TabIndex = 0;
            // 
            // txtSK
            // 
            this.txtSK.Location = new System.Drawing.Point(472, 115);
            this.txtSK.Multiline = true;
            this.txtSK.Name = "txtSK";
            this.txtSK.Size = new System.Drawing.Size(689, 158);
            this.txtSK.TabIndex = 1;
            // 
            // txtContext
            // 
            this.txtContext.Location = new System.Drawing.Point(472, 279);
            this.txtContext.Multiline = true;
            this.txtContext.Name = "txtContext";
            this.txtContext.Size = new System.Drawing.Size(689, 67);
            this.txtContext.TabIndex = 2;
            // 
            // txtSed
            // 
            this.txtSed.Location = new System.Drawing.Point(472, 352);
            this.txtSed.Multiline = true;
            this.txtSed.Name = "txtSed";
            this.txtSed.Size = new System.Drawing.Size(689, 68);
            this.txtSed.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(258, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "公钥(用于解密)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(258, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "私钥(用于加密)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(270, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "要加密的内容";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(306, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "加密后";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(321, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "解密";
            // 
            // txtDsed
            // 
            this.txtDsed.Location = new System.Drawing.Point(472, 439);
            this.txtDsed.Multiline = true;
            this.txtDsed.Name = "txtDsed";
            this.txtDsed.Size = new System.Drawing.Size(689, 68);
            this.txtDsed.TabIndex = 8;
            // 
            // btnGen
            // 
            this.btnGen.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGen.Location = new System.Drawing.Point(54, 46);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(162, 46);
            this.btnGen.TabIndex = 10;
            this.btnGen.Text = "生成密钥";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("宋体", 12F);
            this.btnS.Location = new System.Drawing.Point(54, 311);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(162, 46);
            this.btnS.TabIndex = 11;
            this.btnS.Text = "用私钥加密";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnDs
            // 
            this.btnDs.Font = new System.Drawing.Font("宋体", 12F);
            this.btnDs.Location = new System.Drawing.Point(54, 456);
            this.btnDs.Name = "btnDs";
            this.btnDs.Size = new System.Drawing.Size(162, 46);
            this.btnDs.TabIndex = 12;
            this.btnDs.Text = "用公钥解密";
            this.btnDs.UseVisualStyleBackColor = true;
            this.btnDs.Click += new System.EventHandler(this.btnDs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 547);
            this.Controls.Add(this.btnDs);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDsed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSed);
            this.Controls.Add(this.txtContext);
            this.Controls.Add(this.txtSK);
            this.Controls.Add(this.txtPK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPK;
        private System.Windows.Forms.TextBox txtSK;
        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.TextBox txtSed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDsed;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnDs;
    }
}

