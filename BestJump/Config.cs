using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestJump
{
    public class Config:IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public float RemoveStamina { get; set; } = 0.1f;
    }
}
