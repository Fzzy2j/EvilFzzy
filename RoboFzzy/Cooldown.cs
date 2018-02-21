using System;
using System.Collections.Generic;
using System.Text;

namespace RoboFzzy
{
    class Cooldown
    {
        public ulong id;

        public Cooldown(ulong id, long lastUsed)
        {
            this.id = id;
            this.lastUsed = lastUsed;
        }

        public long lastUsed { get; set; }

    }
}
