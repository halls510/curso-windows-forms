
namespace CursoWindowsForms
{
    partial class Frm_Test
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.testeToolStripMenuItem2,
            this.testeToolStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 70);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem1});
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.testeToolStripMenuItem.Text = "teste";
            // 
            // testeToolStripMenuItem1
            // 
            this.testeToolStripMenuItem1.Name = "testeToolStripMenuItem1";
            this.testeToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.testeToolStripMenuItem1.Text = "teste";
            // 
            // testeToolStripMenuItem2
            // 
            this.testeToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem3});
            this.testeToolStripMenuItem2.Name = "testeToolStripMenuItem2";
            this.testeToolStripMenuItem2.Size = new System.Drawing.Size(99, 22);
            this.testeToolStripMenuItem2.Text = "teste";
            // 
            // testeToolStripMenuItem3
            // 
            this.testeToolStripMenuItem3.Name = "testeToolStripMenuItem3";
            this.testeToolStripMenuItem3.Size = new System.Drawing.Size(99, 22);
            this.testeToolStripMenuItem3.Text = "teste";
            // 
            // testeToolStripMenuItem4
            // 
            this.testeToolStripMenuItem4.Name = "testeToolStripMenuItem4";
            this.testeToolStripMenuItem4.Size = new System.Drawing.Size(99, 22);
            this.testeToolStripMenuItem4.Text = "teste";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frm_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button1);
            this.Name = "Frm_Test";
            this.Text = "Form_Test";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem4;
        private System.Windows.Forms.Button button1;
    }
}