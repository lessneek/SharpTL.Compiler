﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SharpTL.Compiler
{
    using Annotations;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class SharpTLDefaultTemplate : SharpTLDefaultTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("// ------------------------------------------------------------------------------" +
                    "\r\n// <auto-generated>\r\n//     This code was generated by the SharpTL compiler (h" +
                    "ttps://github.com/Taggersoft/SharpTL).\r\n//     Generated at ");
            
            #line 8 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DateTime.Now));
            
            #line default
            #line hidden
            this.Write(@"
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#pragma warning disable 1591
// ReSharper disable UnusedMember.Global
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable InconsistentNaming
namespace ");
            
            #line 20 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_templateVars.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    using SharpTL;\r\n    using System.Threading.Tasks;\r\n\r\n    // TL construct" +
                    "ors.\r\n\r\n");
            
            #line 27 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"

    // Writing constructors with common types.
    WriteTLObjects(_templateVars.Schema.Constructors, _templateVars.Schema.TypesBox.Where(t => t.HasConstructors && !t.IsBuiltIn));

    // Writing constructors without common types, because this is methods.
    // Hence method constructor is actually bunch of args to a method, which knows how to serialize itself.
    WriteTLObjects(_templateVars.Schema.Methods, null, true);

            
            #line default
            #line hidden
            this.Write("\r\n    // TL types.\r\n\r\n");
            
            #line 38 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"

foreach (TLType type in from t in _templateVars.Schema.TypesBox where t.HasConstructors && !t.IsBuiltIn select t)
{

            
            #line default
            #line hidden
            this.Write("    [TLType(");
            
            #line 42 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Constructors.Select(constructor => string.Format("typeof({0})", constructor.Name)).Aggregate((s, s1) => s + ", " + s1)));
            
            #line default
            #line hidden
            this.Write(")]\r\n    public partial interface ");
            
            #line 44 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n    }\r\n\r\n");
            
            #line 48 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"

}

            
            #line default
            #line hidden
            this.Write("\r\n    /// <summary>\r\n    ///     TL methods.\r\n    /// </summary>\r\n    public inte" +
                    "rface I");
            
            #line 55 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_templateVars.MethodsInterfaceName));
            
            #line default
            #line hidden
            this.Write("Methods\r\n    {\r\n");
            
            #line 57 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"

    foreach (TLCombinator method in _templateVars.Schema.Methods)
    {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 61 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Type.Name));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 61 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 61 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("Args args);\r\n");
            
            #line 62 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("    }\r\n\r\n    /// <summary>\r\n    ///     TL async methods.\r\n    /// </summary>\r\n  " +
                    "  public interface I");
            
            #line 70 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_templateVars.MethodsInterfaceName));
            
            #line default
            #line hidden
            this.Write("AsyncMethods\r\n    {\r\n");
            
            #line 72 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"

    foreach (TLCombinator method in _templateVars.Schema.Methods)
    {
        string returnType = method.Type.IsVoid ? "Task" : String.Format("Task<{0}>", method.Type.Name);

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 77 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 77 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("Async(");
            
            #line 77 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("Args args);\r\n");
            
            #line 78 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n#pragma warning restore 1591\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 84 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
[UsedImplicitly] private TemplateVars _templateVars; 
        
        #line default
        #line hidden
        
        #line 85 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"

private void WriteTLObjects(IEnumerable<TLCombinator> constructors, IEnumerable<TLType> types, bool isMethodsArgs = false)
{
    List<TLType> typesList = types != null ? types.ToList() : null;
    foreach (TLCombinator constructor in constructors)
    {

        
        #line default
        #line hidden
        
        #line 91 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write("    [TLObject(0x");

        
        #line default
        #line hidden
        
        #line 92 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(constructor.Number.ToString("X8")));

        
        #line default
        #line hidden
        
        #line 92 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write(")]\r\n    public partial class ");

        
        #line default
        #line hidden
        
        #line 93 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("{0}{1}", isMethodsArgs ? constructor.Name + "Args" : constructor.Name,
        (typesList != null && typesList.Contains(constructor.Type)) ? " : " + constructor.Type.Name : String.Empty)));

        
        #line default
        #line hidden
        
        #line 96 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write("\r\n    {\r\n");

        
        #line default
        #line hidden
        
        #line 98 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"

        int i = 0;
        foreach (TLCombinatorParameter parameter in constructor.Parameters)
        {
            TLSerializationMode? serModeOverride = parameter.Type.SerializationModeOverride;

        
        #line default
        #line hidden
        
        #line 103 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write("        [TLProperty(");

        
        #line default
        #line hidden
        
        #line 104 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(++i));

        
        #line default
        #line hidden
        
        #line 104 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(serModeOverride.HasValue ? string.Format(", TLSerializationMode.{0}", serModeOverride.Value) : String.Empty));

        
        #line default
        #line hidden
        
        #line 104 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write(")]\r\n        public ");

        
        #line default
        #line hidden
        
        #line 105 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Type.Name));

        
        #line default
        #line hidden
        
        #line 105 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write(" ");

        
        #line default
        #line hidden
        
        #line 105 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));

        
        #line default
        #line hidden
        
        #line 105 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write(" { get; set; }\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 107 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"

        } 

        
        #line default
        #line hidden
        
        #line 109 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"
this.Write("    }\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 112 "E:\Projects\SharpTL\src\SharpTL.Compiler.NET45\SharpTLDefaultTemplate.tt"

    }
}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class SharpTLDefaultTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
