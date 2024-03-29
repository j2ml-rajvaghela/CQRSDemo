﻿using CQRSDemo.Framework.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSDemo.Framework.CQRS.Query
{
    public class GetCustomerByIdQuery : IRequest<CustomerByIdResponse>
    {
        public GetCustomerByIdQuery(long customerID)
        {
            CustomerID = customerID;
        }

        public long CustomerID { get; }
    }
}
