﻿using GMonitoria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMonitoria.Domain.Interfaces.Domain
{
    public interface IServicesOfDomain
    {
        bool Login(out string retorno);
    }
}
