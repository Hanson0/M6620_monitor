namespace Production.AllForms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.picFormMainHeader = new System.Windows.Forms.PictureBox();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.txtYeild = new System.Windows.Forms.TextBox();
            this.lblYeild = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改计划单号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息看板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEid = new System.Windows.Forms.Label();
            this.txtEid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFormMainHeader)).BeginInit();
            this.grpResult.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFormMainHeader
            // 
            this.picFormMainHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFormMainHeader.Location = new System.Drawing.Point(7, 31);
            this.picFormMainHeader.Margin = new System.Windows.Forms.Padding(2);
            this.picFormMainHeader.Name = "picFormMainHeader";
            this.picFormMainHeader.Size = new System.Drawing.Size(260, 195);
            this.picFormMainHeader.TabIndex = 130;
            this.picFormMainHeader.TabStop = false;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.txtYeild);
            this.grpResult.Controls.Add(this.lblYeild);
            this.grpResult.Controls.Add(this.lblClear);
            this.grpResult.Controls.Add(this.txtTotal);
            this.grpResult.Controls.Add(this.btnClear);
            this.grpResult.Controls.Add(this.txtFail);
            this.grpResult.Controls.Add(this.txtPass);
            this.grpResult.Controls.Add(this.lblTotal);
            this.grpResult.Controls.Add(this.lblFail);
            this.grpResult.Controls.Add(this.lblPass);
            this.grpResult.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpResult.ForeColor = System.Drawing.Color.Green;
            this.grpResult.Location = new System.Drawing.Point(7, 249);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(260, 220);
            this.grpResult.TabIndex = 131;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            // 
            // txtYeild
            // 
            this.txtYeild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtYeild.Location = new System.Drawing.Point(107, 147);
            this.txtYeild.Name = "txtYeild";
            this.txtYeild.ReadOnly = true;
            this.txtYeild.Size = new System.Drawing.Size(142, 35);
            this.txtYeild.TabIndex = 25;
            this.txtYeild.Text = "0";
            // 
            // lblYeild
            // 
            this.lblYeild.AutoSize = true;
            this.lblYeild.Location = new System.Drawing.Point(5, 147);
            this.lblYeild.Name = "lblYeild";
            this.lblYeild.Size = new System.Drawing.Size(82, 24);
            this.lblYeild.TabIndex = 24;
            this.lblYeild.Text = "RATE :";
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Location = new System.Drawing.Point(5, 185);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(82, 24);
            this.lblClear.TabIndex = 23;
            this.lblClear.Text = "CLEAR:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(107, 108);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(142, 35);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 15F);
            this.btnClear.Location = new System.Drawing.Point(106, 186);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 30);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "清零";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtFail
            // 
            this.txtFail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtFail.Location = new System.Drawing.Point(107, 69);
            this.txtFail.Name = "txtFail";
            this.txtFail.ReadOnly = true;
            this.txtFail.Size = new System.Drawing.Size(142, 35);
            this.txtFail.TabIndex = 4;
            this.txtFail.Text = "0";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPass.Location = new System.Drawing.Point(106, 30);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(143, 35);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(5, 109);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 24);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblFail
            // 
            this.lblFail.AutoSize = true;
            this.lblFail.Location = new System.Drawing.Point(6, 71);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(82, 24);
            this.lblFail.TabIndex = 1;
            this.lblFail.Text = "FAIL :";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(6, 33);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(82, 24);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "PASS :";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLog.Location = new System.Drawing.Point(286, 94);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(425, 384);
            this.txtLog.TabIndex = 133;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 29);
            this.menuStrip1.TabIndex = 135;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更改计划单号ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.设置ToolStripMenuItem.Text = "工具";
            // 
            // 更改计划单号ToolStripMenuItem
            // 
            this.更改计划单号ToolStripMenuItem.Name = "更改计划单号ToolStripMenuItem";
            this.更改计划单号ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.更改计划单号ToolStripMenuItem.Text = "更改计划单号";
            this.更改计划单号ToolStripMenuItem.Click += new System.EventHandler(this.更改计划单号ToolStripMenuItem_Click);
            // 
            // 信息ToolStripMenuItem
            // 
            this.信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息看板ToolStripMenuItem});
            this.信息ToolStripMenuItem.Name = "信息ToolStripMenuItem";
            this.信息ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.信息ToolStripMenuItem.Text = "信息";
            this.信息ToolStripMenuItem.Click += new System.EventHandler(this.信息ToolStripMenuItem_Click);
            // 
            // 信息看板ToolStripMenuItem
            // 
            this.信息看板ToolStripMenuItem.Name = "信息看板ToolStripMenuItem";
            this.信息看板ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.信息看板ToolStripMenuItem.Text = "信息看板";
            this.信息看板ToolStripMenuItem.Click += new System.EventHandler(this.信息看板ToolStripMenuItem_Click);
            // 
            // lblEid
            // 
            this.lblEid.AutoSize = true;
            this.lblEid.BackColor = System.Drawing.Color.White;
            this.lblEid.Font = new System.Drawing.Font("宋体", 30F);
            this.lblEid.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblEid.Location = new System.Drawing.Point(316, 41);
            this.lblEid.Name = "lblEid";
            this.lblEid.Size = new System.Drawing.Size(77, 40);
            this.lblEid.TabIndex = 126;
            this.lblEid.Text = "EID";
            this.lblEid.Click += new System.EventHandler(this.lblImei_Click);
            // 
            // txtEid
            // 
            this.txtEid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEid.BackColor = System.Drawing.Color.White;
            this.txtEid.Font = new System.Drawing.Font("宋体", 30F);
            this.txtEid.Location = new System.Drawing.Point(286, 35);
            this.txtEid.Name = "txtEid";
            this.txtEid.Size = new System.Drawing.Size(425, 53);
            this.txtEid.TabIndex = 122;
            this.txtEid.TextChanged += new System.EventHandler(this.txtEid_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 486);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.picFormMainHeader);
            this.Controls.Add(this.lblEid);
            this.Controls.Add(this.txtEid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M6620_monitor_V1.2.9Beta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picFormMainHeader)).EndInit();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picFormMainHeader;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.TextBox txtYeild;
        private System.Windows.Forms.Label lblYeild;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtFail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改计划单号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息看板ToolStripMenuItem;
        private System.Windows.Forms.Label lblEid;
        private System.Windows.Forms.TextBox txtEid;
    }
}

