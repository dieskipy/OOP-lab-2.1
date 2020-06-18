namespace MusicLearning.FormLearningObject
{
    partial class FAccessory
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbLessonType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тип Занятия";
            // 
            // cbLessonType
            // 
            this.cbLessonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLessonType.FormattingEnabled = true;
            this.cbLessonType.Location = new System.Drawing.Point(183, 109);
            this.cbLessonType.Name = "cbLessonType";
            this.cbLessonType.Size = new System.Drawing.Size(200, 24);
            this.cbLessonType.TabIndex = 7;
            // 
            // FAccessory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 338);
            this.Controls.Add(this.cbLessonType);
            this.Controls.Add(this.label4);
            this.Name = "FAccessory";
            this.Text = "FAccessory";
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbLessonType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLessonType;
    }
}