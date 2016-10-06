//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
    
namespace ISpySoft.FeatureModelLanguage.Designer
{
	#region Using directives
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Microsoft.VisualStudio.EnterpriseTools.Shell;
	using Microsoft.VisualStudio.Modeling;
	using Microsoft.VisualStudio.Modeling.Utilities;
	using System.Windows.Forms;
	using Microsoft.VisualStudio.Modeling.Diagrams;
	#endregion

	///<summary>
	///The MouseAction that handles the gesture for creating a Connector.
	///</summary>
	public class RelationshipFeatureConnectorConnectAction : ConnectorConnectAction
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="diagram"></param>
		/// <param name="permitClick"></param>
		public RelationshipFeatureConnectorConnectAction(Microsoft.VisualStudio.Modeling.Diagrams.Diagram diagram, bool permitClick): base(diagram, permitClick )
		{
		}

		/// <summary>
		/// Get the ConnectionType instance associated with this action when the source and target conditions are met
		/// </summary>
		/// <param name="sourceShapeElement"></param>
		/// <param name="targetShapeElement"></param>
		/// <returns></returns>
		protected override ShapeToShapeConnectionType GetConnectionType(ShapeElement sourceShapeElement, ShapeElement targetShapeElement)
		{
			return RelationshipFeatureConnectorConnectionType.Instance;
		}
	}

	/// <summary>
	/// Singleton ConnectionType for creating the Connector between two Shapes.
	/// </summary>
	public partial class RelationshipFeatureConnectorConnectionType : ShapeToShapeConnectionType
	{
		private static RelationshipFeatureConnectorConnectionType instance;

		public RelationshipFeatureConnectorConnectionType() : base()
		{
		}

		/// <summary>
		/// Get the types of shape that are valid as sources
		/// </summary>
		/// <value></value>
		public override IList<Type> SourceShapeTypes
		{
			get
			{
				List<Type> types = new List<Type>();
				types.Add(typeof(ISpySoft.FeatureModelLanguage.Designer.FeatureSetShape));
				types.Add(typeof(ISpySoft.FeatureModelLanguage.Designer.FeatureShape));
				types.Add(typeof(ISpySoft.FeatureModelLanguage.Designer.RootFeatureShape));
				 
				return types.AsReadOnly();				 
			}
		}

		/// <summary>
		/// Get the types of shape that are valid as targets
		/// </summary>
		/// <value></value>
		public override IList<Type> TargetShapeTypes
		{
			get
			{
				List<Type> types = new List<Type>();
				types.Add(typeof(ISpySoft.FeatureModelLanguage.Designer.FeatureShape));
				 
				return types.AsReadOnly();				 
			}
		}
	
		public static new RelationshipFeatureConnectorConnectionType Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new RelationshipFeatureConnectorConnectionType();
				}
				return instance;
			}
		}
	

		/// Return whether the instance is OK to be the source of a link, in its current state.
		/// </summary>
		/// <param name="shape"></param>
		/// <returns></returns>
		public override bool IsValidSourceInstance(ShapeElement shape)
		{
			if (!SourceShapeTypes.Contains(ConnectorConnectAction.TopLevelShape(shape).GetType())) return false;
			return base.IsValidSourceInstance(shape);
		}
		
		/// <summary>
		/// Return whether the instance is OK to be the source of a link, in its current state.
		/// </summary>
		/// <param name="modelElement"></param>
		/// <returns></returns>
		public override bool IsValidSourceInstance(ModelElement element)
		{
				return true;
			}	

		/// <summary>
		/// Whether the instance is OK to be the target of a link, in its current state.
		/// </summary>
		/// <param name="modelElement"></param>
		/// <returns></returns>
		public override bool IsValidTargetInstance(ModelElement element)
		{
		
				return true;
			}

		/// <summary>
		/// Creates a relationship between TransitionFrom and TransitionTo
		/// </summary>
		/// <param name="source">TransitionFrom to start the relationship at</param>
		/// <param name="target">TransitionTo to end the relationship at</param>
		public override void CreateConnection(Shape sourceShape, Shape targetShape)
		{
			if (sourceShape == null)
			{
				throw new ArgumentNullException("sourceShape");
			}

			if (targetShape == null)
			{
				throw new ArgumentNullException("targetShape");
			}

			if (sourceShape != null && targetShape != null)
			{
				ISpySoft.FeatureModelLanguage.DomainModel.AbstractFeature sourceElement = sourceShape.ModelElement as ISpySoft.FeatureModelLanguage.DomainModel.AbstractFeature;
				ISpySoft.FeatureModelLanguage.DomainModel.AbstractFeature targetElement = targetShape.ModelElement as ISpySoft.FeatureModelLanguage.DomainModel.AbstractFeature;

				// Make MEL relationship - PEL relationship will be handled by ViewFixup mechanism
				if (sourceElement != null && targetElement != null)
				{
										    targetElement.TransitionFrom.Add(sourceElement);
					    
					    if (sourceElement.GetType() == typeof(ISpySoft.FeatureModelLanguage.DomainModel.FeatureSet))
						{
							foreach (System.ComponentModel.PropertyDescriptor property in targetElement.GetProperties())
							{
        						if (property.Name == "Kind")
								{
                					property.SetValue(property, ISpySoft.FeatureModelLanguage.DomainModel.FeatureKind.FeatureSetFeature);
								}
							}
						}
					    
					    
									}
			}
		}	
		

	}
}
namespace ISpySoft.FeatureModelLanguage.Designer
{
	#region Using directives
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Microsoft.VisualStudio.EnterpriseTools.Shell;
	using Microsoft.VisualStudio.Modeling;
	using Microsoft.VisualStudio.Modeling.Utilities;
	using System.Windows.Forms;
	using Microsoft.VisualStudio.Modeling.Diagrams;
	#endregion

	///<summary>
	///The MouseAction that handles the gesture for creating a Connector.
	///</summary>
	public class RelationshipFeatureSetConnectorConnectAction : ConnectorConnectAction
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="diagram"></param>
		/// <param name="permitClick"></param>
		public RelationshipFeatureSetConnectorConnectAction(Microsoft.VisualStudio.Modeling.Diagrams.Diagram diagram, bool permitClick): base(diagram, permitClick )
		{
		}

		/// <summary>
		/// Get the ConnectionType instance associated with this action when the source and target conditions are met
		/// </summary>
		/// <param name="sourceShapeElement"></param>
		/// <param name="targetShapeElement"></param>
		/// <returns></returns>
		protected override ShapeToShapeConnectionType GetConnectionType(ShapeElement sourceShapeElement, ShapeElement targetShapeElement)
		{
			return RelationshipFeatureSetConnectorConnectionType.Instance;
		}
	}

	/// <summary>
	/// Singleton ConnectionType for creating the Connector between two Shapes.
	/// </summary>
	public partial class RelationshipFeatureSetConnectorConnectionType : ShapeToShapeConnectionType
	{
		private static RelationshipFeatureSetConnectorConnectionType instance;

		public RelationshipFeatureSetConnectorConnectionType() : base()
		{
		}

		/// <summary>
		/// Get the types of shape that are valid as sources
		/// </summary>
		/// <value></value>
		public override IList<Type> SourceShapeTypes
		{
			get
			{
				List<Type> types = new List<Type>();
				types.Add(typeof(ISpySoft.FeatureModelLanguage.Designer.FeatureShape));
				types.Add(typeof(ISpySoft.FeatureModelLanguage.Designer.RootFeatureShape));
				 
				return types.AsReadOnly();				 
			}
		}

		/// <summary>
		/// Get the types of shape that are valid as targets
		/// </summary>
		/// <value></value>
		public override IList<Type> TargetShapeTypes
		{
			get
			{
				List<Type> types = new List<Type>();
				types.Add(typeof(ISpySoft.FeatureModelLanguage.Designer.FeatureSetShape));
				 
				return types.AsReadOnly();				 
			}
		}
	
		public static new RelationshipFeatureSetConnectorConnectionType Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new RelationshipFeatureSetConnectorConnectionType();
				}
				return instance;
			}
		}
	

		/// Return whether the instance is OK to be the source of a link, in its current state.
		/// </summary>
		/// <param name="shape"></param>
		/// <returns></returns>
		public override bool IsValidSourceInstance(ShapeElement shape)
		{
			if (!SourceShapeTypes.Contains(ConnectorConnectAction.TopLevelShape(shape).GetType())) return false;
			return base.IsValidSourceInstance(shape);
		}
		
		/// <summary>
		/// Return whether the instance is OK to be the source of a link, in its current state.
		/// </summary>
		/// <param name="modelElement"></param>
		/// <returns></returns>
		public override bool IsValidSourceInstance(ModelElement element)
		{
				return true;
			}	

		/// <summary>
		/// Whether the instance is OK to be the target of a link, in its current state.
		/// </summary>
		/// <param name="modelElement"></param>
		/// <returns></returns>
		public override bool IsValidTargetInstance(ModelElement element)
		{
		
				return true;
			}

		/// <summary>
		/// Creates a relationship between ObjectTransitionFrom and ObjectTransitionTo
		/// </summary>
		/// <param name="source">ObjectTransitionFrom to start the relationship at</param>
		/// <param name="target">ObjectTransitionTo to end the relationship at</param>
		public override void CreateConnection(Shape sourceShape, Shape targetShape)
		{
			if (sourceShape == null)
			{
				throw new ArgumentNullException("sourceShape");
			}

			if (targetShape == null)
			{
				throw new ArgumentNullException("targetShape");
			}

			if (sourceShape != null && targetShape != null)
			{
				ISpySoft.FeatureModelLanguage.DomainModel.AbstractFeature sourceElement = sourceShape.ModelElement as ISpySoft.FeatureModelLanguage.DomainModel.AbstractFeature;
				ISpySoft.FeatureModelLanguage.DomainModel.AbstractFeature targetElement = targetShape.ModelElement as ISpySoft.FeatureModelLanguage.DomainModel.AbstractFeature;

				// Make MEL relationship - PEL relationship will be handled by ViewFixup mechanism
				if (sourceElement != null && targetElement != null)
				{
										    targetElement.ObjectTransitionFrom.Add(sourceElement);
					    
					    if (sourceElement.GetType() == typeof(ISpySoft.FeatureModelLanguage.DomainModel.FeatureSet))
						{
							foreach (System.ComponentModel.PropertyDescriptor property in targetElement.GetProperties())
							{
        						if (property.Name == "Kind")
								{
                					property.SetValue(property, ISpySoft.FeatureModelLanguage.DomainModel.FeatureKind.FeatureSetFeature);
								}
							}
						}
					    
					    
									}
			}
		}	
		

	}
}
