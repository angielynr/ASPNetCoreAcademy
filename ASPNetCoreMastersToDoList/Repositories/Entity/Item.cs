using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entity
{
    public class Item
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Priority { get; set; }
        public bool isDone { get; set; }
    }
}
