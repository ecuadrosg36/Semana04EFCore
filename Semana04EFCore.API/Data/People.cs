﻿using System;
using System.Collections.Generic;

namespace Semana04EFCore.API.Data;

public partial class Product
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Unit_Price { get; set; }

}
