using TrainBooking.Model;

namespace TrainBooking.Data
{
    public class SeatBookingRepository
    {

        private AppDBContext dBContext;

        public SeatBookingRepository(AppDBContext context)
        {
            dBContext = context;
        }

        public bool CreateSeatBooking(SeatBooking seatbooking)
        {
            if (seatbooking != null)
            {
                dBContext.seatbookings.Add(seatbooking);
                return Save();
            }
            else
                return false;
        }

        public bool Save()
        {
            int count = dBContext.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;

        }

        public bool UpdateSeatBooking(SeatBooking seatbooking)
        {
            dBContext.seatbookings.Update(seatbooking);
            return Save();
        }

        public bool RemoveSeatBooking(SeatBooking seatbooking)
        {
            dBContext.seatbookings.Remove(seatbooking);
            return Save();
        }

        public SeatBooking GetSeatBooking(int id)
        {
            return dBContext.seatbookings.FirstOrDefault(seatbooking => seatbooking.Id == id);
        }

        public IEnumerable<SeatBooking> GetSeatBookings()
        {
            return dBContext.seatbookings.ToList();
        }
    }
}
