using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace IMA.Properties
{
	// Token: 0x02000007 RID: 7
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00005CAC File Offset: 0x00003EAC
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00005CC4 File Offset: 0x00003EC4
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("100")]
		public double Opacity
		{
			get
			{
				return (double)this["Opacity"];
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("128, 128, 255")]
		public Color Color
		{
			get
			{
				return (Color)this["Color"];
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00005D0C File Offset: 0x00003F0C
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00005D2E File Offset: 0x00003F2E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("uzytkownik")]
		public string username
		{
			get
			{
				return (string)this["username"];
			}
			set
			{
				this["username"] = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00005D40 File Offset: 0x00003F40
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Ima Editor")]
		public string NazwaProgramu
		{
			get
			{
				return (string)this["NazwaProgramu"];
			}
		}

		// Token: 0x0400005B RID: 91
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
