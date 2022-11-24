using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace IMA.Properties
{
	// Token: 0x02000008 RID: 8
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00005D78 File Offset: 0x00003F78
		internal Resources()
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00005D84 File Offset: 0x00003F84
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager temp = new ResourceManager("IMA.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = temp;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00005DCC File Offset: 0x00003FCC
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00005DE3 File Offset: 0x00003FE3
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x0400005C RID: 92
		private static ResourceManager resourceMan;

		// Token: 0x0400005D RID: 93
		private static CultureInfo resourceCulture;
	}
}
