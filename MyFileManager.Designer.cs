
namespace FileManager
{
    partial class MyFileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyFileManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labОпераціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.LabPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Label();
            this.MoveFile = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LeftUpdateButton = new System.Windows.Forms.Button();
            this.LeftDirPath = new System.Windows.Forms.TextBox();
            this.LeftBackButton = new System.Windows.Forms.Button();
            this.LeftFilesListView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LeftDirListView = new System.Windows.Forms.ListView();
            this.IcoColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DirColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LeftTypeComboBox = new System.Windows.Forms.ComboBox();
            this.LeftFoldersComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RughtUpdateButton = new System.Windows.Forms.Button();
            this.RightDirPath = new System.Windows.Forms.TextBox();
            this.RightBackButton = new System.Windows.Forms.Button();
            this.RightFilesListView = new System.Windows.Forms.ListView();
            this.RightDirListView = new System.Windows.Forms.ListView();
            this.RightTypeComboBox = new System.Windows.Forms.ComboBox();
            this.RightFoldersComboBox = new System.Windows.Forms.ComboBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramToolStripMenuItem,
            this.FileToolStripMenuItem,
            this.OperationsToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.labОпераціїToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProgramToolStripMenuItem
            // 
            this.ProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMeToolStripMenuItem});
            this.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem";
            this.ProgramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.ProgramToolStripMenuItem.Text = "Програма";
            // 
            // AboutMeToolStripMenuItem
            // 
            this.AboutMeToolStripMenuItem.Name = "AboutMeToolStripMenuItem";
            this.AboutMeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.AboutMeToolStripMenuItem.Text = "Про власника";
            this.AboutMeToolStripMenuItem.Click += new System.EventHandler(this.AboutMeToolStripMenuItem_Click);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.CreateToolStripMenuItem,
            this.DelToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.OpenToolStripMenuItem.Text = "Відкрити";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.CreateToolStripMenuItem.Text = "Створити";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.DelToolStripMenuItem.Text = "Видалити";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // OperationsToolStripMenuItem
            // 
            this.OperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem,
            this.MoveToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.EditToolStripMenuItem});
            this.OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem";
            this.OperationsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.OperationsToolStripMenuItem.Text = "Операції";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.CopyToolStripMenuItem.Text = "\'c\' Копіювати";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // MoveToolStripMenuItem
            // 
            this.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem";
            this.MoveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.MoveToolStripMenuItem.Text = "\'v\' Перемістити";
            this.MoveToolStripMenuItem.Click += new System.EventHandler(this.MoveToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.DeleteToolStripMenuItem.Text = "\'d\' Видалити";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.EditToolStripMenuItem.Text = "\'o\' Відкрити";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartHelpToolStripMenuItem,
            this.MainHelpToolStripMenuItem,
            this.LabHelpToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.HelpToolStripMenuItem.Text = "Допомога";
            // 
            // StartHelpToolStripMenuItem
            // 
            this.StartHelpToolStripMenuItem.Name = "StartHelpToolStripMenuItem";
            this.StartHelpToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.StartHelpToolStripMenuItem.Text = "Початок роботи";
            this.StartHelpToolStripMenuItem.Click += new System.EventHandler(this.StartHelpToolStripMenuItem_Click);
            // 
            // MainHelpToolStripMenuItem
            // 
            this.MainHelpToolStripMenuItem.Name = "MainHelpToolStripMenuItem";
            this.MainHelpToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.MainHelpToolStripMenuItem.Text = "Основний функціонал";
            this.MainHelpToolStripMenuItem.Click += new System.EventHandler(this.MainHelpToolStripMenuItem_Click);
            // 
            // LabHelpToolStripMenuItem
            // 
            this.LabHelpToolStripMenuItem.Name = "LabHelpToolStripMenuItem";
            this.LabHelpToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.LabHelpToolStripMenuItem.Text = "Лабораторна";
            this.LabHelpToolStripMenuItem.Click += new System.EventHandler(this.LabHelpToolStripMenuItem_Click);
            // 
            // labОпераціїToolStripMenuItem
            // 
            this.labОпераціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabCopyToolStripMenuItem,
            this.CounterToolStripMenuItem,
            this.CopyGroupToolStripMenuItem,
            this.CopyHTMLToolStripMenuItem});
            this.labОпераціїToolStripMenuItem.Name = "labОпераціїToolStripMenuItem";
            this.labОпераціїToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.labОпераціїToolStripMenuItem.Text = "Lab Операції";
            // 
            // LabCopyToolStripMenuItem
            // 
            this.LabCopyToolStripMenuItem.Name = "LabCopyToolStripMenuItem";
            this.LabCopyToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.LabCopyToolStripMenuItem.Text = "9. Копіювати .txt";
            this.LabCopyToolStripMenuItem.Click += new System.EventHandler(this.LabCopyToolStripMenuItem_Click);
            // 
            // CounterToolStripMenuItem
            // 
            this.CounterToolStripMenuItem.Name = "CounterToolStripMenuItem";
            this.CounterToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.CounterToolStripMenuItem.Text = "2. Підрахунок слів";
            this.CounterToolStripMenuItem.Click += new System.EventHandler(this.CounterToolStripMenuItem_Click);
            // 
            // CopyGroupToolStripMenuItem
            // 
            this.CopyGroupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabCopy,
            this.LabPaste});
            this.CopyGroupToolStripMenuItem.Name = "CopyGroupToolStripMenuItem";
            this.CopyGroupToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.CopyGroupToolStripMenuItem.Text = "3. Копіювати групу файлів";
            // 
            // LabCopy
            // 
            this.LabCopy.Name = "LabCopy";
            this.LabCopy.Size = new System.Drawing.Size(132, 22);
            this.LabCopy.Text = "Копіювати";
            this.LabCopy.Click += new System.EventHandler(this.LabCopy_Click);
            // 
            // LabPaste
            // 
            this.LabPaste.Name = "LabPaste";
            this.LabPaste.Size = new System.Drawing.Size(132, 22);
            this.LabPaste.Text = "Вставити";
            this.LabPaste.Click += new System.EventHandler(this.LabPaste_Click);
            // 
            // CopyHTMLToolStripMenuItem
            // 
            this.CopyHTMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyHtml,
            this.MoveHtml});
            this.CopyHTMLToolStripMenuItem.Name = "CopyHTMLToolStripMenuItem";
            this.CopyHTMLToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.CopyHTMLToolStripMenuItem.Text = "9. Копіювати HTML";
            // 
            // CopyHtml
            // 
            this.CopyHtml.Name = "CopyHtml";
            this.CopyHtml.Size = new System.Drawing.Size(144, 22);
            this.CopyHtml.Text = "Копіювати";
            this.CopyHtml.Click += new System.EventHandler(this.CopyHtml_Click);
            // 
            // MoveHtml
            // 
            this.MoveHtml.Name = "MoveHtml";
            this.MoveHtml.Size = new System.Drawing.Size(144, 22);
            this.MoveHtml.Text = "Перемістити";
            this.MoveHtml.Click += new System.EventHandler(this.MoveHtml_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.MoveFile);
            this.groupBox1.Location = new System.Drawing.Point(5, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файл";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Видалити";
            // 
            // Delete
            // 
            this.Delete.AutoSize = true;
            this.Delete.Location = new System.Drawing.Point(26, 36);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(51, 13);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Відкрити";
            // 
            // MoveFile
            // 
            this.MoveFile.AutoSize = true;
            this.MoveFile.Location = new System.Drawing.Point(127, 36);
            this.MoveFile.Name = "MoveFile";
            this.MoveFile.Size = new System.Drawing.Size(54, 13);
            this.MoveFile.TabIndex = 1;
            this.MoveFile.Text = "Створити";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(331, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операції";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "\'o\' Відкрити";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "\'d\' Видалити";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "\'v\' Перемістити";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "\'c\' Копіювати";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LeftUpdateButton);
            this.groupBox3.Controls.Add(this.LeftDirPath);
            this.groupBox3.Controls.Add(this.LeftBackButton);
            this.groupBox3.Controls.Add(this.LeftFilesListView);
            this.groupBox3.Controls.Add(this.LeftDirListView);
            this.groupBox3.Controls.Add(this.LeftTypeComboBox);
            this.groupBox3.Controls.Add(this.LeftFoldersComboBox);
            this.groupBox3.Location = new System.Drawing.Point(5, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 347);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ліва";
            // 
            // LeftUpdateButton
            // 
            this.LeftUpdateButton.Location = new System.Drawing.Point(49, 293);
            this.LeftUpdateButton.Name = "LeftUpdateButton";
            this.LeftUpdateButton.Size = new System.Drawing.Size(75, 21);
            this.LeftUpdateButton.TabIndex = 9;
            this.LeftUpdateButton.Text = "Оновити";
            this.LeftUpdateButton.UseVisualStyleBackColor = true;
            this.LeftUpdateButton.Click += new System.EventHandler(this.LeftUpdateButton_Click);
            // 
            // LeftDirPath
            // 
            this.LeftDirPath.Location = new System.Drawing.Point(6, 320);
            this.LeftDirPath.Name = "LeftDirPath";
            this.LeftDirPath.Size = new System.Drawing.Size(195, 20);
            this.LeftDirPath.TabIndex = 8;
            this.LeftDirPath.TextChanged += new System.EventHandler(this.LeftDirPath_TextChanged);
            // 
            // LeftBackButton
            // 
            this.LeftBackButton.Location = new System.Drawing.Point(130, 293);
            this.LeftBackButton.Name = "LeftBackButton";
            this.LeftBackButton.Size = new System.Drawing.Size(70, 21);
            this.LeftBackButton.TabIndex = 6;
            this.LeftBackButton.Text = "<<";
            this.LeftBackButton.UseVisualStyleBackColor = true;
            this.LeftBackButton.Click += new System.EventHandler(this.LeftBackButton_Click);
            // 
            // LeftFilesListView
            // 
            this.LeftFilesListView.HideSelection = false;
            this.LeftFilesListView.LabelEdit = true;
            this.LeftFilesListView.Location = new System.Drawing.Point(209, 19);
            this.LeftFilesListView.Name = "LeftFilesListView";
            this.LeftFilesListView.Size = new System.Drawing.Size(195, 295);
            this.LeftFilesListView.SmallImageList = this.imageList1;
            this.LeftFilesListView.TabIndex = 5;
            this.LeftFilesListView.UseCompatibleStateImageBehavior = false;
            this.LeftFilesListView.View = System.Windows.Forms.View.SmallIcon;
            this.LeftFilesListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.LeftFilesListView_AfterLabelEdit);
            this.LeftFilesListView.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.LeftFilesListView_BeforeLabelEdit);
            this.LeftFilesListView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LeftFilesListView_KeyPress);
            this.LeftFilesListView.Leave += new System.EventHandler(this.LeftFilesListView_Leave);
            this.LeftFilesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LeftFilesListView_MouseClick);
            this.LeftFilesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LeftFilesListView_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "html-16.png");
            this.imageList1.Images.SetKeyName(1, "ico-16.png");
            this.imageList1.Images.SetKeyName(2, "icons8-folder-16.png");
            this.imageList1.Images.SetKeyName(3, "jpeg-16.png");
            this.imageList1.Images.SetKeyName(4, "jpg-16.png");
            this.imageList1.Images.SetKeyName(5, "mp3-16.png");
            this.imageList1.Images.SetKeyName(6, "mp4-16.png");
            this.imageList1.Images.SetKeyName(7, "pdf-16.png");
            this.imageList1.Images.SetKeyName(8, "png-16.png");
            this.imageList1.Images.SetKeyName(9, "txt-16.png");
            this.imageList1.Images.SetKeyName(10, "BMP-16.png");
            this.imageList1.Images.SetKeyName(11, "GIF-16.png");
            this.imageList1.Images.SetKeyName(12, "PDF-16.png");
            this.imageList1.Images.SetKeyName(13, "all-16.png");
            // 
            // LeftDirListView
            // 
            this.LeftDirListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IcoColumn,
            this.DirColumn});
            this.LeftDirListView.HideSelection = false;
            this.LeftDirListView.Location = new System.Drawing.Point(6, 19);
            this.LeftDirListView.Name = "LeftDirListView";
            this.LeftDirListView.Size = new System.Drawing.Size(195, 269);
            this.LeftDirListView.SmallImageList = this.imageList1;
            this.LeftDirListView.TabIndex = 4;
            this.LeftDirListView.UseCompatibleStateImageBehavior = false;
            this.LeftDirListView.View = System.Windows.Forms.View.SmallIcon;
            this.LeftDirListView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LeftDirListView_KeyPress);
            this.LeftDirListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LeftDirListView_MouseClick);
            this.LeftDirListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LeftDirListView_MouseDoubleClick);
            // 
            // IcoColumn
            // 
            this.IcoColumn.Text = "Icon";
            // 
            // LeftTypeComboBox
            // 
            this.LeftTypeComboBox.FormattingEnabled = true;
            this.LeftTypeComboBox.Location = new System.Drawing.Point(209, 320);
            this.LeftTypeComboBox.Name = "LeftTypeComboBox";
            this.LeftTypeComboBox.Size = new System.Drawing.Size(195, 21);
            this.LeftTypeComboBox.TabIndex = 1;
            this.LeftTypeComboBox.TextChanged += new System.EventHandler(this.LeftTypeComboBox_TextChanged);
            // 
            // LeftFoldersComboBox
            // 
            this.LeftFoldersComboBox.FormattingEnabled = true;
            this.LeftFoldersComboBox.Location = new System.Drawing.Point(6, 294);
            this.LeftFoldersComboBox.Name = "LeftFoldersComboBox";
            this.LeftFoldersComboBox.Size = new System.Drawing.Size(40, 21);
            this.LeftFoldersComboBox.TabIndex = 0;
            this.LeftFoldersComboBox.TextChanged += new System.EventHandler(this.LeftFoldersComboBox_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RughtUpdateButton);
            this.groupBox4.Controls.Add(this.RightDirPath);
            this.groupBox4.Controls.Add(this.RightBackButton);
            this.groupBox4.Controls.Add(this.RightFilesListView);
            this.groupBox4.Controls.Add(this.RightDirListView);
            this.groupBox4.Controls.Add(this.RightTypeComboBox);
            this.groupBox4.Controls.Add(this.RightFoldersComboBox);
            this.groupBox4.Location = new System.Drawing.Point(421, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 347);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Права";
            // 
            // RughtUpdateButton
            // 
            this.RughtUpdateButton.Location = new System.Drawing.Point(52, 295);
            this.RughtUpdateButton.Name = "RughtUpdateButton";
            this.RughtUpdateButton.Size = new System.Drawing.Size(75, 21);
            this.RughtUpdateButton.TabIndex = 7;
            this.RughtUpdateButton.Text = "Оновити";
            this.RughtUpdateButton.UseVisualStyleBackColor = true;
            this.RughtUpdateButton.Click += new System.EventHandler(this.RughtUpdateButton_Click);
            // 
            // RightDirPath
            // 
            this.RightDirPath.Location = new System.Drawing.Point(6, 320);
            this.RightDirPath.Name = "RightDirPath";
            this.RightDirPath.Size = new System.Drawing.Size(195, 20);
            this.RightDirPath.TabIndex = 6;
            this.RightDirPath.TextChanged += new System.EventHandler(this.RightDirPath_TextChanged);
            // 
            // RightBackButton
            // 
            this.RightBackButton.Location = new System.Drawing.Point(131, 295);
            this.RightBackButton.Name = "RightBackButton";
            this.RightBackButton.Size = new System.Drawing.Size(70, 21);
            this.RightBackButton.TabIndex = 4;
            this.RightBackButton.Text = "<<";
            this.RightBackButton.UseVisualStyleBackColor = true;
            this.RightBackButton.Click += new System.EventHandler(this.RightBackButton_Click);
            // 
            // RightFilesListView
            // 
            this.RightFilesListView.HideSelection = false;
            this.RightFilesListView.LabelEdit = true;
            this.RightFilesListView.Location = new System.Drawing.Point(209, 19);
            this.RightFilesListView.Name = "RightFilesListView";
            this.RightFilesListView.Size = new System.Drawing.Size(195, 295);
            this.RightFilesListView.SmallImageList = this.imageList1;
            this.RightFilesListView.TabIndex = 3;
            this.RightFilesListView.UseCompatibleStateImageBehavior = false;
            this.RightFilesListView.View = System.Windows.Forms.View.SmallIcon;
            this.RightFilesListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.RightFilesListView_AfterLabelEdit);
            this.RightFilesListView.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.RightFilesListView_BeforeLabelEdit);
            this.RightFilesListView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RightFilesListView_KeyPress);
            this.RightFilesListView.Leave += new System.EventHandler(this.RightFilesListView_Leave);
            this.RightFilesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RightFilesListView_MouseClick);
            this.RightFilesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RightFilesListView_MouseDoubleClick);
            // 
            // RightDirListView
            // 
            this.RightDirListView.HideSelection = false;
            this.RightDirListView.Location = new System.Drawing.Point(6, 19);
            this.RightDirListView.Name = "RightDirListView";
            this.RightDirListView.Size = new System.Drawing.Size(195, 269);
            this.RightDirListView.SmallImageList = this.imageList1;
            this.RightDirListView.TabIndex = 2;
            this.RightDirListView.UseCompatibleStateImageBehavior = false;
            this.RightDirListView.View = System.Windows.Forms.View.SmallIcon;
            this.RightDirListView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RightDirListView_KeyPress);
            this.RightDirListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RightDirListView_MouseClick);
            this.RightDirListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RightDirListView_MouseDoubleClick);
            // 
            // RightTypeComboBox
            // 
            this.RightTypeComboBox.FormattingEnabled = true;
            this.RightTypeComboBox.Location = new System.Drawing.Point(209, 320);
            this.RightTypeComboBox.Name = "RightTypeComboBox";
            this.RightTypeComboBox.Size = new System.Drawing.Size(195, 21);
            this.RightTypeComboBox.TabIndex = 1;
            this.RightTypeComboBox.TextChanged += new System.EventHandler(this.RightTypeComboBox_TextChanged);
            // 
            // RightFoldersComboBox
            // 
            this.RightFoldersComboBox.FormattingEnabled = true;
            this.RightFoldersComboBox.Location = new System.Drawing.Point(6, 295);
            this.RightFoldersComboBox.Name = "RightFoldersComboBox";
            this.RightFoldersComboBox.Size = new System.Drawing.Size(40, 21);
            this.RightFoldersComboBox.TabIndex = 0;
            this.RightFoldersComboBox.TextChanged += new System.EventHandler(this.RightFoldersComboBox_TextChanged);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // MyFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 459);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyFileManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyFileManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyFileManager_FormClosing);
            this.Load += new System.EventHandler(this.MyFileManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Delete;
        private System.Windows.Forms.Label MoveFile;
        private System.Windows.Forms.ComboBox LeftTypeComboBox;
        private System.Windows.Forms.ComboBox LeftFoldersComboBox;
        private System.Windows.Forms.ComboBox RightTypeComboBox;
        private System.Windows.Forms.ComboBox RightFoldersComboBox;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ListView LeftDirListView;
        private System.Windows.Forms.ListView LeftFilesListView;
        private System.Windows.Forms.ListView RightFilesListView;
        private System.Windows.Forms.ListView RightDirListView;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader IcoColumn;
        private System.Windows.Forms.ColumnHeader DirColumn;
        private System.Windows.Forms.Button LeftBackButton;
        private System.Windows.Forms.TextBox LeftDirPath;
        private System.Windows.Forms.TextBox RightDirPath;
        private System.Windows.Forms.Button RightBackButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button LeftUpdateButton;
        private System.Windows.Forms.Button RughtUpdateButton;
        private System.Windows.Forms.ToolStripMenuItem labОпераціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LabCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LabCopy;
        private System.Windows.Forms.ToolStripMenuItem LabPaste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem CopyHtml;
        private System.Windows.Forms.ToolStripMenuItem MoveHtml;
        private System.Windows.Forms.ToolStripMenuItem MainHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LabHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartHelpToolStripMenuItem;
    }
}

