﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.832
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("TibiaTekBot.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        Friend ReadOnly Property Alarms() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("Alarms", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        Friend ReadOnly Property Cavebot() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("Cavebot", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        Friend ReadOnly Property ChangeLoginServer() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("ChangeLoginServer", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        Friend ReadOnly Property CharacterStatistics() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("CharacterStatistics", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        Friend ReadOnly Property Close() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("Close", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        Friend ReadOnly Property ConstantsEditor() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("ConstantsEditor", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        Friend ReadOnly Property creature() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("creature", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property depot() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("depot", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property doorclosed() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("doorclosed", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property doorlocked() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("doorlocked", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property dooropen() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("dooropen", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property holeclosed() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("holeclosed", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property holeopen() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("holeopen", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property ladder() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ladder", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property mailbox() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("mailbox", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property notwalkable() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("notwalkable", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property otherplayer() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("otherplayer", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property player() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("player", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property stairsgodown() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("stairsgodown", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property stairsgoup() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("stairsgoup", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property swamp() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("swamp", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property teleport() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("teleport", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property Tibia() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("Tibia", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        Friend ReadOnly Property TibiaMultiClientPatch() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("TibiaMultiClientPatch", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        Friend ReadOnly Property ttb_splash0() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ttb_splash0", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property ttb_splash1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ttb_splash1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property ttb_splash2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ttb_splash2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property ttb_splash3() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ttb_splash3", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property ttb_splash4() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ttb_splash4", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property ttb21() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("ttb21", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        Friend ReadOnly Property ttb21_16() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("ttb21_16", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        Friend ReadOnly Property void() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("void", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property walkable() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("walkable", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property waterfish() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("waterfish", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property waternofish() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("waternofish", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
