using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api1.Models
{
    public enum Category
    {
        NONE,
        PRESENTATION,
        APPLICATION,
        OTHER
    }
    public class FileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public Category Category { get; set; }
       public byte[] AddedFile { get; set; }
    }
}
