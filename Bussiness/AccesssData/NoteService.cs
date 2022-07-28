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


        public List<Note> FindNotesByName(string name, int userID)
        {
            var notes = context.Users.Include(x => x.Notes).Where(i => i.Id == userID).FirstOrDefault().Notes.Where(x=>x.Name == name).ToList();
            //var filteredNotes = context.Notes
             //   .Where(i => i.Name == name).ToList();

            return notes;
        }

        public List<Note> FindNotesByCategoryName(string categoryName, int userID)
        {
            var filteredNotes = context.Notes
                .Include(x => x.Categories)
                .Where(x=>x.Categories.Any(x=>x.Name == categoryName))
                .Include(i => i.Images)
                .Where(x => x.UserId == userID)
                .ToList();


            //var filteredNotes = context.Categories
            //    .Include(i => i.Notes)
            //    .Where(x=>x.UserId == userID)
            //    .Where(i => i.Name == categoryName).FirstOrDefault().Notes.ToList();

            return filteredNotes;
        }

        public List<Note> GetAllNotesByUser(int userId)
        {
            
            var notes = context.Notes
                .Include(i => i.Categories)
                .Include(i => i.Images)
                .Where(i => i.UserId == userId)
                .ToList();

            return notes;
        }


    }
}
