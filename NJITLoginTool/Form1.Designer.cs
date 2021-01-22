
namespace NJITLoginTool
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
            this.finPannel = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cliver = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.devid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.devmodel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sysver = new System.Windows.Forms.TextBox();
            this.sysname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.locationName = new System.Windows.Forms.TextBox();
            this.Location = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.desKey = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stuid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpd_ext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CAS = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.finPannel.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // finPannel
            // 
            this.finPannel.Controls.Add(this.groupBox5);
            this.finPannel.Controls.Add(this.groupBox4);
            this.finPannel.Controls.Add(this.groupBox3);
            this.finPannel.Controls.Add(this.res);
            this.finPannel.Controls.Add(this.groupBox2);
            this.finPannel.Controls.Add(this.groupBox1);
            this.finPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finPannel.Location = new System.Drawing.Point(0, 0);
            this.finPannel.Name = "finPannel";
            this.finPannel.Size = new System.Drawing.Size(886, 522);
            this.finPannel.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.cliver);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.devid);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.devmodel);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.sysver);
            this.groupBox5.Controls.Add(this.sysname);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(12, 215);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(862, 91);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "设备和客户端识别信息";
            // 
            // cliver
            // 
            this.cliver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cliver.Location = new System.Drawing.Point(43, 52);
            this.cliver.Name = "cliver";
            this.cliver.Size = new System.Drawing.Size(196, 25);
            this.cliver.TabIndex = 9;
            this.cliver.Text = "8.2.17";
            this.cliver.TextChanged += new System.EventHandler(this.stuid_TextChanged);
            this.cliver.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ver.";
            // 
            // devid
            // 
            this.devid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.devid.Location = new System.Drawing.Point(480, 18);
            this.devid.Name = "devid";
            this.devid.Size = new System.Drawing.Size(376, 25);
            this.devid.TabIndex = 7;
            this.devid.Text = "Mi 11 Pro";
            this.devid.TextChanged += new System.EventHandler(this.stuid_TextChanged);
            this.devid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "UUID";
            // 
            // devmodel
            // 
            this.devmodel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.devmodel.Location = new System.Drawing.Point(322, 18);
            this.devmodel.Name = "devmodel";
            this.devmodel.Size = new System.Drawing.Size(83, 25);
            this.devmodel.TabIndex = 5;
            this.devmodel.Text = "Mi 11 Pro";
            this.devmodel.TextChanged += new System.EventHandler(this.stuid_TextChanged);
            this.devmodel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Model";
            // 
            // sysver
            // 
            this.sysver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sysver.Location = new System.Drawing.Point(144, 18);
            this.sysver.Name = "sysver";
            this.sysver.Size = new System.Drawing.Size(95, 25);
            this.sysver.TabIndex = 3;
            this.sysver.Text = "10";
            this.sysver.TextChanged += new System.EventHandler(this.stuid_TextChanged);
            this.sysver.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // sysname
            // 
            this.sysname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sysname.Location = new System.Drawing.Point(43, 18);
            this.sysname.Name = "sysname";
            this.sysname.Size = new System.Drawing.Size(95, 25);
            this.sysname.TabIndex = 2;
            this.sysname.Text = "android";
            this.sysname.TextChanged += new System.EventHandler(this.stuid_TextChanged);
            this.sysname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sys";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.locationName);
            this.groupBox4.Controls.Add(this.Location);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(334, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 90);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "位置信息";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "详细地址";
            // 
            // locationName
            // 
            this.locationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationName.Location = new System.Drawing.Point(121, 57);
            this.locationName.Name = "locationName";
            this.locationName.Size = new System.Drawing.Size(413, 25);
            this.locationName.TabIndex = 2;
            this.locationName.Text = "南京工程学院(江宁校区)";
            this.locationName.TextChanged += new System.EventHandler(this.stuid_TextChanged);
            this.locationName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // Location
            // 
            this.Location.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Location.Location = new System.Drawing.Point(121, 24);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(413, 25);
            this.Location.TabIndex = 1;
            this.Location.Text = "31.928509,118.887844";
            this.Location.TextChanged += new System.EventHandler(this.stuid_TextChanged);
            this.Location.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "坐标(Lat,Lng)";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.desKey);
            this.groupBox3.Location = new System.Drawing.Point(661, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 101);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "基准加密常量";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 30);
            this.label11.TabIndex = 2;
            this.label11.Text = "用于通讯加密，很重要\r\n如果不知道这是什么，请别改";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "DES Key";
            // 
            // desKey
            // 
            this.desKey.Location = new System.Drawing.Point(75, 24);
            this.desKey.Name = "desKey";
            this.desKey.Size = new System.Drawing.Size(132, 25);
            this.desKey.TabIndex = 0;
            this.desKey.Text = "b3L26XNL";
            this.desKey.TextChanged += new System.EventHandler(this.stuid_TextChanged);
            this.desKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // res
            // 
            this.res.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.res.Location = new System.Drawing.Point(12, 312);
            this.res.Name = "res";
            this.res.ReadOnly = true;
            this.res.Size = new System.Drawing.Size(862, 198);
            this.res.TabIndex = 2;
            this.res.Text = "";
            this.res.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.stuid);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户信息";
            // 
            // stuid
            // 
            this.stuid.Location = new System.Drawing.Point(49, 31);
            this.stuid.Name = "stuid";
            this.stuid.Size = new System.Drawing.Size(251, 25);
            this.stuid.TabIndex = 1;
            this.stuid.TextChanged += new System.EventHandler(this.stuid_TextChanged);
            this.stuid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "学号";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cpd_ext);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CAS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "加密/认证信息";
            // 
            // cpd_ext
            // 
            this.cpd_ext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpd_ext.Location = new System.Drawing.Point(155, 64);
            this.cpd_ext.Name = "cpd_ext";
            this.cpd_ext.ReadOnly = true;
            this.cpd_ext.Size = new System.Drawing.Size(482, 25);
            this.cpd_ext.TabIndex = 3;
            this.cpd_ext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cpdaily-Extension";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOD_AUTH_CAS";
            // 
            // CAS
            // 
            this.CAS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CAS.Location = new System.Drawing.Point(155, 24);
            this.CAS.Name = "CAS";
            this.CAS.ReadOnly = true;
            this.CAS.Size = new System.Drawing.Size(482, 25);
            this.CAS.TabIndex = 0;
            this.CAS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "account.private";
            this.saveFileDialog1.Filter = "用户授权文件|account.private";
            this.saveFileDialog1.Title = "选择保存授权文件的位置";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 522);
            this.Controls.Add(this.finPannel);
            this.Name = "Form1";
            this.Text = "NJIT签到助手 账号登录工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.finPannel.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel finPannel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CAS;
        private System.Windows.Forms.TextBox cpd_ext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox desKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stuid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox locationName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox sysname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sysver;
        private System.Windows.Forms.TextBox devmodel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox devid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cliver;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

