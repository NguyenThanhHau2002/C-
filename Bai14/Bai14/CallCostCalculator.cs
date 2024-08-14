using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    public class CallCostCalculator
    {
        private static readonly decimal BASE_RATE = 0.40m; // Giá cơ bản
        private static readonly decimal FEDERAL_TAX = 0.04m; // Thuế liên bang
        private static readonly decimal NIGHT_DISCOUNT = 0.50m; // Giảm giá cho cuộc gọi ban đêm
        private static readonly decimal LONG_CALL_DISCOUNT = 0.15m; // Giảm giá cho cuộc gọi dài
        private const int LONG_CALL_THRESHOLD = 60; // Ngưỡng cuộc gọi dài

        public static decimal CalculateTotalCost(int startHour, int startMinute, int durationMinutes)
        {
            TimeSpan startTime = new TimeSpan(startHour, startMinute, 0);
            decimal totalCost = BASE_RATE * durationMinutes; // Tính tổng chi phí
            decimal discountedCost = ApplyTimeDiscount(startTime, totalCost); // Áp dụng giảm giá theo thời gian
            decimal finalCost = ApplyDurationDiscount(discountedCost, durationMinutes); // Áp dụng giảm giá theo độ dài
            return Math.Round(ApplyFederalTax(finalCost), 2); // Tính thuế và làm tròn kết quả
        }

        private static decimal ApplyTimeDiscount(TimeSpan startTime, decimal totalCost)
        {
            if (startTime.Hours >= 18 || startTime.Hours < 8)
            {
                return totalCost * NIGHT_DISCOUNT; // Giảm giá cho cuộc gọi ban đêm
            }
            return totalCost; // Không có giảm giá
        }

        private static decimal ApplyDurationDiscount(decimal cost, int durationMinutes)
        {
            if (durationMinutes > LONG_CALL_THRESHOLD)
            {
                return cost * (1 - LONG_CALL_DISCOUNT); // Giảm giá cho cuộc gọi dài
            }
            return cost; // Không có giảm giá
        }

        private static decimal ApplyFederalTax(decimal cost)
        {
            return cost * (1 + FEDERAL_TAX); // Tính thuế liên bang
        }
    }
}
