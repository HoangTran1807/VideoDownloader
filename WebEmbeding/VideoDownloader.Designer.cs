namespace WebEmbeding
{
    partial class VideoDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoDownloader));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_footer = new System.Windows.Forms.Panel();
            this.pn_web = new System.Windows.Forms.Panel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pn_control = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_save_dir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_format = new System.Windows.Forms.ComboBox();
            this.lb_url = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbt_full = new System.Windows.Forms.RadioButton();
            this.rbt_videoOnly = new System.Windows.Forms.RadioButton();
            this.rbt_audioOnly = new System.Windows.Forms.RadioButton();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.btn_dowload = new System.Windows.Forms.Button();
            this.btn_downloadSegment = new System.Windows.Forms.Button();
            this.btn_nextPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_prePage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pn_web.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.pn_control.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pn_footer);
            this.panel1.Controls.Add(this.pn_web);
            this.panel1.Controls.Add(this.pn_control);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 633);
            this.panel1.TabIndex = 0;
            // 
            // pn_footer
            // 
            this.pn_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_footer.Location = new System.Drawing.Point(0, 622);
            this.pn_footer.Name = "pn_footer";
            this.pn_footer.Size = new System.Drawing.Size(1333, 11);
            this.pn_footer.TabIndex = 2;
            // 
            // pn_web
            // 
            this.pn_web.Controls.Add(this.webView21);
            this.pn_web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_web.Location = new System.Drawing.Point(0, 100);
            this.pn_web.Name = "pn_web";
            this.pn_web.Size = new System.Drawing.Size(1333, 533);
            this.pn_web.TabIndex = 1;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1333, 533);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // pn_control
            // 
            this.pn_control.Controls.Add(this.panel3);
            this.pn_control.Controls.Add(this.panel2);
            this.pn_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_control.Location = new System.Drawing.Point(0, 0);
            this.pn_control.Name = "pn_control";
            this.pn_control.Size = new System.Drawing.Size(1333, 100);
            this.pn_control.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_filename);
            this.panel3.Controls.Add(this.btn_check);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_save_dir);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbx_format);
            this.panel3.Controls.Add(this.lb_url);
            this.panel3.Controls.Add(this.txt_url);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 100);
            this.panel3.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Save Name";
            // 
            // txt_filename
            // 
            this.txt_filename.Location = new System.Drawing.Point(448, 60);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.Size = new System.Drawing.Size(208, 22);
            this.txt_filename.TabIndex = 28;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(581, 14);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 27;
            this.btn_check.Text = "check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Save Dir";
            // 
            // txt_save_dir
            // 
            this.txt_save_dir.Location = new System.Drawing.Point(119, 55);
            this.txt_save_dir.Name = "txt_save_dir";
            this.txt_save_dir.ReadOnly = true;
            this.txt_save_dir.Size = new System.Drawing.Size(195, 22);
            this.txt_save_dir.TabIndex = 25;
            this.txt_save_dir.Click += new System.EventHandler(this.txt_save_dir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Video Format";
            // 
            // cbx_format
            // 
            this.cbx_format.FormattingEnabled = true;
            this.cbx_format.Location = new System.Drawing.Point(448, 14);
            this.cbx_format.Name = "cbx_format";
            this.cbx_format.Size = new System.Drawing.Size(118, 24);
            this.cbx_format.TabIndex = 23;
            // 
            // lb_url
            // 
            this.lb_url.AutoSize = true;
            this.lb_url.Location = new System.Drawing.Point(12, 17);
            this.lb_url.Name = "lb_url";
            this.lb_url.Size = new System.Drawing.Size(34, 16);
            this.lb_url.TabIndex = 22;
            this.lb_url.Text = "URL";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(119, 15);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(195, 22);
            this.txt_url.TabIndex = 21;
            this.txt_url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_url_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbt_full);
            this.panel2.Controls.Add(this.rbt_videoOnly);
            this.panel2.Controls.Add(this.rbt_audioOnly);
            this.panel2.Controls.Add(this.txt_end);
            this.panel2.Controls.Add(this.txt_start);
            this.panel2.Controls.Add(this.btn_dowload);
            this.panel2.Controls.Add(this.btn_downloadSegment);
            this.panel2.Controls.Add(this.btn_nextPage);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_prePage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(669, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 100);
            this.panel2.TabIndex = 14;
            // 
            // rbt_full
            // 
            this.rbt_full.AutoSize = true;
            this.rbt_full.Checked = true;
            this.rbt_full.Location = new System.Drawing.Point(20, 14);
            this.rbt_full.Name = "rbt_full";
            this.rbt_full.Size = new System.Drawing.Size(49, 20);
            this.rbt_full.TabIndex = 27;
            this.rbt_full.TabStop = true;
            this.rbt_full.Text = "Full";
            this.rbt_full.UseVisualStyleBackColor = true;
            this.rbt_full.Visible = false;
            // 
            // rbt_videoOnly
            // 
            this.rbt_videoOnly.AutoSize = true;
            this.rbt_videoOnly.Location = new System.Drawing.Point(20, 71);
            this.rbt_videoOnly.Name = "rbt_videoOnly";
            this.rbt_videoOnly.Size = new System.Drawing.Size(94, 20);
            this.rbt_videoOnly.TabIndex = 25;
            this.rbt_videoOnly.Text = "Video Only";
            this.rbt_videoOnly.UseVisualStyleBackColor = true;
            this.rbt_videoOnly.Visible = false;
            // 
            // rbt_audioOnly
            // 
            this.rbt_audioOnly.AutoSize = true;
            this.rbt_audioOnly.Location = new System.Drawing.Point(20, 42);
            this.rbt_audioOnly.Name = "rbt_audioOnly";
            this.rbt_audioOnly.Size = new System.Drawing.Size(93, 20);
            this.rbt_audioOnly.TabIndex = 24;
            this.rbt_audioOnly.Text = "Audio Only";
            this.rbt_audioOnly.UseVisualStyleBackColor = true;
            this.rbt_audioOnly.Visible = false;
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(315, 57);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(85, 22);
            this.txt_end.TabIndex = 23;
            this.txt_end.Validated += new System.EventHandler(this.txt_end_Validated);
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(315, 22);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(85, 22);
            this.txt_start.TabIndex = 22;
            this.txt_start.Validated += new System.EventHandler(this.txt_start_Validated);
            // 
            // btn_dowload
            // 
            this.btn_dowload.Location = new System.Drawing.Point(178, 22);
            this.btn_dowload.Name = "btn_dowload";
            this.btn_dowload.Size = new System.Drawing.Size(78, 60);
            this.btn_dowload.TabIndex = 5;
            this.btn_dowload.Text = "Dowload Full";
            this.btn_dowload.UseVisualStyleBackColor = true;
            this.btn_dowload.Click += new System.EventHandler(this.btn_dowload_Click);
            // 
            // btn_downloadSegment
            // 
            this.btn_downloadSegment.Location = new System.Drawing.Point(415, 22);
            this.btn_downloadSegment.Name = "btn_downloadSegment";
            this.btn_downloadSegment.Size = new System.Drawing.Size(85, 61);
            this.btn_downloadSegment.TabIndex = 10;
            this.btn_downloadSegment.Text = "Dowload Segment";
            this.btn_downloadSegment.UseVisualStyleBackColor = true;
            this.btn_downloadSegment.Click += new System.EventHandler(this.btn_downloadSegment_Click);
            // 
            // btn_nextPage
            // 
            this.btn_nextPage.Location = new System.Drawing.Point(521, 13);
            this.btn_nextPage.Name = "btn_nextPage";
            this.btn_nextPage.Size = new System.Drawing.Size(99, 36);
            this.btn_nextPage.TabIndex = 3;
            this.btn_nextPage.Text = "Go Foward";
            this.btn_nextPage.UseVisualStyleBackColor = true;
            this.btn_nextPage.Click += new System.EventHandler(this.btn_nextPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "end";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "start";
            // 
            // btn_prePage
            // 
            this.btn_prePage.Location = new System.Drawing.Point(521, 51);
            this.btn_prePage.Name = "btn_prePage";
            this.btn_prePage.Size = new System.Drawing.Size(99, 36);
            this.btn_prePage.TabIndex = 4;
            this.btn_prePage.Text = "Go back";
            this.btn_prePage.UseVisualStyleBackColor = true;
            this.btn_prePage.Click += new System.EventHandler(this.btn_prePage_Click);
            // 
            // VideoDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 633);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VideoDownloader";
            this.Text = "Video Downloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoDownloader_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pn_web.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.pn_control.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_web;
        private System.Windows.Forms.Panel pn_control;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Panel pn_footer;
        private System.Windows.Forms.Button btn_dowload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_downloadSegment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_save_dir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_format;
        private System.Windows.Forms.Label lb_url;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_nextPage;
        private System.Windows.Forms.Button btn_prePage;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.TextBox txt_start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.RadioButton rbt_videoOnly;
        private System.Windows.Forms.RadioButton rbt_audioOnly;
        private System.Windows.Forms.RadioButton rbt_full;
    }
}

