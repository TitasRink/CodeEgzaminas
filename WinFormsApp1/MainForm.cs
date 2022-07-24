﻿using Bussiness.AccesssData;
using System.Drawing;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class MainForm : Form
    {

        private readonly CategoryService categoryService = new CategoryService();
        private readonly NoteService noteService = new NoteService();
       

        public MainForm()
        {
            InitializeComponent();

            CategorylistView.Items.Clear();
            var cat = categoryService.GetCatAll();
            foreach (var item in cat)
            {
                ListViewItem list = new ListViewItem(item.Name);
                CategorylistView.Items.Add(list);
            }

            NoteListViewItem.Items.Clear();
            var notes = noteService.GetAllNotesByUser(LogIn.UserID);
            foreach (var item in notes)
            {
                ListViewItem not = new ListViewItem(item.Name);
                not.SubItems.Add(item.Message.ToString());
                NoteListViewItem.Items.Add(not);

            }

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            LogIn ne = new LogIn();
            ne.Show();
            this.Close();
        }

        private void AddCategorybutton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(RenameCategoryTextBox.Text))
            {
                MessageBox.Show("Please fill up fields");
            }
            else
            {
                CategorylistView.Items.Clear();
                var cattegory = AddCategorytextBox1.Text;

                categoryService.CreatCat(cattegory);


                var cat = categoryService.GetCatAll();
                foreach (var item in cat)
                {
                    ListViewItem list = new ListViewItem(item.Name);
                    CategorylistView.Items.Add(list);
                }
                AddCategorytextBox1.Text = "";
            }
       
        }

        private void RenameCategoryButton_Click(object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(RenameCategoryTextBox.Text))
            {
                MessageBox.Show("Please fill up fields");
            }
            else
            {
                var catText = CategorylistView.SelectedItems[0].Text;
                var catinput = RenameCategoryTextBox.Text;
                categoryService.EditCat(catinput, catText);

                CategorylistView.Items.Clear();

                var cat = categoryService.GetCatAll();

                foreach (var item in cat)
                {
                    ListViewItem list = new ListViewItem(item.Name);
                    CategorylistView.Items.Add(list);
                }
                RenameCategoryTextBox.Text = "";

            }

        }

        private void RemoveCategoryButton_Click(object sender, System.EventArgs e)
        {

            if (CategorylistView.SelectedItems[0].Text == null )
            {
                MessageBox.Show("Please select what to remove");
            }
            else
            {
                var catText = CategorylistView.SelectedItems[0].Text;

                categoryService.RemoveCategory(catText);
                CategorylistView.Items.Clear();

                var cat = categoryService.GetCatAll();

                foreach (var item in cat)
                {
                    ListViewItem list = new ListViewItem(item.Name);
                    CategorylistView.Items.Add(list);
                }
            }
      
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.jpg;*.jepg;.*.gif;) |*.jpg;*.jepg;.*.gif";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFile.FileName;
                pictureBox1.Image = new Bitmap(fileName);
                textBox5.Text = fileName;
            }
        }

        private void AddButtonNote_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(NameAddInput.Text) || string.IsNullOrEmpty(MessageAddInput.Text))
            {
                MessageBox.Show("Please fill up fields");
            }
            else
            {
                var notename = NameAddInput.Text;
                var mesagenote = MessageAddInput.Text;

                noteService.CreateNote(notename, mesagenote, LogIn.UserID);

                NoteListViewItem.Items.Clear();
                var notes = noteService.GetAllNotesByUser(LogIn.UserID);
                foreach (var item in notes)
                {
                    ListViewItem list = new ListViewItem(item.Name.ToString());
                    list.SubItems.Add(item.Message.ToString());
                    NoteListViewItem.Items.Add(list);
                }
                NameAddInput.Text = "";
                MessageAddInput.Text = "";
            }
        }

        private void RenameNoteButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(NoteEdittextBox.Text))
            {
                MessageBox.Show("Please fill up fields");
            }
            else
            {
                var noteSetectedFromList = NoteListViewItem.SelectedItems[0].Text;

                var text = NoteEdittextBox.Text;
                noteService.EditTheNote(noteSetectedFromList, text);

                NoteListViewItem.Items.Clear();
                var notes = noteService.GetAllNotesByUser(LogIn.UserID);
                foreach (var item in notes)
                {
                    ListViewItem list = new ListViewItem(item.Name.ToString());
                    list.SubItems.Add(item.Message.ToString());
                    NoteListViewItem.Items.Add(list);
                }
                NoteEdittextBox.Text = "";
            }
     
        }

        private void RemoveNoteButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(NoteListViewItem.SelectedItems[0].Text))
            {
                MessageBox.Show("Please select what to remove");
            }
            var noteSetectedFromList = NoteListViewItem.SelectedItems[0].Text;
            noteService.RemoveTheNote(noteSetectedFromList);


            NoteListViewItem.Items.Clear();
            var notes = noteService.GetAllNotesByUser(LogIn.UserID);
            foreach (var item in notes)
            {
                ListViewItem list = new ListViewItem(item.Name.ToString());
                list.SubItems.Add(item.Message.ToString());
                NoteListViewItem.Items.Add(list);
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            var noteSetectedFromList = NoteListViewItem.SelectedItems[0].Text;
            var cat = CategorylistView.SelectedItems[0].Text;

            noteService.AssignACategoryToTheNote(noteSetectedFromList, cat );


            NoteListViewItem.Items.Clear();
            var notes = noteService.GetAllNotesByUser(LogIn.UserID);
            foreach (var item in notes)
            {
                ListViewItem list = new ListViewItem(item.Name.ToString());
                list.SubItems.Add(item.Message.ToString());
                NoteListViewItem.Items.Add(list);
            }
        }

        private void ShowByCategoryButton_Click(object sender, System.EventArgs e)
        {
            var catText = CategorylistView.SelectedItems[0].Text;

            var result = noteService.FindNotesByCategoryName(catText);

            NoteListViewItem.Items.Clear();
            
            foreach (var item in result)
            {
                ListViewItem list = new ListViewItem(item.Name.ToString());
                list.SubItems.Add(item.Message.ToString());
                NoteListViewItem.Items.Add(list);
            }
        }

        private void ShowALLButton_Click(object sender, System.EventArgs e)
        {
            NoteListViewItem.Items.Clear();
            var notes = noteService.GetAllNotesByUser(LogIn.UserID);
            foreach (var item in notes)
            {
                ListViewItem list = new ListViewItem(item.Name.ToString());
                list.SubItems.Add(item.Message.ToString());
                NoteListViewItem.Items.Add(list);
            }
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            var noteSetectedFromList = NoteListViewItem.SelectedItems[0].Text;

            NoteListViewItem.Items.Clear();

            var notes = noteService.FindNotesByName(noteSetectedFromList);
            foreach (var item in notes)
            {
                ListViewItem list = new ListViewItem(item.Name.ToString());
                list.SubItems.Add(item.Message.ToString());
                NoteListViewItem.Items.Add(list);
            }
        }
    }
}
