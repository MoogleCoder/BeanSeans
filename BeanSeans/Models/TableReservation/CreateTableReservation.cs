using BeanSeans.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeanSeans.Models.TableReservation
{
    public class CreateTableReservation
    {
        public Table  Table { get; set; }

        public Data.Reservation Reservation { get; set; }
    }
}
