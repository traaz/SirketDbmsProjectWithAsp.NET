﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICalisanService
    {
        IDataResult<List<Calisan>> GetAll();
        IResult Add(Calisan calisan);
        IResult Delete(Calisan calisan);
        IResult Update(Calisan calisan);
    }
}