﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGitApp
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class CustomerV1 :Customer
    {

    }

    public class CustomerV2 : CustomerV1
    {
        public string version;
    }
	
	public class CustomerV3 : CustomerV1
	{

	}
}
