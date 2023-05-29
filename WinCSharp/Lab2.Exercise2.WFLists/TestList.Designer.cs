namespace ITMO2023.WinCSharp.Lab7
{
    partial class TestList
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
            this.peopleList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.memberList = new System.Windows.Forms.CheckedListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleList
            // 
            this.peopleList.FormattingEnabled = true;
            this.peopleList.Items.AddRange(new object[] {
            "Трищенко А.В.",
            "Самарченко Б.Г.",
            "Иванова И.А.",
            "Карташева О.И.",
            "Самыкин О.В.",
            "Печалина Н.А."});
            this.peopleList.Location = new System.Drawing.Point(247, 12);
            this.peopleList.Name = "peopleList";
            this.peopleList.Size = new System.Drawing.Size(121, 21);
            this.peopleList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.memberList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список участников";
            // 
            // memberList
            // 
            this.memberList.FormattingEnabled = true;
            this.memberList.Location = new System.Drawing.Point(7, 20);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(120, 94);
            this.memberList.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 222);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(157, 222);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(284, 222);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(80, 23);
            this.buttonSort.TabIndex = 6;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // TestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 257);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.peopleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TestList";
            this.Text = "Работа со списками";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox peopleList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox memberList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSort;
    }
}

