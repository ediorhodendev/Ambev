﻿namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.Create
{
    public class CreateCustomerRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }

}
