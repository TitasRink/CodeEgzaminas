namespace WinFormsApp1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryAttributeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategorylistView = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.AddCategorytextBox1 = new System.Windows.Forms.TextBox();
            this.RenameCategoryTextBox = new System.Windows.Forms.TextBox();
            this.NoteListViewItem = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.MessageAddInput = new System.Windows.Forms.TextBox();
            this.NameAddInput = new System.Windows.Forms.TextBox();
            this.input12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AddCategorybutton = new System.Windows.Forms.Button();
            this.RenameCategoryButton = new System.Windows.Forms.Button();
            this.AddButtonNote = new System.Windows.Forms.Button();
            this.RenameNoteButton = new System.Windows.Forms.Button();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.RemoveCategoryButton = new System.Windows.Forms.Button();
            this.NoteEdittextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ShowByCategoryButton = new System.Windows.Forms.Button();
            this.ShowALLButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoryAttributeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 758);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rename Category";
            // 
            // categoryAttributeBindingSource
            // 
            this.categoryAttributeBindingSource.DataSource = typeof(System.ComponentModel.CategoryAttribute);
            // 
            // CategorylistView
            // 
            this.CategorylistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name});
            this.CategorylistView.HideSelection = false;
            this.CategorylistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.CategorylistView.Location = new System.Drawing.Point(181, 47);
            this.CategorylistView.Name = "CategorylistView";
            this.CategorylistView.Size = new System.Drawing.Size(215, 286);
            this.CategorylistView.TabIndex = 7;
            this.CategorylistView.UseCompatibleStateImageBehavior = false;
            this.CategorylistView.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Category Name";
            this.Name.Width = 200;
            // 
            // AddCategorytextBox1
            // 
            this.AddCategorytextBox1.Location = new System.Drawing.Point(64, 65);
            this.AddCategorytextBox1.Name = "AddCategorytextBox1";
            this.AddCategorytextBox1.Size = new System.Drawing.Size(100, 23);
            this.AddCategorytextBox1.TabIndex = 8;
            // 
            // RenameCategoryTextBox
            // 
            this.RenameCategoryTextBox.Location = new System.Drawing.Point(64, 165);
            this.RenameCategoryTextBox.Name = "RenameCategoryTextBox";
            this.RenameCategoryTextBox.Size = new System.Drawing.Size(100, 23);
            this.RenameCategoryTextBox.TabIndex = 9;
            // 
            // NoteListViewItem
            // 
            this.NoteListViewItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.NoteListViewItem.HideSelection = false;
            this.NoteListViewItem.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.NoteListViewItem.Location = new System.Drawing.Point(181, 375);
            this.NoteListViewItem.Name = "NoteListViewItem";
            this.NoteListViewItem.Size = new System.Drawing.Size(709, 352);
            this.NoteListViewItem.TabIndex = 10;
            this.NoteListViewItem.UseCompatibleStateImageBehavior = false;
            this.NoteListViewItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Message";
            this.columnHeader2.Width = 500;
            // 
            // MessageAddInput
            // 
            this.MessageAddInput.Location = new System.Drawing.Point(75, 404);
            this.MessageAddInput.Name = "MessageAddInput";
            this.MessageAddInput.Size = new System.Drawing.Size(100, 23);
            this.MessageAddInput.TabIndex = 15;
            // 
            // NameAddInput
            // 
            this.NameAddInput.Location = new System.Drawing.Point(74, 375);
            this.NameAddInput.Name = "NameAddInput";
            this.NameAddInput.Size = new System.Drawing.Size(100, 23);
            this.NameAddInput.TabIndex = 14;
            // 
            // input12
            // 
            this.input12.AutoSize = true;
            this.input12.Location = new System.Drawing.Point(12, 407);
            this.input12.Name = "input12";
            this.input12.Size = new System.Drawing.Size(53, 15);
            this.input12.TabIndex = 12;
            this.input12.Text = "Message";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(592, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 247);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(452, 310);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(438, 23);
            this.textBox5.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Add IMG";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddCategorybutton
            // 
            this.AddCategorybutton.Location = new System.Drawing.Point(64, 94);
            this.AddCategorybutton.Name = "AddCategorybutton";
            this.AddCategorybutton.Size = new System.Drawing.Size(100, 23);
            this.AddCategorybutton.TabIndex = 19;
            this.AddCategorybutton.Text = "Add";
            this.AddCategorybutton.UseVisualStyleBackColor = true;
            this.AddCategorybutton.Click += new System.EventHandler(this.AddCategorybutton_Click);
            // 
            // RenameCategoryButton
            // 
            this.RenameCategoryButton.Location = new System.Drawing.Point(64, 194);
            this.RenameCategoryButton.Name = "RenameCategoryButton";
            this.RenameCategoryButton.Size = new System.Drawing.Size(101, 23);
            this.RenameCategoryButton.TabIndex = 20;
            this.RenameCategoryButton.Text = "Rename";
            this.RenameCategoryButton.UseVisualStyleBackColor = true;
            this.RenameCategoryButton.Click += new System.EventHandler(this.RenameCategoryButton_Click);
            // 
            // AddButtonNote
            // 
            this.AddButtonNote.Location = new System.Drawing.Point(74, 433);
            this.AddButtonNote.Name = "AddButtonNote";
            this.AddButtonNote.Size = new System.Drawing.Size(100, 23);
            this.AddButtonNote.TabIndex = 21;
            this.AddButtonNote.Text = "Add";
            this.AddButtonNote.UseVisualStyleBackColor = true;
            this.AddButtonNote.Click += new System.EventHandler(this.AddButtonNote_Click);
            // 
            // RenameNoteButton
            // 
            this.RenameNoteButton.Location = new System.Drawing.Point(74, 525);
            this.RenameNoteButton.Name = "RenameNoteButton";
            this.RenameNoteButton.Size = new System.Drawing.Size(101, 23);
            this.RenameNoteButton.TabIndex = 22;
            this.RenameNoteButton.Text = "Rename";
            this.RenameNoteButton.UseVisualStyleBackColor = true;
            this.RenameNoteButton.Click += new System.EventHandler(this.RenameNoteButton_Click);
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.Location = new System.Drawing.Point(75, 586);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(101, 43);
            this.RemoveNoteButton.TabIndex = 23;
            this.RemoveNoteButton.Text = "Remove";
            this.RemoveNoteButton.UseVisualStyleBackColor = true;
            this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
            // 
            // RemoveCategoryButton
            // 
            this.RemoveCategoryButton.Location = new System.Drawing.Point(64, 289);
            this.RemoveCategoryButton.Name = "RemoveCategoryButton";
            this.RemoveCategoryButton.Size = new System.Drawing.Size(101, 43);
            this.RemoveCategoryButton.TabIndex = 24;
            this.RemoveCategoryButton.Text = "Remove";
            this.RemoveCategoryButton.UseVisualStyleBackColor = true;
            this.RemoveCategoryButton.Click += new System.EventHandler(this.RemoveCategoryButton_Click);
            // 
            // NoteEdittextBox
            // 
            this.NoteEdittextBox.Location = new System.Drawing.Point(75, 496);
            this.NoteEdittextBox.Name = "NoteEdittextBox";
            this.NoteEdittextBox.Size = new System.Drawing.Size(100, 23);
            this.NoteEdittextBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Message";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 749);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 32);
            this.button3.TabIndex = 28;
            this.button3.Text = "Add Note to Category";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ShowByCategoryButton
            // 
            this.ShowByCategoryButton.Location = new System.Drawing.Point(417, 82);
            this.ShowByCategoryButton.Name = "ShowByCategoryButton";
            this.ShowByCategoryButton.Size = new System.Drawing.Size(134, 23);
            this.ShowByCategoryButton.TabIndex = 29;
            this.ShowByCategoryButton.Text = "Show By Category";
            this.ShowByCategoryButton.UseVisualStyleBackColor = true;
            this.ShowByCategoryButton.Click += new System.EventHandler(this.ShowByCategoryButton_Click);
            // 
            // ShowALLButton
            // 
            this.ShowALLButton.Location = new System.Drawing.Point(417, 127);
            this.ShowALLButton.Name = "ShowALLButton";
            this.ShowALLButton.Size = new System.Drawing.Size(134, 23);
            this.ShowALLButton.TabIndex = 30;
            this.ShowALLButton.Text = "Show ALL";
            this.ShowALLButton.UseVisualStyleBackColor = true;
            this.ShowALLButton.Click += new System.EventHandler(this.ShowALLButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(384, 749);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 32);
            this.button4.TabIndex = 31;
            this.button4.Text = "Show ALL by Name";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 817);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ShowALLButton);
            this.Controls.Add(this.ShowByCategoryButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NoteEdittextBox);
            this.Controls.Add(this.RemoveCategoryButton);
            this.Controls.Add(this.RemoveNoteButton);
            this.Controls.Add(this.RenameNoteButton);
            this.Controls.Add(this.AddButtonNote);
            this.Controls.Add(this.RenameCategoryButton);
            this.Controls.Add(this.AddCategorybutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MessageAddInput);
            this.Controls.Add(this.NameAddInput);
            this.Controls.Add(this.input12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NoteListViewItem);
            this.Controls.Add(this.RenameCategoryTextBox);
            this.Controls.Add(this.AddCategorytextBox1);
            this.Controls.Add(this.CategorylistView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Text = "main";
            ((System.ComponentModel.ISupportInitialize)(this.categoryAttributeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource categoryAttributeBindingSource;
        private System.Windows.Forms.ListView CategorylistView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.TextBox AddCategorytextBox1;
        private System.Windows.Forms.TextBox RenameCategoryTextBox;
        private System.Windows.Forms.ListView NoteListViewItem;
        private System.Windows.Forms.TextBox MessageAddInput;
        private System.Windows.Forms.TextBox NameAddInput;
        private System.Windows.Forms.Label input12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddCategorybutton;
        private System.Windows.Forms.Button RenameCategoryButton;
        private System.Windows.Forms.Button AddButtonNote;
        private System.Windows.Forms.Button RenameNoteButton;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button RemoveCategoryButton;
        private System.Windows.Forms.TextBox NoteEdittextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ShowByCategoryButton;
        private System.Windows.Forms.Button ShowALLButton;
        private System.Windows.Forms.Button button4;
    }
}