﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DDay.iCal.Validator
{
    public interface IValidationRule :
        ICalendarTestProvider
    {
        string Name { get; }
        Type ValidatorType { get; }
    }
}
