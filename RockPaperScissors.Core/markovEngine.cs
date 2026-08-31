namespace RockPaperScissors.Core;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
public class markovEngine
{
    private string HALnameBinary()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return "Rscript.exe";
        }
        else
        {
            return "Rscript";
        }
    }
}