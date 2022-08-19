using GraitecExtensionsContracts;
using Inventor;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ContextExtensionInventor1
{
    [Export(typeof(IVContextPlugin))]
    public class ContextExtensionInventor1 : IVContextPlugin
    {
        private Assembly thisAssembly = System.Reflection.Assembly.GetExecutingAssembly();
        private static GraitecLog4NetFileHelper logHelper = null;
        public static readonly ILog log = LogManager.GetLogger(typeof(ContextExtensionInventor1));
        public static Application m_InventorApp = null;

        public string CommandDisplayName
        {
            get
            {
                return "First Context Command";
            }
        }

        public string CommandInternalName
        {
            get
            {
                //Assembly a = Assembly.GetCallingAssembly();
                var attribute = (GuidAttribute)thisAssembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
                string AssemblyGuid = attribute.Value;
                return Properties.Settings.Default.ContextExtensionInternalName + AssemblyGuid;
            }
        }

        public string CommandName
        {
            get
            {
                return "FirstContextCommand";
            }
        }

        public CommandTypesEnum CommandType
        {
            get
            {
                return CommandTypesEnum.kQueryOnlyCmdType;
            }
        }

        public string DefaultResourceName
        {
            get
            {
                return "ContextExtensionInventor1.Resources.TurdPolish.ico";
            }
        }

        public string Description
        {
            get
            {
                return "This is the Description";
            }
        }

        public bool DisplayBigIcon
        {
            get
            {
                return false;
            }
        }

        public bool DisplayText
        {
            get
            {
                return true;
            }
        }

        public EnvironmentRibbonName EnvironmentRibbonName
        {
            get
            {
                return EnvironmentRibbonName.Main;
            }
        }

        public bool InsertBeforeTarget
        {
            get
            {
                return true;
            }
        }

        public Application InventorApp
        {
            get
            {
                return m_InventorApp;
            }

            set
            {
                m_InventorApp = value;
            }
        }

        public GraitecLog4NetFileHelper LogFileHelper
        {
            get
            {
                return logHelper;
            }

            set
            {
                logHelper = value;
            }
        }

        public string Path
        {
            get
            {
                System.Reflection.Assembly thisAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                return thisAssembly.Location;
            }
        }

        public string TargetControlName
        {
            get
            {
                return "PartMoveEOPMarkerCmd";
            }
        }

        public string ToolTip
        {
            get
            {
                return "This is the Tooltip";
            }
        }

        public void Execute()
        {
            ButtonActions.Button1_Execute();
        }
    }
}
