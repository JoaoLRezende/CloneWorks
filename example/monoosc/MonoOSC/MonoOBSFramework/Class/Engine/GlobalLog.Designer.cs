//
// GlobalLog.Designer.cs
//
// Author:
//       Surfzoid <surfzoid@gmail.com>
//
// Copyright (c) 2009 Surfzoid
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace MonoOBSFramework.Engine
{
partial class GlobalLog
{
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.AutoSrcollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        this.richTextBox2 = new System.Windows.Forms.RichTextBox();
        this.richTextBox1 = new System.Windows.Forms.RichTextBox();
        this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.lineNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip1.SuspendLayout();
        this.toolStripContainer1.ContentPanel.SuspendLayout();
        this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
        this.toolStripContainer1.SuspendLayout();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        this.SuspendLayout();
        //
        // menuStrip1
        //
        this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.optionsToolStripMenuItem,
            this.displayToolStripMenuItem
        });
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(866, 24);
        this.menuStrip1.TabIndex = 1;
        this.menuStrip1.Text = "menuStrip1";
        //
        // optionsToolStripMenuItem
        //
        this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.alwaysOnTopToolStripMenuItem,
            this.AutoSrcollToolStripMenuItem,
            this.wordWrapToolStripMenuItem
        });
        this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
        this.optionsToolStripMenuItem.Text = "Options";
        //
        // alwaysOnTopToolStripMenuItem
        //
        this.alwaysOnTopToolStripMenuItem.Checked = true;
        this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
        this.alwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
        this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
        this.alwaysOnTopToolStripMenuItem.Text = "Always on top";
        this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
        //
        // AutoSrcollToolStripMenuItem
        //
        this.AutoSrcollToolStripMenuItem.Checked = true;
        this.AutoSrcollToolStripMenuItem.CheckOnClick = true;
        this.AutoSrcollToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        this.AutoSrcollToolStripMenuItem.Name = "AutoSrcollToolStripMenuItem";
        this.AutoSrcollToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
        this.AutoSrcollToolStripMenuItem.Text = "Autoscroll";
        //
        // toolStripContainer1
        //
        //
        // toolStripContainer1.ContentPanel
        //
        this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
        this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(866, 402);
        this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
        this.toolStripContainer1.Name = "toolStripContainer1";
        this.toolStripContainer1.Size = new System.Drawing.Size(866, 426);
        this.toolStripContainer1.TabIndex = 2;
        this.toolStripContainer1.Text = "toolStripContainer1";
        //
        // toolStripContainer1.TopToolStripPanel
        //
        this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
        //
        // splitContainer1
        //
        this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
        this.splitContainer1.IsSplitterFixed = true;
        this.splitContainer1.Location = new System.Drawing.Point(0, 0);
        this.splitContainer1.Name = "splitContainer1";
        //
        // splitContainer1.Panel1
        //
        this.splitContainer1.Panel1.Controls.Add(this.richTextBox2);
        //
        // splitContainer1.Panel2
        //
        this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
        this.splitContainer1.Size = new System.Drawing.Size(866, 402);
        this.splitContainer1.SplitterDistance = 25;
        this.splitContainer1.SplitterWidth = 1;
        this.splitContainer1.TabIndex = 3;
        this.splitContainer1.TabStop = false;
        //
        // richTextBox2
        //
        this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        this.richTextBox2.Location = new System.Drawing.Point(0, 0);
        this.richTextBox2.Name = "richTextBox2";
        this.richTextBox2.ReadOnly = true;
        this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
        this.richTextBox2.Size = new System.Drawing.Size(25, 402);
        this.richTextBox2.TabIndex = 0;
        this.richTextBox2.Text = "";
        this.richTextBox2.Visible = false;
        this.richTextBox2.WordWrap = false;
        //
        // richTextBox1
        //
        this.richTextBox1.AcceptsTab = true;
        this.richTextBox1.AutoWordSelection = true;
        this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.richTextBox1.EnableAutoDragDrop = true;
        this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        this.richTextBox1.ForeColor = System.Drawing.Color.DarkBlue;
        this.richTextBox1.HideSelection = false;
        this.richTextBox1.Location = new System.Drawing.Point(0, 0);
        this.richTextBox1.Name = "richTextBox1";
        this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
        this.richTextBox1.Size = new System.Drawing.Size(840, 402);
        this.richTextBox1.TabIndex = 1;
        this.richTextBox1.Text = "";
        this.richTextBox1.WordWrap = false;
        this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
        this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
        this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
        this.richTextBox1.Resize += new System.EventHandler(this.richTextBox1_Resize);
        this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
        //
        // wordWrapToolStripMenuItem
        //
        this.wordWrapToolStripMenuItem.CheckOnClick = true;
        this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
        this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
        this.wordWrapToolStripMenuItem.Text = "WordWrap";
        this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
        //
        // displayToolStripMenuItem
        //
        this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.lineNumberToolStripMenuItem
        });
        this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
        this.displayToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
        this.displayToolStripMenuItem.Text = "Display";
        //
        // lineNumberToolStripMenuItem
        //
        this.lineNumberToolStripMenuItem.CheckOnClick = true;
        this.lineNumberToolStripMenuItem.Name = "lineNumberToolStripMenuItem";
        this.lineNumberToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.lineNumberToolStripMenuItem.Text = "Line number";
        this.lineNumberToolStripMenuItem.Click += new System.EventHandler(this.lineNumberToolStripMenuItem_Click);
        //
        // GlobalLog
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(866, 426);
        this.Controls.Add(this.toolStripContainer1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "GlobalLog";
        this.Text = "GlobalLog";
        this.TopMost = true;
        this.Shown += new System.EventHandler(this.GlobalLog_Shown);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlobalLog_FormClosing);
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.toolStripContainer1.ContentPanel.ResumeLayout(false);
        this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
        this.toolStripContainer1.TopToolStripPanel.PerformLayout();
        this.toolStripContainer1.ResumeLayout(false);
        this.toolStripContainer1.PerformLayout();
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel2.ResumeLayout(false);
        this.splitContainer1.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem AutoSrcollToolStripMenuItem;
    private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.RichTextBox richTextBox2;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem lineNumberToolStripMenuItem;
}
}
