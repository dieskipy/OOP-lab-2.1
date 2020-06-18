namespace MusicLearning.FormLearningObject.FormAccessories
{
    partial class FInstrumentAccessories
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbInstrumentGroup = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Группа инструментов";
            // 
            // cbInstrumentGroup
            // 
            this.cbInstrumentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstrumentGroup.FormattingEnabled = true;
            this.cbInstrumentGroup.Location = new System.Drawing.Point(183, 139);
            this.cbInstrumentGroup.Name = "cbInstrumentGroup";
            this.cbInstrumentGroup.Size = new System.Drawing.Size(200, 24);
            this.cbInstrumentGroup.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(121, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 48);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FInstrumentAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 250);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbInstrumentGroup);
            this.Controls.Add(this.label5);
            this.Name = "FInstrumentAccessories";
            this.Text = "FInstrumentAccessories";
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cbInstrumentGroup, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbInstrumentGroup;
        private System.Windows.Forms.Button btnSave;
    }
}