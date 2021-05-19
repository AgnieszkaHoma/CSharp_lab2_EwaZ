
namespace Lab2_02_Formularz
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rduSmall = new System.Windows.Forms.RadioButton();
            this.rduBig = new System.Windows.Forms.RadioButton();
            this.rduVeryBig = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1pogrubienie = new System.Windows.Forms.CheckBox();
            this.pochylenie = new System.Windows.Forms.CheckBox();
            this.checkBox3podkreślenie = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rduRed = new System.Windows.Forms.RadioButton();
            this.rduBlue = new System.Windows.Forms.RadioButton();
            this.rduOrange = new System.Windows.Forms.RadioButton();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj tekst";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 23);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rduSmall);
            this.groupBox1.Controls.Add(this.rduBig);
            this.groupBox1.Controls.Add(this.rduVeryBig);
            this.groupBox1.Location = new System.Drawing.Point(35, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wielkość";
            // 
            // rduSmall
            // 
            this.rduSmall.AutoSize = true;
            this.rduSmall.Location = new System.Drawing.Point(6, 22);
            this.rduSmall.Name = "rduSmall";
            this.rduSmall.Size = new System.Drawing.Size(51, 19);
            this.rduSmall.TabIndex = 3;
            this.rduSmall.TabStop = true;
            this.rduSmall.Text = "mała";
            this.rduSmall.UseVisualStyleBackColor = true;
            // 
            // rduBig
            // 
            this.rduBig.AutoSize = true;
            this.rduBig.Location = new System.Drawing.Point(6, 47);
            this.rduBig.Name = "rduBig";
            this.rduBig.Size = new System.Drawing.Size(50, 19);
            this.rduBig.TabIndex = 4;
            this.rduBig.TabStop = true;
            this.rduBig.Text = "duża";
            this.rduBig.UseVisualStyleBackColor = true;
            // 
            // rduVeryBig
            // 
            this.rduVeryBig.AutoSize = true;
            this.rduVeryBig.Location = new System.Drawing.Point(6, 72);
            this.rduVeryBig.Name = "rduVeryBig";
            this.rduVeryBig.Size = new System.Drawing.Size(89, 19);
            this.rduVeryBig.TabIndex = 5;
            this.rduVeryBig.TabStop = true;
            this.rduVeryBig.Text = "bardzo duża";
            this.rduVeryBig.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1pogrubienie);
            this.groupBox2.Controls.Add(this.pochylenie);
            this.groupBox2.Controls.Add(this.checkBox3podkreślenie);
            this.groupBox2.Location = new System.Drawing.Point(207, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 104);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Styl czcionki";
            // 
            // checkBox1pogrubienie
            // 
            this.checkBox1pogrubienie.AutoSize = true;
            this.checkBox1pogrubienie.Location = new System.Drawing.Point(6, 22);
            this.checkBox1pogrubienie.Name = "checkBox1pogrubienie";
            this.checkBox1pogrubienie.Size = new System.Drawing.Size(90, 19);
            this.checkBox1pogrubienie.TabIndex = 6;
            this.checkBox1pogrubienie.Text = "pogrubienie";
            this.checkBox1pogrubienie.UseVisualStyleBackColor = true;
            // 
            // pochylenie
            // 
            this.pochylenie.AutoSize = true;
            this.pochylenie.Location = new System.Drawing.Point(6, 47);
            this.pochylenie.Name = "pochylenie";
            this.pochylenie.Size = new System.Drawing.Size(84, 19);
            this.pochylenie.TabIndex = 7;
            this.pochylenie.Text = "pochylenie";
            this.pochylenie.UseVisualStyleBackColor = true;
            // 
            // checkBox3podkreślenie
            // 
            this.checkBox3podkreślenie.AutoSize = true;
            this.checkBox3podkreślenie.Location = new System.Drawing.Point(6, 73);
            this.checkBox3podkreślenie.Name = "checkBox3podkreślenie";
            this.checkBox3podkreślenie.Size = new System.Drawing.Size(93, 19);
            this.checkBox3podkreślenie.TabIndex = 8;
            this.checkBox3podkreślenie.Text = "podkreślenie";
            this.checkBox3podkreślenie.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rduRed);
            this.groupBox3.Controls.Add(this.rduBlue);
            this.groupBox3.Controls.Add(this.rduOrange);
            this.groupBox3.Location = new System.Drawing.Point(378, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 104);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kolor czcionki";
            // 
            // rduRed
            // 
            this.rduRed.AutoSize = true;
            this.rduRed.Location = new System.Drawing.Point(6, 22);
            this.rduRed.Name = "rduRed";
            this.rduRed.Size = new System.Drawing.Size(75, 19);
            this.rduRed.TabIndex = 6;
            this.rduRed.TabStop = true;
            this.rduRed.Text = "czerwony";
            this.rduRed.UseVisualStyleBackColor = true;
            // 
            // rduBlue
            // 
            this.rduBlue.AutoSize = true;
            this.rduBlue.Location = new System.Drawing.Point(6, 47);
            this.rduBlue.Name = "rduBlue";
            this.rduBlue.Size = new System.Drawing.Size(71, 19);
            this.rduBlue.TabIndex = 7;
            this.rduBlue.TabStop = true;
            this.rduBlue.Text = "niebieski";
            this.rduBlue.UseVisualStyleBackColor = true;
            // 
            // rduOrange
            // 
            this.rduOrange.AutoSize = true;
            this.rduOrange.Location = new System.Drawing.Point(6, 72);
            this.rduOrange.Name = "rduOrange";
            this.rduOrange.Size = new System.Drawing.Size(106, 19);
            this.rduOrange.TabIndex = 8;
            this.rduOrange.TabStop = true;
            this.rduOrange.Text = "pomarańczowy";
            this.rduOrange.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.Location = new System.Drawing.Point(198, 245);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(205, 45);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Aktualizuj";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 302);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rduOrange;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.RadioButton rduSmall;
        private System.Windows.Forms.RadioButton rduBig;
        private System.Windows.Forms.RadioButton rduVeryBig;
        private System.Windows.Forms.RadioButton rduRed;
        private System.Windows.Forms.RadioButton rduBlue;
        private System.Windows.Forms.CheckBox checkBox1pogrubienie;
        private System.Windows.Forms.CheckBox pochylenie;
        private System.Windows.Forms.CheckBox checkBox3podkreślenie;
    }
}

