using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Interfaces.CORE.Interfaces
{
    public interface IVolumeChangeable
    {
        int CurrentVolume { get; }

        void VolumeUp();
        void VolumeDown();
    }
}
