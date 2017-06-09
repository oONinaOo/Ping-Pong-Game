namespace PingPongGame
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.progress = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.progressfull = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.easy = new System.Windows.Forms.Button();
            this.normal = new System.Windows.Forms.Button();
            this.hardcore = new System.Windows.Forms.Button();
            this.controls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ping Pong Game ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(407, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ver 1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(196, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loading...";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.progress,
            this.progressfull});
            this.shapeContainer1.Size = new System.Drawing.Size(486, 261);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.HotPink;
            this.progress.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.progress.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.progress.BorderWidth = 2;
            this.progress.CornerRadius = 6;
            this.progress.Location = new System.Drawing.Point(31, 192);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(12, 20);
            // 
            // progressfull
            // 
            this.progressfull.BackColor = System.Drawing.Color.Transparent;
            this.progressfull.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.progressfull.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.progressfull.BorderWidth = 2;
            this.progressfull.CornerRadius = 11;
            this.progressfull.Location = new System.Drawing.Point(30, 190);
            this.progressfull.Name = "progressfull";
            this.progressfull.Size = new System.Drawing.Size(423, 23);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(175, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Choose difficulty";
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.HotPink;
            this.easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.easy.Location = new System.Drawing.Point(46, 183);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(85, 30);
            this.easy.TabIndex = 5;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            // 
            // normal
            // 
            this.normal.BackColor = System.Drawing.Color.HotPink;
            this.normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.normal.Location = new System.Drawing.Point(199, 183);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(85, 30);
            this.normal.TabIndex = 5;
            this.normal.Text = "Normal";
            this.normal.UseVisualStyleBackColor = false;
            this.normal.Click += new System.EventHandler(this.normal_Click);
            // 
            // hardcore
            // 
            this.hardcore.BackColor = System.Drawing.Color.HotPink;
            this.hardcore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardcore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hardcore.Location = new System.Drawing.Point(345, 183);
            this.hardcore.Name = "hardcore";
            this.hardcore.Size = new System.Drawing.Size(85, 30);
            this.hardcore.TabIndex = 5;
            this.hardcore.Text = "Hardcore";
            this.hardcore.UseVisualStyleBackColor = false;
            this.hardcore.Click += new System.EventHandler(this.hardcore_Click);
            // 
            // controls
            // 
            this.controls.BackColor = System.Drawing.Color.HotPink;
            this.controls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.controls.Location = new System.Drawing.Point(199, 228);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(85, 30);
            this.controls.TabIndex = 6;
            this.controls.Text = "Controls";
            this.controls.UseVisualStyleBackColor = false;
            this.controls.Click += new System.EventHandler(this.controls_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(486, 261);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.hardcore);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape progress;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape progressfull;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button normal;
        private System.Windows.Forms.Button hardcore;
        private System.Windows.Forms.Button controls;
    }
}