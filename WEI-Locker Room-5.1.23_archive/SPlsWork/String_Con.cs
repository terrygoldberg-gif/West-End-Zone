using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_STRING_CON
{
    public class UserModuleClass_STRING_CON : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.StringInput TV__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> IN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput LABEL__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> OUT__DOLLAR__;
        CrestronString TEMP1__DOLLAR__;
        CrestronString TEMP2__DOLLAR__;
        object TV__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 182;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TV__DOLLAR__ == "TV-1 "))  ) ) 
                    { 
                    __context__.SourceCodeLine = 186;
                    LABEL__DOLLAR__  .UpdateValue ( TV__DOLLAR__ + "  " + IN__DOLLAR__ [ 1 ]  ) ; 
                    __context__.SourceCodeLine = 187;
                    Print( "I'm TV1 Dammit \r\n") ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 191;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TV__DOLLAR__ == "TV-2 "))  ) ) 
                        { 
                        __context__.SourceCodeLine = 194;
                        LABEL__DOLLAR__  .UpdateValue ( TV__DOLLAR__ + "  " + IN__DOLLAR__ [ 2 ]  ) ; 
                        __context__.SourceCodeLine = 195;
                        Print( "This is my beautiful TV2 \r\n") ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 198;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TV__DOLLAR__ == "TV-3 "))  ) ) 
                            { 
                            __context__.SourceCodeLine = 200;
                            LABEL__DOLLAR__  .UpdateValue ( TV__DOLLAR__ + "  " + IN__DOLLAR__ [ 3 ]  ) ; 
                            __context__.SourceCodeLine = 201;
                            Print( "This is TV3 \r\n") ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 204;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TV__DOLLAR__ == "TV-4 "))  ) ) 
                                { 
                                __context__.SourceCodeLine = 208;
                                LABEL__DOLLAR__  .UpdateValue ( TV__DOLLAR__ + "  " + IN__DOLLAR__ [ 4 ]  ) ; 
                                __context__.SourceCodeLine = 209;
                                Print( "This is TV4 \r\n") ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 213;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TV__DOLLAR__ == "TV-5 "))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 217;
                                    LABEL__DOLLAR__  .UpdateValue ( TV__DOLLAR__ + "  " + IN__DOLLAR__ [ 5 ]  ) ; 
                                    __context__.SourceCodeLine = 218;
                                    Print( "This is TV5 \r\n") ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 222;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TV__DOLLAR__ == "TV-6 "))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 226;
                                        LABEL__DOLLAR__  .UpdateValue ( TV__DOLLAR__ + "  " + IN__DOLLAR__ [ 6 ]  ) ; 
                                        __context__.SourceCodeLine = 227;
                                        Print( "This is TV6 \r\n") ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 236;
                                        LABEL__DOLLAR__  .UpdateValue ( TV__DOLLAR__  ) ; 
                                        } 
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object IN__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 250;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TV__DOLLAR__ == "TV-1 "))  ) ) 
                { 
                __context__.SourceCodeLine = 254;
                LABEL__DOLLAR__  .UpdateValue ( TV__DOLLAR__ + "  " + IN__DOLLAR__ [ 1 ]  ) ; 
                __context__.SourceCodeLine = 255;
                Print( "I'm TV1 Dammit \r\n") ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 259;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TV__DOLLAR__ == "TV-2 "))  ) ) 
                    { 
                    __context__.SourceCodeLine = 263;
                    LABEL__DOLLAR__  .UpdateValue ( TV__DOLLAR__ + "  " + IN__DOLLAR__ [ 2 ]  ) ; 
                    __context__.SourceCodeLine = 264;
                    Print( "This is my beautiful TV2 \r\n") ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 269;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TV__DOLLAR__ == "TV-3 "))  ) ) 
                        { 
                        __context__.SourceCodeLine = 273;
                        LABEL__DOLLAR__  .UpdateValue ( TV__DOLLAR__ + "  " + IN__DOLLAR__ [ 3 ]  ) ; 
                        __context__.SourceCodeLine = 274;
                        Print( "This is TV3 \r\n") ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 278;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TV__DOLLAR__ == "TV-4 "))  ) ) 
                            { 
                            __context__.SourceCodeLine = 282;
                            LABEL__DOLLAR__  .UpdateValue ( TV__DOLLAR__ + "  " + IN__DOLLAR__ [ 4 ]  ) ; 
                            __context__.SourceCodeLine = 283;
                            Print( "This is TV4 \r\n") ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 287;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TV__DOLLAR__ == "TV-5 "))  ) ) 
                                { 
                                __context__.SourceCodeLine = 291;
                                LABEL__DOLLAR__  .UpdateValue ( TV__DOLLAR__ + "  " + IN__DOLLAR__ [ 5 ]  ) ; 
                                __context__.SourceCodeLine = 292;
                                Print( "This is TV5 \r\n") ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 296;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TV__DOLLAR__ == "TV-6 "))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 300;
                                    LABEL__DOLLAR__  .UpdateValue ( TV__DOLLAR__ + "  " + IN__DOLLAR__ [ 6 ]  ) ; 
                                    __context__.SourceCodeLine = 301;
                                    Print( "This is TV6 \r\n") ; 
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 305;
            OUT__DOLLAR__ [ 1]  .UpdateValue ( "TV1" + "  " + IN__DOLLAR__ [ 1 ]  ) ; 
            __context__.SourceCodeLine = 306;
            OUT__DOLLAR__ [ 2]  .UpdateValue ( "TV2" + "  " + IN__DOLLAR__ [ 2 ]  ) ; 
            __context__.SourceCodeLine = 307;
            OUT__DOLLAR__ [ 3]  .UpdateValue ( "TV3" + "  " + IN__DOLLAR__ [ 3 ]  ) ; 
            __context__.SourceCodeLine = 308;
            OUT__DOLLAR__ [ 4]  .UpdateValue ( "TV4" + "  " + IN__DOLLAR__ [ 4 ]  ) ; 
            __context__.SourceCodeLine = 309;
            OUT__DOLLAR__ [ 5]  .UpdateValue ( "TV5" + "  " + IN__DOLLAR__ [ 5 ]  ) ; 
            __context__.SourceCodeLine = 310;
            OUT__DOLLAR__ [ 6]  .UpdateValue ( "TV6" + "  " + IN__DOLLAR__ [ 6 ]  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 368;
        WaitForInitializationComplete ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    TEMP1__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    TEMP2__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    
    TV__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( TV__DOLLAR____AnalogSerialInput__, 20, this );
    m_StringInputList.Add( TV__DOLLAR____AnalogSerialInput__, TV__DOLLAR__ );
    
    IN__DOLLAR__ = new InOutArray<StringInput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        IN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( IN__DOLLAR____AnalogSerialInput__ + i, IN__DOLLAR____AnalogSerialInput__, 200, this );
        m_StringInputList.Add( IN__DOLLAR____AnalogSerialInput__ + i, IN__DOLLAR__[i+1] );
    }
    
    LABEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( LABEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( LABEL__DOLLAR____AnalogSerialOutput__, LABEL__DOLLAR__ );
    
    OUT__DOLLAR__ = new InOutArray<StringOutput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        OUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( OUT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( OUT__DOLLAR____AnalogSerialOutput__ + i, OUT__DOLLAR__[i+1] );
    }
    
    
    TV__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TV__DOLLAR___OnChange_0, false ) );
    for( uint i = 0; i < 6; i++ )
        IN__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( IN__DOLLAR___OnChange_1, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_STRING_CON ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint TV__DOLLAR____AnalogSerialInput__ = 0;
const uint IN__DOLLAR____AnalogSerialInput__ = 1;
const uint LABEL__DOLLAR____AnalogSerialOutput__ = 0;
const uint OUT__DOLLAR____AnalogSerialOutput__ = 1;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
