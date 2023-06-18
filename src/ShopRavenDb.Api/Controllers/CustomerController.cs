namespace ShopRavenDb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerApplication _customerApplication;

        public CustomerController(ICustomerApplication customerApplication)
        {
            _customerApplication = customerApplication;
        }

        [HttpPost("customer", Name = "add-customer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<CustomerDto>> AddCustomer(CustomerDto customerDto)
        {
            _customerApplication.AddCustomer(customerDto);

            return Ok("Customer Inserted Sucessfully!");
        }

        [HttpPut("customer", Name = "update-customer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<CustomerDto>> UpdateCustomer(CustomerDto customerDto)
        {
            _customerApplication.UpdateCustomer(customerDto);

            return Ok("Customer Updated Sucessfully!");
        }

        [HttpDelete("customer/{customerId}", Name = "delete-customer-by-id")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<CustomerDto>> DeleteCustomerById(string customerId)
        {
            var formattedCustomerId = Uri.UnescapeDataString(customerId);

            _customerApplication.DeleteCustomerById(formattedCustomerId);

            return Ok("Customer Deleted Sucessfully!");
        }

        [HttpGet("customers", Name = "get-customers")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<CustomerDto>> GetCustomers()
        {
            return Ok(_customerApplication.GetCustomers());
        }

        [HttpGet("customer/{customerId}", Name = "get-customer-by-id")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<CustomerDto>> GetCustomerById(string customerId)
        {
            var formattedCustomerId = Uri.UnescapeDataString(customerId);

            var customer = _customerApplication.GetCustomerById(formattedCustomerId);

            if (customer is null)
                return NotFound();
            else
                return Ok(customer);
        }
    }
}
