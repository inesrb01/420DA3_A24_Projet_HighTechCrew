﻿using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class PurchaseOrderDAO {

    private readonly AppDbContexte context;

    public PurchaseOrderDAO(AppDbContexte context) {
        this.context = context;
    }

    

}
