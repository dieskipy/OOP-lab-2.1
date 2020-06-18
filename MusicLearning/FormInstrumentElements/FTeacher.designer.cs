namespace MusicLearning.FormInstrumentElements
{
    partial class FTeacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTeacherName = new System.Windows.Forms.TextBox();
            this.tbTeacherExpirience = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя преподавателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стаж работы";
            // 
            // tbTeacherName
            // 
            this.tbTeacherName.Location = new System.Drawing.Point(169, 29);
            this.tbTeacherName.Name = "tbTeacherName";
            this.tbTeacherName.Size = new System.Drawing.Size(149, 22);
            this.tbTeacherName.TabIndex = 2;
            // 
            // tbTeacherExpirience
            // 
            this.tbTeacherExpirience.Location = new System.Drawing.Point(169, 67);
            this.tbTeacherExpirience.Name = "tbTeacherExpirience";
            this.tbTeacherExpirience.Size = new System.Drawing.Size(81, 22);
            this.tbTeacherExpirience.TabIndex = 3;
            this.tbTeacherExpirience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTeacherExpirience_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(78, 111);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "лет";
            // 
            // FTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 167);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbTeacherExpirience);
            this.Controls.Add(this.tbTeacherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FTeacher";
            this.Text = "FTeacher";
            this.Shown += new System.EventHandler(this.FTeacher_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTeacherName;
        private System.Windows.Forms.TextBox tbTeacherExpirience;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
    }
}