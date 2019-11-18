using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clarksons.Search.Data.ViewModel
{
    public class Item<T>
    {
        public T Id { get; set; }

        [StringLength(150)]
        public string Text { get; set; }
    }
}
