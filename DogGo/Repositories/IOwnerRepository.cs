﻿using DogGo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);

        Owner AddOwner(Owner owner);
        Owner UpdateOwner(Owner owner);
        Owner DeleteOwner(int ownerId);

    }


}