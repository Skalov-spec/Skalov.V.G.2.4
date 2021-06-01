
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstVector = new System.Windows.Forms.TextBox();
            this.secondVector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.scals = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstVector
            // 
            this.firstVector.Location = new System.Drawing.Point(267, 70);
            this.firstVector.Name = "firstVector";
            this.firstVector.Size = new System.Drawing.Size(267, 23);
            this.firstVector.TabIndex = 0;
            // 
            // secondVector
            // 
            this.secondVector.Location = new System.Drawing.Point(267, 114);
            this.secondVector.Name = "secondVector";
            this.secondVector.Size = new System.Drawing.Size(267, 23);
            this.secondVector.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(267, 165);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(267, 23);
            this.result.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "result";
            // 
            // add
            // 
            this.add.ForeColor = System.Drawing.Color.Snow;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.Location = new System.Drawing.Point(176, 228);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(210, 153);
            this.add.TabIndex = 6;
            this.add.Text = "додавання";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // scals
            // 
            this.scals.ForeColor = System.Drawing.SystemColors.Control;
            this.scals.Image = ((System.Drawing.Image)(resources.GetObject("scals.Image")));
            this.scals.Location = new System.Drawing.Point(176, 387);
            this.scals.Name = "scals";
            this.scals.Size = new System.Drawing.Size(210, 153);
            this.scals.TabIndex = 7;
            this.scals.Text = "скалярний добуток";
            this.scals.UseVisualStyleBackColor = true;
            this.scals.Click += new System.EventHandler(this.scals_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(392, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 153);
            this.button2.TabIndex = 8;
            this.button2.Text = "множення на конст";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // sub
            // 
            this.sub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sub.Image = ((System.Drawing.Image)(resources.GetObject("sub.Image")));
            this.sub.Location = new System.Drawing.Point(392, 228);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(210, 153);
            this.sub.TabIndex = 9;
            this.sub.Text = "віднімання";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.scals);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondVector);
            this.Controls.Add(this.firstVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstVector;
        private System.Windows.Forms.TextBox secondVector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button scals;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sub;
    }
}

