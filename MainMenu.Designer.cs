namespace ViewTree
{
    partial class MainMenu
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button_GetItems = new System.Windows.Forms.Button();
            this.TypeStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьПредметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Execute = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ItemType = new System.Windows.Forms.ComboBox();
            this.textBox_NameItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TitleFunction = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.numericUpDown_Worth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Value = new System.Windows.Forms.NumericUpDown();
            this.textBox_AttributeName = new System.Windows.Forms.TextBox();
            this.comboBox_AttributeName = new System.Windows.Forms.ComboBox();
            this.TypeStripMenu.SuspendLayout();
            this.ItemStripMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Worth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Value)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(292, 443);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // button_GetItems
            // 
            this.button_GetItems.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_GetItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GetItems.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_GetItems.ForeColor = System.Drawing.Color.Brown;
            this.button_GetItems.Location = new System.Drawing.Point(301, 384);
            this.button_GetItems.Name = "button_GetItems";
            this.button_GetItems.Size = new System.Drawing.Size(155, 63);
            this.button_GetItems.TabIndex = 1;
            this.button_GetItems.Text = "Загрузить Базу данных";
            this.button_GetItems.UseVisualStyleBackColor = false;
            this.button_GetItems.Click += new System.EventHandler(this.button_GetItems_Click);
            // 
            // TypeStripMenu
            // 
            this.TypeStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПредметToolStripMenuItem});
            this.TypeStripMenu.Name = "TypeStripMenu";
            this.TypeStripMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // добавитьПредметToolStripMenuItem
            // 
            this.добавитьПредметToolStripMenuItem.Name = "добавитьПредметToolStripMenuItem";
            this.добавитьПредметToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьПредметToolStripMenuItem.Text = "Добавить предмет";
            this.добавитьПредметToolStripMenuItem.Click += new System.EventHandler(this.добавитьПредметToolStripMenuItem_Click);
            // 
            // ItemStripMenu
            // 
            this.ItemStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.ItemStripMenu.Name = "ItemStripMenu";
            this.ItemStripMenu.Size = new System.Drawing.Size(155, 48);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.ForeColor = System.Drawing.Color.Brown;
            this.button_Exit.Location = new System.Drawing.Point(462, 384);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(157, 63);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox_AttributeName);
            this.panel1.Controls.Add(this.textBox_AttributeName);
            this.panel1.Controls.Add(this.numericUpDown_Value);
            this.panel1.Controls.Add(this.numericUpDown_Worth);
            this.panel1.Controls.Add(this.button_Cancel);
            this.panel1.Controls.Add(this.button_Execute);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_Description);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox_ItemType);
            this.panel1.Controls.Add(this.textBox_NameItem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_TitleFunction);
            this.panel1.Location = new System.Drawing.Point(301, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 374);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // button_Execute
            // 
            this.button_Execute.BackColor = System.Drawing.Color.LightSalmon;
            this.button_Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Execute.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Execute.ForeColor = System.Drawing.Color.Black;
            this.button_Execute.Location = new System.Drawing.Point(28, 295);
            this.button_Execute.Name = "button_Execute";
            this.button_Execute.Size = new System.Drawing.Size(121, 63);
            this.button_Execute.TabIndex = 14;
            this.button_Execute.Text = "Назавние кнопки";
            this.button_Execute.UseVisualStyleBackColor = false;
            this.button_Execute.Click += new System.EventHandler(this.button_Execute_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Описание предмета";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(28, 201);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(253, 88);
            this.textBox_Description.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(157, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип атрибута";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(157, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Значание атрибута";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тип Предмета";
            // 
            // comboBox_ItemType
            // 
            this.comboBox_ItemType.FormattingEnabled = true;
            this.comboBox_ItemType.Items.AddRange(new object[] {
            "Оружие ближенго боя",
            "Оружие дальнего боя",
            "Шлем",
            "Нагрудник",
            "Поножи",
            "Ноги",
            "Квестовый           "});
            this.comboBox_ItemType.Location = new System.Drawing.Point(28, 110);
            this.comboBox_ItemType.Name = "comboBox_ItemType";
            this.comboBox_ItemType.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ItemType.TabIndex = 3;
            this.comboBox_ItemType.TextChanged += new System.EventHandler(this.comboBox_ItemType_TextChanged);
            // 
            // textBox_NameItem
            // 
            this.textBox_NameItem.Location = new System.Drawing.Point(28, 62);
            this.textBox_NameItem.Name = "textBox_NameItem";
            this.textBox_NameItem.Size = new System.Drawing.Size(253, 20);
            this.textBox_NameItem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название предмета";
            // 
            // label_TitleFunction
            // 
            this.label_TitleFunction.AutoSize = true;
            this.label_TitleFunction.Font = new System.Drawing.Font("Clickuper", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TitleFunction.ForeColor = System.Drawing.Color.Brown;
            this.label_TitleFunction.Location = new System.Drawing.Point(27, 4);
            this.label_TitleFunction.Name = "label_TitleFunction";
            this.label_TitleFunction.Size = new System.Drawing.Size(263, 38);
            this.label_TitleFunction.TabIndex = 0;
            this.label_TitleFunction.Text = "Название операции";
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.LightSalmon;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.button_Cancel.Location = new System.Drawing.Point(160, 295);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(121, 63);
            this.button_Cancel.TabIndex = 15;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // numericUpDown_Worth
            // 
            this.numericUpDown_Worth.Location = new System.Drawing.Point(28, 154);
            this.numericUpDown_Worth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Worth.Name = "numericUpDown_Worth";
            this.numericUpDown_Worth.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_Worth.TabIndex = 16;
            this.numericUpDown_Worth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_Value
            // 
            this.numericUpDown_Value.Location = new System.Drawing.Point(160, 154);
            this.numericUpDown_Value.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Value.Name = "numericUpDown_Value";
            this.numericUpDown_Value.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_Value.TabIndex = 17;
            this.numericUpDown_Value.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_AttributeName
            // 
            this.textBox_AttributeName.Enabled = false;
            this.textBox_AttributeName.Location = new System.Drawing.Point(160, 110);
            this.textBox_AttributeName.Name = "textBox_AttributeName";
            this.textBox_AttributeName.Size = new System.Drawing.Size(121, 20);
            this.textBox_AttributeName.TabIndex = 18;
            // 
            // comboBox_AttributeName
            // 
            this.comboBox_AttributeName.AutoCompleteCustomSource.AddRange(new string[] {
            "Здоровье",
            "Регенерация здоровья",
            "Нет"});
            this.comboBox_AttributeName.FormattingEnabled = true;
            this.comboBox_AttributeName.Items.AddRange(new object[] {
            "Здоровье",
            "Регенерация здоровья",
            "Нет"});
            this.comboBox_AttributeName.Location = new System.Drawing.Point(160, 110);
            this.comboBox_AttributeName.Name = "comboBox_AttributeName";
            this.comboBox_AttributeName.Size = new System.Drawing.Size(121, 21);
            this.comboBox_AttributeName.TabIndex = 19;
            this.comboBox_AttributeName.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_GetItems);
            this.Controls.Add(this.treeView1);
            this.Name = "MainMenu";
            this.Text = "Древовидное представление";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.TypeStripMenu.ResumeLayout(false);
            this.ItemStripMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Worth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Value)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button_GetItems;
        private System.Windows.Forms.ContextMenuStrip TypeStripMenu;
        private System.Windows.Forms.ToolStripMenuItem добавитьПредметToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ItemStripMenu;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_TitleFunction;
        private System.Windows.Forms.TextBox textBox_NameItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Execute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_ItemType;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.NumericUpDown numericUpDown_Value;
        private System.Windows.Forms.NumericUpDown numericUpDown_Worth;
        private System.Windows.Forms.TextBox textBox_AttributeName;
        private System.Windows.Forms.ComboBox comboBox_AttributeName;
    }
}

