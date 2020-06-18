namespace MusicLearning.FormLearningObject
{
    partial class FInstrument
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
            this.cbProffessionalLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbProffessionalLevel
            // 
            this.cbProffessionalLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProffessionalLevel.FormattingEnabled = true;
            this.cbProffessionalLevel.Location = new System.Drawing.Point(183, 109);
            this.cbProffessionalLevel.Name = "cbProffessionalLevel";
            this.cbProffessionalLevel.Size = new System.Drawing.Size(200, 24);
            this.cbProffessionalLevel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Уровень навыка";
            // 
            // FInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbProffessionalLevel);
            this.Controls.Add(this.label4);
            this.Name = "FInstrument";
            this.Text = "FInstrument";
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbProffessionalLevel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProffessionalLevel;
        private System.Windows.Forms.Label label4;
    }
}