// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 2.1.3226.27803
//   <NameSpace>Umc.Core.Tools.VSGesture.Actions</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><CustomUsings></CustomUsings><CollectionBase></CollectionBase>
//  <auto-generated>
// ------------------------------------------------------------------------------
namespace Umc.Core.Tools.VSGesture.Actions {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/GestureActionMapper.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/GestureActionMapper.xsd", IsNullable=false)]
    public partial class GestureActionMapper {
        
        private List<GestureActionMapperItem> itemField;
        
        public GestureActionMapper() {
            if ((this.itemField == null)) {
                this.itemField = new List<GestureActionMapperItem>();
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public List<GestureActionMapperItem> Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/GestureActionMapper.xsd")]
    public partial class GestureActionMapperItem {
        
        private GestureActionMapperItems gestureActionTypeField;
        
        private bool gestureActionTypeFieldSpecified;
        
        private ActionType actionTypeField;
        
        private bool actionTypeFieldSpecified;
        
        private string valueField;

		private string argumentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GestureActionMapperItems GestureActionType {
            get {
                return this.gestureActionTypeField;
            }
            set {
                this.gestureActionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GestureActionTypeSpecified {
            get {
                return this.gestureActionTypeFieldSpecified;
            }
            set {
                this.gestureActionTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType ActionType {
            get {
                return this.actionTypeField;
            }
            set {
                this.actionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionTypeSpecified {
            get {
                return this.actionTypeFieldSpecified;
            }
            set {
                this.actionTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }

		[System.Xml.Serialization.XmlAttribute]
		public string Argument
		{
			get { return this.argumentField; }
			set { this.argumentField = value; }
		}
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/GestureActionMapper.xsd")]
    public enum GestureActionMapperItems {
        
        /// <remarks/>
        ArrowDown,
        
        /// <remarks/>
        ArrowLeft,
        
        /// <remarks/>
        ArrowRight,
        
        /// <remarks/>
        ArrowUp,
        
        /// <remarks/>
        Check,
        
        /// <remarks/>
        ChevronDown,
        
        /// <remarks/>
        ChevronLeft,
        
        /// <remarks/>
        ChevronRight,
        
        /// <remarks/>
        ChevronUp,
        
        /// <remarks/>
        Circle,
        
        /// <remarks/>
        Curlicue,
        
        /// <remarks/>
        DoubleCircle,
        
        /// <remarks/>
        DoubleCurlicue,
        
        /// <remarks/>
        DoubleTap,
        
        /// <remarks/>
        Down,
        
        /// <remarks/>
        DownLeft,
        
        /// <remarks/>
        DownLeftLong,
        
        /// <remarks/>
        DownRight,
        
        /// <remarks/>
        DownRightLong,
        
        /// <remarks/>
        DownUp,
        
        /// <remarks/>
        Exclamation,
        
        /// <remarks/>
        Left,
        
        /// <remarks/>
        LeftDown,
        
        /// <remarks/>
        LeftRight,
        
        /// <remarks/>
        LeftUp,
        
        /// <remarks/>
        NoGesture,
        
        /// <remarks/>
        Right,
        
        /// <remarks/>
        RightDown,
        
        /// <remarks/>
        RightLeft,
        
        /// <remarks/>
        RightUp,
        
        /// <remarks/>
        ScratchOut,
        
        /// <remarks/>
        SemicircleLeft,
        
        /// <remarks/>
        SemicircleRight,
        
        /// <remarks/>
        Square,
        
        /// <remarks/>
        Star,
        
        /// <remarks/>
        Tap,
        
        /// <remarks/>
        Triangle,
        
        /// <remarks/>
        Up,
        
        /// <remarks/>
        UpDown,
        
        /// <remarks/>
        UpLeft,
        
        /// <remarks/>
        UpLeftLong,
        
        /// <remarks/>
        UpRight,
        
        /// <remarks/>
        UpRightLong,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/GestureActionMapper.xsd")]
    public enum ActionType {
        
        /// <remarks/>
        Action,
        
        /// <remarks/>
        Command,
    }
}