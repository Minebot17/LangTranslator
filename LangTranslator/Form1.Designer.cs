namespace LangTranslator {
	partial class MainForm {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
            this.smallRegister = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.ComboBox();
            this.open = new System.Windows.Forms.Button();
            this.translateButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.yandex = new System.Windows.Forms.LinkLabel();
            this.customListLoadButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.listLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.listNameLabel = new System.Windows.Forms.Label();
            this.openList = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // smallRegister
            // 
            this.smallRegister.AutoSize = true;
            this.smallRegister.Location = new System.Drawing.Point(44, 37);
            this.smallRegister.Name = "smallRegister";
            this.smallRegister.Size = new System.Drawing.Size(88, 17);
            this.smallRegister.TabIndex = 20;
            this.smallRegister.Text = "Small register";
            this.smallRegister.UseVisualStyleBackColor = true;
            this.smallRegister.CheckedChanged += new System.EventHandler(this.smallRegister_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "To";
            // 
            // to
            // 
            this.to.FormattingEnabled = true;
            this.to.Location = new System.Drawing.Point(44, 10);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(121, 21);
            this.to.TabIndex = 16;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(171, 39);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 15;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // translateButton
            // 
            this.translateButton.Enabled = false;
            this.translateButton.Location = new System.Drawing.Point(171, 10);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(75, 23);
            this.translateButton.TabIndex = 21;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // openFile
            // 
            this.openFile.Filter = "lang files|*.lang|txt files|*.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Переведено сервисом";
            // 
            // yandex
            // 
            this.yandex.AutoSize = true;
            this.yandex.Location = new System.Drawing.Point(121, 100);
            this.yandex.Name = "yandex";
            this.yandex.Size = new System.Drawing.Size(121, 13);
            this.yandex.TabIndex = 23;
            this.yandex.TabStop = true;
            this.yandex.Text = "«Яндекс.Переводчик»";
            this.yandex.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.yandex_LinkClicked);
            // 
            // customListLoadButton
            // 
            this.customListLoadButton.Location = new System.Drawing.Point(171, 68);
            this.customListLoadButton.Name = "customListLoadButton";
            this.customListLoadButton.Size = new System.Drawing.Size(75, 23);
            this.customListLoadButton.TabIndex = 24;
            this.customListLoadButton.Text = "Upload list";
            this.customListLoadButton.UseVisualStyleBackColor = true;
            this.customListLoadButton.Click += new System.EventHandler(this.customListLoadButton_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(12, 57);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(29, 13);
            this.fileLabel.TabIndex = 25;
            this.fileLabel.Text = "File: ";
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Location = new System.Drawing.Point(12, 78);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(29, 13);
            this.listLabel.TabIndex = 26;
            this.listLabel.Text = "List: ";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(36, 57);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(23, 13);
            this.fileNameLabel.TabIndex = 27;
            this.fileNameLabel.Text = "null";
            // 
            // listNameLabel
            // 
            this.listNameLabel.AutoSize = true;
            this.listNameLabel.Location = new System.Drawing.Point(36, 78);
            this.listNameLabel.Name = "listNameLabel";
            this.listNameLabel.Size = new System.Drawing.Size(23, 13);
            this.listNameLabel.TabIndex = 28;
            this.listNameLabel.Text = "null";
            // 
            // openList
            // 
            this.openList.Filter = "txt files|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 122);
            this.Controls.Add(this.listNameLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.customListLoadButton);
            this.Controls.Add(this.yandex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.smallRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.to);
            this.Controls.Add(this.open);
            this.Name = "MainForm";
            this.Text = "Lang Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox smallRegister;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox to;
		private System.Windows.Forms.Button open;
		private System.Windows.Forms.Button translateButton;
		private System.Windows.Forms.OpenFileDialog openFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel yandex;
        private System.Windows.Forms.Button customListLoadButton;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label listNameLabel;
        private System.Windows.Forms.OpenFileDialog openList;
    }
}

