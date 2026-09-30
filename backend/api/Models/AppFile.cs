using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class AppFile
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public long Size { get; set; }
        public string StoredFileName { get; set; } = string.Empty;
    }
}