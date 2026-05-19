using System;

namespace GamingCafeAsset_InventorySystem
{
    internal class DataDeletionHelper
    {
        DBAccessHelper dbHelper = new DBAccessHelper();

        // =====================================================
        // USERS
        // =====================================================

        public ResultSet DeleteUser(int userId)
        {
            string query =
              "DELETE FROM Users WHERE UserID = " + userId;

            return dbHelper.ExecuteNonQuery(query);
        }

        // =====================================================
        // FOOD ITEMS
        // =====================================================

        public ResultSet DeleteFoodItemsByBooking(int bookingId)
        {
            string query =
              "DELETE FROM FoodItem WHERE BookingID = " + bookingId;

            return dbHelper.ExecuteNonQuery(query);
        }

        // =====================================================
        // BOOKINGS
        // =====================================================

        public ResultSet DeletePaymentsByBooking(int bookingId)
        {
            string query =
              "DELETE FROM Payment WHERE BookingID = " + bookingId;

            return dbHelper.ExecuteNonQuery(query);
        }

        public ResultSet DeleteBookingsByDevice(int deviceId)
        {
            string query =
              "DELETE FROM Booking WHERE DeviceID = " + deviceId;

            return dbHelper.ExecuteNonQuery(query);
        }

        // =====================================================
        // DEVICE
        // =====================================================

        public ResultSet DeleteDevice(int deviceId)
        {
            string query =
              "DELETE FROM Device WHERE DeviceID = " + deviceId;

            return dbHelper.ExecuteNonQuery(query);
        }

        public ResultSet SetDeviceStatus(int deviceId, string status)
        {
            string query =
              "UPDATE Device SET Status = '" + status +
              "' WHERE DeviceID = " + deviceId;

            return dbHelper.ExecuteNonQuery(query);
        }

        // =====================================================
        // DEVICE CATEGORY MAP
        // =====================================================

        public ResultSet DeleteDeviceCategoryMap(int deviceId)
        {
            string query =
              "DELETE FROM DeviceCategoryMap WHERE DeviceID = " + deviceId;

            return dbHelper.ExecuteNonQuery(query);
        }

        // =====================================================
        // DEVICE GAME MAP
        // =====================================================

        public ResultSet DeleteDeviceGameMap(int deviceId)
        {
            string query =
              "DELETE FROM DeviceGames WHERE DeviceID = " + deviceId;

            return dbHelper.ExecuteNonQuery(query);
        }

        // =====================================================
        // GAME
        // =====================================================

        public ResultSet DeleteGame(int gameId)
        {
            string query =
              "DELETE FROM Games WHERE GameID = " + gameId;

            return dbHelper.ExecuteNonQuery(query);
        }

        // =====================================================
        // SAFE CHECKS
        // =====================================================

        public bool HasDeviceBooking(int deviceId)
        {
            string query =
              "SELECT COUNT(*) FROM Booking WHERE DeviceID = " + deviceId;

            ResultSet result = dbHelper.GetQueryData(query);

            if (result.HasError || result.Data == null || result.Data.Rows.Count == 0)
                return false;

            return Convert.ToInt32(result.Data.Rows[0][0]) > 0;
        }
    }
}
