
namespace stockmanagmentapp
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.titlebar = new System.Windows.Forms.Panel();
            this.maxbtn = new FontAwesome.Sharp.IconPictureBox();
            this.minimizebtn = new FontAwesome.Sharp.IconPictureBox();
            this.closebtn = new FontAwesome.Sharp.IconPictureBox();
            this.currenttitle = new System.Windows.Forms.Label();
            this.currenttitleicon = new FontAwesome.Sharp.IconPictureBox();
            this.homepanel = new System.Windows.Forms.Panel();
            this.panel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.alertbutton = new FontAwesome.Sharp.IconButton();
            this.customerbutton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homebtn = new System.Windows.Forms.PictureBox();
            this.exitbutton = new FontAwesome.Sharp.IconButton();
            this.productbutton = new FontAwesome.Sharp.IconButton();
            this.salesbutton = new FontAwesome.Sharp.IconButton();
            this.categorybutton = new FontAwesome.Sharp.IconButton();
            this.addstockbutton = new FontAwesome.Sharp.IconButton();
            this.titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenttitleicon)).BeginInit();
            this.homepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.titlebar.Controls.Add(this.maxbtn);
            this.titlebar.Controls.Add(this.minimizebtn);
            this.titlebar.Controls.Add(this.closebtn);
            this.titlebar.Controls.Add(this.currenttitle);
            this.titlebar.Controls.Add(this.currenttitleicon);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(250, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(971, 93);
            this.titlebar.TabIndex = 3;
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebar_MouseDown);
            // 
            // maxbtn
            // 
            this.maxbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(69)))));
            this.maxbtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maxbtn.IconColor = System.Drawing.Color.White;
            this.maxbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maxbtn.IconSize = 20;
            this.maxbtn.Location = new System.Drawing.Point(931, 0);
            this.maxbtn.Margin = new System.Windows.Forms.Padding(0);
            this.maxbtn.Name = "maxbtn";
            this.maxbtn.Size = new System.Drawing.Size(20, 20);
            this.maxbtn.TabIndex = 5;
            this.maxbtn.TabStop = false;
            this.maxbtn.Click += new System.EventHandler(this.maxbtn_Click);
            this.maxbtn.MouseLeave += new System.EventHandler(this.maxbtn_MouseLeave);
            this.maxbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.maxbtn_MouseMove);
            // 
            // minimizebtn
            // 
            this.minimizebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(69)))));
            this.minimizebtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizebtn.IconColor = System.Drawing.Color.White;
            this.minimizebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizebtn.IconSize = 20;
            this.minimizebtn.Location = new System.Drawing.Point(911, 0);
            this.minimizebtn.Margin = new System.Windows.Forms.Padding(0);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(20, 20);
            this.minimizebtn.TabIndex = 4;
            this.minimizebtn.TabStop = false;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            this.minimizebtn.MouseLeave += new System.EventHandler(this.minimizebtn_MouseLeave);
            this.minimizebtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.minimizebtn_MouseMove);
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(69)))));
            this.closebtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.closebtn.IconColor = System.Drawing.Color.White;
            this.closebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closebtn.IconSize = 20;
            this.closebtn.Location = new System.Drawing.Point(951, 0);
            this.closebtn.Margin = new System.Windows.Forms.Padding(0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(20, 20);
            this.closebtn.TabIndex = 2;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            this.closebtn.MouseLeave += new System.EventHandler(this.closebtn_MouseLeave);
            this.closebtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.closebtn_MouseMove);
            // 
            // currenttitle
            // 
            this.currenttitle.AutoSize = true;
            this.currenttitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currenttitle.Location = new System.Drawing.Point(85, 18);
            this.currenttitle.Margin = new System.Windows.Forms.Padding(0);
            this.currenttitle.Name = "currenttitle";
            this.currenttitle.Size = new System.Drawing.Size(85, 30);
            this.currenttitle.TabIndex = 1;
            this.currenttitle.Text = "Home";
            // 
            // currenttitleicon
            // 
            this.currenttitleicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.currenttitleicon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currenttitleicon.IconColor = System.Drawing.Color.White;
            this.currenttitleicon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currenttitleicon.IconSize = 43;
            this.currenttitleicon.Location = new System.Drawing.Point(40, 18);
            this.currenttitleicon.Margin = new System.Windows.Forms.Padding(0);
            this.currenttitleicon.Name = "currenttitleicon";
            this.currenttitleicon.Size = new System.Drawing.Size(45, 43);
            this.currenttitleicon.TabIndex = 0;
            this.currenttitleicon.TabStop = false;
            // 
            // homepanel
            // 
            this.homepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.homepanel.Controls.Add(this.titlebar);
            this.homepanel.Controls.Add(this.panel1);
            this.homepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homepanel.Location = new System.Drawing.Point(0, 0);
            this.homepanel.Name = "homepanel";
            this.homepanel.Size = new System.Drawing.Size(1221, 562);
            this.homepanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderRadius = 50;
            this.panel1.Controls.Add(this.alertbutton);
            this.panel1.Controls.Add(this.customerbutton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.exitbutton);
            this.panel1.Controls.Add(this.productbutton);
            this.panel1.Controls.Add(this.salesbutton);
            this.panel1.Controls.Add(this.categorybutton);
            this.panel1.Controls.Add(this.addstockbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Quality = 10;
            this.panel1.Size = new System.Drawing.Size(250, 562);
            this.panel1.TabIndex = 11;
            // 
            // alertbutton
            // 
            this.alertbutton.FlatAppearance.BorderSize = 0;
            this.alertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alertbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertbutton.ForeColor = System.Drawing.Color.White;
            this.alertbutton.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.alertbutton.IconColor = System.Drawing.Color.White;
            this.alertbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.alertbutton.IconSize = 30;
            this.alertbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alertbutton.Location = new System.Drawing.Point(-2, 413);
            this.alertbutton.Margin = new System.Windows.Forms.Padding(0);
            this.alertbutton.Name = "alertbutton";
            this.alertbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.alertbutton.Size = new System.Drawing.Size(250, 50);
            this.alertbutton.TabIndex = 11;
            this.alertbutton.Text = "Alerts";
            this.alertbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alertbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alertbutton.UseVisualStyleBackColor = true;
            this.alertbutton.Click += new System.EventHandler(this.alertbutton_Click);
            // 
            // customerbutton
            // 
            this.customerbutton.FlatAppearance.BorderSize = 0;
            this.customerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerbutton.ForeColor = System.Drawing.Color.White;
            this.customerbutton.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows;
            this.customerbutton.IconColor = System.Drawing.Color.White;
            this.customerbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customerbutton.IconSize = 30;
            this.customerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerbutton.Location = new System.Drawing.Point(0, 92);
            this.customerbutton.Margin = new System.Windows.Forms.Padding(0);
            this.customerbutton.Name = "customerbutton";
            this.customerbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.customerbutton.Size = new System.Drawing.Size(250, 55);
            this.customerbutton.TabIndex = 4;
            this.customerbutton.Text = "Customers";
            this.customerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customerbutton.UseVisualStyleBackColor = true;
            this.customerbutton.Click += new System.EventHandler(this.customerbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.homebtn);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 92);
            this.panel2.TabIndex = 2;
            // 
            // homebtn
            // 
            this.homebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homebtn.Image = global::stockmanagmentapp.Properties.Resources.logo3;
            this.homebtn.Location = new System.Drawing.Point(0, 0);
            this.homebtn.Margin = new System.Windows.Forms.Padding(0);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(250, 92);
            this.homebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homebtn.TabIndex = 0;
            this.homebtn.TabStop = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.White;
            this.exitbutton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.exitbutton.IconColor = System.Drawing.Color.White;
            this.exitbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitbutton.IconSize = 30;
            this.exitbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitbutton.Location = new System.Drawing.Point(-2, 477);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(0);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.exitbutton.Size = new System.Drawing.Size(250, 51);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.Text = "Exit";
            this.exitbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            this.exitbutton.MouseLeave += new System.EventHandler(this.exitbutton_MouseLeave);
            this.exitbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exitbutton_MouseMove);
            // 
            // productbutton
            // 
            this.productbutton.FlatAppearance.BorderSize = 0;
            this.productbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbutton.ForeColor = System.Drawing.Color.White;
            this.productbutton.IconChar = FontAwesome.Sharp.IconChar.TruckLoading;
            this.productbutton.IconColor = System.Drawing.Color.White;
            this.productbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productbutton.IconSize = 30;
            this.productbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productbutton.Location = new System.Drawing.Point(0, 156);
            this.productbutton.Margin = new System.Windows.Forms.Padding(0);
            this.productbutton.Name = "productbutton";
            this.productbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.productbutton.Size = new System.Drawing.Size(250, 55);
            this.productbutton.TabIndex = 5;
            this.productbutton.Text = "Product";
            this.productbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productbutton.UseVisualStyleBackColor = true;
            this.productbutton.Click += new System.EventHandler(this.productbutton_Click);
            // 
            // salesbutton
            // 
            this.salesbutton.FlatAppearance.BorderSize = 0;
            this.salesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesbutton.ForeColor = System.Drawing.Color.White;
            this.salesbutton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.salesbutton.IconColor = System.Drawing.Color.White;
            this.salesbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.salesbutton.IconSize = 30;
            this.salesbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesbutton.Location = new System.Drawing.Point(0, 219);
            this.salesbutton.Margin = new System.Windows.Forms.Padding(0);
            this.salesbutton.Name = "salesbutton";
            this.salesbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.salesbutton.Size = new System.Drawing.Size(252, 55);
            this.salesbutton.TabIndex = 6;
            this.salesbutton.Text = "Sales";
            this.salesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salesbutton.UseVisualStyleBackColor = true;
            this.salesbutton.Click += new System.EventHandler(this.salesbutton_Click);
            // 
            // categorybutton
            // 
            this.categorybutton.FlatAppearance.BorderSize = 0;
            this.categorybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorybutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorybutton.ForeColor = System.Drawing.Color.White;
            this.categorybutton.IconChar = FontAwesome.Sharp.IconChar.Sitemap;
            this.categorybutton.IconColor = System.Drawing.Color.White;
            this.categorybutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.categorybutton.IconSize = 30;
            this.categorybutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorybutton.Location = new System.Drawing.Point(0, 347);
            this.categorybutton.Margin = new System.Windows.Forms.Padding(0);
            this.categorybutton.Name = "categorybutton";
            this.categorybutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.categorybutton.Size = new System.Drawing.Size(250, 57);
            this.categorybutton.TabIndex = 8;
            this.categorybutton.Text = "Category";
            this.categorybutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorybutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.categorybutton.UseVisualStyleBackColor = true;
            this.categorybutton.Click += new System.EventHandler(this.categorybutton_Click);
            // 
            // addstockbutton
            // 
            this.addstockbutton.FlatAppearance.BorderSize = 0;
            this.addstockbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addstockbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstockbutton.ForeColor = System.Drawing.Color.White;
            this.addstockbutton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addstockbutton.IconColor = System.Drawing.Color.White;
            this.addstockbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addstockbutton.IconSize = 30;
            this.addstockbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addstockbutton.Location = new System.Drawing.Point(-2, 284);
            this.addstockbutton.Margin = new System.Windows.Forms.Padding(0);
            this.addstockbutton.Name = "addstockbutton";
            this.addstockbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.addstockbutton.Size = new System.Drawing.Size(250, 52);
            this.addstockbutton.TabIndex = 7;
            this.addstockbutton.Text = "Add Stock";
            this.addstockbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addstockbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addstockbutton.UseVisualStyleBackColor = true;
            this.addstockbutton.Click += new System.EventHandler(this.addstockbutton_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 562);
            this.Controls.Add(this.homepanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenttitleicon)).EndInit();
            this.homepanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homebtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton customerbutton;
        private FontAwesome.Sharp.IconButton exitbutton;
        private FontAwesome.Sharp.IconButton categorybutton;
        private FontAwesome.Sharp.IconButton addstockbutton;
        private FontAwesome.Sharp.IconButton salesbutton;
        private FontAwesome.Sharp.IconButton productbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox homebtn;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Label currenttitle;
        private FontAwesome.Sharp.IconPictureBox currenttitleicon;
        private System.Windows.Forms.Panel homepanel;
        private FontAwesome.Sharp.IconPictureBox minimizebtn;
        private FontAwesome.Sharp.IconPictureBox closebtn;
        private FontAwesome.Sharp.IconPictureBox maxbtn;
        private Bunifu.UI.WinForms.BunifuGradientPanel panel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private FontAwesome.Sharp.IconButton alertbutton;
    }
}