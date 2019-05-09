﻿using HRM.Infra.CrossCutting.Identity.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRM.Infra.CrossCutting.Identity.Validations
{
    public class ExchangeRefreshTokenRequestValidation : AuthValidation<ExchangeRefreshTokenRequest>
    {
        public ExchangeRefreshTokenRequestValidation()
        {
            ValidateExchangeRefreshToken();       
        }
    }
}
