using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadas.Exceptions;
using System;

namespace ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("RoomNumber");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("CheckIn date (dd/MM/yyyy)");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("CheckOut date (dd/MM/yyyy)");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("OK");

                Console.WriteLine("");
                Console.WriteLine("Entre com os dados para atualizar a reserva");

                Console.WriteLine("CheckIn date (dd/MM/yyyy)");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("CheckOut date (dd/MM/yyyy)");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);

            }catch(FormatException e)
            {
                Console.WriteLine("Formato incorreto "+e.Message);
            }catch(Exception e)
            {
                Console.WriteLine("Houve um erro "+e.Message);
            }
           



        }
    }
}
