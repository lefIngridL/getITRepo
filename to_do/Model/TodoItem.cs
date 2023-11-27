using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_do.Model
{
    internal class TodoItem
    {
        public string Text { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime? Done { get; set; }

        public TodoItem(string text, DateTime deadline)
        {
            Text = text;
            Deadline = deadline;
        }

        public string AsText()
        {
            return Deadline.ToShortDateString().PadRight(11)
                   + (Done?.ToShortDateString() ?? "").PadRight(11)
                   + Text;
        }

        public void MarkAsDone()
        {
            Done = DateTime.Now;
        }
    }
}
