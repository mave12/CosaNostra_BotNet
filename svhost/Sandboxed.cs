// Decompiled with JetBrains decompiler
// Type: svhost.Sandboxed
// Assembly: svhost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7DC793DB-CF4C-4ECD-BC3A-2E8425BD618A
// Assembly location: C:\Users\matze\Desktop\Neuer Ordner (7)\Builder\Builder\Resources\svhost.exe

using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;

namespace svhost
{
  [StandardModule]
  internal sealed class Sandboxed
  {
    public static bool IsRunning(params string[] processes)
    {
      Process[] processes1 = Process.GetProcesses();
      int index1 = 0;
      while (index1 < processes1.Length)
      {
        Process process = processes1[index1];
        string[] strArray = processes;
        int index2 = 0;
        while (index2 < strArray.Length)
        {
          string Right = strArray[index2];
          if (Operators.CompareString(process.ProcessName, Right, false) == 0)
            return true;
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      return false;
    }

    public static bool IsModuleLoaded(params string[] modules)
    {
      Process[] processes = Process.GetProcesses();
      int index1 = 0;
      while (index1 < processes.Length)
      {
        Process process = processes[index1];
        try
        {
          try
          {
            foreach (ProcessModule module in (ReadOnlyCollectionBase) process.Modules)
            {
              string[] strArray = modules;
              int index2 = 0;
              while (index2 < strArray.Length)
              {
                string strB = strArray[index2];
                if (string.Compare(module.ModuleName, strB, true, CultureInfo.InvariantCulture) == 0)
                  return true;
                checked { ++index2; }
              }
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index1; }
      }
      return false;
    }

    public static object IsSandbox(string ID) => Operators.CompareString(Sandboxed.GetWindowsProductId(), ID, false) == 0 ? (object) true : (object) false;

    public static string GetWindowsProductId() => Sandboxed.GetRegistry("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductId", true);

    public static string GetRegistry(string _key, string name, bool globalNode)
    {
      string str;
      try
      {
        if (globalNode)
        {
          RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(_key, false);
          if (registryKey != null)
          {
            str = registryKey.GetValue(name).ToString();
            goto label_8;
          }
        }
        else
        {
          RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_key, false);
          if (registryKey != null)
          {
            str = registryKey.GetValue(name).ToString();
            goto label_8;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "";
        ProjectData.ClearProjectError();
        goto label_8;
      }
      str = "";
label_8:
      return str;
    }
  }
}
