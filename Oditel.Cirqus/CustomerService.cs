﻿using System;
using d60.Cirqus;
using Oditel.Cirqus.Models.Commands;
using Oditel.Cirqus.Models.Exceptions;
using Oditel.Models;
using Oditel.Services;

namespace Oditel.Cirqus
{
    public class CustomerService : ICustomerService
    {
        private readonly ICommandProcessor _processor;

        public CustomerService(ICommandProcessor processor)
        {
            _processor = processor;
        }

        public Guid AddCustomer(ICustomer customer)
        {
            var command = new AddCustomerCommand(customer);
            var result = _processor.ProcessCommand(command);
            if (result.EventsWereEmitted)
            {
                return command.CreatedGuid;
            }
            throw new CreationFailedException(command.CreatedGuid, typeof(ICustomer));
        }
    }
}