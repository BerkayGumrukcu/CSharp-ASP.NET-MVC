using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Services
{
    public class CustomerMessageService : BaseService<CustomerMessage>, ICustomerMessageService
    {
        private ProjectContext _context;

        public CustomerMessageService(ProjectContext context) : base(context)
        {
            _context = context;
        }


    }
}
