using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.models {
    public class AuthorList {
        public string AppUserId { get; set; }
        public int CustomerId { get; set; }
        public AppUser AppUser { get; set; }

    }
}