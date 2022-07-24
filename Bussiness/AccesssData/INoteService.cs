using FrameworkData.Model;
using System.Collections.Generic;

namespace Bussiness.AccesssData
{
    public interface INoteService
    {
        void AssignACategoryToTheNote(int noteId, int categoryId);
        void CreateNote(string name, string address, int userId);
        void EditTheNote(int noteId, string noteContent);
        List<Note> FindNotesByCategoryName(string categoryName, int userId);
        List<Note> FindNotesByTitle(string noteTitle, int userId);
        List<Note> GetAllNotesByUser(int userId);
        void RemoveTheNote(int noteId);
    }
}