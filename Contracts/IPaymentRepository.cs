using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IPaymentRepository
    {
        IEnumerable<Payment> GetAllPayments();
        Payment GetPaymentById(int Id);
        void CreatePayment(Payment payment);
        void DeletePayment(Payment payment);
        void UpdatePayment(Payment payment);
    }
}
