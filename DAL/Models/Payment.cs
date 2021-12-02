using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public decimal Amount { get; set; }
        public decimal Allowance { get; set; }
    }
}
