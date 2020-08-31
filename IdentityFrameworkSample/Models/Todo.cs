using System;
using System.Collections.Generic;

namespace IdentityFrameworkSample.Models
{
    public partial class Todo
    {
        public int Id { get; set; }
        public string TodoDesc { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Complete { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
