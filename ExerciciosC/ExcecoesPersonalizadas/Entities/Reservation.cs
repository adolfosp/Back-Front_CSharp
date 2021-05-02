using ExcecoesPersonalizadas.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExcecoesPersonalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("A data de checkou não pode ser menor que a data de checkIn");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public Reservation()
        {
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public override string ToString()
        {
            return "Romm "
                + RoomNumber
                + ", CheckIn "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", CheckOut"
                + ", "
                + Duration()
                + " nights";

        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
              throw new DomainException("Datas da reserva não podem ser menor que a data atual");
            }
             if (checkOut <= checkIn)
            {
                throw new DomainException("A data de checkou não pode ser menor que a data de checkIn");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}
