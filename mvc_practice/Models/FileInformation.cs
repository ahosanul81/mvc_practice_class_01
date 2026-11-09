using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_practice.Models
{
    public class FileInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }
    }
}