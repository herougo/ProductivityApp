using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityApp.Core.Data.Models
{
    public class ButtonClick
    {
        public int Id { get; set; }

        public DateTime ClickedAt {  get; set; }

        public ClickType ClickType {  get; set; }
    }
}
