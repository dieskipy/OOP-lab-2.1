namespace MusicLearning.FormLearningObjects.FormInstruments
{
    partial class FStrings
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
            this.cbInstrument = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbInstrument
            // 
            this.cbInstrument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstrument.FormattingEnabled = true;
            this.cbInstrument.Location = new System.Drawing.Point(183, 139);
            this.cbInstrument.Name = "cbInstrument";
            this.cbInstrument.Size = new System.Drawing.Size(200, 24);
            this.cbInstrument.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Инструмент";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(117, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 48);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 246);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbInstrument);
            this.Controls.Add(this.label5);
            this.Name = "FStrings";
            this.Text = "FStrings";
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cbInstrument, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInstrument;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
    }
}