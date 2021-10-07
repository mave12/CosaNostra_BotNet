// Decompiled with JetBrains decompiler
// Type: svhost.My.Resources.Resources
// Assembly: svhost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7DC793DB-CF4C-4ECD-BC3A-2E8425BD618A
// Assembly location: C:\Users\matze\Desktop\Neuer Ordner (7)\Builder\Builder\Resources\svhost.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace svhost.My.Resources
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [HideModuleName]
  [DebuggerNonUserCode]
  [StandardModule]
  [CompilerGenerated]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) svhost.My.Resources.Resources.resourceMan, (object) null))
          svhost.My.Resources.Resources.resourceMan = new ResourceManager("svhost.Resources", typeof (svhost.My.Resources.Resources).Assembly);
        return svhost.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => svhost.My.Resources.Resources.resourceCulture;
      set => svhost.My.Resources.Resources.resourceCulture = value;
    }

    internal static byte[] bin => (byte[]) RuntimeHelpers.GetObjectValue(svhost.My.Resources.Resources.ResourceManager.GetObject(nameof (bin), svhost.My.Resources.Resources.resourceCulture));
  }
}
