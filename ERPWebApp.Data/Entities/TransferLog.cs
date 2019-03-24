﻿using ERPWebApp.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERPWebApp.Data.Entities
{
    public class TransferLog : DomainEntity<int>
    {
        int MerchantFK { get; set; }
    }
}
