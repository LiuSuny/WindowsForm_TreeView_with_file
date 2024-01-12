namespace WindowsForm_TreeView
{
    partial class DragDrop
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
            this.labelName = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(390, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(156, 40);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Kindly Drag & Drop Your File Here!";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treeView1.ForeColor = System.Drawing.Color.Yellow;
            this.treeView1.Location = new System.Drawing.Point(374, 1);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(199, 109);
            this.treeView1.TabIndex = 2;
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.DragLeave += new System.EventHandler(this.treeView1_DragLeave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightGray;
            this.richTextBox1.Location = new System.Drawing.Point(7, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(361, 349);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // DragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 362);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.treeView1);
            this.Name = "DragDrop";
            this.Text = "DragDrop";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}