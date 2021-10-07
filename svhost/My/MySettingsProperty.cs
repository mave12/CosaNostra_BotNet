// Decompiled with JetBrains decompiler
// Type: svhost.My.MySettingsProperty
// Assembly: svhost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7DC793DB-CF4C-4ECD-BC3A-2E8425BD618A
// Assembly location: C:\Users\matze\Desktop\Neuer Ordner (7)\Builder\Builder\Resources\svhost.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace svhost.My
{
  [StandardModule]
  [HideModuleName]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        MySettings mySettings = MySettings.Default;
        return mySettings;
      }
    }
  }
}
