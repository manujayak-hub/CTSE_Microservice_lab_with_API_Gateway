using Microsoft.AspNetCore.Mvc;

namespace PaymentService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        private static List<Payment> _payments = new();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_payments);
        }

        [HttpPost]
        public IActionResult Process(Payment payment)
        {
            payment.Id = _payments.Count + 1;
            payment.PaymentDate = DateTime.Now;
            payment.Status = "Completed";

            _payments.Add(payment);

            return Ok(payment);
        }
    }

    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }
    }
}