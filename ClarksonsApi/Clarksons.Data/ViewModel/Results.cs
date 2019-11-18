using System;
using System.Collections.Generic;
using System.Text;

namespace Clarksons.Search.Data.ViewModel
{
    public class Results
    {
        public bool Succeeded { get; set; }
        public List<Item<string>> Messages { get; set; }

        public Results()
        {
            Messages = new List<Item<string>>();
        }

        public void AddMessage(string Name)
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                Messages.Add(new Item<string> { Text = Name });
            }
        }

        public void AddMessage(string Id, string Name)
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                Messages.Add(new Item<string> { Id = Id, Text = Name });
            }
        }
    }
}
