using System;

namespace WebApplicationForAPInet5.Models
{
    public class Folder
    {
        public string FolderId { get; set; }
        public string name { get; set; }
        public string extension { get; set; }
        public DateTime createAt { get; set; }
        public string createBy { get; set; }
        public DateTime modifiedAt { get; set; }
        public string modifiedBy { get; set; }
    }
}
