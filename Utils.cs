namespace testenuget;

using System;
using System.Runtime.InteropServices;

public class Utils
{
    public DateTime DataHoraBrasilia()
    {
            var s_isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            var s_strBrasil = s_isWindows ? "SA Eastern Standard Time" : "America/Sao_Paulo";
            return TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById(s_strBrasil));
    }
}