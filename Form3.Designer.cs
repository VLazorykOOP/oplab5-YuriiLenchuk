namespace lab5
{
    partial class Form3
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.textBoxK = new System.Windows.Forms.TextBox();
        this.buttonGenerate = new System.Windows.Forms.Button();
        this.pictureBoxFern = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFern)).BeginInit();
        this.SuspendLayout();
        // 
        // textBoxK
        // 
        this.textBoxK.Location = new System.Drawing.Point(12, 12);
        this.textBoxK.Name = "textBoxK";
        this.textBoxK.Size = new System.Drawing.Size(100, 20);
        this.textBoxK.Text = "100000";
        this.textBoxK.TabIndex = 0;
        // 
        // buttonGenerate
        // 
        this.buttonGenerate.Location = new System.Drawing.Point(118, 10);
        this.buttonGenerate.Name = "buttonGenerate";
        this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
        this.buttonGenerate.TabIndex = 1;
        this.buttonGenerate.Text = "Generate";
        this.buttonGenerate.UseVisualStyleBackColor = true;
        this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
        // 
        // pictureBoxFern
        // 
        this.pictureBoxFern.Location = new System.Drawing.Point(12, 39);
        this.pictureBoxFern.Name = "pictureBoxFern";
        this.pictureBoxFern.Size = new System.Drawing.Size(776, 399);
        this.pictureBoxFern.TabIndex = 2;
        this.pictureBoxFern.TabStop = false;
        // 
        // Form3
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.pictureBoxFern);
        this.Controls.Add(this.buttonGenerate);
        this.Controls.Add(this.textBoxK);
        this.Name = "Form3";
        this.Text = "Barnsley Fern Generator";
        ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFern)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox textBoxK;
    private System.Windows.Forms.Button buttonGenerate;
    private System.Windows.Forms.PictureBox pictureBoxFern;
}

}
