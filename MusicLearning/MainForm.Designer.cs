namespace MusicLearning
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvService = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUploadS = new System.Windows.Forms.Button();
            this.btnSaveS = new System.Windows.Forms.Button();
            this.cbSerializer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChooseService = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvService
            // 
            this.lvService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvService.ContextMenuStrip = this.contextMenuStrip1;
            this.lvService.FullRowSelect = true;
            this.lvService.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvService.HideSelection = false;
            this.lvService.Location = new System.Drawing.Point(12, 12);
            this.lvService.MultiSelect = false;
            this.lvService.Name = "lvService";
            this.lvService.Size = new System.Drawing.Size(411, 426);
            this.lvService.TabIndex = 0;
            this.lvService.UseCompatibleStateImageBehavior = false;
            this.lvService.View = System.Windows.Forms.View.Details;
            this.lvService.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvService_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название курса";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Инструмент";
            this.columnHeader3.Width = 142;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 76);
            // 
            // ShowToolStripMenuItem
            // 
            this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            this.ShowToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.ShowToolStripMenuItem.Text = "Посмотреть";
            this.ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.EditToolStripMenuItem.Text = "Редактировать";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUploadS);
            this.groupBox1.Controls.Add(this.btnSaveS);
            this.groupBox1.Controls.Add(this.cbSerializer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbChooseService);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(441, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnUploadS
            // 
            this.btnUploadS.Location = new System.Drawing.Point(234, 217);
            this.btnUploadS.Name = "btnUploadS";
            this.btnUploadS.Size = new System.Drawing.Size(94, 33);
            this.btnUploadS.TabIndex = 8;
            this.btnUploadS.Text = "Загрузить";
            this.btnUploadS.UseVisualStyleBackColor = true;
            this.btnUploadS.Click += new System.EventHandler(this.btnUploadS_Click);
            // 
            // btnSaveS
            // 
            this.btnSaveS.Location = new System.Drawing.Point(16, 217);
            this.btnSaveS.Name = "btnSaveS";
            this.btnSaveS.Size = new System.Drawing.Size(94, 33);
            this.btnSaveS.TabIndex = 7;
            this.btnSaveS.Text = "Сохранить";
            this.btnSaveS.UseVisualStyleBackColor = true;
            this.btnSaveS.Click += new System.EventHandler(this.btnSaveS_Click);
            // 
            // cbSerializer
            // 
            this.cbSerializer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerializer.FormattingEnabled = true;
            this.cbSerializer.Location = new System.Drawing.Point(16, 178);
            this.cbSerializer.Name = "cbSerializer";
            this.cbSerializer.Size = new System.Drawing.Size(312, 24);
            this.cbSerializer.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите сериализатор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите предмет урока";
            // 
            // cbChooseService
            // 
            this.cbChooseService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseService.FormattingEnabled = true;
            this.cbChooseService.Location = new System.Drawing.Point(16, 43);
            this.cbChooseService.Name = "cbChooseService";
            this.cbChooseService.Size = new System.Drawing.Size(312, 24);
            this.cbChooseService.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(234, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Музыкальный Магазин";
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbChooseService;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUploadS;
        private System.Windows.Forms.Button btnSaveS;
        private System.Windows.Forms.ComboBox cbSerializer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
    }
}

