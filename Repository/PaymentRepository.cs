using Contracts;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
    {
        public PaymentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public void CreatePayment(Payment payment) =>
            Create(payment);
        public void DeletePayment(Payment payment) =>
            Delete(payment);
        public IEnumerable<Payment> GetAllPayments()=>
            FindAll()
            .OrderBy(x => x.Date)
            .ToList();

        public Payment GetPaymentById(int Id) =>
            FindByCondition(c => c.Id.Equals(Id)).SingleOrDefault();

        public void UpdatePayment(Payment payment)=>
            Update(payment);
    }
}
