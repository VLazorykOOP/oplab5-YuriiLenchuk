namespace lab5
{
    partial class Form2
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
            textBoxX1 = new TextBox();
            textBoxY1 = new TextBox();
            textBoxX2 = new TextBox();
            textBoxY2 = new TextBox();
            textBoxVx1 = new TextBox();
            textBoxVy1 = new TextBox();
            textBoxVx2 = new TextBox();
            textBoxVy2 = new TextBox();
            buttonDraw = new Button();
            panelGraph = new Panel();
            SuspendLayout();
            // 
            // textBoxX1
            // 
            textBoxX1.Location = new Point(16, 18);
            textBoxX1.Margin = new Padding(4, 5, 4, 5);
            textBoxX1.Name = "textBoxX1";
            textBoxX1.PlaceholderText = "x1";
            textBoxX1.Size = new Size(65, 27);
            textBoxX1.TabIndex = 1;
            // 
            // textBoxY1
            // 
            textBoxY1.Location = new Point(91, 18);
            textBoxY1.Margin = new Padding(4, 5, 4, 5);
            textBoxY1.Name = "textBoxY1";
            textBoxY1.PlaceholderText = "y1";
            textBoxY1.Size = new Size(65, 27);
            textBoxY1.TabIndex = 2;
            // 
            // textBoxX2
            // 
            textBoxX2.Location = new Point(16, 58);
            textBoxX2.Margin = new Padding(4, 5, 4, 5);
            textBoxX2.Name = "textBoxX2";
            textBoxX2.PlaceholderText = "x2";
            textBoxX2.Size = new Size(65, 27);
            textBoxX2.TabIndex = 3;
            // 
            // textBoxY2
            // 
            textBoxY2.Location = new Point(91, 58);
            textBoxY2.Margin = new Padding(4, 5, 4, 5);
            textBoxY2.Name = "textBoxY2";
            textBoxY2.PlaceholderText = "y2";
            textBoxY2.Size = new Size(65, 27);
            textBoxY2.TabIndex = 4;
            // 
            // textBoxVx1
            // 
            textBoxVx1.Location = new Point(16, 98);
            textBoxVx1.Margin = new Padding(4, 5, 4, 5);
            textBoxVx1.Name = "textBoxVx1";
            textBoxVx1.PlaceholderText = "vx1";
            textBoxVx1.Size = new Size(65, 27);
            textBoxVx1.TabIndex = 5;
            // 
            // textBoxVy1
            // 
            textBoxVy1.Location = new Point(91, 98);
            textBoxVy1.Margin = new Padding(4, 5, 4, 5);
            textBoxVy1.Name = "textBoxVy1";
            textBoxVy1.PlaceholderText = "vy1";
            textBoxVy1.Size = new Size(65, 27);
            textBoxVy1.TabIndex = 6;
            // 
            // textBoxVx2
            // 
            textBoxVx2.Location = new Point(16, 138);
            textBoxVx2.Margin = new Padding(4, 5, 4, 5);
            textBoxVx2.Name = "textBoxVx2";
            textBoxVx2.PlaceholderText = "vx2";
            textBoxVx2.Size = new Size(65, 27);
            textBoxVx2.TabIndex = 7;
            // 
            // textBoxVy2
            // 
            textBoxVy2.Location = new Point(91, 138);
            textBoxVy2.Margin = new Padding(4, 5, 4, 5);
            textBoxVy2.Name = "textBoxVy2";
            textBoxVy2.PlaceholderText = "vy2";
            textBoxVy2.Size = new Size(65, 27);
            textBoxVy2.TabIndex = 8;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(16, 178);
            buttonDraw.Margin = new Padding(4, 5, 4, 5);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(141, 35);
            buttonDraw.TabIndex = 9;
            buttonDraw.Text = "Draw";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // panelGraph
            // 
            panelGraph.Location = new Point(165, 18);
            panelGraph.Margin = new Padding(4, 5, 4, 5);
            panelGraph.Name = "panelGraph";
            panelGraph.Size = new Size(666, 462);
            panelGraph.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 498);
            Controls.Add(panelGraph);
            Controls.Add(buttonDraw);
            Controls.Add(textBoxVy2);
            Controls.Add(textBoxVx2);
            Controls.Add(textBoxVy1);
            Controls.Add(textBoxVx1);
            Controls.Add(textBoxY2);
            Controls.Add(textBoxX2);
            Controls.Add(textBoxY1);
            Controls.Add(textBoxX1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Hermite Curve";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxVx1;
        private System.Windows.Forms.TextBox textBoxVy1;
        private System.Windows.Forms.TextBox textBoxVx2;
        private System.Windows.Forms.TextBox textBoxVy2;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Panel panelGraph;
    }
}
