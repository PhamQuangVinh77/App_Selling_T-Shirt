﻿using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QUANLY.IServices
{
    public interface IQLmauSacServices
    {
        List<mauSac> GetMauSacFromDB();
        bool addMauSac(mauSac MauSac);
        bool RemoveMauSac(mauSac MauSac);
        bool UpdateMauSac(mauSac MauSac);
    }
}
