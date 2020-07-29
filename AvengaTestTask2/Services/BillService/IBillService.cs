using System;
using AvengaTestTask2.Models;

namespace AvengaTestTask2.Services.BillService
{
    public interface IBillService
    {
        void PrintOrderBill(Order order);
    }
}
