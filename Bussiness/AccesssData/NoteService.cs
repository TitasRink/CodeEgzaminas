using FrameworkData.DataContext;
using FrameworkData.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bussiness.AccesssData
{
    public class NoteService 
    {
        public DataConection context = new DataConection();
        public void CreateNote(string name, string address, int userId)
        {

            Note pat = new Note(name, address);
            context.Users.Where(x => x.Id == userId).FirstOrDefault().Notes.Add(pat);
            context.SaveChanges();
        }

        public void AssignACategoryToTheNote(string noteId, string categoryId)
        {
            var note = context.Notes
                .Include(i => i.Categories)
                .FirstOrDefault(i => i.Name == noteId);

            var category = context.Categories.Where(x => x.Name == categoryId).FirstOrDefault();
            category.Notes.Add(note);
            note.Categories.Add(category);
            context.SaveChanges();

        }

        public void EditTheNote(string noteId, string noteContent)
        {
            var note = context.Notes.Where(x => x.Name == noteId).FirstOrDefault();


            note.Message = noteContent;

            context.Notes.Update(note);
            context.SaveChanges();
        }

        public void RemoveTheNote(string noteId)
        {
            var note = context.Notes.Where(x=>x.Name==noteId).FirstOrDefault();

            context.Notes.Remove(note);
            context.SaveChanges();
        }


        public List<Note> FindNotesByName(string name)
        {

            var filteredNotes = context.Notes
                .Where(i => i.Name == name).ToList();

            return filteredNotes;
        }

        public List<Note> FindNotesByCategoryName(string categoryName)
        {

            var filteredNotes = context.Categories
                .Include(i => i.Notes)
                .Where(i => i.Name == categoryName).FirstOrDefault().Notes.ToList();

            return filteredNotes;
        }

        public List<Note> GetAllNotesByUser(int userId)
        {

            var notes = context.Notes
                .Include(i => i.Categories)
                .Where(i => i.UserId == userId)
                .ToList();

            return notes;
        }
    }
}
