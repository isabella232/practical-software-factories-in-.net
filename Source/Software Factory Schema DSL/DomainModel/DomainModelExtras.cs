//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Partial classes to provide basic naming on merge

namespace ISpySoft.SFSchemaLanguage.DomainModel
{
	#region Using directives

	using System;
	using System.Collections.Generic;
	using Microsoft.VisualStudio.Modeling;

	#endregion

	public partial class SchemaModel
	{
		#region Merge functions

		public override string RootName
		{
			get
			{
				return "SchemaModel";
			}
		}
		
		public override string GenerateName(string rootName)
		{
			if (count == 0) count = this.Partition.ElementDirectory.GetElements(SchemaModel.MetaClassGuid).Count;
			string newResourceFullName = this.GetType().Namespace + ".DomainModel_Resource";
			Type newResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(newResourceFullName, false);
			string format = "";
			if (newResourceType != null)
			{
				System.Reflection.PropertyInfo resourceProperty = newResourceType.GetProperty("NewObjectName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
				if (resourceProperty != null)  format = resourceProperty.GetValue(null, new object[] { }) as string;
			}
			if (String.IsNullOrEmpty(format))
			{
				string oldResourceFullName = this.GetType().Namespace + ".Properties.Resources";
				Type oldResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(oldResourceFullName, false);
				if (oldResourceType != null)
				{
					System.Reflection.PropertyInfo resourceProperty = oldResourceType.GetProperty("NewConceptName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
					if (resourceProperty != null) format = resourceProperty.GetValue(null, new object[] { }) as string;
				}
			}
			if (String.IsNullOrEmpty(format))
			{
				format = "{0} {1}";
			}
			
			return System.String.Format(System.Globalization.CultureInfo.CurrentCulture, format, rootName, count++);
		}

		private static int count = 0;
		
		#endregion
	}
}

namespace ISpySoft.SFSchemaLanguage.DomainModel
{
	#region Using directives

	using System;
	using System.Collections.Generic;
	using Microsoft.VisualStudio.Modeling;

	#endregion

	public partial class SchemaModelItem
	{
		#region Merge functions

		public override string RootName
		{
			get
			{
				return "SchemaModelItem";
			}
		}
		
		public override string GenerateName(string rootName)
		{
			if (count == 0) count = this.Partition.ElementDirectory.GetElements(SchemaModelItem.MetaClassGuid).Count;
			string newResourceFullName = this.GetType().Namespace + ".DomainModel_Resource";
			Type newResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(newResourceFullName, false);
			string format = "";
			if (newResourceType != null)
			{
				System.Reflection.PropertyInfo resourceProperty = newResourceType.GetProperty("NewObjectName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
				if (resourceProperty != null)  format = resourceProperty.GetValue(null, new object[] { }) as string;
			}
			if (String.IsNullOrEmpty(format))
			{
				string oldResourceFullName = this.GetType().Namespace + ".Properties.Resources";
				Type oldResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(oldResourceFullName, false);
				if (oldResourceType != null)
				{
					System.Reflection.PropertyInfo resourceProperty = oldResourceType.GetProperty("NewConceptName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
					if (resourceProperty != null) format = resourceProperty.GetValue(null, new object[] { }) as string;
				}
			}
			if (String.IsNullOrEmpty(format))
			{
				format = "{0} {1}";
			}
			
			return System.String.Format(System.Globalization.CultureInfo.CurrentCulture, format, rootName, count++);
		}

		private static int count = 0;
		
		#endregion
	}
}

namespace ISpySoft.SFSchemaLanguage.DomainModel
{
	#region Using directives

	using System;
	using System.Collections.Generic;
	using Microsoft.VisualStudio.Modeling;

	#endregion

	public partial class Activity
	{
		#region Merge functions

		public override string RootName
		{
			get
			{
				return "Activity";
			}
		}
		
		public override string GenerateName(string rootName)
		{
			if (count == 0) count = this.Partition.ElementDirectory.GetElements(Activity.MetaClassGuid).Count;
			string newResourceFullName = this.GetType().Namespace + ".DomainModel_Resource";
			Type newResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(newResourceFullName, false);
			string format = "";
			if (newResourceType != null)
			{
				System.Reflection.PropertyInfo resourceProperty = newResourceType.GetProperty("NewObjectName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
				if (resourceProperty != null)  format = resourceProperty.GetValue(null, new object[] { }) as string;
			}
			if (String.IsNullOrEmpty(format))
			{
				string oldResourceFullName = this.GetType().Namespace + ".Properties.Resources";
				Type oldResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(oldResourceFullName, false);
				if (oldResourceType != null)
				{
					System.Reflection.PropertyInfo resourceProperty = oldResourceType.GetProperty("NewConceptName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
					if (resourceProperty != null) format = resourceProperty.GetValue(null, new object[] { }) as string;
				}
			}
			if (String.IsNullOrEmpty(format))
			{
				format = "{0} {1}";
			}
			
			return System.String.Format(System.Globalization.CultureInfo.CurrentCulture, format, rootName, count++);
		}

		private static int count = 0;
		
		#endregion
	}
}

namespace ISpySoft.SFSchemaLanguage.DomainModel
{
	#region Using directives

	using System;
	using System.Collections.Generic;
	using Microsoft.VisualStudio.Modeling;

	#endregion

	public partial class ViewPoint
	{
		#region Merge functions

		public override string RootName
		{
			get
			{
				return "ViewPoint";
			}
		}
		
		public override string GenerateName(string rootName)
		{
			if (count == 0) count = this.Partition.ElementDirectory.GetElements(ViewPoint.MetaClassGuid).Count;
			string newResourceFullName = this.GetType().Namespace + ".DomainModel_Resource";
			Type newResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(newResourceFullName, false);
			string format = "";
			if (newResourceType != null)
			{
				System.Reflection.PropertyInfo resourceProperty = newResourceType.GetProperty("NewObjectName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
				if (resourceProperty != null)  format = resourceProperty.GetValue(null, new object[] { }) as string;
			}
			if (String.IsNullOrEmpty(format))
			{
				string oldResourceFullName = this.GetType().Namespace + ".Properties.Resources";
				Type oldResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(oldResourceFullName, false);
				if (oldResourceType != null)
				{
					System.Reflection.PropertyInfo resourceProperty = oldResourceType.GetProperty("NewConceptName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
					if (resourceProperty != null) format = resourceProperty.GetValue(null, new object[] { }) as string;
				}
			}
			if (String.IsNullOrEmpty(format))
			{
				format = "{0} {1}";
			}
			
			return System.String.Format(System.Globalization.CultureInfo.CurrentCulture, format, rootName, count++);
		}

		private static int count = 0;
		
		#endregion
	}
}

namespace ISpySoft.SFSchemaLanguage.DomainModel
{
	#region Using directives

	using System;
	using System.Collections.Generic;
	using Microsoft.VisualStudio.Modeling;

	#endregion

	public partial class Stakeholder
	{
		#region Merge functions

		public override string RootName
		{
			get
			{
				return "Stakeholder";
			}
		}
		
		public override string GenerateName(string rootName)
		{
			if (count == 0) count = this.Partition.ElementDirectory.GetElements(Stakeholder.MetaClassGuid).Count;
			string newResourceFullName = this.GetType().Namespace + ".DomainModel_Resource";
			Type newResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(newResourceFullName, false);
			string format = "";
			if (newResourceType != null)
			{
				System.Reflection.PropertyInfo resourceProperty = newResourceType.GetProperty("NewObjectName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
				if (resourceProperty != null)  format = resourceProperty.GetValue(null, new object[] { }) as string;
			}
			if (String.IsNullOrEmpty(format))
			{
				string oldResourceFullName = this.GetType().Namespace + ".Properties.Resources";
				Type oldResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(oldResourceFullName, false);
				if (oldResourceType != null)
				{
					System.Reflection.PropertyInfo resourceProperty = oldResourceType.GetProperty("NewConceptName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
					if (resourceProperty != null) format = resourceProperty.GetValue(null, new object[] { }) as string;
				}
			}
			if (String.IsNullOrEmpty(format))
			{
				format = "{0} {1}";
			}
			
			return System.String.Format(System.Globalization.CultureInfo.CurrentCulture, format, rootName, count++);
		}

		private static int count = 0;
		
		#endregion
	}
}

namespace ISpySoft.SFSchemaLanguage.DomainModel
{
	#region Using directives

	using System;
	using System.Collections.Generic;
	using Microsoft.VisualStudio.Modeling;

	#endregion

	public partial class Mapping
	{
		#region Merge functions

		public override string RootName
		{
			get
			{
				return "Mapping";
			}
		}
		
		public override string GenerateName(string rootName)
		{
			if (count == 0) count = this.Partition.ElementDirectory.GetElements(Mapping.MetaClassGuid).Count;
			string newResourceFullName = this.GetType().Namespace + ".DomainModel_Resource";
			Type newResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(newResourceFullName, false);
			string format = "";
			if (newResourceType != null)
			{
				System.Reflection.PropertyInfo resourceProperty = newResourceType.GetProperty("NewObjectName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
				if (resourceProperty != null)  format = resourceProperty.GetValue(null, new object[] { }) as string;
			}
			if (String.IsNullOrEmpty(format))
			{
				string oldResourceFullName = this.GetType().Namespace + ".Properties.Resources";
				Type oldResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(oldResourceFullName, false);
				if (oldResourceType != null)
				{
					System.Reflection.PropertyInfo resourceProperty = oldResourceType.GetProperty("NewConceptName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
					if (resourceProperty != null) format = resourceProperty.GetValue(null, new object[] { }) as string;
				}
			}
			if (String.IsNullOrEmpty(format))
			{
				format = "{0} {1}";
			}
			
			return System.String.Format(System.Globalization.CultureInfo.CurrentCulture, format, rootName, count++);
		}

		private static int count = 0;
		
		#endregion
	}
}

namespace ISpySoft.SFSchemaLanguage.DomainModel
{
	#region Using directives

	using System;
	using System.Collections.Generic;
	using Microsoft.VisualStudio.Modeling;

	#endregion

	public partial class Artifact
	{
		#region Merge functions

		public override string RootName
		{
			get
			{
				return "Artifact";
			}
		}
		
		public override string GenerateName(string rootName)
		{
			if (count == 0) count = this.Partition.ElementDirectory.GetElements(Artifact.MetaClassGuid).Count;
			string newResourceFullName = this.GetType().Namespace + ".DomainModel_Resource";
			Type newResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(newResourceFullName, false);
			string format = "";
			if (newResourceType != null)
			{
				System.Reflection.PropertyInfo resourceProperty = newResourceType.GetProperty("NewObjectName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
				if (resourceProperty != null)  format = resourceProperty.GetValue(null, new object[] { }) as string;
			}
			if (String.IsNullOrEmpty(format))
			{
				string oldResourceFullName = this.GetType().Namespace + ".Properties.Resources";
				Type oldResourceType = System.Reflection.Assembly.GetAssembly(this.GetType()).GetType(oldResourceFullName, false);
				if (oldResourceType != null)
				{
					System.Reflection.PropertyInfo resourceProperty = oldResourceType.GetProperty("NewConceptName", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
					if (resourceProperty != null) format = resourceProperty.GetValue(null, new object[] { }) as string;
				}
			}
			if (String.IsNullOrEmpty(format))
			{
				format = "{0} {1}";
			}
			
			return System.String.Format(System.Globalization.CultureInfo.CurrentCulture, format, rootName, count++);
		}

		private static int count = 0;
		
		#endregion
	}
}


#endregion

#region Partial classes to provide merge on Acceptor roles of relationships


namespace ISpySoft.SFSchemaLanguage.DomainModel
{
	#region Using directives

	using System;
	using System.Collections.Generic;
	using Microsoft.VisualStudio.Modeling;

	#endregion

	public partial class ViewPoint
	{
		#region MergeContext functions
		
		/// <summary>
		/// Check whether this model class is an acceptor for the content of a prototype
		/// </summary>
		/// <param name="elementGroupPrototype"></param>
		/// <param name="protoElement"></param>
		/// <returns></returns>
		protected override bool CanAddChildElement(ElementGroupPrototype elementGroupPrototype, ProtoElementBase protoElement)
		{
			if (protoElement != null)
			{
				bool canAdd = false;
				MetaClassInfo metaClassInfo = this.Store.MetaDataDirectory.FindMetaClass(protoElement.MetaClassId);

								if (typeof(ISpySoft.SFSchemaLanguage.DomainModel.Stakeholder).IsAssignableFrom(metaClassInfo.ImplementationClass)) 
				{
										canAdd = true;
									}
				
				return canAdd;
			}
			return false;
		}

		/// <summary>
		/// Connect a prototype instance into the model by relating the elements in the prototype to ones already in the model
		/// </summary>
		/// <param name="sourceElement"></param>
		/// <param name="elementGroup"></param>
		public override void MergeRelate(ModelElement sourceElement, ElementGroup elementGroup)
		{
			base.MergeRelate(sourceElement, elementGroup);
			if (sourceElement == null)
			{
				return;
			}

						ISpySoft.SFSchemaLanguage.DomainModel.Stakeholder typedStakeholdersSourceElement = sourceElement as ISpySoft.SFSchemaLanguage.DomainModel.Stakeholder;
			if (typedStakeholdersSourceElement != null)
			{
								this.Stakeholders.Add(typedStakeholdersSourceElement);
							}
				
		}
		#endregion
	}
}


namespace ISpySoft.SFSchemaLanguage.DomainModel
{
	#region Using directives

	using System;
	using System.Collections.Generic;
	using Microsoft.VisualStudio.Modeling;

	#endregion

	public partial class SchemaModel
	{
		#region MergeContext functions
		
		/// <summary>
		/// Check whether this model class is an acceptor for the content of a prototype
		/// </summary>
		/// <param name="elementGroupPrototype"></param>
		/// <param name="protoElement"></param>
		/// <returns></returns>
		protected override bool CanAddChildElement(ElementGroupPrototype elementGroupPrototype, ProtoElementBase protoElement)
		{
			if (protoElement != null)
			{
				bool canAdd = false;
				MetaClassInfo metaClassInfo = this.Store.MetaDataDirectory.FindMetaClass(protoElement.MetaClassId);

								if (typeof(ISpySoft.SFSchemaLanguage.DomainModel.SchemaModelItem).IsAssignableFrom(metaClassInfo.ImplementationClass)) 
				{
										canAdd = true;
									}
				
				return canAdd;
			}
			return false;
		}

		/// <summary>
		/// Connect a prototype instance into the model by relating the elements in the prototype to ones already in the model
		/// </summary>
		/// <param name="sourceElement"></param>
		/// <param name="elementGroup"></param>
		public override void MergeRelate(ModelElement sourceElement, ElementGroup elementGroup)
		{
			base.MergeRelate(sourceElement, elementGroup);
			if (sourceElement == null)
			{
				return;
			}

						ISpySoft.SFSchemaLanguage.DomainModel.SchemaModelItem typedSchemaModelItemsSourceElement = sourceElement as ISpySoft.SFSchemaLanguage.DomainModel.SchemaModelItem;
			if (typedSchemaModelItemsSourceElement != null)
			{
								this.SchemaModelItems.Add(typedSchemaModelItemsSourceElement);
							}
				
		}
		#endregion
	}
}


#endregion

#region SubStore Partial Class To Specify Closures
namespace ISpySoft.SFSchemaLanguage.DomainModel
{
	#region Using directives
	using System;
	using System.Collections.Generic;
	using Microsoft.VisualStudio.Modeling;
	using Microsoft.VisualStudio.Modeling.Utilities;
	#endregion

	public  partial class SFSchemaLanguage
	{
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static Microsoft.VisualStudio.Modeling.IElementVisitorFilter copyClosureMember;
		/// <summary>
		/// RemoveClosure cache
		/// </summary>
		private static Microsoft.VisualStudio.Modeling.IElementVisitorFilter removeClosureMember;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override Microsoft.VisualStudio.Modeling.IElementVisitorFilter GetClosureFilter(Microsoft.VisualStudio.Modeling.ClosureType type, System.Collections.ICollection rootElements)
		{
			switch (type)
			{
				case Microsoft.VisualStudio.Modeling.ClosureType.CopyClosure:
					return SFSchemaLanguage.CopyClosure;
				case Microsoft.VisualStudio.Modeling.ClosureType.RemoveClosure:
					return SFSchemaLanguage.RemoveClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (SFSchemaLanguage.copyClosureMember == null)
				{
					ChainingElementVisitorFilter copyFilter = new ChainingElementVisitorFilter();
										copyFilter.AddFilter(new CoreMetaModelCopyFilter(false));
					copyFilter.AddFilter(new UtilitiesCopyClosure());
					copyFilter.AddFilter(new SFSchemaLanguageCopyClosure());
					
					SFSchemaLanguage.copyClosureMember = copyFilter;
				}
				return SFSchemaLanguage.copyClosureMember;
			}
		}
		/// <summary>
		/// RemoveClosure cache
		/// </summary>
		private static IElementVisitorFilter RemoveClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (SFSchemaLanguage.removeClosureMember == null)
				{
					ChainingElementVisitorFilter removeFilter = new ChainingElementVisitorFilter();
										removeFilter.AddFilter(new CoreMetaModelRemoveFilter(false));
					removeFilter.AddFilter(new UtilitiesRemoveClosure());
					removeFilter.AddFilter(new SFSchemaLanguageRemoveClosure());

					SFSchemaLanguage.removeClosureMember = removeFilter;
				}
				return SFSchemaLanguage.removeClosureMember;
			}
		}
	}
}
#endregion

