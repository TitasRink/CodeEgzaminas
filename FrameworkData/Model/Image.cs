using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkData.Model
{
    public class Image
    {
        public int Id { get; set; }
        public byte[] Byte { get; set; }
        [ForeignKey("Note")]
        public int NoteId { get; set; }
        public Note Note { get; set; }

        public Image(byte[] @byte, int noteid)
        {
            NoteId = noteid;
            Byte = @byte;
        }
        public Image()
        {

        }
    }
}
