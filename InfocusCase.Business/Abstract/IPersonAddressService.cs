﻿using InfocusCase.Entity.Concrete;
using InfocusCase.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfocusCase.Business.Abstract
{
    public interface IPersonAddressService
    {
        void Add(PersonAddress personAddress);
        
    }
}
