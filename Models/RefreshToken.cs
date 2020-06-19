using System;
using System.Collections.Generic;

namespace Kollokwium_2.Models
{
    public partial class RefreshToken
    {
        public string Id { get; set; }
        public string HashingPassword { get; set; }
        public string Salt { get; set; }
    }
}
