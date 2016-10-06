//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// VsPkg.cs : Implementation of SFSchemaLanguage
//

namespace ISpySoft.SFSchemaLanguage.Designer
{
	#region Using directives
	using System;
	using System.Diagnostics;
	using System.Globalization;
	using System.Runtime.InteropServices;
	using System.ComponentModel.Design;
	using Microsoft.Win32;
	using Microsoft.VisualStudio.Shell.Interop;
	using Microsoft.VisualStudio.OLE.Interop;
	using Microsoft.VisualStudio.Shell;
	using Microsoft.VisualStudio.EnterpriseTools.Shell;
	using Microsoft.VisualStudio.Modeling.Utilities;
	using Microsoft.VisualStudio.TextTemplating.VSHost;
	using MSVSIP = Microsoft.VisualStudio.Shell;
	#endregion

	/////////////////////////////////////////////////////////////////////////////
	// SFSchemaLanguage
	[MSVSIP.DefaultRegistryRoot("Software\\Microsoft\\VisualStudio\\8.0")]
	[MSVSIP.PackageRegistration(RegisterUsing = RegistrationMethod.Assembly, UseManagedResourcesOnly = true)]
	[MSVSIP.ProvideToolWindow(typeof(SFSchemaLanguageModelExplorer), MultiInstances = false, Style = VsDockStyle.Tabbed, Orientation = ToolWindowOrientation.Right, Window = "{3AE79031-E1BC-11D0-8F78-00A0C9110057}")]
	[MSVSIP.ProvideToolWindowVisibility(typeof(SFSchemaLanguageModelExplorer), GuidList.guidEditorFactoryString)]
	[MSVSIP.ProvideEditorFactory(typeof(EditorFactory), 106, TrustLevel = __VSEDITORTRUSTLEVEL.ETL_AlwaysTrusted)]
	[MSVSIP.ProvideEditorExtension(typeof(EditorFactory), "."+Constants.designerFileExtension, 32)]
	[RegisterAdditionalEditorExtension("{8B382828-6202-11d1-8870-0000F87579D2}", ".ReportTemplate", 0x28)]
	[ProvideDirectiveProcessor(typeof(SFSchemaLanguageDirectiveProcessor), SFSchemaLanguageDirectiveProcessor.SFSchemaLanguageDirectiveProcessorName, "A directive processor that provides access to SFSchemaLanguage files")]
	[RegisterAsDslToolsEditor]
	[Guid(GuidList.guidSFSchemaLanguagePkgString)]
	[CLSCompliant(false)]
	[ComVisible(true)]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
	public sealed partial class SFSchemaLanguagePackage : Microsoft.VisualStudio.Modeling.Utilities.Package
	{
	    #region Member variables

        /// <summary>
        /// The commands supported by this package
        /// </summary>
        private CommandSet commandSet;

		/// <summary>
        /// Pointer to a singleton instance of this package, useful for unit testing.
		/// </summary>
		private static SFSchemaLanguagePackage singletonInstance;
		
		internal static SFSchemaLanguagePackage Singleton
		{
			get { return SFSchemaLanguagePackage.singletonInstance; }
		}
        #endregion

        #region Construction/destruction
		/// <summary>
		/// Constructor
		/// </summary>
		public SFSchemaLanguagePackage()
		{
            Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering constructor for: {0}", this.ToString()));
			SFSchemaLanguagePackage.singletonInstance = this;
		}

		/// <summary>
		/// This is called by the package base class when our package gets unloaded.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					// Dispose of any private objects here
					if (commandSet != null)
					{
						commandSet.Dispose();
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
        #endregion

        #region Properties

		/// <summary>
		/// Unit test object name.
		/// </summary>
		protected override string UnitTestObjectName
		{
			get { return "ISpySoft.SFSchemaLanguage.Designer"; }
        }
		#endregion

        #region Base overrides
		/// <summary>
		/// This is called by the package base class when our package is loaded. When devenv is run
		/// with the "/setup" command line switch it is not able to do a lot of the normal things,
		/// such as creating output windows and tool windows. Under normal circumstances our package
		/// isn't loaded when run with this switch. However, our package will be loaded when items 
		/// are added to the toolbox, even when run with "/setup". To be safe we'll check for "setup"
		/// and we don't do anything interesting UI-based if we find it. 
		/// </summary>
		protected override void Initialize()
		{
			Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering Initialize() of: {0}", this.ToString()));


			base.Initialize();

			this.RegisterModelingEditorFactory(new EditorFactory(this));
			if (!this.SetupMode)
			{
				this.commandSet = new CommandSet(this);
				this.commandSet.Initialize();

				// Register the tool window for lazy creation
				this.AddToolWindow(typeof(SFSchemaLanguageModelExplorer));

				if (this.DesignTimeRunMode)
				{
					// We're being run from the IDE.

					// Toolbar registration doesn't work well under design run mode as the toolbox needs to be reset
					// Instead we'll dynamically zap and recreate our toolbox every time
					// Regular users of the finished tool will get the toolbox setup in the perfectly normal way
					this.SetupDynamicToolbox();
				}
			}
		}
		#endregion

		
	}
}

//
// Package attributes which may need to change are placed on the partial class below, rather than in the main include file.
//
namespace ISpySoft.SFSchemaLanguage.Designer
{
	#region Using directives
	using Microsoft.VisualStudio.Shell;
	#endregion
	
	// A package load key is required to allow this package to load when the VS SDK is not installed.
	// Package load keys may be obtained from http://msdn.microsoft.com/vstudio/extend.
	// Consult the VS SDK documentation for more information.
	// [ProvideLoadKey("Standard", Constants.productVersion, Constants.productName, Constants.companyName, 1)]
	[ProvideMenuResource(1000, 2)]
	[ProvideToolboxItems(1)]
	public sealed partial class SFSchemaLanguagePackage
	{
	}
}