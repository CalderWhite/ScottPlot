﻿
namespace ScottPlot
{
    partial class FormsPlot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.DefaultRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.autoAxisMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PlottableCountTimer = new System.Windows.Forms.Timer(this.components);
			this.openInNewWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.DefaultRightClickMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(533, 369);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.DoubleClick += new System.EventHandler(this.PictureBox1_DoubleClick);
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
			// 
			// DefaultRightClickMenu
			// 
			this.DefaultRightClickMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.DefaultRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMenuItem,
            this.saveImageMenuItem,
            this.toolStripSeparator1,
            this.autoAxisMenuItem,
            this.toolStripSeparator2,
            this.helpMenuItem,
            this.toolStripSeparator3,
            this.openInNewWindowMenuItem});
			this.DefaultRightClickMenu.Name = "contextMenuStrip1";
			this.DefaultRightClickMenu.Size = new System.Drawing.Size(280, 178);
			// 
			// copyMenuItem
			// 
			this.copyMenuItem.Name = "copyMenuItem";
			this.copyMenuItem.Size = new System.Drawing.Size(223, 24);
			this.copyMenuItem.Text = "Copy Image";
			this.copyMenuItem.Click += new System.EventHandler(this.RightClickMenu_Copy_Click);
			// 
			// saveImageMenuItem
			// 
			this.saveImageMenuItem.Name = "saveImageMenuItem";
			this.saveImageMenuItem.Size = new System.Drawing.Size(223, 24);
			this.saveImageMenuItem.Text = "Save Image As...";
			this.saveImageMenuItem.Click += new System.EventHandler(this.RightClickMenu_SaveImage_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(276, 6);
			// 
			// autoAxisMenuItem
			// 
			this.autoAxisMenuItem.Name = "autoAxisMenuItem";
			this.autoAxisMenuItem.Size = new System.Drawing.Size(223, 24);
			this.autoAxisMenuItem.Text = "Zoom to Fit Data";
			this.autoAxisMenuItem.Click += new System.EventHandler(this.RightClickMenu_AutoAxis_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(276, 6);
			// 
			// helpMenuItem
			// 
			this.helpMenuItem.Name = "helpMenuItem";
			this.helpMenuItem.Size = new System.Drawing.Size(223, 24);
			this.helpMenuItem.Text = "Help";
			this.helpMenuItem.Click += new System.EventHandler(this.RightClickMenu_Help_Click);
			// 
			// PlottableCountTimer
			// 
			this.PlottableCountTimer.Enabled = true;
			this.PlottableCountTimer.Interval = 10;
			this.PlottableCountTimer.Tick += new System.EventHandler(this.PlottableCountTimer_Tick);
			// 
			// openInNewWindowMenuItem
			// 
			this.openInNewWindowMenuItem.Name = "openInNewWindowMenuItem";
			this.openInNewWindowMenuItem.Size = new System.Drawing.Size(223, 24);
			this.openInNewWindowMenuItem.Text = "Open in New Window";
			this.openInNewWindowMenuItem.Click += new System.EventHandler(this.RightClickMenu_OpenInNewWindow_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(276, 6);
			// 
			// FormsPlot
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormsPlot";
			this.Size = new System.Drawing.Size(533, 369);
			this.Load += new System.EventHandler(this.FormsPlot_Load);
			this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.DefaultRightClickMenu.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip DefaultRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem autoAxisMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer PlottableCountTimer;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem openInNewWindowMenuItem;
	}
}
