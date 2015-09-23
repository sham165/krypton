﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class SummaryResult
{

    private string testNameField;

    private testResultType testResultField;

    private string errorMessageField;

    private string detailedResultsFileField;

    private SummaryResultInnerTest[] innerTestsField;

    /// <remarks/>
    public string TestName
    {
        get
        {
            return this.testNameField;
        }
        set
        {
            this.testNameField = value;
        }
    }

    /// <remarks/>
    public testResultType TestResult
    {
        get
        {
            return this.testResultField;
        }
        set
        {
            this.testResultField = value;
        }
    }

    /// <remarks/>
    public string ErrorMessage
    {
        get
        {
            return this.errorMessageField;
        }
        set
        {
            this.errorMessageField = value;
        }
    }

    /// <remarks/>
    public string DetailedResultsFile
    {
        get
        {
            return this.detailedResultsFileField;
        }
        set
        {
            this.detailedResultsFileField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("InnerTest", IsNullable = false)]
    public SummaryResultInnerTest[] InnerTests
    {
        get
        {
            return this.innerTestsField;
        }
        set
        {
            this.innerTestsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
public enum testResultType
{

    /// <remarks/>
    Aborted,

    /// <remarks/>
    Error,

    /// <remarks/>
    Inconclusive,

    /// <remarks/>
    Failed,

    /// <remarks/>
    NotRunnable,

    /// <remarks/>
    NotExecuted,

    /// <remarks/>
    Disconnected,

    /// <remarks/>
    Warning,

    /// <remarks/>
    InProgress,

    /// <remarks/>
    Pending,

    /// <remarks/>
    PassedButRunAborted,

    /// <remarks/>
    Completed,

    /// <remarks/>
    Passed,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SummaryResultInnerTest
{

    private string testNameField;

    private testResultType testResultField;

    private string errorMessageField;

    private string detailedResultsFileField;

    /// <remarks/>
    public string TestName
    {
        get
        {
            return this.testNameField;
        }
        set
        {
            this.testNameField = value;
        }
    }

    /// <remarks/>
    public testResultType TestResult
    {
        get
        {
            return this.testResultField;
        }
        set
        {
            this.testResultField = value;
        }
    }

    /// <remarks/>
    public string ErrorMessage
    {
        get
        {
            return this.errorMessageField;
        }
        set
        {
            this.errorMessageField = value;
        }
    }

    /// <remarks/>
    public string DetailedResultsFile
    {
        get
        {
            return this.detailedResultsFileField;
        }
        set
        {
            this.detailedResultsFileField = value;
        }
    }
}