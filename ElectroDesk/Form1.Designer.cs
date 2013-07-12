namespace ElectroDesk
{
    partial class ED_Form
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ED_Form));
            this.PicName = new System.Windows.Forms.ComboBox();
            this.PicName_label = new System.Windows.Forms.Label();
            this.UpdMins_Label = new System.Windows.Forms.Label();
            this.UpdTime = new System.Windows.Forms.ComboBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AutoRun = new System.Windows.Forms.CheckBox();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.WpUpdTimer = new System.Windows.Forms.Timer(this.components);
            this.TrayBaloon = new System.Windows.Forms.CheckBox();
            this.StartIntray = new System.Windows.Forms.CheckBox();
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьобоиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicName
            // 
            this.PicName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PicName.FormattingEnabled = true;
            this.PicName.Items.AddRange(new object[] {
            "http://east.yaakov.ru/100.png ",
            "http://east.yaakov.ru/200.png",
            "http://east.yaakov.ru/400.png",
            "http://east.yaakov.ru/800.png",
            "http://east.yaakov.ru/1280.jpg",
            "http://east.yaakov.ru/2048.jpg"});
            this.PicName.Location = new System.Drawing.Point(150, 10);
            this.PicName.Name = "PicName";
            this.PicName.Size = new System.Drawing.Size(245, 21);
            this.PicName.TabIndex = 0;
            this.Hint.SetToolTip(this.PicName, "Размер изображений соответственно 100х100, 200х200...");
            this.PicName.SelectedIndexChanged += new System.EventHandler(this.PicName_SelectedIndexChanged);
            // 
            // PicName_label
            // 
            this.PicName_label.AutoSize = true;
            this.PicName_label.Location = new System.Drawing.Point(13, 12);
            this.PicName_label.Name = "PicName_label";
            this.PicName_label.Size = new System.Drawing.Size(131, 13);
            this.PicName_label.TabIndex = 1;
            this.PicName_label.Text = "Выберите изображение:";
            // 
            // UpdMins_Label
            // 
            this.UpdMins_Label.AutoSize = true;
            this.UpdMins_Label.Location = new System.Drawing.Point(13, 34);
            this.UpdMins_Label.Name = "UpdMins_Label";
            this.UpdMins_Label.Size = new System.Drawing.Size(137, 13);
            this.UpdMins_Label.TabIndex = 3;
            this.UpdMins_Label.Text = "Обновлять каждые, мин.:";
            // 
            // UpdTime
            // 
            this.UpdTime.FormattingEnabled = true;
            this.UpdTime.Items.AddRange(new object[] {
            "15",
            "30",
            "60",
            "90",
            "120"});
            this.UpdTime.Location = new System.Drawing.Point(150, 32);
            this.UpdTime.Name = "UpdTime";
            this.UpdTime.Size = new System.Drawing.Size(41, 21);
            this.UpdTime.TabIndex = 2;
            this.UpdTime.Text = "30";
            this.Hint.SetToolTip(this.UpdTime, "Штатное время получения снимков со спутника - 30 минут. \r\nПри возникновении чрезв" +
                    "ычайных ситуаций это время может\r\nбыть уменьшено до 15 минут.");
            this.UpdTime.SelectedIndexChanged += new System.EventHandler(this.UpdTime_SelectedIndexChanged);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(16, 83);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(379, 23);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Обновить";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdBtn_Click);
            // 
            // AutoRun
            // 
            this.AutoRun.AutoSize = true;
            this.AutoRun.Location = new System.Drawing.Point(204, 37);
            this.AutoRun.Name = "AutoRun";
            this.AutoRun.Size = new System.Drawing.Size(135, 17);
            this.AutoRun.TabIndex = 5;
            this.AutoRun.Text = "Запускать с Windows";
            this.AutoRun.UseVisualStyleBackColor = true;
            this.AutoRun.CheckedChanged += new System.EventHandler(this.AutoRun_CheckedChanged);
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "ElectroDesk";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayicon_MouseClick);
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // Hint
            // 
            this.Hint.AutoPopDelay = 5000;
            this.Hint.InitialDelay = 500;
            this.Hint.ReshowDelay = 100;
            // 
            // WpUpdTimer
            // 
            this.WpUpdTimer.Enabled = true;
            this.WpUpdTimer.Interval = 30000;
            this.WpUpdTimer.Tick += new System.EventHandler(this.UpdBtn_Click);
            // 
            // TrayBaloon
            // 
            this.TrayBaloon.AutoSize = true;
            this.TrayBaloon.Location = new System.Drawing.Point(16, 59);
            this.TrayBaloon.Name = "TrayBaloon";
            this.TrayBaloon.Size = new System.Drawing.Size(184, 17);
            this.TrayBaloon.TabIndex = 6;
            this.TrayBaloon.Text = "Сообщать об обновлении фона";
            this.TrayBaloon.UseVisualStyleBackColor = true;
            this.TrayBaloon.CheckedChanged += new System.EventHandler(this.TrayBaloon_CheckedChanged);
            // 
            // StartIntray
            // 
            this.StartIntray.AutoSize = true;
            this.StartIntray.Location = new System.Drawing.Point(204, 60);
            this.StartIntray.Name = "StartIntray";
            this.StartIntray.Size = new System.Drawing.Size(134, 17);
            this.StartIntray.TabIndex = 7;
            this.StartIntray.Text = "Запускать свернутой";
            this.StartIntray.UseVisualStyleBackColor = true;
            this.StartIntray.CheckedChanged += new System.EventHandler(this.StarIntray_CheckedChanged);
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьНастройкиToolStripMenuItem,
            this.обновитьобоиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(183, 70);
            // 
            // открытьНастройкиToolStripMenuItem
            // 
            this.открытьНастройкиToolStripMenuItem.Name = "открытьНастройкиToolStripMenuItem";
            this.открытьНастройкиToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.открытьНастройкиToolStripMenuItem.Text = "Открыть настройки";
            this.открытьНастройкиToolStripMenuItem.Click += new System.EventHandler(this.открытьНастройкиToolStripMenuItem_Click);
            // 
            // обновитьобоиToolStripMenuItem
            // 
            this.обновитьобоиToolStripMenuItem.Name = "обновитьобоиToolStripMenuItem";
            this.обновитьобоиToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.обновитьобоиToolStripMenuItem.Text = "Обновить \"обои\"";
            this.обновитьобоиToolStripMenuItem.Click += new System.EventHandler(this.UpdBtn_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // ED_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 115);
            this.Controls.Add(this.StartIntray);
            this.Controls.Add(this.TrayBaloon);
            this.Controls.Add(this.AutoRun);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.UpdMins_Label);
            this.Controls.Add(this.UpdTime);
            this.Controls.Add(this.PicName_label);
            this.Controls.Add(this.PicName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ED_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroDesk 1.0";
            this.Load += new System.EventHandler(this.ED_Form_Load);
            this.Resize += new System.EventHandler(this.ED_Form_Resize);
            this.TrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PicName;
        private System.Windows.Forms.Label PicName_label;
        private System.Windows.Forms.Label UpdMins_Label;
        private System.Windows.Forms.ComboBox UpdTime;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.CheckBox AutoRun;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.Timer WpUpdTimer;
        private System.Windows.Forms.CheckBox TrayBaloon;
        private System.Windows.Forms.CheckBox StartIntray;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem открытьНастройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьобоиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

